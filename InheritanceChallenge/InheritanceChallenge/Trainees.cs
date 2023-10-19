using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge
{
    internal class Trainees :Employee
    {
        Timer timer;
        private int currHour=0;
        public int WorkingHours { get; set; }
        public int SchoolHours { get; set; }


        public Trainees(string name,string firstName,int salary, int workingHours,int schoolHours)
            : base(name, firstName, salary)
        {
            WorkingHours = workingHours;
            SchoolHours = schoolHours;
        }


        public override void Work()
        {
            if (!IsWorking)
            {
                IsWorking = true;
                Console.WriteLine("Working Hours : " + WorkingHours);
                timer = new Timer(TimerCallBack, null, currHour, 500);
            }
            else
            {
                Console.WriteLine("Already Working");
            }
            
        }

        public override void Pause()
        {
            if (IsWorking)
            {
                base.Pause();
                IsWorking = false;
                timer.Dispose();
            }
            else
            {
                timer.Dispose();
                Console.WriteLine("Go Home and have Rest!");
                Console.WriteLine("Today salary = "+ Salary*WorkingHours);
            }
           
        }
        private void TimerCallBack(object o)
        {
            if (WorkingHours>currHour)
            {
                Console.WriteLine($"{currHour++}");
                GC.Collect();
            }
            else
            {
                IsWorking = false;
                Pause();
            }
                

        }
        public void Learn()
        {
            Console.WriteLine("{0} is Learning",Name);
        }

        public override string ToString()
        {
            return base.ToString() + " " + WorkingHours +" " +SchoolHours;
        }
    }
}
