namespace ShortAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileNeedToRead = @"C:\Users\User\Desktop\C#\C-Testing\ShortAssignment\ShortAssignment\input.txt";
            string[] input =File.ReadAllLines(fileNeedToRead);
            List<string> output=new List<string>();
            foreach (string line in input)
            {
                if (line.Contains("split"))
                {
                    string[] temp =line.Split("split");
                    foreach (string s in temp)
                    {
                        output.Add(s); 
                    }
                }
            }

            string fileNeedToWrite = @"C:\Users\User\Desktop\C#\C-Testing\ShortAssignment\ShortAssignment\output.txt";
            Console.WriteLine(output[4]);
            using (StreamWriter writer= new StreamWriter(fileNeedToWrite))
            {
                writer.WriteLine(output[4]);
            }
        }
    }
}