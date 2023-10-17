using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Members
    {
        //member private field
        private string _memberName;
        private string _jobTitle;
        private int _salary;
        //member -public field;
        public int _age;

        public Members()
        {
            _age = 30;
            _memberName = "Lucy";
            _salary = 60000;
            _jobTitle = "Developer";
            Console.WriteLine("this is a member");
        }


        //member - property - exposes jobTitle safely - property start with capital letter
        public string JobTitle {
            get
            {
                return _jobTitle;
            }
            set
            {
                _jobTitle = value;
            }}
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine("Hi my name is {0}, and my job is {1}. I'am {2} years old",_memberName,_jobTitle,_age);
            }
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine("My salary is {0}", _salary);
        }

        //member - finalizer -destructor
        ~Members()
        {
            // cleanup statements
            Console.WriteLine("Deconstruction of Member Object! ");
            Debug.WriteLine("Deconstruction of Member Object! of Member Object!");
        }

    }

    //public member method - can be called from other classes
    
}
