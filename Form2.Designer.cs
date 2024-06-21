namespace STgui
{
    partial class Form2
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
            this.addnewstckbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.transactionlogbtn_Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addnewstckbtn
            // 
            this.addnewstckbtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addnewstckbtn.Location = new System.Drawing.Point(199, 113);
            this.addnewstckbtn.Name = "addnewstckbtn";
            this.addnewstckbtn.Size = new System.Drawing.Size(403, 49);
            this.addnewstckbtn.TabIndex = 6;
            this.addnewstckbtn.Text = "Add a new item of stock";
            this.addnewstckbtn.UseVisualStyleBackColor = true;
            this.addnewstckbtn.Click += new System.EventHandler(this.addnewstckbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(164, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "STOCK MANAGEMENT SYSTEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(199, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(403, 49);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add quantity to a stock item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // transactionlogbtn_Click
            // 
            this.transactionlogbtn_Click.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionlogbtn_Click.Location = new System.Drawing.Point(199, 297);
            this.transactionlogbtn_Click.Name = "transactionlogbtn_Click";
            this.transactionlogbtn_Click.Size = new System.Drawing.Size(403, 49);
            this.transactionlogbtn_Click.TabIndex = 9;
            this.transactionlogbtn_Click.Text = "View transaction log";
            this.transactionlogbtn_Click.UseVisualStyleBackColor = true;
            this.transactionlogbtn_Click.Click += new System.EventHandler(this.transactionlogbtn_Click_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.transactionlogbtn_Click);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addnewstckbtn);
            this.Name = "Form2";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addnewstckbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button transactionlogbtn_Click;
    }
}