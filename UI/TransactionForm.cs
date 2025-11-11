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
        }
    }
}
