using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_System
{
    internal class User : Entity
    {
        public override string FileName => "user.txt";
        public string? Name { get; set; }
        public string? Email { get; set; }
        public User()
        {
            Name = string.Empty;
            Email = string.Empty;
        }
        public User(Guid id, string name, string email) : base(id)
        {
            Name = name;
            Email = email;
        }

        public new bool IsValid()
        {
            return base.IsValid() && !string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(Email); 
        }
        public override string Format()
        {
            return $"[{base.Format()}][{Name}][{Email}]";
        }
        public virtual void Parse(string record)
        {
            if (string.IsNullOrWhiteSpace(record))
            {
                throw new ArgumentException("Record cannot be null or empty.", nameof(record));
            }

            var parts = record.Trim('[', ']').Split(new[] { "][" }, StringSplitOptions.None);

            if (parts.Length != 3)
            {
                throw new FormatException("Invalid record format.");
            }

            if (!Guid.TryParse(parts[0], out Guid id))
            {
                throw new FormatException("Invalid ID format.");
            }

            Id = id;
            Name = parts[1];
            Email = parts[2];
        }
    }
}
