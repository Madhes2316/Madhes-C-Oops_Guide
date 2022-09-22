using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZomatoApp
{
    public class Annavasal
    {
        public HotelProperty AvInfo()
        {
            var avitem = new HotelProperty()
            {
                Hotelno=4,
                HotelName="Annavasal",
                Hoteladr="qwert",
                price=55
            };
            return avitem;
        }
    }
}
