namespace ReadTextFromFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Method 1 
            List<string> lines =new List<string> { "First High Score 15", "Second High Score 22", "Third High Score 30"};
            Console.WriteLine("Please Enter the filename without extensions");
            
            string fileName = Console.ReadLine();
            Console.WriteLine("Please Enter the value u want to enter to the text ");
            lines.Add(Console.ReadLine());
            string writeFilePosition = @"C:\Users\User\Desktop\C#\C-Testing\ReadTextFromFile\ReadTextFromFile\" + fileName+".txt";
            File.WriteAllLines(writeFilePosition, lines);
            File.AppendAllLines(writeFilePosition, lines);


            //Method 2
            File.WriteAllText(writeFilePosition, $"Helo\n this is another method");

            //Method3 streamWriter
            using (StreamWriter file = new StreamWriter(writeFilePosition))
            {
                foreach (string line in lines)
                {
                    if (line.Contains("Third"))
                    {
                        file.WriteLine(line);
                    }
                }
            }
            using (StreamWriter file = new StreamWriter(writeFilePosition,true))
            {
                foreach (string line in lines)
                {
                    if (line.Contains("Third"))
                    {
                        file.WriteLine(line);
                    }
                }
            }

            //foreach (string line in lines)
            //{
            //    if (line.Contains("Third"))
            //    {
            //        File.WriteAllText(writeFilePosition,line );
            //    }
            //}

            string[] readLines = File.ReadAllLines(writeFilePosition);
            foreach (string line in readLines)
            {
                Console.WriteLine(line);
            }



            //string readFilePosition = @"C:\Users\User\Desktop\C#\C-Testing\ReadTextFromFile\ReadTextFromFile\TextFiles.txt";
            ////Example 1 - reading Text

            //string txt= System.IO.File.ReadAllText(readFilePosition);
            //Console.WriteLine(txt);

            ////Example 2 -reading Text;
            //string[] lines = System.IO.File.ReadAllLines(readFilePosition);

            //foreach (string line in lines)
            //{
            //    Console.WriteLine("\t"+line);
            //}
        }
    }
}