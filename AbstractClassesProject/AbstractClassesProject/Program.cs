namespace AbstractClassesProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //cause it is abstract clas so i cant create object on it 
            //Shape shape =new Shape();


            Shape[] shapes = { new Sphere(4), new Cube(5) };
            foreach (Shape shape in shapes)
            {
                shape.GetInfo();

                Cube iceCube = shape as Cube;
                if (iceCube != null)
                {
                    Console.WriteLine("This is a Cude");
                }
                else
                    Console.WriteLine("This is not a cube");
                if (shape is Cube)
                {
                    Console.WriteLine("This is a Cube");
                }
                else
                    Console.WriteLine("This is not a Cube");

                object cube1 = new Cube(7);
                Cube cube2= (Cube)cube1;
                cube2.GetInfo();

            }
        }
    }
}