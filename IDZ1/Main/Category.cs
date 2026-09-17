using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public string Info => $"{Name} - {Type}";
    }
}
