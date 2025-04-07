using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MaterialSkin;
using MaterialSkin.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Car_Rental_System
{
    internal class Car : Entity
    {
        public override string FileName => "cars.txt";
        public string? Model { get; set; }
        public string? CarStatus { get; set; }
        public int Year { get; set; }
        public Car()
        {
            Model = "";
            CarStatus = "";
            Year = 0;
        }
        public Car(Guid id, string model, string status, int year) : base(id)
        {
            Model = model;
            CarStatus = status;
            Year = year;
        }
        public new bool IsValid()
        {
            return base.IsValid() && !string.IsNullOrEmpty(Model) && !string.IsNullOrEmpty(CarStatus) && Year > 0;
        }
        public override string Format()
        {
            return $"[{base.Format()}][{Model}][{CarStatus}][{Year}]";
        }
        public override void Parse(string record)
        {
            if (string.IsNullOrWhiteSpace(record))
            {
                throw new ArgumentException("Record cannot be null or empty.", nameof(record));
            }

            var parts = record.Trim('[', ']').Split(new[] { "][" }, StringSplitOptions.None);

            if (parts.Length != 4)
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

            if (!int.TryParse(parts[3], out int year) || year <= 0)
            {
                throw new FormatException("Invalid year format.");
            }

            Year = year;
        }
        public override bool Search(string searchString)
        {
            return Model!.IndexOf(searchString, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   CarStatus!.IndexOf(searchString, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   Year.ToString().IndexOf(searchString, StringComparison.OrdinalIgnoreCase) >= 0;
        }
    }
}
