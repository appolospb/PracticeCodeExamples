using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StructureMap;
using CoreLibrary.Interfaces;
using CoreLibrary.Common.Interfaces;

namespace CoreLibrary.UI
{
    public class Program
    {
        #region Fields

        private Container _container;
        private ICoreLibrary _coreLib;

        #endregion

        public Program()
        {
            InitIOC iniIOC = new InitIOC();
            _container = iniIOC.Resolver(_container);

            _coreLib = _container.GetInstance<ICoreLibrary>();
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.DspMenu();
            Console.ReadLine();
        }

        private void DspMenu()
        {
            string selection;

            Console.WriteLine("What task do you want to perform (Select number)?:\n" +
                "1. Add a customer\n"+
                "2. Get customers");

            selection = Console.ReadLine();

            ProcessSelection(selection);
        }

        private void ProcessSelection(string selection)
        {
            switch (selection)
            {
                case "1":
                    AddCustomer();
                    break;
                case "2":
                    GetCustomers();
                    break;
                default:
                    Console.WriteLine("Incorrect selection, press enter to try again");
                    Console.ReadLine();
                    Console.Clear();
                    DspMenu();
                    break;
            }
        }

        private void PostResultMenu()
        {
            Console.WriteLine("Press enter to display the main menu");
            Console.ReadLine();
            Console.Clear();
            DspMenu();
        }

        private void AddCustomer()
        {
            ICustomer newCustomer = _container.GetInstance<ICustomer>();

            Console.WriteLine("Enter customer forename:");
            newCustomer.Forename = Console.ReadLine();
            Console.WriteLine("Enter customer surname:");
            newCustomer.Surname = Console.ReadLine();

            _coreLib.AddCustomer(newCustomer);

            // TODO - Show confirmation or error onscreen

            PostResultMenu();
        }

        private void GetCustomers()
        {
            _coreLib.GetCustomers();

            // TODO - Show result or error  onscreen

            PostResultMenu();
        }
    }
}
