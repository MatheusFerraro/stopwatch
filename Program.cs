namespace Stopwatch
{
    internal class Program
    {
        static void Main(string[] args)
        {     
            Option();            
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("""
                _________________________________________
                                
                            Choose an Option

                    S - For Seconds
                    M - For Minute
                    Q - Quit
                    
                __________________________________________
                """);     
        }
        static void Option()
        {
            bool isQuit = true;      

            while (isQuit)
            {
                Menu();
                Console.Write("Enter an Option: ");
                string option = Console.ReadLine()?.ToUpper();
                           
                switch (option)
                {
                    case "S":
                        Console.Write("Enter a value for time: ");
                        int time = Convert.ToInt32(Console.ReadLine());
                        Seconds(time);
                        break;

                    case "M":
                        Console.Write("Enter a value for time: ");
                        time = Convert.ToInt32(Console.ReadLine());
                        Minutes(time);
                        break;

                    case "Q":
                        Console.Clear();
                        Console.WriteLine("Thanks for use the application!");
                        Thread.Sleep(2000);
                        isQuit = false;
                        break;

                    default:
                        Console.WriteLine("\nPlease enter a VALID input");
                        Console.WriteLine("Press any key to progress...");
                        Console.ReadKey();
                        break;
                }
            }
        }
        static void Minutes(int seconds)
        {
            int minutes = seconds * 60;

            for(int i = 0; i <= minutes; i++)
            {
                Console.Clear();
                Console.WriteLine(i);
                Thread.Sleep(900);
            }
            Console.Clear();
            Console.WriteLine("Stopwatch Done, going back to menu");
            Thread.Sleep(2200);
        }
        static void Seconds(int time)
        {       
            for(int i = 0; i <= time; i++)
            {
                Console.Clear();
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Stopwatch Done, going back to menu");
            Thread.Sleep(2000);
        }
    }
}
