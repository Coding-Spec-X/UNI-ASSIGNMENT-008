using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Simulator
{
    public partial class Form1 : Form
    {
        double clientBalance = 40000.00; ///Set balance to your desired amount

        public Form1()
        {
            InitializeComponent();
        }
        //METHID FOR DEPOSITS
        private void checkDeposit(double depositAmount)
        {
            if (depositAmount < 20 || depositAmount > 200)
            {
                MessageBox.Show("Inavalid Amount.");
            }
            clientBalance += depositAmount;
            depositTextBox.Clear();
            depositTextBox.Focus();
        }
        private void depositButton_Click(object sender, EventArgs e)
        {
            //get the deposit amount
            double deposit = double.Parse(depositTextBox.Text);
            depositTextBox.Text = deposit.ToString();
            //Display the balance
            double balance = clientBalance + deposit;
            balanceTextBox.Text = balance.ToString("c");
            //evoke checkDeposit method and call in value from the textbox
            checkDeposit(deposit);
        }

        //METHOD FOR ATM WITHDRAWALS
        private void checkWithdrawal(double withdrawalAmount)
        {
            if (withdrawalAmount < 20 || withdrawalAmount > clientBalance)
            {
                MessageBox.Show("Inavalid Amount.");
            }
            clientBalance -= withdrawalAmount;
            depositTextBox.Clear();
            depositTextBox.Focus();
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            //get values from textbox to withdraw from balance
            double withdraw = double.Parse(depositTextBox.Text);
            depositTextBox.Text = withdraw.ToString();
            //calculate withdrawal amount
            double balance = clientBalance - withdraw;
            balanceTextBox.Text = balance.ToString("c");
            //evoke checkWithdrawal method and call in value from the textbox
            checkWithdrawal(withdraw);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            balanceTextBox.Text = "$40,000.00";
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            depositTextBox.Clear();
            balanceTextBox.Clear();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}