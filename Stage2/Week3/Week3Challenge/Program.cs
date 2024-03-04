using System;
using Week3Challenge;

namespace InterfaceAndDI_EventExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            bool userChoice;
            string userChoiceString;
            float materialCost = 0.0F;

            do
            {
                //Get valid input
                do
                {
                    //initialize variables
                    userChoice = false;

                    //user menu of options
                    Console.WriteLine("");
                    Console.WriteLine("What crochet item would you like a price for? ");
                    Console.WriteLine("Select the item:");
                    Console.WriteLine("B : Blanket Pricing");
                    Console.WriteLine("A : Amigurumi Pricing");
                    Console.WriteLine("P : Potholder Pricing");
                    Console.WriteLine("C : Clothing Pricing");
                    Console.WriteLine("G : Bag Pricing");
                    Console.WriteLine("Q : Quit");
                    Console.WriteLine("");
                    userChoiceString = Console.ReadLine().ToUpper();


                    userChoice = (userChoiceString == "B" ||
                                  userChoiceString == "A" ||
                                  userChoiceString == "P" ||
                                  userChoiceString == "C" ||
                                  userChoiceString == "G" ||
                                  userChoiceString == "Q");

                    if (!userChoice)
                    {
                        Console.WriteLine("Please enter a valid option");
                    }

                } while (!userChoice);

                if (userChoiceString == "B" ||
                    userChoiceString == "A" ||
                    userChoiceString == "P" ||
                    userChoiceString == "C" ||
                    userChoiceString == "G")
                {
                    Console.WriteLine("What is the material cost?");
                    materialCost = float.Parse(Console.ReadLine());
                }

                if (userChoiceString == "B")
                {
                    ICrochet crochetItem = new CrochetBlanket();
                    ProductService productService1 = new ProductService(crochetItem);
                    productService1.GetPricing(materialCost);
                }

                else if (userChoiceString == "A")
                {
                    ICrochet crochetItem = new CrochetAmigurumi();
                    ProductService productService1 = new ProductService(crochetItem);
                    productService1.GetPricing(materialCost);
                }

                else if (userChoiceString == "P")
                {
                    ICrochet crochetItem = new CrochetPotholder();
                    ProductService productService1 = new ProductService(crochetItem);
                    productService1.GetPricing(materialCost);
                }

                else if (userChoiceString == "C")
                {
                    ICrochet crochetItem = new CrochetClothing();
                    ProductService productService1 = new ProductService(crochetItem);
                    productService1.GetPricing(materialCost);
                }

                else if (userChoiceString == "G")
                {
                    ICrochet crochetItem = new CrochetBag();
                    ProductService productService1 = new ProductService(crochetItem);
                    productService1.GetPricing(materialCost);
                }

                else
                {
                    Console.WriteLine("Thank you!");
                }

            } while (!(userChoiceString == "Q"));

        }
    }
}