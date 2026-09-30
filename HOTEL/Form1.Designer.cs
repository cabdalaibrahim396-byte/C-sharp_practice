namespace HOTEL
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
            this.lbltitle = new System.Windows.Forms.Label();
            this.lblNane = new System.Windows.Forms.Label();
            this.Lblroom = new System.Windows.Forms.Label();
            this.lblnights = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.txtNights = new System.Windows.Forms.TextBox();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.txtPriceNight = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblspace = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lbldiscountt = new System.Windows.Forms.Label();
            this.lblservice = new System.Windows.Forms.Label();
            this.lblServiceTax = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(147, 26);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(424, 28);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "HOTEL ROOM BOOKING CALCULATOR";
            // 
            // lblNane
            // 
            this.lblNane.AutoSize = true;
            this.lblNane.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNane.Location = new System.Drawing.Point(83, 106);
            this.lblNane.Name = "lblNane";
            this.lblNane.Size = new System.Drawing.Size(132, 16);
            this.lblNane.TabIndex = 1;
            this.lblNane.Text = "Enter Gaust Name";
            // 
            // Lblroom
            // 
            this.Lblroom.AutoSize = true;
            this.Lblroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblroom.Location = new System.Drawing.Point(83, 161);
            this.Lblroom.Name = "Lblroom";
            this.Lblroom.Size = new System.Drawing.Size(122, 16);
            this.Lblroom.TabIndex = 2;
            this.Lblroom.Text = "Enter Room type";
            this.Lblroom.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblnights
            // 
            this.lblnights.AutoSize = true;
            this.lblnights.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnights.Location = new System.Drawing.Point(83, 202);
            this.lblnights.Name = "lblnights";
            this.lblnights.Size = new System.Drawing.Size(168, 16);
            this.lblnights.TabIndex = 3;
            this.lblnights.Text = "Enter Number Of Nights";
            this.lblnights.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.Location = new System.Drawing.Point(83, 243);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(150, 16);
            this.lblprice.TabIndex = 4;
            this.lblprice.Text = "Enter price per night ";
            // 
            // txtGuestName
            // 
            this.txtGuestName.Location = new System.Drawing.Point(279, 106);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(274, 22);
            this.txtGuestName.TabIndex = 5;
            // 
            // txtNights
            // 
            this.txtNights.Location = new System.Drawing.Point(279, 196);
            this.txtNights.Name = "txtNights";
            this.txtNights.Size = new System.Drawing.Size(274, 22);
            this.txtNights.TabIndex = 6;
            this.txtNights.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtRoomType
            // 
            this.txtRoomType.Location = new System.Drawing.Point(279, 158);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(274, 22);
            this.txtRoomType.TabIndex = 7;
            // 
            // txtPriceNight
            // 
            this.txtPriceNight.Location = new System.Drawing.Point(279, 237);
            this.txtPriceNight.Name = "txtPriceNight";
            this.txtPriceNight.Size = new System.Drawing.Size(274, 22);
            this.txtPriceNight.TabIndex = 8;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalculate.Location = new System.Drawing.Point(309, 283);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(249, 53);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "calculate booking";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblspace
            // 
            this.lblspace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblspace.Location = new System.Drawing.Point(58, 339);
            this.lblspace.Name = "lblspace";
            this.lblspace.Size = new System.Drawing.Size(681, 118);
            this.lblspace.TabIndex = 10;
            this.lblspace.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(151, 422);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(118, 20);
            this.lbltotal.TabIndex = 11;
            this.lbltotal.Text = "Total amount";
            this.lbltotal.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbldiscountt
            // 
            this.lbldiscountt.AutoSize = true;
            this.lbldiscountt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiscountt.Location = new System.Drawing.Point(147, 394);
            this.lbldiscountt.Name = "lbldiscountt";
            this.lbldiscountt.Size = new System.Drawing.Size(130, 20);
            this.lbldiscountt.TabIndex = 12;
            this.lbldiscountt.Text = "Discount (5%)";
            // 
            // lblservice
            // 
            this.lblservice.AutoSize = true;
            this.lblservice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblservice.Location = new System.Drawing.Point(130, 355);
            this.lblservice.Name = "lblservice";
            this.lblservice.Size = new System.Drawing.Size(164, 20);
            this.lblservice.TabIndex = 13;
            this.lblservice.Text = "Service Tax (10%)";
            this.lblservice.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // lblServiceTax
            // 
            this.lblServiceTax.Location = new System.Drawing.Point(344, 352);
            this.lblServiceTax.Name = "lblServiceTax";
            this.lblServiceTax.Size = new System.Drawing.Size(169, 23);
            this.lblServiceTax.TabIndex = 14;
            this.lblServiceTax.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblDiscount
            // 
            this.lblDiscount.Location = new System.Drawing.Point(344, 391);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(169, 23);
            this.lblDiscount.TabIndex = 15;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Location = new System.Drawing.Point(344, 425);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(169, 23);
            this.lblTotalAmount.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 490);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblServiceTax);
            this.Controls.Add(this.lblservice);
            this.Controls.Add(this.lbldiscountt);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lblspace);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtPriceNight);
            this.Controls.Add(this.txtRoomType);
            this.Controls.Add(this.txtNights);
            this.Controls.Add(this.txtGuestName);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.lblnights);
            this.Controls.Add(this.Lblroom);
            this.Controls.Add(this.lblNane);
            this.Controls.Add(this.lbltitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lblNane;
        private System.Windows.Forms.Label Lblroom;
        private System.Windows.Forms.Label lblnights;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.TextBox txtNights;
        private System.Windows.Forms.TextBox txtRoomType;
        private System.Windows.Forms.TextBox txtPriceNight;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblspace;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lbldiscountt;
        private System.Windows.Forms.Label lblservice;
        private System.Windows.Forms.Label lblServiceTax;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTotalAmount;
    }
}

