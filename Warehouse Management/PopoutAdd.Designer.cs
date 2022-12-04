
namespace Warehouse_Management
{
    partial class PopoutAdd
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
            this.IDITEMLAB = new System.Windows.Forms.Label();
            this.Quantlab = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ConfirmButtAdd = new System.Windows.Forms.Button();
            this.CancelButtAdd = new System.Windows.Forms.Button();
            this.IDboxBuy = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // IDITEMLAB
            // 
            this.IDITEMLAB.AutoSize = true;
            this.IDITEMLAB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDITEMLAB.Location = new System.Drawing.Point(98, 23);
            this.IDITEMLAB.Name = "IDITEMLAB";
            this.IDITEMLAB.Size = new System.Drawing.Size(154, 18);
            this.IDITEMLAB.TabIndex = 4;
            this.IDITEMLAB.Text = "Enter Name of Item";
            // 
            // Quantlab
            // 
            this.Quantlab.AutoSize = true;
            this.Quantlab.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantlab.Location = new System.Drawing.Point(98, 83);
            this.Quantlab.Name = "Quantlab";
            this.Quantlab.Size = new System.Drawing.Size(115, 18);
            this.Quantlab.TabIndex = 5;
            this.Quantlab.Text = "Enter Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter Cost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter Category";
            // 
            // ConfirmButtAdd
            // 
            this.ConfirmButtAdd.Location = new System.Drawing.Point(22, 284);
            this.ConfirmButtAdd.Name = "ConfirmButtAdd";
            this.ConfirmButtAdd.Size = new System.Drawing.Size(129, 36);
            this.ConfirmButtAdd.TabIndex = 8;
            this.ConfirmButtAdd.Text = "Confirm";
            this.ConfirmButtAdd.UseVisualStyleBackColor = true;
            // 
            // CancelButtAdd
            // 
            this.CancelButtAdd.Location = new System.Drawing.Point(199, 286);
            this.CancelButtAdd.Name = "CancelButtAdd";
            this.CancelButtAdd.Size = new System.Drawing.Size(109, 34);
            this.CancelButtAdd.TabIndex = 9;
            this.CancelButtAdd.Text = "Cancel";
            this.CancelButtAdd.UseVisualStyleBackColor = true;
            this.CancelButtAdd.Click += new System.EventHandler(this.CancelButtAdd_Click);
            // 
            // IDboxBuy
            // 
            this.IDboxBuy.Location = new System.Drawing.Point(40, 60);
            this.IDboxBuy.Name = "IDboxBuy";
            this.IDboxBuy.Size = new System.Drawing.Size(278, 20);
            this.IDboxBuy.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(278, 20);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(40, 189);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(278, 20);
            this.textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(40, 242);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(278, 20);
            this.textBox3.TabIndex = 13;
            // 
            // PopoutAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 380);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.IDboxBuy);
            this.Controls.Add(this.CancelButtAdd);
            this.Controls.Add(this.ConfirmButtAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Quantlab);
            this.Controls.Add(this.IDITEMLAB);
            this.Name = "PopoutAdd";
            this.Text = "Adding";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IDITEMLAB;
        private System.Windows.Forms.Label Quantlab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ConfirmButtAdd;
        private System.Windows.Forms.Button CancelButtAdd;
        private System.Windows.Forms.TextBox IDboxBuy;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}