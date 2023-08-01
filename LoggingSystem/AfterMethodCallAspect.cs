using System;
using System.Collections.Generic;
using System.Text;

using Spring.Aop;

namespace LoggingSystem
{
    class AfterMethodCallAspect : LoggingBase, IAfterReturningAdvice
    {
        public AfterMethodCallAspect(Logger loggerInstance)
            : base(loggerInstance)
        {
        }

        public void AfterReturning(object returnValue, System.Reflection.MethodInfo method, object[] args, object target)
        {
            log.Log.Debug("Finished call to " + method.Name);
        }
    }
}
