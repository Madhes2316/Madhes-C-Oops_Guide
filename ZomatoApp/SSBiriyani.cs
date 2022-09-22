using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZomatoApp
{
    public class SSBiriyani
    {
                //we are creating a method/function with a class object and we are returning that class.
        public HotelProperty giveValues()
        {
            var item = new HotelProperty() //creating an object with hotel property class
            {
                HotelId = 1,
                HotelName = "SS Biriyani",
                Hotelno = 12345,
                price = 90,
                Hoteladr = "123 abc road"
            };
            return item; //returning object of class

        }
    }
}
