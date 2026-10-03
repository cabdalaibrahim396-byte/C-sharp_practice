namespace Range_chacker
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
            this.lbltitlle = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblRanged = new System.Windows.Forms.Label();
            this.lblRangeDecision = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(57, 37);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(414, 52);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Range Chacker Appliaction ";
            // 
            // lbltitlle
            // 
            this.lbltitlle.AutoSize = true;
            this.lbltitlle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitlle.Location = new System.Drawing.Point(57, 75);
            this.lbltitlle.Name = "lbltitlle";
            this.lbltitlle.Size = new System.Drawing.Size(458, 29);
            this.lbltitlle.TabIndex = 1;
            this.lbltitlle.Text = "Enter an  intrger in the of 1 throught 10";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(200, 125);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(328, 34);
            this.txtNumber.TabIndex = 3;
            // 
            // lblRanged
            // 
            this.lblRanged.AutoSize = true;
            this.lblRanged.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRanged.Location = new System.Drawing.Point(246, 188);
            this.lblRanged.Name = "lblRanged";
            this.lblRanged.Size = new System.Drawing.Size(198, 29);
            this.lblRanged.TabIndex = 4;
            this.lblRanged.Text = "Range Decision";
            // 
            // lblRangeDecision
            // 
            this.lblRangeDecision.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblRangeDecision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRangeDecision.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRangeDecision.Location = new System.Drawing.Point(151, 243);
            this.lblRangeDecision.Name = "lblRangeDecision";
            this.lblRangeDecision.Size = new System.Drawing.Size(506, 44);
            this.lblRangeDecision.TabIndex = 5;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(195, 354);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(92, 53);
            this.btnCheck.TabIndex = 6;
            this.btnCheck.Text = "Check Qualification ";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(425, 354);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 38);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(318, 354);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 38);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear ";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblRangeDecision);
            this.Controls.Add(this.lblRanged);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbltitlle);
            this.Controls.Add(this.lbltitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lbltitlle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblRanged;
        private System.Windows.Forms.Label lblRangeDecision;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
    }
}

