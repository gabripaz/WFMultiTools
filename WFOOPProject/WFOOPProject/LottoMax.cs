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
using System.Text.RegularExpressions;

namespace WFOOPProject
{
    public partial class LottoMax : Form
    {
        public LottoMax()
        {
            InitializeComponent();
        }

        private void LottoMax_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit this application?", "Exit ?", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string numberslist = txtNumbers.Text = "";            
            for (int i = 1; i < 9; i++)
            {
                int randomNumber;
                do { randomNumber = random.Next(1, 50); }
                while (Regex.IsMatch(numberslist, @"(" + randomNumber.ToString() + ")"));   //Verifies if its reppeated and if yes, then it generates a new number.
                txtNumbers.Text += randomNumber.ToString() + Environment.NewLine;
                if (i == 8) numberslist += " Bonus " + randomNumber.ToString(); // verifies if its the last number and add Bonus if yes
                else if (i == 7) numberslist += randomNumber.ToString(); // verifies if its the penultimate number and removes comma if yes (as required)
                else numberslist += randomNumber.ToString() + ", ";
            }

            //Starting exportation
            DateTime dateodnow = DateTime.Now;
            FileStream directory = new FileStream(@"../../txtfiles/LottoNbrs.txt", FileMode.Append, FileAccess.Write);
            StreamWriter file = new StreamWriter(directory);
            file.WriteLine("Max,"+dateodnow.ToShortDateString() + " " + dateodnow.ToLongTimeString() + ", " + numberslist); ;
            file.Close();
            directory.Close();
        }

        private void btnreadfile_Click(object sender, EventArgs e)
        {
            try 
            {
                if (!File.Exists(@"../../txtfiles/LottoNbrs.txt")) throw new Exception("File not created yet. Please generate some numbers first.");
                FileStream directory = new FileStream(@"../../txtfiles/LottoNbrs.txt", FileMode.Open, FileAccess.Read);
                StreamReader file = new StreamReader(directory);
                string textoprint = file.ReadToEnd();
                file.Close();
                directory.Close();
                MessageBox.Show(textoprint, "LottoNbrs.txt");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error"); }
        }
    }
}
