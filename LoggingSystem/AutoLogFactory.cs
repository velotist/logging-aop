using System;
using System.Collections.Generic;
using System.Text;

using Spring.Aop.Framework;

namespace LoggingSystem
{
    public class AutoLogFactory
    {
        public static object AddAutoLogger(object instance)
        {
            Logger myLogger = new Logger();

            ProxyFactory factory = new ProxyFactory(instance);
            factory.AddAdvice(new BeforeMethodCallAspect(myLogger));
            factory.AddAdvice(new InterceptMethodAspect(myLogger));
            factory.AddAdvice(new AfterMethodCallAspect(myLogger));
            factory.AddAdvice(new OnExceptionAspect(myLogger));

            return factory.GetProxy();
        }

        private AutoLogFactory()
        {
        }
    }
}