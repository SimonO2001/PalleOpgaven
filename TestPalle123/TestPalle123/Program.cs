namespace TestPalle123 
{
    public class Program 
    {
        static void Main(string[] args)
        {
            bool loop = true;

            while (loop) 
            {
                Console.WriteLine("Hvor hurtigt løber du");

                int hastighed = Convert.ToInt32(Console.ReadLine());

                if (hastighed < 9 && hastighed > 0)
                {
                    Console.WriteLine("Du er med i VM!");
                }
                else if (hastighed < 10 && hastighed > 0)
                {
                    Console.WriteLine("Du er med i EM!");
                }
                else if (hastighed >= 11 && hastighed > 0)
                {
                    Console.WriteLine("Du er med i EJ!");
                }
                else if (hastighed < 12 && hastighed > 0)
                {
                    Console.WriteLine("Du er med i INGENTING!");
                }
                else if (hastighed == 0)
                {
                    Console.WriteLine("Du er ude af loopen nu!");

                    loop = false;
                }

                Console.ReadKey();


            }
            

            

        }

    }
    


}

