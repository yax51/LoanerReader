using System.Collections.ObjectModel;
using System.Data;
using System.Management.Automation;
using Microsoft.Management.Infrastructure;
using System.Management.Automation.Runspaces;


namespace LoanerReader
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            if (TxtLoanerName.Text != "")
            {
                string LoanerName = TxtLoanerName.Text.ToUpper();
                string PSScript = "Get-ADComputer -Filter {(Name -like " + "'" + LoanerName + "*'" + ")} -Properties Name, Description | select Name, Description";
                this.Cursor = Cursors.WaitCursor;
                RefreshTable();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Name");
                dataTable.Columns.Add("Description");

                using (PowerShell powerShell = PowerShell.Create().AddScript(PSScript))
                {

                    foreach (PSObject result in powerShell.Invoke())
                    {
                        dataTable.Rows.Add(result.Properties["Name"].Value, result.Properties["Description"].Value);
                    }
                }
                Table.DataSource = dataTable;
                Table.Columns[0].Width = 400;
                this.Cursor = Cursors.Default;
            }
            else
            {
                MessageBox.Show("Error. Loaner Name cannot be blank!");
                TxtLoanerName.Focus();
            }


        }

        private void RefreshTable()
        {
            Table.DataSource = null;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnLoad_Click(sender, e);
            }
        }
    }

}
