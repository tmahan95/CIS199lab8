namespace Lab8
{
    partial class DateForm
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
            this.yearTxtBox = new System.Windows.Forms.TextBox();
            this.dayTxtBox = new System.Windows.Forms.TextBox();
            this.monthTxtBox = new System.Windows.Forms.TextBox();
            this.dispLbl = new System.Windows.Forms.Label();
            this.updateYearBttn = new System.Windows.Forms.Button();
            this.updateDayBttn = new System.Windows.Forms.Button();
            this.monthUpdateBttn = new System.Windows.Forms.Button();
            this.dateLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // yearTxtBox
            // 
            this.yearTxtBox.Location = new System.Drawing.Point(12, 139);
            this.yearTxtBox.Name = "yearTxtBox";
            this.yearTxtBox.Size = new System.Drawing.Size(100, 20);
            this.yearTxtBox.TabIndex = 4;
            // 
            // dayTxtBox
            // 
            this.dayTxtBox.Location = new System.Drawing.Point(12, 96);
            this.dayTxtBox.Name = "dayTxtBox";
            this.dayTxtBox.Size = new System.Drawing.Size(100, 20);
            this.dayTxtBox.TabIndex = 2;
            // 
            // monthTxtBox
            // 
            this.monthTxtBox.Location = new System.Drawing.Point(12, 52);
            this.monthTxtBox.Name = "monthTxtBox";
            this.monthTxtBox.Size = new System.Drawing.Size(100, 20);
            this.monthTxtBox.TabIndex = 0;
            // 
            // dispLbl
            // 
            this.dispLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dispLbl.Location = new System.Drawing.Point(136, 197);
            this.dispLbl.Name = "dispLbl";
            this.dispLbl.Size = new System.Drawing.Size(100, 23);
            this.dispLbl.TabIndex = 3;
            // 
            // updateYearBttn
            // 
            this.updateYearBttn.Location = new System.Drawing.Point(147, 136);
            this.updateYearBttn.Name = "updateYearBttn";
            this.updateYearBttn.Size = new System.Drawing.Size(89, 23);
            this.updateYearBttn.TabIndex = 5;
            this.updateYearBttn.Text = "Update Year";
            this.updateYearBttn.UseVisualStyleBackColor = true;
            this.updateYearBttn.Click += new System.EventHandler(this.updateYearBttn_Click);
            // 
            // updateDayBttn
            // 
            this.updateDayBttn.Location = new System.Drawing.Point(147, 94);
            this.updateDayBttn.Name = "updateDayBttn";
            this.updateDayBttn.Size = new System.Drawing.Size(89, 23);
            this.updateDayBttn.TabIndex = 3;
            this.updateDayBttn.Text = "Update Day";
            this.updateDayBttn.UseVisualStyleBackColor = true;
            this.updateDayBttn.Click += new System.EventHandler(this.updateDayBttn_Click);
            // 
            // monthUpdateBttn
            // 
            this.monthUpdateBttn.Location = new System.Drawing.Point(147, 49);
            this.monthUpdateBttn.Name = "monthUpdateBttn";
            this.monthUpdateBttn.Size = new System.Drawing.Size(89, 23);
            this.monthUpdateBttn.TabIndex = 1;
            this.monthUpdateBttn.Text = "Update Month";
            this.monthUpdateBttn.UseVisualStyleBackColor = true;
            this.monthUpdateBttn.Click += new System.EventHandler(this.monthUpdateBttn_Click);
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Location = new System.Drawing.Point(79, 198);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(33, 13);
            this.dateLbl.TabIndex = 7;
            this.dateLbl.Text = "Date:";
            // 
            // DateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.monthUpdateBttn);
            this.Controls.Add(this.updateDayBttn);
            this.Controls.Add(this.updateYearBttn);
            this.Controls.Add(this.dispLbl);
            this.Controls.Add(this.monthTxtBox);
            this.Controls.Add(this.dayTxtBox);
            this.Controls.Add(this.yearTxtBox);
            this.Name = "DateForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.makeDateObject);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox yearTxtBox;
        private System.Windows.Forms.TextBox dayTxtBox;
        private System.Windows.Forms.TextBox monthTxtBox;
        private System.Windows.Forms.Label dispLbl;
        private System.Windows.Forms.Button updateYearBttn;
        private System.Windows.Forms.Button updateDayBttn;
        private System.Windows.Forms.Button monthUpdateBttn;
        private System.Windows.Forms.Label dateLbl;
    }
}

