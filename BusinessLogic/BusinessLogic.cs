using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class BusinessLogicClass : IBusinessLogic
    {
        public string doSomething(string parameter)
        {
            // Some call to the DAL using Parameter....
            return "some string value and " + parameter;
        }

        public string doSomethingElse(int parameter1, string parameter2)
        {
            // Some call to the DAL using Parameter....
            return "i am a string";
        }

        public string doSomethingToo()
        {
            int zero = 0;
            int divideByZero = 14 / zero;
            return null;
        }
    }
}
