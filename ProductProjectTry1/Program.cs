using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductProjectTry1
{
    class Program
    {
        static Administrator Admin;
        static void Main(string[] args)
        {
            

            Admin = new Administrator();
            Admin.AddingStuffToList();
            do
            {
                PrintMenu();
            } while (MakeChoice() == false);
            
            
            
            Console.ReadLine();

        }
        private static void PrintMenu()
        {
            Console.WriteLine("\n");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("-- Main Menu : --------------------");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("1. Get information About Workers ");
            Console.WriteLine("2. Get information About raw materials available");
            Console.WriteLine("3. Get information About Workers available");
            Console.WriteLine("4. New order");
            Console.WriteLine("5. Get List of Orders");
            Console.WriteLine("9. Stop program");
        }
        private static bool MakeChoice()
        {
            bool stopProgram = false;

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("\n");

            switch (Console.ReadKey().KeyChar)
            {
                case '1':
                    CallingMethodeOfInfosAboutWorkers();
                    stopProgram = false;
                    break;
                case '2':
                    CallingMethodeOfInfosAboutRawMaterials();
                    stopProgram = false;
                    break;
                case '3':
                    CallingMethodeOfInfosAboutWorkersAvailable();
                    stopProgram = false;
                    break;
                case '4':
                    CallingMethodeReceivingANewOrder();
                    stopProgram = false;
                    break;
                case '5':
                    CallingMethodeGettingListOfOrders();
                    stopProgram = false;
                    break;
                case '9':
                    stopProgram = true;
                    break;
            }
            return stopProgram;
        }
        static void CallingMethodeOfInfosAboutWorkers()
        {
            Console.WriteLine("\n");
            Console.WriteLine(Admin.GettingListOfWorkers());
        }
        static void CallingMethodeOfInfosAboutRawMaterials()
        {
            Console.WriteLine("\n");
            Console.WriteLine(Admin.GettingListOfRawMaterialsAvailable());
        }
        static void CallingMethodeOfInfosAboutWorkersAvailable()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Enter the required days of the workers availibility : ");
            int X = int.Parse(Console.ReadLine());
            Console.WriteLine("\n ---------------------------------------------------------------- \n");
            Admin.GettingListOfnumberWorkersAvailableForTheNext(X);
            Console.WriteLine(Admin.GettingListOfWorkersAvailableForTheNext(X));
            
        }
        static void CallingMethodeReceivingANewOrder()
        {
            Admin.GettingListOfRawMaterialsAvailable();
            
            Console.WriteLine("~~~~~ New Order ~~~~~");
            Console.WriteLine("Enter the order ID : ");
            string ID = Console.ReadLine();
            Console.WriteLine("Enter the type of product");
            string Type = Console.ReadLine();
            Console.WriteLine("Enter the type of raw material required : ");
            string RawMaterialNeeded = Console.ReadLine();
            Console.WriteLine("Enter the number of " + RawMaterialNeeded + " in Kg needed : ");
            int RawMaterialNeededNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the in how many days the product should be done : ");
            int TimeLeft = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter how many worker are needed to complete the product in time : ");
            int HowManyWorkers = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the overall price of the product");
            double Cost = double.Parse(Console.ReadLine());
            Admin.GettingListOfnumberWorkersAvailableForTheNext(TimeLeft);
            Admin.ReceivingANewOrder(RawMaterialNeededNumber, RawMaterialNeeded, HowManyWorkers, Type, Cost, 0, TimeLeft, ID);
            
        }
       static void CallingMethodeGettingListOfOrders()
        {
            Console.WriteLine(Admin.GettingTheListOfOrders());
        }
    }
}
