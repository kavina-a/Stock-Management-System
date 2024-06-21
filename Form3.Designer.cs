namespace STgui
{
    partial class Form3
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
            this.stockcodetxtbox = new System.Windows.Forms.TextBox();
            this.stocknametxtbox = new System.Windows.Forms.TextBox();
            this.quantitytxtbox = new System.Windows.Forms.TextBox();
            this.enterbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stocknamelbl = new System.Windows.Forms.Label();
            this.quantitylbl = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stockcodetxtbox
            // 
            this.stockcodetxtbox.Location = new System.Drawing.Point(405, 158);
            this.stockcodetxtbox.Name = "stockcodetxtbox";
            this.stockcodetxtbox.Size = new System.Drawing.Size(148, 22);
            this.stockcodetxtbox.TabIndex = 3;
            // 
            // stocknametxtbox
            // 
            this.stocknametxtbox.Location = new System.Drawing.Point(405, 210);
            this.stocknametxtbox.Name = "stocknametxtbox";
            this.stocknametxtbox.Size = new System.Drawing.Size(148, 22);
            this.stocknametxtbox.TabIndex = 4;
            // 
            // quantitytxtbox
            // 
            this.quantitytxtbox.Location = new System.Drawing.Point(405, 259);
            this.quantitytxtbox.Name = "quantitytxtbox";
            this.quantitytxtbox.Size = new System.Drawing.Size(148, 22);
            this.quantitytxtbox.TabIndex = 5;
            // 
            // enterbtn
            // 
            this.enterbtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterbtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.enterbtn.Location = new System.Drawing.Point(447, 325);
            this.enterbtn.Name = "enterbtn";
            this.enterbtn.Size = new System.Drawing.Size(106, 31);
            this.enterbtn.TabIndex = 6;
            this.enterbtn.Text = "ENTER";
            this.enterbtn.UseVisualStyleBackColor = true;
            this.enterbtn.Click += new System.EventHandler(this.enterbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(180, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(373, 39);
            this.label4.TabIndex = 7;
            this.label4.Text = "Adding a new item of stock";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Stock Code - ";
            // 
            // stocknamelbl
            // 
            this.stocknamelbl.AutoSize = true;
            this.stocknamelbl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stocknamelbl.Location = new System.Drawing.Point(175, 205);
            this.stocknamelbl.Name = "stocknamelbl";
            this.stocknamelbl.Size = new System.Drawing.Size(169, 25);
            this.stocknamelbl.TabIndex = 12;
            this.stocknamelbl.Text = "Stock Name - ";
            // 
            // quantitylbl
            // 
            this.quantitylbl.AutoSize = true;
            this.quantitylbl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantitylbl.Location = new System.Drawing.Point(175, 256);
            this.quantitylbl.Name = "quantitylbl";
            this.quantitylbl.Size = new System.Drawing.Size(132, 25);
            this.quantitylbl.TabIndex = 13;
            this.quantitylbl.Text = "Quantity - ";
            // 
            // backbtn
            // 
            this.backbtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.backbtn.Location = new System.Drawing.Point(447, 371);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(106, 31);
            this.backbtn.TabIndex = 15;
            this.backbtn.Text = "BACK";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.quantitylbl);
            this.Controls.Add(this.stocknamelbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.enterbtn);
            this.Controls.Add(this.quantitytxtbox);
            this.Controls.Add(this.stocknametxtbox);
            this.Controls.Add(this.stockcodetxtbox);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox stockcodetxtbox;
        private System.Windows.Forms.TextBox stocknametxtbox;
        private System.Windows.Forms.TextBox quantitytxtbox;
        private System.Windows.Forms.Button enterbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label stocknamelbl;
        private System.Windows.Forms.Label quantitylbl;
        private System.Windows.Forms.Button backbtn;
    }
}