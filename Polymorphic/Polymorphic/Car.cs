using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphic
{
    internal class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }

        // has a relationship
        protected CarIDInfo carIDInfo =new CarIDInfo();
        public void SetCarIDInfo(int idNum,string owner)
        {
            carIDInfo.IDNum = idNum;
            carIDInfo.Owner = owner;
        }

        public void GetCarIDInfo()
        {
            Console.WriteLine("The Car Id is {0} and it owned by {1}",carIDInfo.IDNum,carIDInfo.Owner);

        }

        public Car(int HP, string Color)
        {
            this.HP = HP;
            this.Color = Color;
        }

        public void ShowDetails()
        {
            Console.WriteLine("The Horse Power is "+HP +" and color is "+Color);
        }

        public virtual void Repair()
        {
            Console.WriteLine("The car was repair.");
        }
    }
}
