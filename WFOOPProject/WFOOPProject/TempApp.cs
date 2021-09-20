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

namespace WFOOPProject
{
    public partial class TempApp : Form
    {
        public TempApp()
        {
            InitializeComponent();
        }

        Tempcalc Cal1 = new Tempcalc();        
        //True = C to F
        //False = F to C

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit the application TempApp?", "Exit ?", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
        }        

        private void radiobtnFtoC_CheckedChanged(object sender, EventArgs e)
        {
            labelResult.Text = "C";
            labelInput.Text = "F";
            txtInput.Text = txtResult.Text = "";
            Cal1.Convertstatus = false;
        }

        private void radiobtnCtoF_CheckedChanged(object sender, EventArgs e)
        {
            labelResult.Text = "F";
            labelInput.Text = "C";
            txtInput.Text = txtResult.Text = "";
            Cal1.Convertstatus = true;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                Cal1.Initval = Convert.ToDouble(txtInput.Text);
                if (Cal1.Convertstatus)
                    Cal1.Finalval = ((Cal1.Initval * 9 / 5) + 32);
                else
                    Cal1.Finalval = (Cal1.Initval - 32) * 5 / 9;
                txtResult.Text = Cal1.Finalval.ToString();
                txtboxMessage.Text = Cal1.Message();

                //Starting exportation
                DateTime dateodnow = DateTime.Now;
                FileStream directory = new FileStream(@"../../txtfiles/TempConversions.txt", FileMode.Append, FileAccess.Write);
                StreamWriter file = new StreamWriter(directory);
                if (Cal1.Convertstatus)
                    file.WriteLine(txtInput.Text + " C = " + txtResult.Text + " " + " F , " + dateodnow.ToShortDateString() + " " + dateodnow.ToLongTimeString());
                else
                    file.WriteLine(txtInput.Text + " F = " + txtResult.Text + " " + " C , " + dateodnow.ToShortDateString() + " " + dateodnow.ToLongTimeString());
                file.Close();
                directory.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :\n" + ex.Message + "\nPlease insert only numbers.", "Error");
                txtInput.Focus();
            }
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {

            try
            {
                if (!File.Exists(@"../../txtfiles/TempConversions.txt")) throw new Exception("File not created yet. Please do at least one convertion first.");
                FileStream directory = new FileStream(@"../../txtfiles/TempConversions.txt", FileMode.Open, FileAccess.Read);
                StreamReader file = new StreamReader(directory);
                string textoprint = "FROM\tTO\t\tDATE\n" + file.ReadToEnd();
                file.Close();
                directory.Close();
                MessageBox.Show(textoprint, "TempConversions.txt");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error"); }
            
        }
    }
    public class Tempcalc
    {
        private bool convertstatus;
        private double initval, finalval;

        public bool Convertstatus { get; set; }
        public double Initval { get; set; }
        public double Finalval { get; set; }

        public string Message()
        {
            if ((Convertstatus && Initval == 100) || (!Convertstatus && Initval == 212))
            {
                return "Water boils";
            } else if ((Convertstatus && Initval == 40) || (!Convertstatus && Initval == 104))
            {
                return "Hot Bath";
            }else if ((Convertstatus && Initval == 37) || (!Convertstatus && Initval == 98.6))
            {
                return "Body temperature";
            }else if ((Convertstatus  && Initval == 30) || (!Convertstatus && Initval == 86))
            {
                return "Beach weather";
            }else if ((Convertstatus  && Initval == 21) || (!Convertstatus && Initval == 70))
            {
                return "Room temperature";
            }else if ((Convertstatus && Initval == 10) || (!Convertstatus && Initval == 50))
            {
                return "Cool Day";
            }else if ((Convertstatus&& Initval == 0) || (!Convertstatus && Initval == 32))
            {
                return "Freezing point of water";
            }else if ((Convertstatus && Initval == -18) || (!Convertstatus && Initval == 0))
            {
                return "Very Cold Day";
            }else if (Initval == -40)
            {
                return "Extremely Cold Day\n(and the same number!)";
            }else { return ""; }
        }


    }
}
