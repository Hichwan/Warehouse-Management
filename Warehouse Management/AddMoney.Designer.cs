
namespace Warehouse_Management
{
    partial class AddMoney
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
            this.CancelButtCanc = new System.Windows.Forms.Button();
            this.ConfirmButtMoney = new System.Windows.Forms.Button();
            this.MoneyAsk = new System.Windows.Forms.Label();
            this.MoneyAdd = new System.Windows.Forms.TextBox();
            this.CurrentBalance = new System.Windows.Forms.TextBox();
            this.Balance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelButtCanc
            // 
            this.CancelButtCanc.Location = new System.Drawing.Point(189, 182);
            this.CancelButtCanc.Name = "CancelButtCanc";
            this.CancelButtCanc.Size = new System.Drawing.Size(109, 34);
            this.CancelButtCanc.TabIndex = 2;
            this.CancelButtCanc.Text = "Cancel";
            this.CancelButtCanc.UseVisualStyleBackColor = true;
            this.CancelButtCanc.Click += new System.EventHandler(this.CancelButtCanc_Click);
            // 
            // ConfirmButtMoney
            // 
            this.ConfirmButtMoney.Location = new System.Drawing.Point(32, 180);
            this.ConfirmButtMoney.Name = "ConfirmButtMoney";
            this.ConfirmButtMoney.Size = new System.Drawing.Size(129, 36);
            this.ConfirmButtMoney.TabIndex = 3;
            this.ConfirmButtMoney.Text = "Confirm";
            this.ConfirmButtMoney.UseVisualStyleBackColor = true;
            this.ConfirmButtMoney.Click += new System.EventHandler(this.ConfirmButtBuy_Click);
            // 
            // MoneyAsk
            // 
            this.MoneyAsk.AutoSize = true;
            this.MoneyAsk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoneyAsk.Location = new System.Drawing.Point(69, 81);
            this.MoneyAsk.Name = "MoneyAsk";
            this.MoneyAsk.Size = new System.Drawing.Size(188, 18);
            this.MoneyAsk.TabIndex = 4;
            this.MoneyAsk.Text = "Enter How Much Money";
            this.MoneyAsk.Click += new System.EventHandler(this.IDITEMLAB_Click);
            // 
            // MoneyAdd
            // 
            this.MoneyAdd.Location = new System.Drawing.Point(32, 128);
            this.MoneyAdd.Name = "MoneyAdd";
            this.MoneyAdd.Size = new System.Drawing.Size(278, 20);
            this.MoneyAdd.TabIndex = 6;
            this.MoneyAdd.TextChanged += new System.EventHandler(this.MoneyAdd_TextChanged);
            this.MoneyAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MoneyAdd_KeyPress);
            // 
            // CurrentBalance
            // 
            this.CurrentBalance.Location = new System.Drawing.Point(32, 43);
            this.CurrentBalance.Name = "CurrentBalance";
            this.CurrentBalance.ReadOnly = true;
            this.CurrentBalance.Size = new System.Drawing.Size(275, 20);
            this.CurrentBalance.TabIndex = 8;
            // 
            // Balance
            // 
            this.Balance.AutoSize = true;
            this.Balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balance.Location = new System.Drawing.Point(69, 9);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(129, 18);
            this.Balance.TabIndex = 9;
            this.Balance.Text = "Current Balance";
            // 
            // AddMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 288);
            this.Controls.Add(this.Balance);
            this.Controls.Add(this.CurrentBalance);
            this.Controls.Add(this.MoneyAdd);
            this.Controls.Add(this.MoneyAsk);
            this.Controls.Add(this.ConfirmButtMoney);
            this.Controls.Add(this.CancelButtCanc);
            this.Name = "AddMoney";
            this.Text = "Add Funds";
            this.Load += new System.EventHandler(this.AddMoney_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButtCanc;
        private System.Windows.Forms.Button ConfirmButtMoney;
        private System.Windows.Forms.Label MoneyAsk;
        private System.Windows.Forms.TextBox MoneyAdd;
        private System.Windows.Forms.TextBox CurrentBalance;
        private System.Windows.Forms.Label Balance;
    }
}