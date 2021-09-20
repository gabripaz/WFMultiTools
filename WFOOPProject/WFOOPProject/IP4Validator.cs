using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFOOPProject
{
    public partial class IP4Validator : Form
    {
        public IP4Validator()
        {
            InitializeComponent();
        }
        private void IP4Validator_Load(object sender, EventArgs e)
        {
            labelToday.Text = "Today: "+ DateTime.Now.ToLongDateString();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit the application IP4 Validator?", "Exit ?", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
        }
        private void btnValidateIP_Click(object sender, EventArgs e)
        {
            string[] arIptriad;
            byte temp;
            try 
            {                
                arIptriad = txtIpAddress.Text.Trim().Split('.'); //Separates each triad
                if (arIptriad.Length != 4) throw new Exception(); //Verify if the string has 4 '.'s, and if its not it calls exception
                for (byte i = 0; i < arIptriad.Length; i++) //Verify if the number its a byte
                {temp = Convert.ToByte(arIptriad[i]);}
                MessageBox.Show(txtIpAddress.Text + "\nThe IP is correct.", "Valid IP");
            }
            catch (Exception)
            {            
                MessageBox.Show(txtIpAddress.Text + "\nThe IP must have 4 bytes\ninteger number between 0 to 255\nseparated by a dot (255.255.255.255)", "Error");
                txtIpAddress.Focus();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtIpAddress.Text = "";
        }
    }
}
