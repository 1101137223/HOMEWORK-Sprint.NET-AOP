using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AopAlliance.Intercept;
using System.Diagnostics;
using KuasCore.Models;

namespace KuasCore.Interceptors
{
    class UpdateEmployeeNameInterceptors : IMethodInterceptor
    {

        public object Invoke(IMethodInvocation invocation)
        {
            Console.WriteLine("UpdateEmployeeNameInterceptors 攔截到一個方法呼叫 = [{0}]", invocation);
            Debug.Print("UpdateEmployeeNameInterceptors 攔截到一個方法呼叫 = [{0}]", invocation);

            object result = invocation.Proceed();
            if(result is Employee)
            {
                Employee employee = (Employee)result;
                employee.Name = employee.Name + "你好";
                result = employee;
            }
            Console.WriteLine("回傳的資料已取得 [{0}]", result);
            Debug.Print("回傳的資料已取得 [{0}]", result);

            return result;
        }
    }
   
}
