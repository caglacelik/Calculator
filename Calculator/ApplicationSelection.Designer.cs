
namespace WindowsFormsApp8
{
    partial class windowApplicationSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(windowApplicationSelection));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.lblCalculator = new System.Windows.Forms.Label();
            this.btnEncryption = new System.Windows.Forms.Button();
            this.lblEncryption = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuesser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(635, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 43);
            this.btnClose.TabIndex = 8;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCalculator
            // 
            this.btnCalculator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalculator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculator.FlatAppearance.BorderSize = 0;
            this.btnCalculator.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnCalculator.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculator.Image = ((System.Drawing.Image)(resources.GetObject("btnCalculator.Image")));
            this.btnCalculator.Location = new System.Drawing.Point(113, 101);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(88, 86);
            this.btnCalculator.TabIndex = 9;
            this.btnCalculator.UseVisualStyleBackColor = true;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // lblCalculator
            // 
            this.lblCalculator.AutoSize = true;
            this.lblCalculator.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCalculator.Location = new System.Drawing.Point(122, 201);
            this.lblCalculator.Name = "lblCalculator";
            this.lblCalculator.Size = new System.Drawing.Size(76, 20);
            this.lblCalculator.TabIndex = 10;
            this.lblCalculator.Text = "Calculator";
            // 
            // btnEncryption
            // 
            this.btnEncryption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncryption.FlatAppearance.BorderSize = 0;
            this.btnEncryption.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnEncryption.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnEncryption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncryption.Image = ((System.Drawing.Image)(resources.GetObject("btnEncryption.Image")));
            this.btnEncryption.Location = new System.Drawing.Point(323, 101);
            this.btnEncryption.Name = "btnEncryption";
            this.btnEncryption.Size = new System.Drawing.Size(88, 86);
            this.btnEncryption.TabIndex = 11;
            this.btnEncryption.UseVisualStyleBackColor = true;
            this.btnEncryption.Click += new System.EventHandler(this.btnEncryption_Click);
            // 
            // lblEncryption
            // 
            this.lblEncryption.AutoSize = true;
            this.lblEncryption.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEncryption.Location = new System.Drawing.Point(332, 201);
            this.lblEncryption.Name = "lblEncryption";
            this.lblEncryption.Size = new System.Drawing.Size(79, 20);
            this.lblEncryption.TabIndex = 10;
            this.lblEncryption.Text = "Encryption";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(513, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Guesser";
            // 
            // btnGuesser
            // 
            this.btnGuesser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuesser.FlatAppearance.BorderSize = 0;
            this.btnGuesser.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnGuesser.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnGuesser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuesser.Image = ((System.Drawing.Image)(resources.GetObject("btnGuesser.Image")));
            this.btnGuesser.Location = new System.Drawing.Point(517, 101);
            this.btnGuesser.Name = "btnGuesser";
            this.btnGuesser.Size = new System.Drawing.Size(50, 86);
            this.btnGuesser.TabIndex = 11;
            this.btnGuesser.UseVisualStyleBackColor = true;
            this.btnGuesser.Click += new System.EventHandler(this.btnGuesser_Click);
            // 
            // windowApplicationSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(672, 347);
            this.Controls.Add(this.btnGuesser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEncryption);
            this.Controls.Add(this.lblEncryption);
            this.Controls.Add(this.lblCalculator);
            this.Controls.Add(this.btnCalculator);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "windowApplicationSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select an App";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.windowApplicationSelection_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.windowApplicationSelection_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.Label lblCalculator;
        private System.Windows.Forms.Button btnEncryption;
        private System.Windows.Forms.Label lblEncryption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuesser;
    }
}