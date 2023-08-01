using System;
using System.Collections.Generic;
using System.Text;

using Spring.Aop;

namespace LoggingSystem
{
    class OnExceptionAspect : LoggingBase, IThrowsAdvice
    {
        public OnExceptionAspect(Logger loggerInstance)
            : base(loggerInstance)
        {
        }

        public void AfterThrowing(Exception ex)
        {
            log.Log.Fatal("General Exception occured!", ex);
        }

        public void AfterThrowing(DivideByZeroException ex)
        {
            log.Log.Error("Division by Zero Occured!", ex);
        }
    }
}