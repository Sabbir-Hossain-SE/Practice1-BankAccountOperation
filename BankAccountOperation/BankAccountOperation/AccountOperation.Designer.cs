﻿namespace BankAccountOperation
{
    partial class AccountOperation
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.accountNUmberTextBox = new System.Windows.Forms.TextBox();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.depositButton = new System.Windows.Forms.Button();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.createButton);
            this.groupBox1.Controls.Add(this.customerNameTextBox);
            this.groupBox1.Controls.Add(this.accountNUmberTextBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 172);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Creation";
            // 
            // accountNUmberTextBox
            // 
            this.accountNUmberTextBox.Location = new System.Drawing.Point(173, 20);
            this.accountNUmberTextBox.Name = "accountNUmberTextBox";
            this.accountNUmberTextBox.Size = new System.Drawing.Size(459, 20);
            this.accountNUmberTextBox.TabIndex = 0;
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(173, 73);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(459, 20);
            this.customerNameTextBox.TabIndex = 1;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(557, 99);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 2;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Account Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Customer Nmae";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.withdrawButton);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.depositButton);
            this.groupBox2.Controls.Add(this.amountTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(754, 90);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transaction";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Amount";
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(405, 46);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(137, 23);
            this.depositButton.TabIndex = 2;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(214, 20);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(370, 20);
            this.amountTextBox.TabIndex = 0;
            // 
            // withdrawButton
            // 
            this.withdrawButton.Location = new System.Drawing.Point(251, 46);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(137, 23);
            this.withdrawButton.TabIndex = 4;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(263, 328);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(291, 23);
            this.reportButton.TabIndex = 6;
            this.reportButton.Text = "Report";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // AccountOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AccountOperation";
            this.Text = "Account Operation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.TextBox accountNUmberTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Button reportButton;
    }
}

