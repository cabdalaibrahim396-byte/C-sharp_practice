namespace Airpline_ticket_booking_system
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
            this.lblname = new System.Windows.Forms.Label();
            this.lblnaggage = new System.Windows.Forms.Label();
            this.lbltickets = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtbaggage = new System.Windows.Forms.TextBox();
            this.txttickets = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.Person_informatin = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.rbfistclass = new System.Windows.Forms.RadioButton();
            this.rbbusiness = new System.Windows.Forms.RadioButton();
            this.rbnormal = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbloption = new System.Windows.Forms.Label();
            this.cbinsurence = new System.Windows.Forms.CheckBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.Person_informatin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(23, 47);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(209, 20);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Enter Passenger Name:";
            this.lblname.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblnaggage
            // 
            this.lblnaggage.AutoSize = true;
            this.lblnaggage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnaggage.Location = new System.Drawing.Point(23, 166);
            this.lblnaggage.Name = "lblnaggage";
            this.lblnaggage.Size = new System.Drawing.Size(198, 20);
            this.lblnaggage.TabIndex = 1;
            this.lblnaggage.Text = "Baggage Wieght (KG):";
            // 
            // lbltickets
            // 
            this.lbltickets.AutoSize = true;
            this.lbltickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltickets.Location = new System.Drawing.Point(23, 132);
            this.lbltickets.Name = "lbltickets";
            this.lbltickets.Size = new System.Drawing.Size(164, 20);
            this.lbltickets.TabIndex = 2;
            this.lbltickets.Text = "Number of tickets:";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblage.Location = new System.Drawing.Point(23, 93);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(148, 20);
            this.lblage.TabIndex = 3;
            this.lblage.Text = "Passenger Age :";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(267, 47);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(204, 27);
            this.txtname.TabIndex = 4;
            // 
            // txtbaggage
            // 
            this.txtbaggage.Location = new System.Drawing.Point(267, 181);
            this.txtbaggage.Name = "txtbaggage";
            this.txtbaggage.Size = new System.Drawing.Size(204, 27);
            this.txtbaggage.TabIndex = 5;
            // 
            // txttickets
            // 
            this.txttickets.Location = new System.Drawing.Point(267, 134);
            this.txttickets.Name = "txttickets";
            this.txttickets.Size = new System.Drawing.Size(204, 27);
            this.txttickets.TabIndex = 6;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(267, 93);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(204, 27);
            this.txtage.TabIndex = 7;
            // 
            // Person_informatin
            // 
            this.Person_informatin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Person_informatin.Controls.Add(this.txtage);
            this.Person_informatin.Controls.Add(this.txttickets);
            this.Person_informatin.Controls.Add(this.txtbaggage);
            this.Person_informatin.Controls.Add(this.txtname);
            this.Person_informatin.Controls.Add(this.lblage);
            this.Person_informatin.Controls.Add(this.lbltickets);
            this.Person_informatin.Controls.Add(this.lblnaggage);
            this.Person_informatin.Controls.Add(this.lblname);
            this.Person_informatin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Person_informatin.Location = new System.Drawing.Point(17, 23);
            this.Person_informatin.Name = "Person_informatin";
            this.Person_informatin.Size = new System.Drawing.Size(499, 233);
            this.Person_informatin.TabIndex = 8;
            this.Person_informatin.TabStop = false;
            this.Person_informatin.Text = "person information";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(554, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(304, 356);
            this.listBox1.TabIndex = 9;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // rbfistclass
            // 
            this.rbfistclass.AutoSize = true;
            this.rbfistclass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbfistclass.Location = new System.Drawing.Point(24, 30);
            this.rbfistclass.Name = "rbfistclass";
            this.rbfistclass.Size = new System.Drawing.Size(116, 22);
            this.rbfistclass.TabIndex = 10;
            this.rbfistclass.TabStop = true;
            this.rbfistclass.Text = "First  Class";
            this.rbfistclass.UseVisualStyleBackColor = true;
            this.rbfistclass.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbbusiness
            // 
            this.rbbusiness.AutoSize = true;
            this.rbbusiness.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbbusiness.Location = new System.Drawing.Point(292, 30);
            this.rbbusiness.Name = "rbbusiness";
            this.rbbusiness.Size = new System.Drawing.Size(146, 22);
            this.rbbusiness.TabIndex = 11;
            this.rbbusiness.TabStop = true;
            this.rbbusiness.Text = "Business Class";
            this.rbbusiness.UseVisualStyleBackColor = true;
            // 
            // rbnormal
            // 
            this.rbnormal.AutoSize = true;
            this.rbnormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnormal.Location = new System.Drawing.Point(157, 30);
            this.rbnormal.Name = "rbnormal";
            this.rbnormal.Size = new System.Drawing.Size(129, 22);
            this.rbnormal.TabIndex = 12;
            this.rbnormal.TabStop = true;
            this.rbnormal.Text = "Normal class";
            this.rbnormal.UseVisualStyleBackColor = true;
            this.rbnormal.CheckedChanged += new System.EventHandler(this.rbnormal_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnormal);
            this.groupBox1.Controls.Add(this.rbbusiness);
            this.groupBox1.Controls.Add(this.rbfistclass);
            this.groupBox1.Location = new System.Drawing.Point(8, 281);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 75);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Travel Class";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbloption
            // 
            this.lbloption.AutoSize = true;
            this.lbloption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloption.Location = new System.Drawing.Point(15, 368);
            this.lbloption.Name = "lbloption";
            this.lbloption.Size = new System.Drawing.Size(133, 20);
            this.lbloption.TabIndex = 14;
            this.lbloption.Text = "Aditinal Option";
            // 
            // cbinsurence
            // 
            this.cbinsurence.AutoSize = true;
            this.cbinsurence.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbinsurence.Location = new System.Drawing.Point(7, 403);
            this.cbinsurence.Name = "cbinsurence";
            this.cbinsurence.Size = new System.Drawing.Size(287, 20);
            this.cbinsurence.TabIndex = 15;
            this.cbinsurence.Text = "Add Travel Insurence  ($25 per ticket)";
            this.cbinsurence.UseVisualStyleBackColor = true;
            // 
            // btncalculate
            // 
            this.btncalculate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btncalculate.Location = new System.Drawing.Point(7, 466);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(183, 44);
            this.btncalculate.TabIndex = 16;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = false;
            this.btncalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnexit.Location = new System.Drawing.Point(422, 466);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(183, 44);
            this.btnexit.TabIndex = 17;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Red;
            this.btnclear.Location = new System.Drawing.Point(224, 466);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(183, 44);
            this.btnclear.TabIndex = 18;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 572);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.cbinsurence);
            this.Controls.Add(this.lbloption);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Person_informatin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Person_informatin.ResumeLayout(false);
            this.Person_informatin.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblnaggage;
        private System.Windows.Forms.Label lbltickets;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtbaggage;
        private System.Windows.Forms.TextBox txttickets;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.GroupBox Person_informatin;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton rbfistclass;
        private System.Windows.Forms.RadioButton rbbusiness;
        private System.Windows.Forms.RadioButton rbnormal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbloption;
        private System.Windows.Forms.CheckBox cbinsurence;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnclear;
    }
}

