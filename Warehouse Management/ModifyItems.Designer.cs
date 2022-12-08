
namespace Warehouse_Management
{
    partial class ModifyItems
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
            this.ConfirmButtMod = new System.Windows.Forms.Button();
            this.IDITEMLAB = new System.Windows.Forms.Label();
            this.ModifyLab = new System.Windows.Forms.Label();
            this.IDboxMod = new System.Windows.Forms.TextBox();
            this.ChangeBox = new System.Windows.Forms.TextBox();
            this.ModList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CancelButtCanc
            // 
            this.CancelButtCanc.Location = new System.Drawing.Point(176, 260);
            this.CancelButtCanc.Name = "CancelButtCanc";
            this.CancelButtCanc.Size = new System.Drawing.Size(109, 34);
            this.CancelButtCanc.TabIndex = 2;
            this.CancelButtCanc.Text = "Cancel";
            this.CancelButtCanc.UseVisualStyleBackColor = true;
            this.CancelButtCanc.Click += new System.EventHandler(this.CancelButtCanc_Click);
            // 
            // ConfirmButtMod
            // 
            this.ConfirmButtMod.Location = new System.Drawing.Point(26, 258);
            this.ConfirmButtMod.Name = "ConfirmButtMod";
            this.ConfirmButtMod.Size = new System.Drawing.Size(129, 36);
            this.ConfirmButtMod.TabIndex = 3;
            this.ConfirmButtMod.Text = "Confirm";
            this.ConfirmButtMod.UseVisualStyleBackColor = true;
            this.ConfirmButtMod.Click += new System.EventHandler(this.ConfirmButtBuy_Click);
            // 
            // IDITEMLAB
            // 
            this.IDITEMLAB.AutoSize = true;
            this.IDITEMLAB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDITEMLAB.Location = new System.Drawing.Point(101, 64);
            this.IDITEMLAB.Name = "IDITEMLAB";
            this.IDITEMLAB.Size = new System.Drawing.Size(126, 18);
            this.IDITEMLAB.TabIndex = 4;
            this.IDITEMLAB.Text = "Enter ID of Item";
            // 
            // ModifyLab
            // 
            this.ModifyLab.AutoSize = true;
            this.ModifyLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyLab.Location = new System.Drawing.Point(78, 179);
            this.ModifyLab.Name = "ModifyLab";
            this.ModifyLab.Size = new System.Drawing.Size(91, 18);
            this.ModifyLab.TabIndex = 5;
            this.ModifyLab.Text = "Enter New:";
            this.ModifyLab.Click += new System.EventHandler(this.Quantlab_Click);
            // 
            // IDboxMod
            // 
            this.IDboxMod.Location = new System.Drawing.Point(26, 99);
            this.IDboxMod.Name = "IDboxMod";
            this.IDboxMod.Size = new System.Drawing.Size(278, 20);
            this.IDboxMod.TabIndex = 6;
            this.IDboxMod.TextChanged += new System.EventHandler(this.IDboxMod_TextChanged);
            // 
            // ChangeBox
            // 
            this.ChangeBox.Location = new System.Drawing.Point(26, 217);
            this.ChangeBox.Name = "ChangeBox";
            this.ChangeBox.Size = new System.Drawing.Size(278, 20);
            this.ChangeBox.TabIndex = 7;
            // 
            // ModList
            // 
            this.ModList.FormattingEnabled = true;
            this.ModList.Items.AddRange(new object[] {
            "Name",
            "Quantity",
            "Category",
            "Price"});
            this.ModList.Location = new System.Drawing.Point(175, 176);
            this.ModList.Name = "ModList";
            this.ModList.Size = new System.Drawing.Size(121, 21);
            this.ModList.TabIndex = 8;
            this.ModList.Text = "Name";
            this.ModList.SelectedIndexChanged += new System.EventHandler(this.ModList_SelectedIndexChanged);
            // 
            // ModifyItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 342);
            this.Controls.Add(this.ModList);
            this.Controls.Add(this.ChangeBox);
            this.Controls.Add(this.IDboxMod);
            this.Controls.Add(this.ModifyLab);
            this.Controls.Add(this.IDITEMLAB);
            this.Controls.Add(this.ConfirmButtMod);
            this.Controls.Add(this.CancelButtCanc);
            this.Name = "ModifyItems";
            this.Text = "Modify";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButtCanc;
        private System.Windows.Forms.Button ConfirmButtMod;
        private System.Windows.Forms.Label IDITEMLAB;
        private System.Windows.Forms.Label ModifyLab;
        private System.Windows.Forms.TextBox IDboxMod;
        private System.Windows.Forms.TextBox ChangeBox;
        private System.Windows.Forms.ComboBox ModList;
    }
}