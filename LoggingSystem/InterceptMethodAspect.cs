using System;
using System.Collections.Generic;
using System.Text;

using AopAlliance.Intercept;

namespace LoggingSystem
{
    class InterceptMethodAspect : LoggingBase, IMethodInterceptor
    {
        public InterceptMethodAspect(Logger loggerInstance)
            : base(loggerInstance)
        {
        }

        public object Invoke(IMethodInvocation invocation)
        {
            object returnValue = invocation.Proceed();

            log.Log.Debug("ReturnValue is " + returnValue.GetType() + " " + returnValue);

            return returnValue;
        }
    }
}
