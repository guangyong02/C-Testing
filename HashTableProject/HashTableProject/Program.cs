using System.Collections;

namespace HashTableProject
{
    internal class Program
    {
        //Key - Value
        //Auto - Car
        static void Main(string[] args)
        {
            Student[] students = new Student[]
            {
                new Student(1,"Jack",3.45,""),
                new Student(2,"Olaf",3.22,""),
                new Student(6,"Ragner",3.00,""),
                new Student(1,"Luise",2.8,""),
                new Student(4,"Levi",3.7,"")
            };
            Hashtable studentsHashTable=new Hashtable();
            foreach (Student student in students)
            {
                if (studentsHashTable.ContainsKey(student.Id))
                {
                    Console.WriteLine("Opps, wrong id input");
                }
                else
                {
                    studentsHashTable.Add(student.Id, student);
                }
                
            }
            foreach (Student temp in studentsHashTable.Values)
            {
                Console.WriteLine($"ID \t:{temp.Id}");
                Console.WriteLine($"Name \t:{temp.Name}");
                Console.WriteLine($"GPA \t:{temp.GPA}");
                Console.WriteLine("=========================");
            }


            Console.WriteLine(studentsHashTable.Contains(students[3]));
            Console.WriteLine(studentsHashTable.Contains(4));
            Console.WriteLine(studentsHashTable.ContainsKey(4));

            //Student jayden = new Student(0, "Jayden", 3.82,"King");
            ////Console.WriteLine(jayden.Id);
            ////Console.WriteLine(jayden.NickName);

            //Hashtable studentTable=new Hashtable();
            //Student stud1 = new Student(1, "Maria", 3.2, "");
            //Student stud2 = new Student(2, "Jason", 3.2, "");
            //Student stud3 = new Student(3, "Clara", 3.2, "");
            //Student stud4 = new Student(4, "Steve", 3.2, "");


            //studentTable.Add(stud1.Id, stud1);
            //studentTable.Add(stud2.Id, stud2);
            //studentTable.Add(stud3.Id, stud3);
            //studentTable.Add(stud4.Id, stud4);

            //Student? storedStudent1 = (Student?)studentTable[3];
            //Console.WriteLine(storedStudent1.Name);
            //Console.WriteLine(studentTable.Keys);


            //foreach (DictionaryEntry entry in studentTable) {
            //    Student temp = (Student)entry.Value;
            //    Console.WriteLine($"Student ID\t:{temp.Id}");
            //    Console.WriteLine($"Student Name \t:{temp.Name}");
            //    Console.WriteLine($"Student GPA \t:{temp.GPA}");
            //}
            //Console.WriteLine("++++++++++++++++++++++++++++++++++++");
            //foreach (Student value in studentTable.Values) {
            //    Console.WriteLine($"Student ID\t:{value.Id}");
            //    Console.WriteLine($"Student Name \t:{value.Name}");
            //    Console.WriteLine($"Student GPA \t:{value.GPA}");
            //}

        }
    }
    
}