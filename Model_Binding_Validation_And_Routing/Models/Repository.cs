using System.Collections.Generic;

namespace Model_Binding_Validation_And_Routing.Models
{
    public static class Repository
    {
        private static List<Buyer> _buyer = new List<Buyer>();
        public static List<Buyer> GetBuyer()
        {
            return _buyer;
        }
        public static void SetBuyer(Buyer buyer)
        {
            _buyer.Add(buyer);
        }
    }
}
