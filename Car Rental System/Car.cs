using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MaterialSkin;
using MaterialSkin.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Car_Rental_System
{
    internal class Car : Entity
    {
        public override string FileName => "cars.txt";
        public string? Model { get; set; }
        public string? CarStatus { get; set; }
        public Car()
        {
            Model = string.Empty;
            CarStatus = string.Empty;
        }
        public Car(Guid id, string model, string status) : base(id)
        {
            Model = model;
            CarStatus = status;
        }
        public new bool IsValid()
        {
            return base.IsValid() && !string.IsNullOrEmpty(Model) && !string.IsNullOrEmpty(CarStatus);
        }
        public override string Format()
        {
            return $"[{base.Format()}][{Model}][{CarStatus}]";
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
            Model = parts[1];
            CarStatus = parts[2];
        }
    }
}
