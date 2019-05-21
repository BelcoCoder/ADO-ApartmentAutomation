namespace _ADO_ApartmentOtomation
{
    partial class IForm
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
            this.gboxAddP = new System.Windows.Forms.GroupBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.nmAp = new System.Windows.Forms.NumericUpDown();
            this.nmAm = new System.Windows.Forms.NumericUpDown();
            this.lbApartment = new System.Windows.Forms.ListBox();
            this.lbAmount = new System.Windows.Forms.ListBox();
            this.lbDate = new System.Windows.Forms.ListBox();
            this.gboxAddP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmAp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmAm)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxAddP
            // 
            this.gboxAddP.Controls.Add(this.nmAm);
            this.gboxAddP.Controls.Add(this.nmAp);
            this.gboxAddP.Controls.Add(this.dtpDate);
            this.gboxAddP.Controls.Add(this.btnAdd);
            this.gboxAddP.Controls.Add(this.lbl3);
            this.gboxAddP.Controls.Add(this.lbl2);
            this.gboxAddP.Controls.Add(this.lbl1);
            this.gboxAddP.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.gboxAddP.Location = new System.Drawing.Point(13, 13);
            this.gboxAddP.Name = "gboxAddP";
            this.gboxAddP.Size = new System.Drawing.Size(709, 214);
            this.gboxAddP.TabIndex = 0;
            this.gboxAddP.TabStop = false;
            this.gboxAddP.Text = "Add Payment";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(17, 61);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(197, 44);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Apartment";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(17, 147);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(152, 44);
            this.lbl2.TabIndex = 0;
            this.lbl2.Text = "Amount";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(366, 61);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(100, 44);
            this.lbl3.TabIndex = 0;
            this.lbl3.Text = "Date";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(383, 144);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(320, 50);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(472, 55);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(231, 50);
            this.dtpDate.TabIndex = 5;
            // 
            // nmAp
            // 
            this.nmAp.Location = new System.Drawing.Point(220, 61);
            this.nmAp.Name = "nmAp";
            this.nmAp.Size = new System.Drawing.Size(120, 50);
            this.nmAp.TabIndex = 6;
            // 
            // nmAm
            // 
            this.nmAm.Location = new System.Drawing.Point(220, 145);
            this.nmAm.Name = "nmAm";
            this.nmAm.Size = new System.Drawing.Size(120, 50);
            this.nmAm.TabIndex = 7;
            // 
            // lbApartment
            // 
            this.lbApartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.lbApartment.FormattingEnabled = true;
            this.lbApartment.ItemHeight = 44;
            this.lbApartment.Location = new System.Drawing.Point(13, 234);
            this.lbApartment.Name = "lbApartment";
            this.lbApartment.Size = new System.Drawing.Size(231, 224);
            this.lbApartment.TabIndex = 1;
            // 
            // lbAmount
            // 
            this.lbAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.lbAmount.FormattingEnabled = true;
            this.lbAmount.ItemHeight = 44;
            this.lbAmount.Location = new System.Drawing.Point(250, 234);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(229, 224);
            this.lbAmount.TabIndex = 1;
            // 
            // lbDate
            // 
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.lbDate.FormattingEnabled = true;
            this.lbDate.ItemHeight = 44;
            this.lbDate.Location = new System.Drawing.Point(485, 233);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(239, 224);
            this.lbDate.TabIndex = 1;
            // 
            // IForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.lbApartment);
            this.Controls.Add(this.gboxAddP);
            this.Name = "IForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.IForm_Load);
            this.gboxAddP.ResumeLayout(false);
            this.gboxAddP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmAp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmAm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxAddP;
        private System.Windows.Forms.NumericUpDown nmAm;
        private System.Windows.Forms.NumericUpDown nmAp;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.ListBox lbApartment;
        private System.Windows.Forms.ListBox lbAmount;
        private System.Windows.Forms.ListBox lbDate;
    }
}

