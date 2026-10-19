namespace Hotel_room
{
    partial class form1
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
            this.lblname = new System.Windows.Forms.Label();
            this.lblnumber = new System.Windows.Forms.Label();
            this.lblnights = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.txtnights = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cbbreakfast = new System.Windows.Forms.CheckBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdstander = new System.Windows.Forms.RadioButton();
            this.rdhight = new System.Windows.Forms.RadioButton();
            this.rdnormal = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(39, 39);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(119, 20);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Guest Name ";
            // 
            // lblnumber
            // 
            this.lblnumber.AutoSize = true;
            this.lblnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumber.Location = new System.Drawing.Point(39, 187);
            this.lblnumber.Name = "lblnumber";
            this.lblnumber.Size = new System.Drawing.Size(172, 20);
            this.lblnumber.TabIndex = 3;
            this.lblnumber.Text = "Number Of Guests ";
            // 
            // lblnights
            // 
            this.lblnights.AutoSize = true;
            this.lblnights.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnights.Location = new System.Drawing.Point(39, 143);
            this.lblnights.Name = "lblnights";
            this.lblnights.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblnights.Size = new System.Drawing.Size(160, 20);
            this.lblnights.TabIndex = 4;
            this.lblnights.Text = "Number Of Nights";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblage.Location = new System.Drawing.Point(39, 89);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(103, 20);
            this.lblage.TabIndex = 5;
            this.lblage.Text = "Guest Age ";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(209, 39);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(241, 22);
            this.txtname.TabIndex = 6;
            // 
            // txtnumber
            // 
            this.txtnumber.Location = new System.Drawing.Point(209, 187);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(241, 22);
            this.txtnumber.TabIndex = 7;
            // 
            // txtnights
            // 
            this.txtnights.Location = new System.Drawing.Point(209, 143);
            this.txtnights.Name = "txtnights";
            this.txtnights.Size = new System.Drawing.Size(241, 22);
            this.txtnights.TabIndex = 8;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(209, 87);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(241, 22);
            this.txtage.TabIndex = 9;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(475, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(314, 436);
            this.listBox1.TabIndex = 10;
            // 
            // cbbreakfast
            // 
            this.cbbreakfast.AutoSize = true;
            this.cbbreakfast.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbreakfast.Location = new System.Drawing.Point(22, 31);
            this.cbbreakfast.Name = "cbbreakfast";
            this.cbbreakfast.Size = new System.Drawing.Size(269, 20);
            this.cbbreakfast.TabIndex = 15;
            this.cbbreakfast.Text = "BreakFast(10 per Guest per nights)";
            this.cbbreakfast.UseVisualStyleBackColor = true;
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(19, 485);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(116, 44);
            this.btncalculate.TabIndex = 17;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(273, 485);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(116, 44);
            this.btnexit.TabIndex = 18;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(153, 485);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(116, 44);
            this.btnclear.TabIndex = 19;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbreakfast);
            this.groupBox1.Location = new System.Drawing.Point(17, 350);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 115);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Additional Option";
            // 
            // rdstander
            // 
            this.rdstander.AutoSize = true;
            this.rdstander.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdstander.Location = new System.Drawing.Point(16, 30);
            this.rdstander.Name = "rdstander";
            this.rdstander.Size = new System.Drawing.Size(82, 20);
            this.rdstander.TabIndex = 12;
            this.rdstander.TabStop = true;
            this.rdstander.Text = "Stander";
            this.rdstander.UseVisualStyleBackColor = true;
            // 
            // rdhight
            // 
            this.rdhight.AutoSize = true;
            this.rdhight.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdhight.Location = new System.Drawing.Point(294, 30);
            this.rdhight.Name = "rdhight";
            this.rdhight.Size = new System.Drawing.Size(55, 20);
            this.rdhight.TabIndex = 13;
            this.rdhight.TabStop = true;
            this.rdhight.Text = "Hiht";
            this.rdhight.UseVisualStyleBackColor = true;
            // 
            // rdnormal
            // 
            this.rdnormal.AutoSize = true;
            this.rdnormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdnormal.Location = new System.Drawing.Point(151, 30);
            this.rdnormal.Name = "rdnormal";
            this.rdnormal.Size = new System.Drawing.Size(78, 20);
            this.rdnormal.TabIndex = 14;
            this.rdnormal.TabStop = true;
            this.rdnormal.Text = "Normal";
            this.rdnormal.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdnormal);
            this.groupBox2.Controls.Add(this.rdhight);
            this.groupBox2.Controls.Add(this.rdstander);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(24, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 74);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Room Tyoe";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 583);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.txtnights);
            this.Controls.Add(this.txtnumber);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblage);
            this.Controls.Add(this.lblnights);
            this.Controls.Add(this.lblnumber);
            this.Controls.Add(this.lblname);
            this.Name = "form1";
            this.Text = "txtname";
            this.Load += new System.EventHandler(this.form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblnumber;
        private System.Windows.Forms.Label lblnights;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.TextBox txtnights;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox cbbreakfast;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdstander;
        private System.Windows.Forms.RadioButton rdhight;
        private System.Windows.Forms.RadioButton rdnormal;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

