namespace RIWinformAssignement1
{
    partial class CountryAddFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCountryName = new System.Windows.Forms.TextBox();
            this.btnsveandaddnew = new System.Windows.Forms.Button();
            this.btnsaveandexit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add New Country";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Country Name:";
            // 
            // txtCountryName
            // 
            this.txtCountryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountryName.Location = new System.Drawing.Point(222, 120);
            this.txtCountryName.Name = "txtCountryName";
            this.txtCountryName.Size = new System.Drawing.Size(213, 29);
            this.txtCountryName.TabIndex = 3;
            // 
            // btnsveandaddnew
            // 
            this.btnsveandaddnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsveandaddnew.Location = new System.Drawing.Point(12, 250);
            this.btnsveandaddnew.Name = "btnsveandaddnew";
            this.btnsveandaddnew.Size = new System.Drawing.Size(167, 38);
            this.btnsveandaddnew.TabIndex = 4;
            this.btnsveandaddnew.Text = "Save and New";
            this.btnsveandaddnew.UseVisualStyleBackColor = true;
            this.btnsveandaddnew.Click += new System.EventHandler(this.btnsveandaddnew_Click);
            // 
            // btnsaveandexit
            // 
            this.btnsaveandexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaveandexit.Location = new System.Drawing.Point(199, 251);
            this.btnsaveandexit.Name = "btnsaveandexit";
            this.btnsaveandexit.Size = new System.Drawing.Size(167, 38);
            this.btnsaveandexit.TabIndex = 5;
            this.btnsaveandexit.Text = "Save and Exit";
            this.btnsaveandexit.UseVisualStyleBackColor = true;
            this.btnsaveandexit.Click += new System.EventHandler(this.btnsaveandexit_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(379, 252);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(147, 38);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // CountryAddFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 311);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnsaveandexit);
            this.Controls.Add(this.btnsveandaddnew);
            this.Controls.Add(this.txtCountryName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CountryAddFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Country";
            this.Load += new System.EventHandler(this.CountryAddFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCountryName;
        private System.Windows.Forms.Button btnsveandaddnew;
        private System.Windows.Forms.Button btnsaveandexit;
        private System.Windows.Forms.Button btnExit;
    }
}