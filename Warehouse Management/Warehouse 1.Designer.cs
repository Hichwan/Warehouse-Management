﻿
namespace Warehouse_Management
{
    partial class WarehouseApptest
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
            this.WelcomeBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddItem = new System.Windows.Forms.Button();
            this.Statement = new System.Windows.Forms.ComboBox();
            this.BuyItem = new System.Windows.Forms.Button();
            this.AddMoney = new System.Windows.Forms.Button();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ItemTable = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogInButt = new System.Windows.Forms.Button();
            this.LogOutButt = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.DeleteItem = new System.Windows.Forms.Button();
            this.ModifyButton = new System.Windows.Forms.Button();
            this.ActionLog = new System.Windows.Forms.Button();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.Balance = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ItemTable)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomeBox
            // 
            this.WelcomeBox.Location = new System.Drawing.Point(264, 12);
            this.WelcomeBox.Name = "WelcomeBox";
            this.WelcomeBox.ReadOnly = true;
            this.WelcomeBox.Size = new System.Drawing.Size(292, 20);
            this.WelcomeBox.TabIndex = 0;
            this.WelcomeBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Statement Logs";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddItem
            // 
            this.AddItem.Location = new System.Drawing.Point(32, 248);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(115, 50);
            this.AddItem.TabIndex = 3;
            this.AddItem.Text = "Add Item";
            this.AddItem.UseVisualStyleBackColor = true;
            this.AddItem.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // Statement
            // 
            this.Statement.FormattingEnabled = true;
            this.Statement.Items.AddRange(new object[] {
            "December",
            "November",
            "October"});
            this.Statement.Location = new System.Drawing.Point(19, 64);
            this.Statement.Name = "Statement";
            this.Statement.Size = new System.Drawing.Size(127, 21);
            this.Statement.TabIndex = 5;
            this.Statement.Text = "December";
            this.Statement.SelectedIndexChanged += new System.EventHandler(this.Statement_SelectedIndexChanged);
            // 
            // BuyItem
            // 
            this.BuyItem.Location = new System.Drawing.Point(31, 316);
            this.BuyItem.Name = "BuyItem";
            this.BuyItem.Size = new System.Drawing.Size(114, 55);
            this.BuyItem.TabIndex = 7;
            this.BuyItem.Text = "Buy Item";
            this.BuyItem.UseVisualStyleBackColor = true;
            this.BuyItem.Click += new System.EventHandler(this.BuyItem_Click);
            // 
            // AddMoney
            // 
            this.AddMoney.Location = new System.Drawing.Point(191, 318);
            this.AddMoney.Name = "AddMoney";
            this.AddMoney.Size = new System.Drawing.Size(109, 52);
            this.AddMoney.TabIndex = 8;
            this.AddMoney.Text = "Add Money To your Account";
            this.AddMoney.UseVisualStyleBackColor = true;
            this.AddMoney.Click += new System.EventHandler(this.AddMoney_Click);
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(536, 260);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(133, 20);
            this.UsernameBox.TabIndex = 9;
            this.UsernameBox.TextChanged += new System.EventHandler(this.UsernameBox_TextChanged);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(532, 322);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(136, 20);
            this.PasswordBox.TabIndex = 10;
            this.PasswordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(529, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(535, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Password";
            // 
            // ItemTable
            // 
            this.ItemTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.ID,
            this.Quantity,
            this.Category,
            this.Price});
            this.ItemTable.Location = new System.Drawing.Point(144, 87);
            this.ItemTable.Name = "ItemTable";
            this.ItemTable.Size = new System.Drawing.Size(553, 144);
            this.ItemTable.TabIndex = 13;
            this.ItemTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // LogInButt
            // 
            this.LogInButt.Location = new System.Drawing.Point(538, 358);
            this.LogInButt.Name = "LogInButt";
            this.LogInButt.Size = new System.Drawing.Size(79, 33);
            this.LogInButt.TabIndex = 14;
            this.LogInButt.Text = "Log In";
            this.LogInButt.UseVisualStyleBackColor = true;
            this.LogInButt.Click += new System.EventHandler(this.LogInButt_Click);
            // 
            // LogOutButt
            // 
            this.LogOutButt.Location = new System.Drawing.Point(636, 360);
            this.LogOutButt.Name = "LogOutButt";
            this.LogOutButt.Size = new System.Drawing.Size(61, 30);
            this.LogOutButt.TabIndex = 15;
            this.LogOutButt.Text = "Log Out";
            this.LogOutButt.UseVisualStyleBackColor = true;
            this.LogOutButt.Click += new System.EventHandler(this.LogOutButt_Click);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(300, 35);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(240, 46);
            this.textBox4.TabIndex = 16;
            this.textBox4.Text = "Warehouse #123\r\nLocation: 128 Fresno Lane 92390 Los Elis, CA\r\n";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DeleteItem
            // 
            this.DeleteItem.Location = new System.Drawing.Point(192, 249);
            this.DeleteItem.Name = "DeleteItem";
            this.DeleteItem.Size = new System.Drawing.Size(109, 48);
            this.DeleteItem.TabIndex = 4;
            this.DeleteItem.Text = "Delete Item";
            this.DeleteItem.UseVisualStyleBackColor = true;
            this.DeleteItem.Click += new System.EventHandler(this.DeleteItem_Click);
            // 
            // ModifyButton
            // 
            this.ModifyButton.Location = new System.Drawing.Point(350, 319);
            this.ModifyButton.Name = "ModifyButton";
            this.ModifyButton.Size = new System.Drawing.Size(153, 52);
            this.ModifyButton.TabIndex = 17;
            this.ModifyButton.Text = "Modify Item";
            this.ModifyButton.UseVisualStyleBackColor = true;
            this.ModifyButton.Click += new System.EventHandler(this.ModifyButton_Click);
            // 
            // ActionLog
            // 
            this.ActionLog.Location = new System.Drawing.Point(21, 104);
            this.ActionLog.Name = "ActionLog";
            this.ActionLog.Size = new System.Drawing.Size(113, 41);
            this.ActionLog.TabIndex = 18;
            this.ActionLog.Text = "View Action Log";
            this.ActionLog.UseVisualStyleBackColor = true;
            this.ActionLog.Click += new System.EventHandler(this.button1_Click);
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceLabel.Location = new System.Drawing.Point(336, 234);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(176, 29);
            this.BalanceLabel.TabIndex = 19;
            this.BalanceLabel.Text = "User Balance:";
            // 
            // Balance
            // 
            this.Balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balance.Location = new System.Drawing.Point(350, 277);
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            this.Balance.Size = new System.Drawing.Size(153, 26);
            this.Balance.TabIndex = 20;
            this.Balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Balance.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // WarehouseApptest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Balance);
            this.Controls.Add(this.BalanceLabel);
            this.Controls.Add(this.ActionLog);
            this.Controls.Add(this.ModifyButton);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.LogOutButt);
            this.Controls.Add(this.LogInButt);
            this.Controls.Add(this.ItemTable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.AddMoney);
            this.Controls.Add(this.BuyItem);
            this.Controls.Add(this.Statement);
            this.Controls.Add(this.DeleteItem);
            this.Controls.Add(this.AddItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WelcomeBox);
 //           this.Name = "WarehouseApptest";
            this.Text = "Warehouse App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WelcomeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddItem;
        private System.Windows.Forms.ComboBox Statement;
        private System.Windows.Forms.Button BuyItem;
        private System.Windows.Forms.Button AddMoney;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.DataGridView ItemTable;
        private new System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Button LogInButt;
        private System.Windows.Forms.Button LogOutButt;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button DeleteItem;
        private System.Windows.Forms.Button ModifyButton;
        private System.Windows.Forms.Button ActionLog;
        private System.Windows.Forms.Label BalanceLabel;
        public System.Windows.Forms.TextBox Balance;
    }
}

