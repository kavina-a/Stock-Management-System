namespace STgui
{
    partial class Form5
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
            this.addqbtn = new System.Windows.Forms.Button();
            this.exstockcode = new System.Windows.Forms.Label();
            this.exsctxtbox = new System.Windows.Forms.TextBox();
            this.addingqtxtbox = new System.Windows.Forms.TextBox();
            this.addingq = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addqbtn
            // 
            this.addqbtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.addqbtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addqbtn.Location = new System.Drawing.Point(490, 274);
            this.addqbtn.Name = "addqbtn";
            this.addqbtn.Size = new System.Drawing.Size(106, 31);
            this.addqbtn.TabIndex = 0;
            this.addqbtn.Text = "ADD";
            this.addqbtn.UseVisualStyleBackColor = true;
            this.addqbtn.Click += new System.EventHandler(this.addqbtn_Click);
            // 
            // exstockcode
            // 
            this.exstockcode.AutoSize = true;
            this.exstockcode.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exstockcode.Location = new System.Drawing.Point(185, 162);
            this.exstockcode.Name = "exstockcode";
            this.exstockcode.Size = new System.Drawing.Size(160, 25);
            this.exstockcode.TabIndex = 1;
            this.exstockcode.Text = "Stock Code - ";
            // 
            // exsctxtbox
            // 
            this.exsctxtbox.Location = new System.Drawing.Point(430, 167);
            this.exsctxtbox.Name = "exsctxtbox";
            this.exsctxtbox.Size = new System.Drawing.Size(166, 22);
            this.exsctxtbox.TabIndex = 2;
            // 
            // addingqtxtbox
            // 
            this.addingqtxtbox.Location = new System.Drawing.Point(430, 218);
            this.addingqtxtbox.Name = "addingqtxtbox";
            this.addingqtxtbox.Size = new System.Drawing.Size(166, 22);
            this.addingqtxtbox.TabIndex = 3;
            // 
            // addingq
            // 
            this.addingq.AutoSize = true;
            this.addingq.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addingq.Location = new System.Drawing.Point(185, 213);
            this.addingq.Name = "addingq";
            this.addingq.Size = new System.Drawing.Size(218, 25);
            this.addingq.TabIndex = 4;
            this.addingq.Text = "Adding Quantity - ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(136, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(546, 39);
            this.label4.TabIndex = 8;
            this.label4.Text = "Adding quantity to an existing stockitem";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // backbtn
            // 
            this.backbtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.backbtn.Location = new System.Drawing.Point(490, 323);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(106, 31);
            this.backbtn.TabIndex = 16;
            this.backbtn.Text = "BACK";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addingq);
            this.Controls.Add(this.addingqtxtbox);
            this.Controls.Add(this.exsctxtbox);
            this.Controls.Add(this.exstockcode);
            this.Controls.Add(this.addqbtn);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addqbtn;
        private System.Windows.Forms.Label exstockcode;
        private System.Windows.Forms.TextBox exsctxtbox;
        private System.Windows.Forms.TextBox addingqtxtbox;
        private System.Windows.Forms.Label addingq;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button backbtn;
    }
}