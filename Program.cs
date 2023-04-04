namespace Vazne_calculator_app_final
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Meghdar vazne ra vared konid?: ");
                int userVAZN = int.Parse(Console.ReadLine());

                int vazne20kilooyi = 0;
                int vazne10kilooyi = 0;
                int vazne5kilooyi = 0;
                int vazne2kilooyi = 0;
                int vazne1kilooyi = 0;
                userVAZN /= 2;

                vazne20kilooyi = userVAZN / 20;
                userVAZN %= 20;
                vazne10kilooyi = userVAZN / 10;
                userVAZN %= 10;
                vazne5kilooyi = userVAZN / 5;
                userVAZN %= 5;
                vazne2kilooyi = userVAZN / 2;
                userVAZN %= 2;
                vazne1kilooyi = userVAZN / 1;
                userVAZN %= 1;
                Console.WriteLine("vazne 20 kilooyi: " + vazne20kilooyi + "\n vazne 10 kilooyi : " + vazne10kilooyi + " \n vazne 5 kilooyi: " + vazne5kilooyi +
                    " \n vazne 2 kilooyi: " + vazne2kilooyi + " \n vazne 1 kilooyi: " + vazne1kilooyi);
                Console.ReadKey();
            }
        }
    }


