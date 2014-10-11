namespace billproject
{
    partial class HomePageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.manageBillsButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelManageBills = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonSchoolType = new System.Windows.Forms.RadioButton();
            this.radioButtonStoreType = new System.Windows.Forms.RadioButton();
            this.buttonGenerateBill = new System.Windows.Forms.Button();
            this.groupBoxAddSub = new System.Windows.Forms.GroupBox();
            this.radioButtonSub = new System.Windows.Forms.RadioButton();
            this.radioButtonAdd = new System.Windows.Forms.RadioButton();
            this.listBoxBills2 = new System.Windows.Forms.ListBox();
            this.listBoxBills1 = new System.Windows.Forms.ListBox();
            this.labelBills2 = new System.Windows.Forms.Label();
            this.labelBills1 = new System.Windows.Forms.Label();
            this.homePageButtonManage = new System.Windows.Forms.Button();
            this.labelGenerate = new System.Windows.Forms.Label();
            this.panelManageBills.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxAddSub.SuspendLayout();
            this.SuspendLayout();
            // 
            // manageBillsButton
            // 
            this.manageBillsButton.Location = new System.Drawing.Point(224, 188);
            this.manageBillsButton.Name = "manageBillsButton";
            this.manageBillsButton.Size = new System.Drawing.Size(122, 23);
            this.manageBillsButton.TabIndex = 2;
            this.manageBillsButton.Text = "Manage Bills";
            this.manageBillsButton.UseVisualStyleBackColor = true;
            this.manageBillsButton.Click += new System.EventHandler(this.manageBillsButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(411, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Show my bills";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create Bill";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panelManageBills
            // 
            this.panelManageBills.Controls.Add(this.labelGenerate);
            this.panelManageBills.Controls.Add(this.groupBox1);
            this.panelManageBills.Controls.Add(this.buttonGenerateBill);
            this.panelManageBills.Controls.Add(this.groupBoxAddSub);
            this.panelManageBills.Controls.Add(this.listBoxBills2);
            this.panelManageBills.Controls.Add(this.listBoxBills1);
            this.panelManageBills.Controls.Add(this.labelBills2);
            this.panelManageBills.Controls.Add(this.labelBills1);
            this.panelManageBills.Controls.Add(this.homePageButtonManage);
            this.panelManageBills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelManageBills.Location = new System.Drawing.Point(0, 0);
            this.panelManageBills.Name = "panelManageBills";
            this.panelManageBills.Size = new System.Drawing.Size(588, 418);
            this.panelManageBills.TabIndex = 3;
            this.panelManageBills.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonSchoolType);
            this.groupBox1.Controls.Add(this.radioButtonStoreType);
            this.groupBox1.Location = new System.Drawing.Point(224, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 51);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bills type";
            // 
            // radioButtonSchoolType
            // 
            this.radioButtonSchoolType.AutoSize = true;
            this.radioButtonSchoolType.Location = new System.Drawing.Point(80, 19);
            this.radioButtonSchoolType.Name = "radioButtonSchoolType";
            this.radioButtonSchoolType.Size = new System.Drawing.Size(58, 17);
            this.radioButtonSchoolType.TabIndex = 1;
            this.radioButtonSchoolType.TabStop = true;
            this.radioButtonSchoolType.Text = "School";
            this.radioButtonSchoolType.UseVisualStyleBackColor = true;
            this.radioButtonSchoolType.CheckedChanged += new System.EventHandler(this.radioButtonSchoolType_CheckedChanged);
            // 
            // radioButtonStoreType
            // 
            this.radioButtonStoreType.AutoSize = true;
            this.radioButtonStoreType.Location = new System.Drawing.Point(7, 20);
            this.radioButtonStoreType.Name = "radioButtonStoreType";
            this.radioButtonStoreType.Size = new System.Drawing.Size(50, 17);
            this.radioButtonStoreType.TabIndex = 0;
            this.radioButtonStoreType.TabStop = true;
            this.radioButtonStoreType.Text = "Store";
            this.radioButtonStoreType.UseVisualStyleBackColor = true;
            this.radioButtonStoreType.CheckedChanged += new System.EventHandler(this.radioButtonStoreType_CheckedChanged);
            // 
            // buttonGenerateBill
            // 
            this.buttonGenerateBill.Location = new System.Drawing.Point(266, 217);
            this.buttonGenerateBill.Name = "buttonGenerateBill";
            this.buttonGenerateBill.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerateBill.TabIndex = 7;
            this.buttonGenerateBill.Text = "Generate";
            this.buttonGenerateBill.UseVisualStyleBackColor = true;
            this.buttonGenerateBill.Click += new System.EventHandler(this.buttonGenerateBill_Click);
            // 
            // groupBoxAddSub
            // 
            this.groupBoxAddSub.Controls.Add(this.radioButtonSub);
            this.groupBoxAddSub.Controls.Add(this.radioButtonAdd);
            this.groupBoxAddSub.Location = new System.Drawing.Point(266, 115);
            this.groupBoxAddSub.Name = "groupBoxAddSub";
            this.groupBoxAddSub.Size = new System.Drawing.Size(66, 67);
            this.groupBoxAddSub.TabIndex = 6;
            this.groupBoxAddSub.TabStop = false;
            // 
            // radioButtonSub
            // 
            this.radioButtonSub.AutoSize = true;
            this.radioButtonSub.Location = new System.Drawing.Point(7, 44);
            this.radioButtonSub.Name = "radioButtonSub";
            this.radioButtonSub.Size = new System.Drawing.Size(47, 17);
            this.radioButtonSub.TabIndex = 1;
            this.radioButtonSub.TabStop = true;
            this.radioButtonSub.Text = "SUB";
            this.radioButtonSub.UseVisualStyleBackColor = true;
            // 
            // radioButtonAdd
            // 
            this.radioButtonAdd.AutoSize = true;
            this.radioButtonAdd.Location = new System.Drawing.Point(7, 20);
            this.radioButtonAdd.Name = "radioButtonAdd";
            this.radioButtonAdd.Size = new System.Drawing.Size(48, 17);
            this.radioButtonAdd.TabIndex = 0;
            this.radioButtonAdd.TabStop = true;
            this.radioButtonAdd.Text = "ADD";
            this.radioButtonAdd.UseVisualStyleBackColor = true;
            // 
            // listBoxBills2
            // 
            this.listBoxBills2.FormattingEnabled = true;
            this.listBoxBills2.Location = new System.Drawing.Point(414, 99);
            this.listBoxBills2.Name = "listBoxBills2";
            this.listBoxBills2.Size = new System.Drawing.Size(120, 95);
            this.listBoxBills2.TabIndex = 4;
            // 
            // listBoxBills1
            // 
            this.listBoxBills1.FormattingEnabled = true;
            this.listBoxBills1.Location = new System.Drawing.Point(56, 99);
            this.listBoxBills1.Name = "listBoxBills1";
            this.listBoxBills1.Size = new System.Drawing.Size(120, 95);
            this.listBoxBills1.TabIndex = 3;
            // 
            // labelBills2
            // 
            this.labelBills2.AutoSize = true;
            this.labelBills2.Location = new System.Drawing.Point(411, 67);
            this.labelBills2.Name = "labelBills2";
            this.labelBills2.Size = new System.Drawing.Size(99, 13);
            this.labelBills2.TabIndex = 2;
            this.labelBills2.Text = "Select a second bill";
            // 
            // labelBills1
            // 
            this.labelBills1.AutoSize = true;
            this.labelBills1.Location = new System.Drawing.Point(53, 67);
            this.labelBills1.Name = "labelBills1";
            this.labelBills1.Size = new System.Drawing.Size(61, 13);
            this.labelBills1.TabIndex = 1;
            this.labelBills1.Text = "Select a bill";
            // 
            // homePageButtonManage
            // 
            this.homePageButtonManage.Location = new System.Drawing.Point(13, 13);
            this.homePageButtonManage.Name = "homePageButtonManage";
            this.homePageButtonManage.Size = new System.Drawing.Size(75, 23);
            this.homePageButtonManage.TabIndex = 0;
            this.homePageButtonManage.Text = "Home Page";
            this.homePageButtonManage.UseVisualStyleBackColor = true;
            this.homePageButtonManage.Click += new System.EventHandler(this.homePageButtonManage_Click);
            // 
            // labelGenerate
            // 
            this.labelGenerate.AutoSize = true;
            this.labelGenerate.Location = new System.Drawing.Point(285, 269);
            this.labelGenerate.Name = "labelGenerate";
            this.labelGenerate.Size = new System.Drawing.Size(35, 13);
            this.labelGenerate.TabIndex = 9;
            this.labelGenerate.Text = "label1";
            // 
            // HomePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 418);
            this.Controls.Add(this.panelManageBills);
            this.Controls.Add(this.manageBillsButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "HomePageForm";
            this.Text = "Form1";
            this.panelManageBills.ResumeLayout(false);
            this.panelManageBills.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxAddSub.ResumeLayout(false);
            this.groupBoxAddSub.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button manageBillsButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelManageBills;
        private System.Windows.Forms.Button homePageButtonManage;
        private System.Windows.Forms.Label labelBills1;
        private System.Windows.Forms.GroupBox groupBoxAddSub;
        private System.Windows.Forms.ListBox listBoxBills2;
        private System.Windows.Forms.ListBox listBoxBills1;
        private System.Windows.Forms.Label labelBills2;
        private System.Windows.Forms.RadioButton radioButtonSub;
        private System.Windows.Forms.RadioButton radioButtonAdd;
        private System.Windows.Forms.Button buttonGenerateBill;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonSchoolType;
        private System.Windows.Forms.RadioButton radioButtonStoreType;
        private System.Windows.Forms.Label labelGenerate;

    }
}