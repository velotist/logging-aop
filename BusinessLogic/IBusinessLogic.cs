using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public interface IBusinessLogic
    {
        string doSomething(string parameter);
        string doSomethingElse(int parameter1, string parameter2);
        string doSomethingToo();
    }
}
