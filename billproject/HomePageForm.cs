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
        private SchoolBill scBill = new SchoolBill(false);
        private StoreBill stBill = new StoreBill(false);

        public HomePageForm()
        {
            InitializeComponent();
        }

        private void manageBillsButton_Click(object sender, EventArgs e)
        {
            panelHomePage.Visible = false;
            panelManageBills.Visible = true;
            radioButtonStoreType.Checked = true;
            radioButtonAdd.Checked = true;
        }

        private void homePageButtonManage_Click(object sender, EventArgs e)
        {
            panelManageBills.Visible = false;
            panelHomePage.Visible = true;
        }

        private void buttonGenerateBill_Click(object sender, EventArgs e)
        {
            if (radioButtonStoreType.Checked)
            {
                StoreBill bill = new StoreBill(false);
                StoreBill bill2 = new StoreBill(false);
                bill.Load(Convert.ToInt32(listBoxBills1.SelectedItem));
                bill2.Load(Convert.ToInt32(listBoxBills2.SelectedItem));

                StoreBill bill3 = new StoreBill(false);
                if (radioButtonAdd.Checked)
                    bill3 = (StoreBill)((Bill)bill + (Bill)bill2);
                else
                    bill3 = (StoreBill)((Bill)bill - (Bill)bill2);

                bill3.Save();
                radioButtonStoreType_CheckedChanged(sender, e);

                labelGenerate.Text = "------- Bill created ! -------\n\n" + bill3.PrintArticles();

                labelGenerate.Visible = true;
            }
            else
            {
                SchoolBill bill = new SchoolBill(false);
                SchoolBill bill2 = new SchoolBill(false);
                bill.Load(Convert.ToInt32(listBoxBills1.SelectedItem));
                bill2.Load(Convert.ToInt32(listBoxBills2.SelectedItem));

                SchoolBill bill3 = new SchoolBill(false);
                if (radioButtonAdd.Checked)
                    bill3 = (SchoolBill)((Bill)bill + (Bill)bill2);
                else
                    bill3 = (SchoolBill)((Bill)bill - (Bill)bill2);

                bill3.Save();

                radioButtonSchoolType_CheckedChanged(sender, e);

                labelGenerate.Text = "------- Bill created ! -------\n\n" + bill3.PrintArticles();

                labelGenerate.Visible = true;
            }
        }

        private void radioButtonSchoolType_CheckedChanged(object sender, EventArgs e)
        {
            listBoxBills1.Items.Clear();
            listBoxBills2.Items.Clear();
            labelGenerate.Visible = false;
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
            labelGenerate.Visible = false;
            DirectoryInfo directory = new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(), @"StoreBills"));
            FileInfo[] files = directory.GetFiles();
            var idFiles = files.Select(f => f).Where(f => (f.Attributes & FileAttributes.Hidden) == 0);

            foreach (FileInfo fi in idFiles)
            {
                listBoxBills1.Items.Add(fi.Name.Split(new char[] { '.' })[0]);
                listBoxBills2.Items.Add(fi.Name.Split(new char[] { '.' })[0]);
            }
        }

        private void listBoxBills1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButtonStoreType.Checked)
            {
                StoreBill bill = new StoreBill(false);
                bill.Load(Convert.ToInt32(listBoxBills1.SelectedItem));
                labelGenerate.Text = "Bill selected :\n\n" + bill.PrintArticles();
                labelGenerate.Visible = true;
            }
            else
            {
                SchoolBill bill = new SchoolBill(false);
                bill.Load(Convert.ToInt32(listBoxBills1.SelectedItem));
                labelGenerate.Text = "Bill selected :\n\n" + bill.PrintArticles();
                labelGenerate.Visible = true;
            }
        }

        private void listBoxBills2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButtonStoreType.Checked)
            {
                StoreBill bill = new StoreBill(false);
                bill.Load(Convert.ToInt32(listBoxBills2.SelectedItem));
                labelGenerate.Text = "Bill selected :\n\n" + bill.PrintArticles();
                labelGenerate.Visible = true;
            }
            else
            {
                SchoolBill bill = new SchoolBill(false);
                bill.Load(Convert.ToInt32(listBoxBills2.SelectedItem));
                labelGenerate.Text = "Bill selected :\n\n" + bill.PrintArticles();
                labelGenerate.Visible = true;
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            ShowPanel.Visible = true;
            labelShowBill.Visible = false;
            radioButtonStoreShow.Checked = true;
            panelHomePage.Visible = false;
        }

        private void buttonHomePageShow_Click(object sender, EventArgs e)
        {
            ShowPanel.Visible = false;
            panelHomePage.Visible = true;
            listBoxShowBill.Items.Clear();
        }

        private void listBoxShowBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButtonStoreShow.Checked)
            {
                StoreBill bill = new StoreBill(false);
                bill.Load(Convert.ToInt32(listBoxShowBill.SelectedItem));
                labelShowBill.Text = "------ Bill selected : ------\n\n" + bill.PrintArticles();
                labelShowBill.Visible = true;
            }
            else
            {
                SchoolBill bill = new SchoolBill(false);
                bill.Load(Convert.ToInt32(listBoxShowBill.SelectedItem));
                labelShowBill.Text = "------ Bill selected : ------\n\n" + bill.PrintArticles();
                labelShowBill.Visible = true;
            }
        }

        private void radioButtonStoreShow_CheckedChanged(object sender, EventArgs e)
        {
            labelShowBill.Visible = false;
            listBoxShowBill.Items.Clear();
            DirectoryInfo directory = new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(), @"StoreBills"));
            FileInfo[] files = directory.GetFiles();
            var idFiles = files.Select(f => f).Where(f => (f.Attributes & FileAttributes.Hidden) == 0);

            foreach (FileInfo fi in idFiles)
            {
                listBoxShowBill.Items.Add(fi.Name.Split(new char[] { '.' })[0]);
            }
        }

        private void radioButtonSchoolShow_CheckedChanged(object sender, EventArgs e)
        {
            labelShowBill.Visible = false;
            listBoxShowBill.Items.Clear();
            DirectoryInfo directory = new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(), @"SchoolBills"));
            FileInfo[] files = directory.GetFiles();
            var idFiles = files.Select(f => f).Where(f => (f.Attributes & FileAttributes.Hidden) == 0);

            foreach (FileInfo fi in idFiles)
            {
                listBoxShowBill.Items.Add(fi.Name.Split(new char[] { '.' })[0]);
            }
        }

        private void createBillButton_Click(object sender, EventArgs e)
        {
            panelBeforeCreate.Visible = true;
            panelHomePage.Visible = false;
            groupBoxAddArticleCreate.Visible = false;
            labelBillCreated.Visible = false;
            radioButtonStoreTypeCreate.Checked = true;
            textBoxNameBillCreate.Enabled = true;
            groupBoxBillTypeCreate.Enabled = true;
            labelBillCreated.Text = "";
        }

        private void buttonHomePageCreate_Click(object sender, EventArgs e)
        {
            panelCreateBill.Visible = false;
            panelHomePage.Visible = true;
        }

        private void buttonSaveBillCreate_Click(object sender, EventArgs e)
        {
            textBoxNameBillCreate.Enabled = false;
            groupBoxBillTypeCreate.Enabled = false;
            buttonAddArticleBillCreate.Enabled = false;
            labelBillCreated.Visible = true;
            if (radioButtonStoreTypeCreate.Checked)
            {
                stBill.Name = textBoxNameBillCreate.TextLength > 0 ? textBoxNameBillCreate.Text : "Unknow";
                stBill.Save();
                labelBillCreated.Text = "------------\n------ Bill saved ! ------\n------------\n\n" + stBill.PrintArticles();
            }
            else
            {
                scBill.Name = textBoxNameBillCreate.TextLength > 0 ? textBoxNameBillCreate.Text : "Unknow";
                scBill.Save();
                labelBillCreated.Text = "------------\n------ Bill saved ! ------\n------------\n\n" + scBill.PrintArticles();
            }
        }

        private void buttonAddArticleCreate_Click(object sender, EventArgs e)
        {
            textBoxNameBillCreate.Enabled = false;
            groupBoxBillTypeCreate.Enabled = false;
            groupBoxAddArticleCreate.Visible = true;
            radioButtonTaxesFPAddArticle.Checked = true;
        }

        private void buttonAddArticleBillCreate_Click(object sender, EventArgs e)
        {
            labelBillCreated.Visible = true;
            Article.typeTaxes typeArt;
            if (radioButtonTaxesFPAddArticle.Checked)
            {
                typeArt = Article.typeTaxes.FP;
            }
            else if (radioButtonTaxesFAddArticle.Checked)
            {
                typeArt = Article.typeTaxes.F;
            }
            else if (radioButtonTaxesPAddArticle.Checked)
            {
                typeArt = Article.typeTaxes.P;
            }
            else
            {
                typeArt = Article.typeTaxes.O;
            }

            if (radioButtonStoreTypeCreate.Checked)
            {
                stBill.CreateArticle(textBoxNameArticleAdd.Text != "" ? textBoxNameArticleAdd.Text : "Unknow", textBoxQuantityArticleAdd.Text != "" ? Convert.ToInt32(textBoxQuantityArticleAdd.Text) : 0, textBoxPriceAddArticle.Text != "" ? Convert.ToDouble(textBoxPriceAddArticle.Text) : 0, typeArt);
                groupBoxAddArticleCreate.Visible = false;
                labelBillCreated.Text = "------ Bill creating : ------\n\n" + stBill.PrintArticles();
            }
            else
            {
                scBill.CreateArticle(textBoxNameArticleAdd.Text != "" ? textBoxNameArticleAdd.Text : "Unknow", textBoxQuantityArticleAdd.Text != "" ? Convert.ToInt32(textBoxQuantityArticleAdd.Text) : 0, textBoxPriceAddArticle.Text != "" ? Convert.ToDouble(textBoxPriceAddArticle.Text) : 0, typeArt);
                groupBoxAddArticleCreate.Visible = false;
                labelBillCreated.Text = "------ Bill creating : ------\n\n" + scBill.PrintArticles();
            }
        }

        private void buttonCreateBillCreate_Click(object sender, EventArgs e)
        {
            panelCreateBill.Visible = true;
            panelBeforeCreate.Visible = false;
        }

        private void buttonHomePageBeforeCreate_Click(object sender, EventArgs e)
        {
            panelHomePage.Visible = true;
            panelBeforeCreate.Visible = false;
        }
    }
}
