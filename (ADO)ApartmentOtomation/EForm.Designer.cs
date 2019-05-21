namespace _ADO_ApartmentOtomation
{
    partial class EForm
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
            this.gbAdde = new System.Windows.Forms.GroupBox();
            this.clb1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.nmAmount = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbExpense = new System.Windows.Forms.ListBox();
            this.lbAmount = new System.Windows.Forms.ListBox();
            this.lbDate = new System.Windows.Forms.ListBox();
            this.gbAdde.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAdde
            // 
            this.gbAdde.Controls.Add(this.btnAdd);
            this.gbAdde.Controls.Add(this.nmAmount);
            this.gbAdde.Controls.Add(this.dtpDate);
            this.gbAdde.Controls.Add(this.label2);
            this.gbAdde.Controls.Add(this.label1);
            this.gbAdde.Controls.Add(this.clb1);
            this.gbAdde.Location = new System.Drawing.Point(12, 12);
            this.gbAdde.Name = "gbAdde";
            this.gbAdde.Size = new System.Drawing.Size(710, 238);
            this.gbAdde.TabIndex = 0;
            this.gbAdde.TabStop = false;
            this.gbAdde.Text = "Add Expense";
            // 
            // clb1
            // 
            this.clb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.clb1.FormattingEnabled = true;
            this.clb1.Items.AddRange(new object[] {
            "Electricity",
            "Water",
            "Elevator",
            "Cleaning"});
            this.clb1.Location = new System.Drawing.Point(16, 59);
            this.clb1.Name = "clb1";
            this.clb1.Size = new System.Drawing.Size(235, 154);
            this.clb1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(464, 110);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(240, 50);
            this.dtpDate.TabIndex = 2;
            // 
            // nmAmount
            // 
            this.nmAmount.Location = new System.Drawing.Point(464, 44);
            this.nmAmount.Name = "nmAmount";
            this.nmAmount.Size = new System.Drawing.Size(240, 50);
            this.nmAmount.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(464, 183);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(240, 49);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbExpense
            // 
            this.lbExpense.FormattingEnabled = true;
            this.lbExpense.ItemHeight = 44;
            this.lbExpense.Location = new System.Drawing.Point(13, 267);
            this.lbExpense.Name = "lbExpense";
            this.lbExpense.Size = new System.Drawing.Size(209, 180);
            this.lbExpense.TabIndex = 1;
            // 
            // lbAmount
            // 
            this.lbAmount.FormattingEnabled = true;
            this.lbAmount.ItemHeight = 44;
            this.lbAmount.Location = new System.Drawing.Point(228, 267);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(242, 180);
            this.lbAmount.TabIndex = 1;
            // 
            // lbDate
            // 
            this.lbDate.FormattingEnabled = true;
            this.lbDate.ItemHeight = 44;
            this.lbDate.Location = new System.Drawing.Point(476, 267);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(250, 180);
            this.lbDate.TabIndex = 1;
            // 
            // EForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 44F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.lbExpense);
            this.Controls.Add(this.gbAdde);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.Name = "EForm";
            this.Text = "EForm";
            this.Load += new System.EventHandler(this.EForm_Load);
            this.gbAdde.ResumeLayout(false);
            this.gbAdde.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAdde;
        private System.Windows.Forms.CheckedListBox clb1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown nmAmount;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbExpense;
        private System.Windows.Forms.ListBox lbAmount;
        private System.Windows.Forms.ListBox lbDate;
    }
}