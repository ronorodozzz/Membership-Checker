using System;
using System.CodeDom;


namespace ownproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string continueprogram;
            do
            {
                Console.Write("Select the type of customer (1. - Regular, 2. - Member, 3. - Senior): ");
                double CustomerType = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the amount of purchase: $");
                double InitialAmount = Convert.ToDouble(Console.ReadLine());

                Console.Write("Do you have a promo code? (YES/NO)");
                string promo = Console.ReadLine();

                Double PromoAmount, Promo10, promo5, promo15;
                Promo10 = 0.90;
                promo5 = 0.95;
                promo15 = 0.85;

                if (promo == "YES")
                {
                    PromoAmount = promo5;
                }

                else
                {
                    PromoAmount = 1;
                }

                switch (CustomerType)
                {
                    case 1:
                        if (InitialAmount > 100)
                        {

                            double FinalAmount = InitialAmount * PromoAmount * promo5;
                            Console.WriteLine($"The amount of your pruchase after discounts is: ${FinalAmount:f2}");
                            break;
                        }
                        break;
                    case 2:
                        if (InitialAmount > 100)
                        {

                            double FinalAmount = InitialAmount * PromoAmount * Promo10;
                            Console.WriteLine($"The amount of your pruchase after discounts is: ${FinalAmount:f2}");
                            break;
                        }
                        else
                        {

                            double FinalAmount = InitialAmount * PromoAmount * promo5;
                            Console.WriteLine($"The amount of your pruchase after discounts is: ${FinalAmount:f2}");
                            break;
                        }

                    case 3:
                        if (InitialAmount > 100)
                        {
                            double FinalAmount = InitialAmount * PromoAmount * promo15;
                            Console.WriteLine($"The amount of your pruchase after discounts is: ${FinalAmount:f2}");
                            break;

                        }
                        else
                        {
                            double FinalAmount = InitialAmount * PromoAmount * Promo10;
                            Console.WriteLine($"The amount of your pruchase after discounts is: ${FinalAmount:f2}");
                            break;

                        }
                    default:
                        Console.WriteLine("Invalid Choice do it again");
                        return;
                }
                Console.ReadKey();
                Console.Write("Would you like to continue the program? (YES/NO):");
                continueprogram = Console.ReadLine();

            } while (continueprogram == "YES");

            Console.WriteLine("Thank you for using this program!");
           
        }
    }
}
