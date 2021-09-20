using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


/*Flags credits: https://www.flaticon.com/br/packs/countrys-flags */

namespace WFOOPProject
{
    public partial class MoneyConversion : Form
    {
        public MoneyConversion()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit the application Money Exchange?", "Exit ?", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
        }

        public string ConvertValues (string Fromopt, string Toopt)
        {
            //The app will verify if the option chosed are the same
            if(Fromopt == Toopt)
            { return (Convert.ToDouble(txtFrom.Text)).ToString(); } //Just to remove if there is 0 before
            else
            {
                //If its not, then itt will get the strings togheter and it will compare it with the strings from the dictionaty to retrive the exchange factor
                Dictionary<string, double> ExchangeFactor = new Dictionary<string, double>();
                ExchangeFactor.Add("CADUSD", 0.797171);
                ExchangeFactor.Add("USDCAD", 1.25444);
                ExchangeFactor.Add("CADEUR", 1.48608);
                ExchangeFactor.Add("EURCAD", 0.672911);
                ExchangeFactor.Add("CADGBP", 1.72956);
                ExchangeFactor.Add("GBPCAD", 0.578180);
                ExchangeFactor.Add("CADBRL", 4.19256);
                ExchangeFactor.Add("BRLCAD", 0.238518);
                ExchangeFactor.Add("USDEUR", 0.844274);
                ExchangeFactor.Add("EURUSD", 1.18445);
                ExchangeFactor.Add("USDGBP", 0.725285);
                ExchangeFactor.Add("GBPUSD", 1.37874);
                ExchangeFactor.Add("BRLUSD", 0.190117);
                ExchangeFactor.Add("USDBRL", 5.25992);
                ExchangeFactor.Add("EURGBP", 0.859034);
                ExchangeFactor.Add("GBPEUR", 1.16410);
                ExchangeFactor.Add("EURBRL", 6.22808);
                ExchangeFactor.Add("BRLEUR", 0.160561);
                ExchangeFactor.Add("GBPBRL", 7.25179);
                ExchangeFactor.Add("BRLGBP", 0.137889);

                return (Convert.ToDouble(txtFrom.Text) * ExchangeFactor[Fromopt+ Toopt]).ToString("0.00");
            }
        }
        
        private void btnConvert_Click(object sender, EventArgs e)
        { 
            string FromOption = "", ToOption = "";
            try
            {
                //Verifies the From option
                foreach (RadioButton rbtnFrom in groupBox1.Controls.OfType<RadioButton>())
                { if (rbtnFrom.Checked) { FromOption = rbtnFrom.Text; break; } }
                
                //Verifies the To option
                foreach (RadioButton rbtnTo in groupBox2.Controls.OfType<RadioButton>())
                { if (rbtnTo.Checked) { ToOption = rbtnTo.Text; break; } }
                if (ToOption == "") { throw new InvalidOperationException("Please select one 'To' radiobox option."); }
                txtTo.Text = this.ConvertValues(FromOption, ToOption);

                //Starting exportation
                DateTime dateodnow = DateTime.Now;
                FileStream directory = new FileStream(@"../../txtfiles/MoneyConversions.txt", FileMode.Append,FileAccess.Write);
                StreamWriter file = new StreamWriter(directory);
                file.WriteLine(txtFrom.Text + " " + FromOption + " = " + txtTo.Text + " " + ToOption + ", " + dateodnow.ToShortDateString() + " " + dateodnow.ToLongTimeString()); ;
                file.Close();
                directory.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(@"../../txtfiles/MoneyConversions.txt")) throw new Exception("File not created yet. Please do at least one convertion first.");
                FileStream directory = new FileStream(@"../../txtfiles/MoneyConversions.txt", FileMode.Open, FileAccess.Read);
                StreamReader file = new StreamReader(directory);
                string textoprint = "FROM\tTO\t\tDATE\n" + file.ReadToEnd();
                file.Close();
                directory.Close();
                MessageBox.Show(textoprint, "MoneyConversions.txt");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error"); }
        }
    }
}
