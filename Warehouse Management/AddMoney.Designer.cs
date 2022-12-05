
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
            this.ConfirmButtBuy = new System.Windows.Forms.Button();
            this.MoneyAsk = new System.Windows.Forms.Label();
            this.MoneyAdd = new System.Windows.Forms.TextBox();
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
            // ConfirmButtBuy
            // 
            this.ConfirmButtBuy.Location = new System.Drawing.Point(32, 180);
            this.ConfirmButtBuy.Name = "ConfirmButtBuy";
            this.ConfirmButtBuy.Size = new System.Drawing.Size(129, 36);
            this.ConfirmButtBuy.TabIndex = 3;
            this.ConfirmButtBuy.Text = "Confirm";
            this.ConfirmButtBuy.UseVisualStyleBackColor = true;
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
            // 
            // AddMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 288);
            this.Controls.Add(this.MoneyAdd);
            this.Controls.Add(this.MoneyAsk);
            this.Controls.Add(this.ConfirmButtBuy);
            this.Controls.Add(this.CancelButtCanc);
            this.Name = "AddMoney";
            this.Text = "Add Funds";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButtCanc;
        private System.Windows.Forms.Button ConfirmButtBuy;
        private System.Windows.Forms.Label MoneyAsk;
        private System.Windows.Forms.TextBox MoneyAdd;
    }
}