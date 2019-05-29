using System;

namespace Homework_5_29
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Food");

            Console.WriteLine("Which is your favorite food?");
            Console.WriteLine("Choose a number: 1. Italian, 2. Chinese, 3. Mexican ");
            string answer1 = Console.ReadLine();
            switch (answer1)
            {
                case "1":
                    ItalianFood();
                    break;

                case "2":
                    ChineseFood();
                    break;

                case "3":
                    MexicanFood();
                    break;

                default:
                    Console.WriteLine("No food for you...");
                    break;
            }

            string[] FoodItems =
            {
                "Entree", "Side", "Dessert"
            };
            int index = 1;
            foreach (string item in FoodItems)
            {
                Console.WriteLine(item);
                Console.WriteLine(index);
                
                index++;
            }

            

        } 

        private static void ChineseFood()
        {
            Console.WriteLine("Awesome, Chinese food is great. You get a full course meal! Including Crab Ragoon with chicken and Brocolli. In total you get:");
        }

        private static void ItalianFood()
        {
            Console.WriteLine("Awesome, Italian food is great. You get a full course meal! Including Pasta and garlic bread. In total you get:");
        }

        private static void MexicanFood()
        {
            Console.WriteLine("Awesome, Mexican food is great. You get a full course meal! Including enchiladas and tostadas with rice and beans. In total you get:");
        }

        private static string Buffet(string words1, string words2)
        {
            string Thanks_Come_Again = words1 + words2;
            return Thanks_Come_Again;
        }
    }
}