using System.Runtime.CompilerServices;

namespace Vazne_calculator_app_final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount of weight: ");
            try
            {
                int userWeight = int.Parse(Console.ReadLine());

                int var20kgweight = 0;
                int var10kgweight = 0;
                int var5kgweight = 0;
                int var2kgweight = 0;
                int var1kgweight = 0;
                userWeight /= 2; //Have to use half the weight , because this app is calculating required weight at "Each end of barbell bar"

                var20kgweight = userWeight / 20;
                userWeight %= 20;
                var10kgweight = userWeight / 10;
                userWeight %= 10;
                var5kgweight = userWeight / 5;
                userWeight %= 5;
                var2kgweight = userWeight / 2;
                userWeight %= 2;
                var1kgweight = userWeight / 1;
                userWeight %= 1;
                Console.WriteLine(" 20 kg weight: " + var20kgweight + "\n 10 kg weight: " + var10kgweight + " \n 5 kg weight: " + var5kgweight +
                    " \n 2 kg weight: " + var2kgweight + " \n 1 kg weight: " + var1kgweight);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("You can only enter numbers not characters, Restart the app and try again !");
            }

        }
    }
}


