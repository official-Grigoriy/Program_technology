using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    /// <summary>
    /// id, ФИО повара, должность
    /// </summary>
    public class Chef
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Specialty { get; set; }
        public bool IsChef => Specialty == "Шеф-повар";

        /// <summary>
        /// если шеф
        /// </summary>
        /// <returns>фио и должность</returns>
        public string GetInfo()
        {
            if (IsChef) return $"{ FullName} - { Specialty}";

            return FullName;
        }
    }
}
