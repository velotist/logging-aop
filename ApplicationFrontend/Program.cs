using System;
using System.Collections.Generic;
using System.Text;

using BusinessLogic;
using LoggingSystem;


namespace ApplicationFrontend
{
    class Program
    {
        static void Main(string[] args)
        {
            IBusinessLogic bl =  (IBusinessLogic)AutoLogFactory.AddAutoLogger(new BusinessLogicClass());
            
            bl.doSomething("test");
            bl.doSomethingElse(1, "Beeblebrox");

            try
            {
                bl.doSomethingToo();
            }
            catch
            {
                Console.WriteLine("Exception aufgetreten");
            }

            System.Console.ReadLine();
        }
    }
}
