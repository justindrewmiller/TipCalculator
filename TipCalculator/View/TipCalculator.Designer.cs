namespace TipCalculator
{
    partial class TipCalculator
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAverage = new System.Windows.Forms.Button();
            this.btnExcellent = new System.Windows.Forms.Button();
            this.btnTax = new System.Windows.Forms.Button();
            this.btnPoor = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.lblDollar = new System.Windows.Forms.Label();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPointer = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblDirections = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(222, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactInfoToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // contactInfoToolStripMenuItem
            // 
            this.contactInfoToolStripMenuItem.Name = "contactInfoToolStripMenuItem";
            this.contactInfoToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.contactInfoToolStripMenuItem.Text = "Contact Info";
            this.contactInfoToolStripMenuItem.Click += new System.EventHandler(this.contactInfoToolStripMenuItem_Click);
            // 
            // btnAverage
            // 
            this.btnAverage.Location = new System.Drawing.Point(15, 203);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(75, 23);
            this.btnAverage.TabIndex = 2;
            this.btnAverage.Text = "Average";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // btnExcellent
            // 
            this.btnExcellent.Location = new System.Drawing.Point(111, 203);
            this.btnExcellent.Name = "btnExcellent";
            this.btnExcellent.Size = new System.Drawing.Size(75, 23);
            this.btnExcellent.TabIndex = 3;
            this.btnExcellent.Text = "Excellent";
            this.btnExcellent.UseVisualStyleBackColor = true;
            this.btnExcellent.Click += new System.EventHandler(this.btnExcellent_Click);
            // 
            // btnTax
            // 
            this.btnTax.Location = new System.Drawing.Point(12, 150);
            this.btnTax.Name = "btnTax";
            this.btnTax.Size = new System.Drawing.Size(75, 23);
            this.btnTax.TabIndex = 4;
            this.btnTax.Text = "Add Tax";
            this.btnTax.UseVisualStyleBackColor = true;
            this.btnTax.Click += new System.EventHandler(this.btnTax_Click);
            // 
            // btnPoor
            // 
            this.btnPoor.Location = new System.Drawing.Point(111, 150);
            this.btnPoor.Name = "btnPoor";
            this.btnPoor.Size = new System.Drawing.Size(75, 24);
            this.btnPoor.TabIndex = 5;
            this.btnPoor.Text = "Poor";
            this.btnPoor.UseVisualStyleBackColor = true;
            this.btnPoor.Click += new System.EventHandler(this.btnPoor_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 83);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(174, 20);
            this.txtInput.TabIndex = 7;
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Location = new System.Drawing.Point(12, 36);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(132, 13);
            this.lblGreeting.TabIndex = 8;
            this.lblGreeting.Text = "Welcome to Tip Calculator";
            // 
            // lblDollar
            // 
            this.lblDollar.AutoSize = true;
            this.lblDollar.Location = new System.Drawing.Point(192, 86);
            this.lblDollar.Name = "lblDollar";
            this.lblDollar.Size = new System.Drawing.Size(13, 13);
            this.lblDollar.TabIndex = 10;
            this.lblDollar.Text = "$";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // lblPointer
            // 
            this.lblPointer.AutoSize = true;
            this.lblPointer.Location = new System.Drawing.Point(12, 118);
            this.lblPointer.Name = "lblPointer";
            this.lblPointer.Size = new System.Drawing.Size(84, 13);
            this.lblPointer.TabIndex = 11;
            this.lblPointer.Text = "Calculated Sum:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(102, 118);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 12;
            // 
            // lblDirections
            // 
            this.lblDirections.AutoSize = true;
            this.lblDirections.Location = new System.Drawing.Point(12, 58);
            this.lblDirections.Name = "lblDirections";
            this.lblDirections.Size = new System.Drawing.Size(160, 13);
            this.lblDirections.TabIndex = 13;
            this.lblDirections.Text = "Input the sum to calculate below";
            // 
            // TipCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 249);
            this.Controls.Add(this.lblDirections);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblPointer);
            this.Controls.Add(this.lblDollar);
            this.Controls.Add(this.lblGreeting);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnPoor);
            this.Controls.Add(this.btnTax);
            this.Controls.Add(this.btnExcellent);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "TipCalculator";
            this.Text = "Tips";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactInfoToolStripMenuItem;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Button btnExcellent;
        private System.Windows.Forms.Button btnTax;
        private System.Windows.Forms.Button btnPoor;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.Label lblDollar;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.Label lblPointer;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblDirections;
    }
}

