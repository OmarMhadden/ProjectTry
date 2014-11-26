using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductProjectTry1
{
    class Availability
    {
        string Name;
        int Quantity;
        List<Availability> ListOfRawMaterials;        
        List<Orders> ConnectionOrder = new List<Orders>();
        Administrator ConnectionToAdministrator = new Administrator();
        public Availability(string Name, int Quantity)
        {
            
            ListOfRawMaterials = new List<Availability>();
            this.Name = Name;
            this.Quantity = Quantity;
        }
        public Availability()
        {
            ListOfRawMaterials = new List<Availability>();
        }       
        public string ListOfWhatDoWeHaveInStorage()
        {
            string TheListOfStorage = "";
            for (int i = 0; i < ListOfRawMaterials.Count; i++)
            {
                TheListOfStorage += ListOfRawMaterials[i].Name + ", " + ListOfRawMaterials[i].Quantity + " in storage\n";
            }
            return TheListOfStorage;
        }
        public void WhatDoWeHaveInStorage()
        {
            Availability Bronze = new Availability("bronze", 1000);
            ListOfRawMaterials.Add(Bronze);
            Availability Metal = new Availability("metal", 800);
            ListOfRawMaterials.Add(Metal);
            Availability Steel = new Availability("steel", 1500);
            ListOfRawMaterials.Add(Steel);
        }
        public void ReceivingNewOrder(int RequiredRawMaterialNumber, string RequiredRawMaterial, int NumberOfWorkersRequired, string Type, double Cost, double Process, int TimeLeft, string ID)
        {
            bool TheOrder = false;
            Orders NewOrder1 = new Orders(RequiredRawMaterialNumber,RequiredRawMaterial,NumberOfWorkersRequired,Type,Cost,Process,TimeLeft,ID);            
            for (int i = 0; i < ListOfRawMaterials.Count; i++)
			{
			if (RequiredRawMaterial.ToLower() == ListOfRawMaterials[i].Name)
            {
                if (RequiredRawMaterialNumber >= ListOfRawMaterials[i].Quantity && NumberOfWorkersRequired >= ConnectionToAdministrator.GettingListOfnumberWorkersAvailableForTheNext(TimeLeft)) ;
                {
                    TheOrder = true;
                    ConnectionOrder.Add(NewOrder1);
                    NewOrder1.AddingToTheListOfOrders(NewOrder1);
                    break;    
                }	                        	               
            }
	


 
			}

            if (TheOrder == false)
            {
                  Console.WriteLine("ERROR !! you can not take that order");            	
            }
            
        }

        public void ListOfSomeOrders()
        {
            Orders RandomOrder = new Orders(100, "bronze", 5, "Bronze grates", 50000, 20, 45, "FID1441");
            ConnectionOrder.Add(RandomOrder);
            RandomOrder.AddingToTheListOfOrders(RandomOrder);
            Orders Order1 = new Orders(300, "Metal", 8, "Metal Grates", 30000, 77, 4, "FG1451");
            ConnectionOrder.Add(Order1);
            RandomOrder.AddingToTheListOfOrders(Order1);
            Orders Order2 = new Orders(200, "Metal", 5, "Metal Grates", 20000, 18, 13, "TR5314");
            ConnectionOrder.Add(Order2);
            RandomOrder.AddingToTheListOfOrders(Order2);
            Orders Order3 = new Orders(100, "Bronze", 4, "Bronze Grates", 25000, 55, 6, "PO1441");
            ConnectionOrder.Add(Order3);
            RandomOrder.AddingToTheListOfOrders(Order3);
            
        }
        public string GettingListOfOrders()
        {
            string RandomString = "";
            for (int i = 0; i < ConnectionOrder.Count; i++)
            {
                RandomString += ConnectionOrder[i].GettingListOfOrderss();
            }
            return RandomString;
        }
    }
}
