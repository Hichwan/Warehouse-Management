
namespace Warehouse_Management
{
    partial class PopoutDelete
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
            this.ItemDelLab = new System.Windows.Forms.Label();
            this.IDboxDel = new System.Windows.Forms.TextBox();
            this.ConfirmButtDel = new System.Windows.Forms.Button();
            this.CancelButtDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ItemDelLab
            // 
            this.ItemDelLab.AutoSize = true;
            this.ItemDelLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemDelLab.Location = new System.Drawing.Point(58, 54);
            this.ItemDelLab.Name = "ItemDelLab";
            this.ItemDelLab.Size = new System.Drawing.Size(192, 18);
            this.ItemDelLab.TabIndex = 4;
            this.ItemDelLab.Text = "Enter ID of Item Deleting";
            // 
            // IDboxDel
            // 
            this.IDboxDel.Location = new System.Drawing.Point(12, 113);
            this.IDboxDel.Name = "IDboxDel";
            this.IDboxDel.Size = new System.Drawing.Size(278, 20);
            this.IDboxDel.TabIndex = 5;
            this.IDboxDel.TextChanged += new System.EventHandler(this.IDboxDel_TextChanged);
            // 
            // ConfirmButtDel
            // 
            this.ConfirmButtDel.Location = new System.Drawing.Point(12, 167);
            this.ConfirmButtDel.Name = "ConfirmButtDel";
            this.ConfirmButtDel.Size = new System.Drawing.Size(129, 36);
            this.ConfirmButtDel.TabIndex = 6;
            this.ConfirmButtDel.Text = "Confirm";
            this.ConfirmButtDel.UseVisualStyleBackColor = true;
            this.ConfirmButtDel.Click += new System.EventHandler(this.ConfirmButtDel_Click);
            // 
            // CancelButtDel
            // 
            this.CancelButtDel.Location = new System.Drawing.Point(171, 167);
            this.CancelButtDel.Name = "CancelButtDel";
            this.CancelButtDel.Size = new System.Drawing.Size(109, 34);
            this.CancelButtDel.TabIndex = 7;
            this.CancelButtDel.Text = "Cancel";
            this.CancelButtDel.UseVisualStyleBackColor = true;
            this.CancelButtDel.Click += new System.EventHandler(this.CancelButtDel_Click);
            // 
            // PopoutDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 280);
            this.Controls.Add(this.CancelButtDel);
            this.Controls.Add(this.ConfirmButtDel);
            this.Controls.Add(this.IDboxDel);
            this.Controls.Add(this.ItemDelLab);
            this.Name = "PopoutDelete";
            this.Text = "Deleting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ItemDelLab;
        private System.Windows.Forms.TextBox IDboxDel;
        private System.Windows.Forms.Button ConfirmButtDel;
        private System.Windows.Forms.Button CancelButtDel;
    }
}