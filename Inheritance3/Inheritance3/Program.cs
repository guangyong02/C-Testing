namespace Inheritance3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post mypost = new Post("Thanks for the birthday wishes", true, "Jiayin");
            Console.WriteLine(mypost.ToString());

            ImagePost myimage = new ImagePost("I like to eat this Cake", true, "Jayden", "www.Facebook.com");
            Console.WriteLine(myimage.ToString());

            VideoPost myVideo = new VideoPost("Check this Computer Spec", true, "Jayden", "www.youtube.com", 18);
            Console.WriteLine(myVideo.ToString());

            myVideo.Play();
            Console.WriteLine("Press any Key to Stop the video");
            Console.ReadKey();
            myVideo.Stop();
            myVideo.Play();
            Console.WriteLine("Press any Key to Stop the video");
            Console.ReadKey();

        }
  
    }
        
}