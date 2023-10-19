namespace IEnumerable
{
    internal class Program
    {

        static void Main(string[] args)
        {
            DogShelter myDogs= new DogShelter();
            foreach (Dog item in myDogs)
            {
                if (!item.IsNaughtyDog)
                {
                    item.GiveTreat(2);
                }
                else
                    item.GiveTreat(1);
            }
            //foreach (Dog item in myDogs.Dogs)
            //{
            //    if (!item.IsNaughtyDog)
            //    {
            //        item.GiveTreat(2);
            //    }
            //    else
            //        item.GiveTreat(1);
            //}





            List<Dog> testing= new List<Dog>()
            {
                new Dog("Poppy",false),
                new Dog("Oreo",true),
                new Dog("Pop",false),
                new Dog("Pizy",false)
            };
            foreach (Dog item in testing)
            {
                Console.WriteLine(item.Name);
            }
        }



    }
}