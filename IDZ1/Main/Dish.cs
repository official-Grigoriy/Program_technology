using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    internal class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Chefid { get; set; }
        public int Categoryid { get; set; }
        public decimal Price { get; set; }
        public int Weight { get; set; }

    }
}
