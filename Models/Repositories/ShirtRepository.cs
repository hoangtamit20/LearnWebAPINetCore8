using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAPINet8.Models.Repositories
{
    public static class ShirtRepository
    {
        private static List<Shirt> shirts = new List<Shirt>(){
            new Shirt(1, "Lacoste", "Blue", 10, "Men", 100),
            new Shirt(2, "Nike", "Red", 12, "Women", 120),
            new Shirt(3, "Adidas", "Black", 14, "Unisex", 140),
            new Shirt(4, "Levi's", "White", 16, "Men", 160),
            new Shirt(5, "Vans", "Green", 18, "Women", 180)
        };
        public static bool shirtExists(int id)
        {
            return shirts.Any(s => s.ShirtID == id);
        }

        public static Shirt? getShirtById(int id)
        {
            return shirts.FirstOrDefault(s => s.ShirtID == id);
        }
    }
}