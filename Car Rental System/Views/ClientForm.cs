using Car_Rental_System.Models;
using Car_Rental_System.Views;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Car_Rental_System
{
    public partial class ClientForm : MaterialForm
    {
        public ClientForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }


        private void rentBtn_Click(object sender, EventArgs e)
        {

        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            this.Hide();
        }
    }
}
