using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public class Personel
    {
        private int children;
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int  DepartmentId { get; set; }

        public DateTime StartofWork { get; set; }
        public int NumOfChildren
        {
            get
            {
                return children;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("The number of children cannot be negative");
                }
                children = value;
            }
        }
        public bool MilitaryService { get; set; }
        public bool ForeignLanguage { get; set; }
        public bool OHS { get; set; }
        public bool Certificate_of_Mastery  { get; set; }

        public Personel(int id)
        {
            Id = id;
        }
        public override string ToString()
        {
            return $"{Id} - {Name} {Surname}";
        }
    }
}
