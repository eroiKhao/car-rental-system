using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Car_Rental_System
{
    internal sealed class Admin : User
    {
        public override string FileName => "admin.txt";
        public string? Role { get; set; }
        public Admin()
        {
            Role = string.Empty;
        }
        public Admin(Guid id, string name, string email, string role) : base(id, name, email)
        {
            Role = role;
        }
        public new bool IsValid()
        {
            return base.IsValid() && !string.IsNullOrEmpty(Role);
        }
        public override string Format()
        {
            return $"[{base.Format()}][{Role}]";
        }
        public new void Parse(string record)
        {
            base.Parse(record);
            var parts = record.Trim('[', ']').Split(new[] { "][" }, StringSplitOptions.None);
            if (parts.Length != 4)
            {
                throw new FormatException("Invalid record format.");
            }

            Role = parts[3];
        }
    }
}
