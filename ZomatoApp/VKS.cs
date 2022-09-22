using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZomatoApp
{
    public class VKS
    {
        public HotelProperty giveInfo()
        {
            var vksitem = new HotelProperty()
            {
                HotelId=2,
                HotelName="Vks",
                Hotelno=67890,
                Hoteladr="mmm road",
                price=120
            };
            return vksitem;
        }
    }
}
