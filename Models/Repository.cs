using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Partyinvites.Models
{
    public class Repository
    {
        public static List<GuestResponse> Adding = new List<GuestResponse>();
        public static IEnumerable<GuestResponse> Added => Adding;
        public static void AddGuest(GuestResponse response)
        {
            Adding.Add(response);

        }
     
    }
}
