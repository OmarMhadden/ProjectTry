using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductProjectTry1
{
    class Orders
    {
        int RequiredRawMaterialNumber;
        string RequiredRawMaterial;
        int NumbreOfWorkersRequired;
        string Type;
        double Cost;
        double Process;
        int TimeLeft;
        string ID;
        List<Orders> ListOfOrders;
        
        public Orders(int RequiredRawMaterialNumber,string RequiredRawMaterial,int NumberOfWorkersRequired,string Type,double Cost,double Process, int TimeLeft,string ID)
        {
            ListOfOrders = new List<Orders>();
            this.RequiredRawMaterialNumber = RequiredRawMaterialNumber;
            this.RequiredRawMaterial = RequiredRawMaterial;
            this.NumbreOfWorkersRequired = NumberOfWorkersRequired;
            this.Type = Type;
            this.Cost = Cost;
            this.Process = Process;
            this.TimeLeft = TimeLeft;
            this.ID = ID;
        }
        public Orders()
        {
            ListOfOrders = new List<Orders>();
        }
        public void AddingToTheListOfOrders(Orders X)
        {
            ListOfOrders.Add(X);            
        }       
        public string GettingListOfOrderss()
        {

            string ListofOrdersString = "";
            for (int i = 0; i < ListOfOrders.Count; i++)
            {
               ListofOrdersString += "ID : " + ListOfOrders[i].ID + "      Process : " + ListOfOrders[i].Process + "%        Time Left : " + ListOfOrders[i].TimeLeft +"\n";
            }
            return ListofOrdersString;
        }
        
       
        

    }
}
