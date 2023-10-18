namespace DictionaryProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<int, string> myDic = new Dictionary<int, string>()
            //{
            //    {1,"one" },
            //    {2,"two"},
            //    {3,"three" }
            //};
            int j = 1;
            Dictionary<int, string> myDic = new Dictionary<int, string>()
            {
                {0,"zero" },
                {1,"one" },
                {2,"two"},
               {3,"three" },
               {4,"four"},
               {5,"five" }
            };
            if (myDic.ContainsKey(j))
            {
                Console.WriteLine( myDic[j]);
            }
            else
                Console.WriteLine("nope");



            Employee[] employees =
            {
                new Employee("CEO","Jayden",22,1000),
                new Employee("Manager","Joe",35,25),
                new Employee("HR","Lora",32,21),
                new Employee("Secretary","Petra",28,35),
                new Employee("Intern","Ernest",22,8)
            };

            Dictionary<string, Employee> myEmployee = new Dictionary<string, Employee>();
            foreach (Employee employee in employees)
            {
                myEmployee.Add(employee.Role, employee);
            }
            //update 
            string keyToUpdate = "HR";
            if (myEmployee.ContainsKey(keyToUpdate))
            {
                myEmployee[keyToUpdate] = new Employee("HR", "Jiayin", 22, 500);
            }
            //Remove/ delete
            string keyToRemove = "Manager";
            if (myEmployee.Remove(keyToRemove))
            {
                Console.WriteLine($"{keyToRemove} Removed!");
            }






            string key = "CEO";
            if (myEmployee.ContainsKey(key))
            {
                Employee emplo = myEmployee[key];
                Console.WriteLine(emplo.Name);
                Console.WriteLine(emplo.Role);
                Console.WriteLine(emplo.Age);
                Console.WriteLine(emplo.Salary);
            }
            else
            {
                Console.WriteLine("No this role");
            }
            key = "Manager";
            if (myEmployee.TryGetValue(key, out Employee result))
            {
                Console.WriteLine(result.Name);
                Console.WriteLine(result.Role);
                Console.WriteLine(result.Age);
                Console.WriteLine(result.Salary);
            }
            else { Console.WriteLine("No this Role available!"); }

            for (int i = 0;i<myEmployee.Count;i++)
            {
                //using ElementAt(i) to return the key-value pair stored at index i

                KeyValuePair<string, Employee> temp = myEmployee.ElementAt(i);
                //print the key
                Console.WriteLine(temp.Key);
                //storing the value in an employee object
                Employee tempEmp = temp.Value;
                //or 
                //Employee tempEmp=myEmployee.ElementAt(i).Value;
                Console.WriteLine(tempEmp.Name);
                Console.WriteLine(tempEmp.Role);
                Console.WriteLine(tempEmp.Age);
                Console.WriteLine(tempEmp.Salary);
                Console.WriteLine("+++++++++++++++++++++");
            }











            
        }
    }
}