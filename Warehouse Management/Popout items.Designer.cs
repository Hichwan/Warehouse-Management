
namespace Warehouse_Management
{
    partial class Popout1
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
            this.ConfirmButtBuy = new System.Windows.Forms.Button();
            this.CancelButtCanc = new System.Windows.Forms.Button();
            this.IDboxBuy = new System.Windows.Forms.TextBox();
            this.IDITEMLAB = new System.Windows.Forms.Label();
            this.Quantlab = new System.Windows.Forms.Label();
            this.QuantityBuy = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ConfirmButtBuy
            // 
            this.ConfirmButtBuy.Location = new System.Drawing.Point(25, 191);
            this.ConfirmButtBuy.Name = "ConfirmButtBuy";
            this.ConfirmButtBuy.Size = new System.Drawing.Size(129, 36);
            this.ConfirmButtBuy.TabIndex = 0;
            this.ConfirmButtBuy.Text = "Confirm";
            this.ConfirmButtBuy.UseVisualStyleBackColor = true;
            this.ConfirmButtBuy.Click += new System.EventHandler(this.ConfirmButt_Click);
            // 
            // CancelButtCanc
            // 
            this.CancelButtCanc.Location = new System.Drawing.Point(194, 193);
            this.CancelButtCanc.Name = "CancelButtCanc";
            this.CancelButtCanc.Size = new System.Drawing.Size(109, 34);
            this.CancelButtCanc.TabIndex = 1;
            this.CancelButtCanc.Text = "Cancel";
            this.CancelButtCanc.UseVisualStyleBackColor = true;
            this.CancelButtCanc.Click += new System.EventHandler(this.CancelButt_Click);
            // 
            // IDboxBuy
            // 
            this.IDboxBuy.Location = new System.Drawing.Point(25, 81);
            this.IDboxBuy.Name = "IDboxBuy";
            this.IDboxBuy.Size = new System.Drawing.Size(278, 20);
            this.IDboxBuy.TabIndex = 2;
            this.IDboxBuy.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // IDITEMLAB
            // 
            this.IDITEMLAB.AutoSize = true;
            this.IDITEMLAB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDITEMLAB.Location = new System.Drawing.Point(110, 41);
            this.IDITEMLAB.Name = "IDITEMLAB";
            this.IDITEMLAB.Size = new System.Drawing.Size(126, 18);
            this.IDITEMLAB.TabIndex = 3;
            this.IDITEMLAB.Text = "Enter ID of Item";
            this.IDITEMLAB.Click += new System.EventHandler(this.label1_Click);
            // 
            // Quantlab
            // 
            this.Quantlab.AutoSize = true;
            this.Quantlab.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantlab.Location = new System.Drawing.Point(104, 117);
            this.Quantlab.Name = "Quantlab";
            this.Quantlab.Size = new System.Drawing.Size(115, 18);
            this.Quantlab.TabIndex = 4;
            this.Quantlab.Text = "Enter Quantity";
            // 
            // QuantityBuy
            // 
            this.QuantityBuy.Location = new System.Drawing.Point(25, 150);
            this.QuantityBuy.Name = "QuantityBuy";
            this.QuantityBuy.Size = new System.Drawing.Size(278, 20);
            this.QuantityBuy.TabIndex = 5;
            // 
            // Popout1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 253);
            this.Controls.Add(this.QuantityBuy);
            this.Controls.Add(this.Quantlab);
            this.Controls.Add(this.IDITEMLAB);
            this.Controls.Add(this.IDboxBuy);
            this.Controls.Add(this.CancelButtCanc);
            this.Controls.Add(this.ConfirmButtBuy);
            this.Name = "Popout1";
            this.Text = "Buying";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConfirmButtBuy;
        private System.Windows.Forms.Button CancelButtCanc;
        private System.Windows.Forms.TextBox IDboxBuy;
        private System.Windows.Forms.Label IDITEMLAB;
        private System.Windows.Forms.Label Quantlab;
        private System.Windows.Forms.TextBox QuantityBuy;
    }
}