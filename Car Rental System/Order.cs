using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Car_Rental_System
{
    internal class Order : Entity, IEntity
    {
        public override string FileName => "orders.txt";
        public Car? RentedCar { get; set; }
        public int? RentalDays { get; set; }
        public string? PassportDetails { get; set; }
        public string? RejectionReason { get; set; }
        public string? StatusOrder { get; set; }
        public Order()
        {
            RentedCar = null;
            RentalDays = 0;
            PassportDetails = string.Empty;
            StatusOrder = "Pending";
            RejectionReason = string.Empty;
        }

        public Order(Guid id, Car rentedCar, int rentalDays, string passportDetails, string rejectionReason, string status = "Pending") : base(id)
        {
            RentedCar = rentedCar;
            RentalDays = rentalDays;
            PassportDetails = passportDetails;
            StatusOrder = status;
            RejectionReason = rejectionReason;
        }
        public new bool IsValid()
        {
            return base.IsValid() && !string.IsNullOrEmpty(PassportDetails) 
                && !string.IsNullOrEmpty(RejectionReason) && !string.IsNullOrEmpty(StatusOrder) 
                && RentedCar != null && RentalDays != null;
        }
        public override string Format()
        {
            return $"[{base.Format()}][{RentedCar.Model}][{RentedCar.Year}][{PassportDetails}][{RentalDays}][{StatusOrder}][{RejectionReason}]";
        }

        public virtual void Parse(string record)
        {
            if (string.IsNullOrWhiteSpace(record))
            {
                throw new ArgumentException("Record cannot be null or empty.", nameof(record));
            }

            var parts = record.Trim().TrimStart('[').TrimEnd(']').Split(new[] { "][" }, StringSplitOptions.None);

            if (parts.Length != 7)
            {
                throw new FormatException($"Invalid record format: {record}");
            }

            if (!Guid.TryParse(parts[0], out Guid id))
            {
                throw new FormatException("Invalid Order ID format.");
            }

            string carModel = parts[1];
            string carYear = parts[2];
            string passportDetails = parts[3];

            if (!int.TryParse(parts[4], out int rentalDays))
            {
                throw new FormatException("Invalid rental days format.");
            }

            string statusOrder = parts[5];
            string rejectionReason = parts[6].Trim();

            if (string.IsNullOrWhiteSpace(rejectionReason))
            {
                rejectionReason = "N/A";
            }
            RentedCar = new Car
            {
                Model = carModel,
                Year = int.TryParse(carYear, out int year) ? year : 0
            };
            RentalDays = rentalDays;
            PassportDetails = passportDetails;
            StatusOrder = statusOrder;
            RejectionReason = rejectionReason;
            Id = id;
        }

        public bool Search(string searchString)
        {
            return RejectionReason!.IndexOf(searchString, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   RentedCar.Model!.IndexOf(searchString, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   PassportDetails!.IndexOf(searchString, StringComparison.OrdinalIgnoreCase) >= 0;
        }
    }
}
