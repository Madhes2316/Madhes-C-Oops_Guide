using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZomatoApp
{
    public class KFC
    {
        public HotelProperty giveInfo()
        {
            var kfcitem = new HotelProperty()
            {
                HotelName = "KFC",
                HotelId = 3,
                Hotelno=1111,
                Hoteladr="lolol",
                price=200
            };
            return kfcitem;

        }
    }
}
