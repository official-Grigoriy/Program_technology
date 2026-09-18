using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    public class Chef
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Specialty { get; set; }
        public bool IsChef => Specialty == "Шеф-повар";

        public string GetInfo()
        {
            if (IsChef) return $"{ FullName} - { Specialty}";

            return FullName;
        }
    }
}
