using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_System
{
    internal interface IEntity
    {
        public Guid Id { get; set; }
        public bool Search(string searchString);
        public void Parse(string record);
        public bool IsValid();
    }
}
