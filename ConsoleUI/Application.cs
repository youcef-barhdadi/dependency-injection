using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Application : IApplication
    {


        IBusinessLogic _businessLogic;
        public Application(IBusinessLogic BusinessLogic)
        {
            _businessLogic = BusinessLogic;
        }



        public void Run()
        {

            _businessLogic.ProcessData();
        }

    }
}
