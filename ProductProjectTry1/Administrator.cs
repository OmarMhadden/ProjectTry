using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductProjectTry1
{
    class Administrator
    {
        string UserName;
        string Password;
        static Workers TheWorkers = new Workers();
        static Availability TheAvailability = new Availability();
        List<Orders> ListOfNewOrders;
        List<Orders> ListOfOrders;
        Orders ConnectionToOrders = new Orders();
        public Administrator()
        {

            ListOfOrders = new List<Orders>();
            ListOfNewOrders = new List<Orders>();
            

        }
        public string GettingListOfWorkers()
        {
            
            
            return TheWorkers.GettingWorkersInfos();
        }
        public string GettingListOfRawMaterialsAvailable()
        {
            
            
            return TheAvailability.ListOfWhatDoWeHaveInStorage();
        }
        public string GettingListOfWorkersAvailableForTheNext(int AvailableForHowMayDayss)
        {
            return TheWorkers.ListOfWorkersAvailable(AvailableForHowMayDayss);
        }
        public int GettingListOfnumberWorkersAvailableForTheNext(int AvailableForHowMayDayss)
        {
            return TheWorkers.ListOfNumberWorkersAvailable(AvailableForHowMayDayss);
        }
        public void ListOfCurrentOrders()
        {
         
        }
        public void ReceivingANewOrder(int RequiredRawMaterialNumber, string RequiredRawMaterial, int NumberOfWorkersRequired, string Type, double Cost, double Process, int TimeLeft, string ID)
        {
            TheAvailability.ReceivingNewOrder(RequiredRawMaterialNumber, RequiredRawMaterial, NumberOfWorkersRequired, Type, Cost, Process, TimeLeft, ID);            
        }
        public string GettingTheListOfOrders()
        {

            TheAvailability.GettingListOfOrders();
            return TheAvailability.GettingListOfOrders();
        }
        public void AddingStuffToList()
        {
            TheAvailability.ListOfSomeOrders();
            TheAvailability.WhatDoWeHaveInStorage();
            TheWorkers.ListOfWorkers();
        }
        
    }
}
