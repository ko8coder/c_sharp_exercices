namespace Password_Generator
{
    partial class frmPwGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPwGenerator));
            this.nud = new System.Windows.Forms.NumericUpDown();
            this.lblPasswordLenght = new System.Windows.Forms.Label();
            this.cbSymbols = new System.Windows.Forms.CheckBox();
            this.cbUppercase = new System.Windows.Forms.CheckBox();
            this.cbNumbers = new System.Windows.Forms.CheckBox();
            this.btnGeneratePassword = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.cbLowercase = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud)).BeginInit();
            this.SuspendLayout();
            // 
            // nud
            // 
            this.nud.AllowDrop = true;
            this.nud.Location = new System.Drawing.Point(111, 81);
            this.nud.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nud.Name = "nud";
            this.nud.Size = new System.Drawing.Size(235, 30);
            this.nud.TabIndex = 0;
            this.nud.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // lblPasswordLenght
            // 
            this.lblPasswordLenght.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblPasswordLenght.Location = new System.Drawing.Point(107, 39);
            this.lblPasswordLenght.Name = "lblPasswordLenght";
            this.lblPasswordLenght.Size = new System.Drawing.Size(239, 39);
            this.lblPasswordLenght.TabIndex = 1;
            this.lblPasswordLenght.Text = "Password Lenght";
            this.lblPasswordLenght.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbSymbols
            // 
            this.cbSymbols.AutoSize = true;
            this.cbSymbols.Location = new System.Drawing.Point(111, 137);
            this.cbSymbols.Name = "cbSymbols";
            this.cbSymbols.Size = new System.Drawing.Size(175, 26);
            this.cbSymbols.TabIndex = 2;
            this.cbSymbols.Text = "Include Symbols";
            this.cbSymbols.UseVisualStyleBackColor = true;
            // 
            // cbUppercase
            // 
            this.cbUppercase.AutoSize = true;
            this.cbUppercase.Location = new System.Drawing.Point(111, 201);
            this.cbUppercase.Name = "cbUppercase";
            this.cbUppercase.Size = new System.Drawing.Size(196, 26);
            this.cbUppercase.TabIndex = 3;
            this.cbUppercase.Text = "Include Uppercase";
            this.cbUppercase.UseVisualStyleBackColor = true;
            // 
            // cbNumbers
            // 
            this.cbNumbers.AutoSize = true;
            this.cbNumbers.Location = new System.Drawing.Point(111, 169);
            this.cbNumbers.Name = "cbNumbers";
            this.cbNumbers.Size = new System.Drawing.Size(181, 26);
            this.cbNumbers.TabIndex = 4;
            this.cbNumbers.Text = "Include Numbers";
            this.cbNumbers.UseVisualStyleBackColor = true;
            // 
            // btnGeneratePassword
            // 
            this.btnGeneratePassword.Location = new System.Drawing.Point(111, 385);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.Size = new System.Drawing.Size(235, 35);
            this.btnGeneratePassword.TabIndex = 5;
            this.btnGeneratePassword.Text = "Generate PassWord";
            this.btnGeneratePassword.UseVisualStyleBackColor = true;
            this.btnGeneratePassword.Click += new System.EventHandler(this.btnGeneratePassword_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPassword.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(38, 276);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(3);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(380, 57);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbLowercase
            // 
            this.cbLowercase.AutoSize = true;
            this.cbLowercase.Location = new System.Drawing.Point(111, 233);
            this.cbLowercase.Name = "cbLowercase";
            this.cbLowercase.Size = new System.Drawing.Size(196, 26);
            this.cbLowercase.TabIndex = 7;
            this.cbLowercase.Text = "Include Lowercase";
            this.cbLowercase.UseVisualStyleBackColor = true;
            // 
            // frmPwGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(462, 489);
            this.Controls.Add(this.cbLowercase);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.btnGeneratePassword);
            this.Controls.Add(this.cbNumbers);
            this.Controls.Add(this.cbUppercase);
            this.Controls.Add(this.cbSymbols);
            this.Controls.Add(this.lblPasswordLenght);
            this.Controls.Add(this.nud);
            this.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmPwGenerator";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "Random Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.nud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nud;
        private System.Windows.Forms.Label lblPasswordLenght;
        private System.Windows.Forms.CheckBox cbSymbols;
        private System.Windows.Forms.CheckBox cbUppercase;
        private System.Windows.Forms.CheckBox cbNumbers;
        private System.Windows.Forms.Button btnGeneratePassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.CheckBox cbLowercase;
    }
}

