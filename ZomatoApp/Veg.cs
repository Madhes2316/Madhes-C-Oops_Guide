using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZomatoApp
{
    public class Veg
    {
        public List<object> vegDisplay(int hotelId)
        {

            var item=new List<object>();
            
            switch (hotelId)
            {
                case 4:
                    var avValues = new Annavasal().AvInfo();
                    item.Add(avValues.HotelName);
                    item.Add(avValues.Hotelno);
                    item.Add(avValues.Hoteladr);
                    item.Add(avValues.price);
                    break;
            }
            return item;
        }
    }
}
