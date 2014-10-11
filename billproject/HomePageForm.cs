using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace billproject
{
    public partial class HomePageForm : Form
    {
        public HomePageForm()
        {
            InitializeComponent();
        }

        private void manageBillsButton_Click(object sender, EventArgs e)
        {
            panelManageBills.Visible = true;

            radioButtonStoreType.Checked = true;
            radioButtonAdd.Checked = true;
            labelGenerate.Visible = false;
        }

        private void homePageButtonManage_Click(object sender, EventArgs e)
        {
            panelManageBills.Visible = false;
        }

        private void buttonGenerateBill_Click(object sender, EventArgs e)
        {
            if (radioButtonStoreType.Checked)
            {
                StoreBill bill = new StoreBill(false);
                StoreBill bill2 = new StoreBill(false);
                bill.Load(Convert.ToInt32(listBoxBills1.SelectedItem));
                bill2.Load(Convert.ToInt32(listBoxBills1.SelectedItem));

                StoreBill bill3 = new StoreBill(false);
                if (radioButtonAdd.Checked)
                    bill3 = (StoreBill)((Bill)bill + (Bill)bill2);
                else
                    bill3 = (StoreBill)((Bill)bill - (Bill)bill2);

                labelGenerate.Text = "Bill created : " + bill3.Name;

                labelGenerate.Visible = true;

                bill3.Save();
            }
            else
            {
                SchoolBill bill = new SchoolBill(false);
                SchoolBill bill2 = new SchoolBill(false);
                bill.Load(Convert.ToInt32(listBoxBills1.SelectedItem));
                bill2.Load(Convert.ToInt32(listBoxBills1.SelectedItem));

                SchoolBill bill3 = new SchoolBill(false);
                if (radioButtonAdd.Checked)
                    bill3 = (SchoolBill)((Bill)bill + (Bill)bill2);
                else
                    bill3 = (SchoolBill)((Bill)bill - (Bill)bill2);

                labelGenerate.Text = "Bill created : " + bill3.Name;

                labelGenerate.Visible = true;

                bill3.Save();
            }
        }

        private void radioButtonSchoolType_CheckedChanged(object sender, EventArgs e)
        {
            listBoxBills1.Items.Clear();
            listBoxBills2.Items.Clear();
            DirectoryInfo directory = new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(), @"SchoolBills"));
            FileInfo[] files = directory.GetFiles();
            var idFiles = files.Select(f => f).Where(f => (f.Attributes & FileAttributes.Hidden) == 0);

            foreach (FileInfo fi in idFiles)
            {
                listBoxBills1.Items.Add(fi.Name.Split(new char[] { '.' })[0]);
                listBoxBills2.Items.Add(fi.Name.Split(new char[] { '.' })[0]);
            }
        }

        private void radioButtonStoreType_CheckedChanged(object sender, EventArgs e)
        {
            listBoxBills1.Items.Clear();
            listBoxBills2.Items.Clear();
            DirectoryInfo directory = new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(), @"StoreBills"));
            FileInfo[] files = directory.GetFiles();
            var idFiles = files.Select(f => f).Where(f => (f.Attributes & FileAttributes.Hidden) == 0);

            foreach (FileInfo fi in idFiles)
            {
                listBoxBills1.Items.Add(fi.Name.Split(new char[] { '.' })[0]);
                listBoxBills2.Items.Add(fi.Name.Split(new char[] { '.' })[0]);
            }
        }
    }
}
