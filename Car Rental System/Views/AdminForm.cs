using MaterialSkin;
using MaterialSkin.Controls;

namespace Car_Rental_System.Views
{
    public partial class AdminForm : MaterialForm
    {
        public AdminForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red100, Primary.Red100, Primary.Red100, Accent.Cyan100, TextShade.WHITE);
        }

        private void clientBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            ClientForm clientForm = new ClientForm();
            clientForm.Show();
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {
            ModifyCarForm modifyCarForm = new ModifyCarForm();
            modifyCarForm.Show();
        }
    }
}
