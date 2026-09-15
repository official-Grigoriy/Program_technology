using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    internal class Chef
    {
        //поля
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Specialty { get; set; }

        //конструкторы
        public Chef(int id, string fullName, string specialty)
        {
            Id = id;
            FullName = fullName;
            Specialty = specialty;
        }
        public Chef()
        {
            Id = 0;
            FullName = "None";
            Specialty = "не устроен";
        }


        //свойства
    }
}
