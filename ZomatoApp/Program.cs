using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZomatoApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Nonveg nonveg = new Nonveg("VKS","Good at affordable Biriyani",90);
            //nonveg.display();
            //nonveg.goodHotel("kfc", "good at chickens",90);

            Console.WriteLine("Do you want Veg/Nonveg: ");
            string userInput2 = Console.ReadLine();

            if (userInput2 == "Nonveg")
            {

                //simple console line to ask user his input
                Console.WriteLine("Please enter the hotel id you want to enquire: ");

                //read line to get input from the user
                int userInput = int.Parse(Console.ReadLine());

                //creating object for nonveg class and calling its method with a parameter
                var item = new Nonveg().display(userInput);


                //printing all the values in the list using foreach
                foreach (var a in item)
                {
                    Console.WriteLine(a);
                }
            }
            else
            {
                Console.WriteLine("Please enter the hotel id you want to enquire: ");
                int userInput = int.Parse(Console.ReadLine());
                var item2 = new Veg().vegDisplay(userInput);
                foreach (var a in item2)
                {
                    Console.WriteLine(a);
                }

            }
            }
    }
}
