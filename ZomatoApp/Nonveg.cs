using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZomatoApp
{

    
    public class Nonveg
    {
        public string Name { get; set; }
        //public string Description { get; set; }

        //public int price { get; set; }
        //public Nonveg(string name,string description,int price)
        //{
        //    this.Name = name;
        //    this.Description= description;
        //    this.price = price;
        //    Console.WriteLine($"DB has opened:{name},{description},{price}");
        //}
        //public  void display()
        //{
        //    //int hotelid = 1;
        //    //string hotelName = "SS biriyani";
        //    //Console.WriteLine(hotelName);

        //    //Console.WriteLine(hotelid);
        //    //Console.WriteLine(hotelName);
        //}
        //public void goodHotel(string name,string description,int price)
        //{
        //    this.Name = name;
        //    this.Description = description;
        //    this.price = price;

        //    Console.WriteLine($"{name},{description},{price}");
        //}

        //we are creating a method/function with return type as List
        public List<object> display(int hotelId)
        {
            //creating a normal list with object type
            var values = new List<object>();

            //switch statement with user input from main method
            switch (hotelId)
            {
                case 1:
                    //if case 1 we are creating a object for SSbiriyani class and calling its method/function
                    var item = new SSBiriyani().giveValues();

                    
                    values.Add(item.HotelName);
                    values.Add(item.Hotelno);
                    values.Add(item.Hoteladr);
                    values.Add(item.price);
                    break;
                case 2:
                    //if case 2 we are creating a object for Vks class and calling its method/function
                    var item2 = new VKS().giveInfo();
                    values.Add(item2.HotelName);
                    values.Add(item2.Hotelno);
                    values.Add(item2.Hoteladr);
                    values.Add(item2.price);
                    break;
                case 3:
                    var item3 = new KFC().giveInfo();
                    values.Add(item3.HotelName);
                    values.Add(item3.Hotelno);
                    values.Add(item3.Hoteladr);
                    values.Add(item3.price);
                    break;
                default:
                    Console.WriteLine("Please select any one hotel");
                    break;

            }
            

            return values;
        }
    }
}
