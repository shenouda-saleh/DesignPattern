using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITIDesignPattern.SingleTon
{
    public class NetworkCard
    {
        static NetworkCard networkCard;
        public string name { get; set; } = "single";

        public static NetworkCard Create()
        {
            if (networkCard == null)
                networkCard = new NetworkCard();

            return networkCard;
        }

    }
}
