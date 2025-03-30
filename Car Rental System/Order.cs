using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Car_Rental_System
{
    internal class Order : Entity
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
            RentalDays = null;
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
            return $"[{base.Format()}][{RentedCar.Model}][{PassportDetails}][{RentalDays}][{StatusOrder}][{RejectionReason}]";
        }

        public virtual void Parse(string record)
        {
            if (string.IsNullOrWhiteSpace(record))
            {
                throw new ArgumentException("Record cannot be null or empty.", nameof(record));
            }

            var parts = record.Trim().Split(new[] { "][" }, StringSplitOptions.None);
            if (parts.Length != 6)
            {
                throw new FormatException("Invalid record format.");
            }

            parts[0] = parts[0].TrimStart('[');
            parts[5] = parts[5].TrimEnd(']');

            if (!Guid.TryParse(parts[0], out Guid id))
            {
                throw new FormatException("Invalid ID format.");
            }

            if (!Guid.TryParse(parts[1], out Guid carId))
            {
                throw new FormatException("Invalid Car ID format.");
            }

            if (!int.TryParse(parts[2], out int rentalDays))
            {
                throw new FormatException("Invalid rental days format.");
            }

            string passportDetails = parts[3];
            string rejectionReason = parts[4];
            string statusOrder = parts[5];

            RentedCar = new Car { Id = carId };
            RentalDays = rentalDays;
            PassportDetails = passportDetails;
            RejectionReason = rejectionReason;
            StatusOrder = statusOrder;
        }
}
}
