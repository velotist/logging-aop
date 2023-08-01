using System;
using System.Collections.Generic;
using System.Text;

using Spring.Aop;
using AopAlliance.Intercept;

namespace LoggingSystem
{
    class BeforeMethodCallAspect : LoggingBase, IMethodBeforeAdvice
    {
        public BeforeMethodCallAspect(Logger logger) : base(logger)
        {
        }

        public void Before(System.Reflection.MethodInfo method, object[] args, object target)
        {
            StringBuilder arguments = new StringBuilder();

            if (args != null)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    object argument = args[i];
                    arguments.Append(argument.GetType().ToString());
                    arguments.Append(" ");
                    arguments.Append(argument.ToString());
                    if (i < args.Length-1)
                    {
                        arguments.Append(" ,");
                    }
                }
            }

            log.Log.Debug( String.Format("Calling : {0}.{1}({2})", target, method.Name, arguments));
        }
    }
}
