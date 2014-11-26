using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductProjectTry1
{
    class Workers
    {
        string Name;
        int Absence;
        bool Paid;
        bool Available;
        int AvailableForTheNext;
        public List<Workers> ControllerForWorkersConnectionWorkers { get; set; }
        public Workers(string Name, int Absence, bool Paid, bool Available, int AvailableforTheNext)
        {
            this.Name = Name;
            this.Absence = Absence;
            this.Paid = Paid;
            this.Available = Available;
            this.AvailableForTheNext = AvailableforTheNext;
        }
        
        public Workers()
        {
            ControllerForWorkersConnectionWorkers = new List<Workers>();

        }
        public void ListOfWorkers()
        {
            Workers Worker1 = new Workers("Bob", 0, false,true,68);
            ControllerForWorkersConnectionWorkers.Add(Worker1);
            Workers Worker2 = new Workers("Boby", 2, true,true,42);
            ControllerForWorkersConnectionWorkers.Add(Worker2);
            Workers Worker3 = new Workers("John", 0, true,true,70);
            ControllerForWorkersConnectionWorkers.Add(Worker3);
            Workers Worker4 = new Workers("Johny", 0, false,true,94);
            ControllerForWorkersConnectionWorkers.Add(Worker4);
            Workers Worker5 = new Workers("Michael", 0, true, true,76);
            ControllerForWorkersConnectionWorkers.Add(Worker5);
            Workers Worker6 = new Workers("Bailey", 0, false, true,40);
            ControllerForWorkersConnectionWorkers.Add(Worker6);
            Workers Worker7 = new Workers("Daniel", 0, true, true, 42);
            ControllerForWorkersConnectionWorkers.Add(Worker7);
            Workers Worker8 = new Workers("Danny", 0, false, true, 57);
            ControllerForWorkersConnectionWorkers.Add(Worker8);
            Workers Worker9 = new Workers("Anis", 0, true, true,75);
            ControllerForWorkersConnectionWorkers.Add(Worker9);
            Workers Worker10 = new Workers("Christian", 0, true, true,95);
            ControllerForWorkersConnectionWorkers.Add(Worker10);
            Workers Worker11 = new Workers("Louis", 1, false, false,0);
            ControllerForWorkersConnectionWorkers.Add(Worker11);
            Workers Worker12 = new Workers("Ramus", 0, false, true,102);
            ControllerForWorkersConnectionWorkers.Add(Worker12);

        }
        

        
        public string GettingWorkersInfos()
        {
            string WorkersInfo = "";
            for (int i = 0; i <ControllerForWorkersConnectionWorkers.Count; i++)
            {
                WorkersInfo +=  "- " + ControllerForWorkersConnectionWorkers[i].Name + " " + ControllerForWorkersConnectionWorkers[i].Absence + " hours of absence, " + IfPaidOrNot(ControllerForWorkersConnectionWorkers[i]) + "\n";
            }
            return WorkersInfo;
        }
        public string IfPaidOrNot(Workers x)
        {
            string PayedStatement = "";
            if (x.Paid == true)
            {
                PayedStatement += " He was paid";
            }
            else if (x.Paid == false)
            {
                PayedStatement += " Not paid yet";
            }
            return PayedStatement;
        }
        public string ListOfWorkersAvailable(int AvailableForHowMayDays)
        {
            string ListOfWorkersAvailableString = "";
            int HowManyOfThem = 0;
            for (int i = 0; i < ControllerForWorkersConnectionWorkers.Count; i++)
            {
                if (ControllerForWorkersConnectionWorkers[i].Available == true && ControllerForWorkersConnectionWorkers[i].AvailableForTheNext >= AvailableForHowMayDays)
                {
                    ListOfWorkersAvailableString += ControllerForWorkersConnectionWorkers[i].Name + "\n"; 
                    HowManyOfThem++;
                }
            }
            return ListOfWorkersAvailableString + "\n" + HowManyOfThem + " of them are available for the next " + AvailableForHowMayDays + " Days";
        }
        public int ListOfNumberWorkersAvailable(int AvailableForHowMayDays)
        {            
            int HowManyOfThem = 0;
            for (int i = 0; i < ControllerForWorkersConnectionWorkers.Count; i++)
            {
                if (ControllerForWorkersConnectionWorkers[i].Available == true && ControllerForWorkersConnectionWorkers[i].AvailableForTheNext >= AvailableForHowMayDays)
                {                    
                    HowManyOfThem++;
                }
            }
            return HowManyOfThem;
        }
        
    }
}
