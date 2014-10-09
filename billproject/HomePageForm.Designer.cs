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
            this.homePageButtonManage = new System.Windows.Forms.Button();
            this.panelManageBills.SuspendLayout();
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
            this.manageBillsButton.Click += new System.EventHandler(this.button3_Click);
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
            this.panelManageBills.Controls.Add(this.homePageButtonManage);
            this.panelManageBills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelManageBills.Location = new System.Drawing.Point(0, 0);
            this.panelManageBills.Name = "panelManageBills";
            this.panelManageBills.Size = new System.Drawing.Size(588, 418);
            this.panelManageBills.TabIndex = 3;
            this.panelManageBills.Visible = false;
            // 
            // homePageButtonManage
            // 
            this.homePageButtonManage.Location = new System.Drawing.Point(13, 13);
            this.homePageButtonManage.Name = "homePageButtonManage";
            this.homePageButtonManage.Size = new System.Drawing.Size(75, 23);
            this.homePageButtonManage.TabIndex = 0;
            this.homePageButtonManage.Text = "Home Page";
            this.homePageButtonManage.UseVisualStyleBackColor = true;
            this.homePageButtonManage.Click += new System.EventHandler(this.button3_Click_1);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button manageBillsButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelManageBills;
        private System.Windows.Forms.Button homePageButtonManage;

    }
}