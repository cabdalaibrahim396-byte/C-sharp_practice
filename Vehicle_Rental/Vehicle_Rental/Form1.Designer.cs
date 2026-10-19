namespace Vehicle_Rental
{
    partial class Form1
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdsuv = new System.Windows.Forms.RadioButton();
            this.rdluxury = new System.Windows.Forms.RadioButton();
            this.rdeconomy = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbinsurance = new System.Windows.Forms.CheckBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btncalculate = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.txtexperience = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblage = new System.Windows.Forms.Label();
            this.lblnumber = new System.Windows.Forms.Label();
            this.lblexperience = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdsuv);
            this.groupBox2.Controls.Add(this.rdluxury);
            this.groupBox2.Controls.Add(this.rdeconomy);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(68, 277);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 74);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Room Tyoe";
            // 
            // rdsuv
            // 
            this.rdsuv.AutoSize = true;
            this.rdsuv.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdsuv.Location = new System.Drawing.Point(151, 30);
            this.rdsuv.Name = "rdsuv";
            this.rdsuv.Size = new System.Drawing.Size(59, 20);
            this.rdsuv.TabIndex = 14;
            this.rdsuv.TabStop = true;
            this.rdsuv.Text = "SUV";
            this.rdsuv.UseVisualStyleBackColor = true;
            // 
            // rdluxury
            // 
            this.rdluxury.AutoSize = true;
            this.rdluxury.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdluxury.Location = new System.Drawing.Point(294, 30);
            this.rdluxury.Name = "rdluxury";
            this.rdluxury.Size = new System.Drawing.Size(72, 20);
            this.rdluxury.TabIndex = 13;
            this.rdluxury.TabStop = true;
            this.rdluxury.Text = "Luxury";
            this.rdluxury.UseVisualStyleBackColor = true;
            // 
            // rdeconomy
            // 
            this.rdeconomy.AutoSize = true;
            this.rdeconomy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdeconomy.Location = new System.Drawing.Point(16, 30);
            this.rdeconomy.Name = "rdeconomy";
            this.rdeconomy.Size = new System.Drawing.Size(92, 20);
            this.rdeconomy.TabIndex = 12;
            this.rdeconomy.TabStop = true;
            this.rdeconomy.Text = "Economy";
            this.rdeconomy.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbinsurance);
            this.groupBox1.Location = new System.Drawing.Point(68, 380);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 77);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Additional Option";
            // 
            // cbinsurance
            // 
            this.cbinsurance.AutoSize = true;
            this.cbinsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbinsurance.Location = new System.Drawing.Point(16, 35);
            this.cbinsurance.Name = "cbinsurance";
            this.cbinsurance.Size = new System.Drawing.Size(288, 20);
            this.cbinsurance.TabIndex = 15;
            this.cbinsurance.Text = "Add Travel Insurance ($25 per tricket)";
            this.cbinsurance.UseVisualStyleBackColor = true;
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(244, 499);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(151, 44);
            this.btnclear.TabIndex = 34;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(435, 499);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(151, 44);
            this.btnexit.TabIndex = 33;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(67, 499);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(151, 44);
            this.btncalculate.TabIndex = 32;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, -60);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(103, 20);
            this.radioButton1.TabIndex = 31;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(632, 78);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(239, 404);
            this.listBox1.TabIndex = 30;
            // 
            // txtage
            // 
            this.txtage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtage.Location = new System.Drawing.Point(345, 113);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(241, 34);
            this.txtage.TabIndex = 29;
            // 
            // txtnumber
            // 
            this.txtnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumber.Location = new System.Drawing.Point(345, 162);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(241, 34);
            this.txtnumber.TabIndex = 28;
            // 
            // txtexperience
            // 
            this.txtexperience.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtexperience.Location = new System.Drawing.Point(345, 213);
            this.txtexperience.Name = "txtexperience";
            this.txtexperience.Size = new System.Drawing.Size(241, 34);
            this.txtexperience.TabIndex = 27;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(345, 60);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(241, 34);
            this.txtname.TabIndex = 26;
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblage.Location = new System.Drawing.Point(63, 118);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(150, 25);
            this.lblage.TabIndex = 25;
            this.lblage.Text = "Customer Age";
            // 
            // lblnumber
            // 
            this.lblnumber.AutoSize = true;
            this.lblnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumber.Location = new System.Drawing.Point(63, 168);
            this.lblnumber.Name = "lblnumber";
            this.lblnumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblnumber.Size = new System.Drawing.Size(223, 25);
            this.lblnumber.TabIndex = 24;
            this.lblnumber.Text = "Number of rental days";
            // 
            // lblexperience
            // 
            this.lblexperience.AutoSize = true;
            this.lblexperience.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexperience.Location = new System.Drawing.Point(63, 219);
            this.lblexperience.Name = "lblexperience";
            this.lblexperience.Size = new System.Drawing.Size(274, 25);
            this.lblexperience.TabIndex = 23;
            this.lblexperience.Text = "Years of driving expereince";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(63, 64);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(164, 25);
            this.lblname.TabIndex = 22;
            this.lblname.Text = "Customer name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(929, 595);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.txtnumber);
            this.Controls.Add(this.txtexperience);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblage);
            this.Controls.Add(this.lblnumber);
            this.Controls.Add(this.lblexperience);
            this.Controls.Add(this.lblname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdsuv;
        private System.Windows.Forms.RadioButton rdluxury;
        private System.Windows.Forms.RadioButton rdeconomy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbinsurance;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.TextBox txtexperience;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lblnumber;
        private System.Windows.Forms.Label lblexperience;
        private System.Windows.Forms.Label lblname;
    }
}

