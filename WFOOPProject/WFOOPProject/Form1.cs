using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Student: Gabriel Paz Paiva
 * Description: Oriented Object Programming Project - Summer 2021
 * Starting Date: 24 June 2021.
 *Version 1.0 - 29/06/2021 - Layout creation, Temp App, and IP application.
  Version 2.0 - 08/07/2021 - MoneyConversion created.
  Version 3.0 - 16/07/2021 -  Started to Create the LottoMax layout, and finished IP, Money Exchange and Temp apps.
  Version 4.0 - 17/07/2024 - Finished LottoMax and Lott649, add ReadFiles functions, added some exeptions clauses, and revied everything.*/

namespace WFOOPProject
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }
       
        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to quit this application?","Exit ?", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                Application.Exit();
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            SimpleCalc Calculator = new SimpleCalc();
            Calculator.Show();
        }

        private void btnIP_Click(object sender, EventArgs e)
        {
            IP4Validator IpVal = new IP4Validator();
            IpVal.Show();
        }

        private void btnTempConv_Click(object sender, EventArgs e)
        {
            TempApp TempInst = new TempApp();
            TempInst.Show();
        }

        private void btnMoneyExc_Click(object sender, EventArgs e)
        {
            MoneyConversion MoneyInst = new MoneyConversion();
            MoneyInst.Show();
        }

        private void btnLottoMax_Click(object sender, EventArgs e)
        {
            LottoMax LottoMaxInst = new LottoMax();
            LottoMaxInst.Show();
        }

        private void btnLotto649_Click(object sender, EventArgs e)
        {
            Lotto649 Lotto649Inst = new Lotto649();
            Lotto649Inst.Show();
        }
    }
}
