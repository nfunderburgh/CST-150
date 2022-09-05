using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Milestone_3
{
    public partial class LoginScreen : MaterialForm
    {
        Form2 form2;
        public LoginScreen()
        {
            InitializeComponent();

            form2 = new Form2(this);
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue800, Primary.BlueGrey500, Accent.LightBlue700, TextShade.WHITE);
        }

        // Used to check if the user selected the correct username password
        private void submitButton_Click(object sender, EventArgs e)
        {
            if(usernameTextbox.Text == "user" && passwordTextbox.Text == "123")
            {
                this.Hide();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Either your username or password is incorrect","Invalid credentials");
            }
        }
    }
}
