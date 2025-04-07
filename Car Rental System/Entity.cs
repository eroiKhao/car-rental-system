using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_System
{
    internal abstract class Entity : IEntity
    {
        public virtual string FileName { get; }
        public Guid Id { get; set; }
        public Entity()
        {
            Id = Guid.NewGuid();
        }
        public Entity(Guid id)
        {
            Id = id;
        }
        public bool IsValid()
        {
            return Id != Guid.Empty;
        }
        public virtual string Format()
        {
            return Id.ToString();
        }
        public abstract void Parse(string record);
        public abstract bool Search(string searchString);
    }
}
