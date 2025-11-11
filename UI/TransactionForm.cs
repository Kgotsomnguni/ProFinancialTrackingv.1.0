using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProFinancialTrackingv._1._0.Models;
using System.Collections.Generic;

namespace ProFinancialTrackingv._1._0.UI
{
    public partial class TransactionForm : Form
    {
        private List<Transaction> transactions = new List<Transaction>();
        private List<Expense> expenses = new List<Expense>();
        private List<Income> incomes = new List<Income>();
        public TransactionForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblNote_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //parse amount
            if(!decimal.TryParse(txtAmount.Text,out decimal amount))
            {
                MessageBox.Show("Please eneter a valid amount");
                return;
            }
            string type =cbType.SelectedItem?.ToString();
            if (type == "Income")
            {
                Income income = new Income
                {
                    Source = txtCategory.Text,
                    Amount = amount,
                    DateRecieved = dtpDate.Value
                };
                incomes.Add(income);
            }
            else if(type =="Expense")
            {
                Expense expense = new Expense
                {
                    Category = txtCategory.Text,
                    Amount = amount,
                    DateSpent = dtpDate.Value,
                    Note = txtNote.Text
                };
                expenses.Add(expense);
            }
            else
            {
                MessageBox.Show("Please select a valid transaction type");
                return;
            }
            MessageBox.Show("Transaction saved!");


                //Create new transaction
                Transaction t = new Transaction
                {
                    Type = cbType.SelectedItem.ToString(),
                    Amount = amount,
                    Date = dtpDate.Value,
                    Description = txtNote.Text
                };


            //add to list
            transactions.Add(t);

            //optional: clear fields for next entry
            txtAmount.Clear();
            txtCategory.Clear();
            txtNote.Clear();
            cbType.SelectedIndex = -1;
            dtpDate.Value = DateTime.Today;
            //UpdateTotals();
        }
        public void UpdateTotals()
        {
            decimal totalIncome = incomes.Sum(i=>i.Amount);
            decimal totalExpenses = expenses.Sum(e=>e.Amount);
            decimal balance = totalIncome - totalExpenses;

            // For now, just show in a MessageBox (later we’ll add labels on the form)
            Console.WriteLine($"Total Income: {totalIncome:C}");
            Console.WriteLine($"Total Expenses: {totalExpenses:C}");
            Console.WriteLine($"Balance: {balance:C}");
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
