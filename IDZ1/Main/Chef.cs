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
        /// конструктор по умолчанию
        /// </summary>
        public Chef() { }

        /// <summary>
        /// консруктор шефов с проверкой правил
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fullName"></param>
        /// <param name="specialty"></param>
        /// <exception cref="ArgumentException"></exception>
        public Chef (int id, string fullName, string specialty)
        {
            if (id == 0) throw new ArgumentException("id должен быть больше 0.", nameof (id));
            if (string.IsNullOrWhiteSpace(fullName)) throw new ArgumentException("имя поввара не может быть пустым.", nameof(fullName));
            if (string.IsNullOrWhiteSpace(specialty)) throw new ArgumentException("специальность не должна быть пустой", nameof(specialty));

            Id = id;
            FullName = fullName;
            Specialty = specialty;
        }

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
