using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    /// <summary>
    /// id, название категоии, тип
    /// </summary>
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        /// <summary>
        /// имя-фамилия
        /// </summary>
        public string Info => $"{Name} - {Type}";
    }
}