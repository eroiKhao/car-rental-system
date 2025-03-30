using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using System.IO;

namespace Car_Rental_System
{
    internal sealed class Client : User
    {
        public override string FileName => "clients.txt";
        public string? PassportDetails { get; set; }

        public Client ()
        {
            PassportDetails = string.Empty;
        }

        public Client(Guid id, string name, string email, string? passportDetails) : base(id, name, email)
        {
            PassportDetails = passportDetails;
        }
        public new bool IsValid()
        {
            return base.IsValid() && !string.IsNullOrEmpty(PassportDetails);
        }
        public override string Format()
        {
            return $"[{base.Format()}][{PassportDetails}]";
        }
        public new void Parse(string record)
        {
            base.Parse(record);
            var parts = record.Trim('[', ']').Split(new[] { "][" }, StringSplitOptions.None);
            if (parts.Length != 5)
            {
                throw new FormatException("Invalid record format.");
            }

            PassportDetails = parts[3];
        }
    }
}   
