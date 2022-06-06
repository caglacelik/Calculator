
namespace WindowsFormsApp8
{
    partial class windowPositionGuesser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(windowPositionGuesser));
            this.btnClose = new System.Windows.Forms.Button();
            this.lblGuess = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnNorth = new System.Windows.Forms.Button();
            this.btnSouth = new System.Windows.Forms.Button();
            this.btnEast = new System.Windows.Forms.Button();
            this.btnWest = new System.Windows.Forms.Button();
            this.btnSouthEast = new System.Windows.Forms.Button();
            this.btnNorthEast = new System.Windows.Forms.Button();
            this.btnSouthWest = new System.Windows.Forms.Button();
            this.btnNorthWest = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(370, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 43);
            this.btnClose.TabIndex = 9;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblGuess
            // 
            this.lblGuess.AutoSize = true;
            this.lblGuess.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGuess.Location = new System.Drawing.Point(105, 64);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(50, 20);
            this.lblGuess.TabIndex = 11;
            this.lblGuess.Text = "Guess:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblResult.Location = new System.Drawing.Point(170, 60);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 25);
            this.lblResult.TabIndex = 11;
            // 
            // btnNorth
            // 
            this.btnNorth.FlatAppearance.BorderSize = 0;
            this.btnNorth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnNorth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnNorth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNorth.Image = ((System.Drawing.Image)(resources.GetObject("btnNorth.Image")));
            this.btnNorth.Location = new System.Drawing.Point(161, 140);
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.Size = new System.Drawing.Size(44, 45);
            this.btnNorth.TabIndex = 13;
            this.btnNorth.UseVisualStyleBackColor = true;
            this.btnNorth.Click += new System.EventHandler(this.btnNorth_Click);
            this.btnNorth.MouseHover += new System.EventHandler(this.btnNorth_MouseHover);
            // 
            // btnSouth
            // 
            this.btnSouth.FlatAppearance.BorderSize = 0;
            this.btnSouth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSouth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSouth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSouth.Image = ((System.Drawing.Image)(resources.GetObject("btnSouth.Image")));
            this.btnSouth.Location = new System.Drawing.Point(161, 280);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(44, 45);
            this.btnSouth.TabIndex = 13;
            this.btnSouth.UseVisualStyleBackColor = true;
            this.btnSouth.Click += new System.EventHandler(this.btnSouth_Click);
            // 
            // btnEast
            // 
            this.btnEast.FlatAppearance.BorderSize = 0;
            this.btnEast.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnEast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEast.Image = ((System.Drawing.Image)(resources.GetObject("btnEast.Image")));
            this.btnEast.Location = new System.Drawing.Point(231, 210);
            this.btnEast.Name = "btnEast";
            this.btnEast.Size = new System.Drawing.Size(44, 45);
            this.btnEast.TabIndex = 13;
            this.btnEast.UseVisualStyleBackColor = true;
            this.btnEast.Click += new System.EventHandler(this.btnEast_Click);
            // 
            // btnWest
            // 
            this.btnWest.FlatAppearance.BorderSize = 0;
            this.btnWest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnWest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnWest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWest.Image = ((System.Drawing.Image)(resources.GetObject("btnWest.Image")));
            this.btnWest.Location = new System.Drawing.Point(91, 210);
            this.btnWest.Name = "btnWest";
            this.btnWest.Size = new System.Drawing.Size(44, 45);
            this.btnWest.TabIndex = 13;
            this.btnWest.UseVisualStyleBackColor = true;
            this.btnWest.Click += new System.EventHandler(this.btnWest_Click);
            // 
            // btnSouthEast
            // 
            this.btnSouthEast.FlatAppearance.BorderSize = 0;
            this.btnSouthEast.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSouthEast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSouthEast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSouthEast.Image = ((System.Drawing.Image)(resources.GetObject("btnSouthEast.Image")));
            this.btnSouthEast.Location = new System.Drawing.Point(211, 261);
            this.btnSouthEast.Name = "btnSouthEast";
            this.btnSouthEast.Size = new System.Drawing.Size(44, 45);
            this.btnSouthEast.TabIndex = 13;
            this.btnSouthEast.UseVisualStyleBackColor = true;
            this.btnSouthEast.Click += new System.EventHandler(this.btnSouthEast_Click);
            // 
            // btnNorthEast
            // 
            this.btnNorthEast.FlatAppearance.BorderSize = 0;
            this.btnNorthEast.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnNorthEast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnNorthEast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNorthEast.Image = ((System.Drawing.Image)(resources.GetObject("btnNorthEast.Image")));
            this.btnNorthEast.Location = new System.Drawing.Point(211, 160);
            this.btnNorthEast.Name = "btnNorthEast";
            this.btnNorthEast.Size = new System.Drawing.Size(44, 45);
            this.btnNorthEast.TabIndex = 13;
            this.btnNorthEast.UseVisualStyleBackColor = true;
            this.btnNorthEast.Click += new System.EventHandler(this.btnNorthEast_Click);
            // 
            // btnSouthWest
            // 
            this.btnSouthWest.FlatAppearance.BorderSize = 0;
            this.btnSouthWest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSouthWest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSouthWest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSouthWest.Image = ((System.Drawing.Image)(resources.GetObject("btnSouthWest.Image")));
            this.btnSouthWest.Location = new System.Drawing.Point(111, 261);
            this.btnSouthWest.Name = "btnSouthWest";
            this.btnSouthWest.Size = new System.Drawing.Size(44, 45);
            this.btnSouthWest.TabIndex = 13;
            this.btnSouthWest.UseVisualStyleBackColor = true;
            this.btnSouthWest.Click += new System.EventHandler(this.btnSouthWest_Click);
            // 
            // btnNorthWest
            // 
            this.btnNorthWest.FlatAppearance.BorderSize = 0;
            this.btnNorthWest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnNorthWest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnNorthWest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNorthWest.Image = ((System.Drawing.Image)(resources.GetObject("btnNorthWest.Image")));
            this.btnNorthWest.Location = new System.Drawing.Point(111, 159);
            this.btnNorthWest.Name = "btnNorthWest";
            this.btnNorthWest.Size = new System.Drawing.Size(44, 45);
            this.btnNorthWest.TabIndex = 13;
            this.btnNorthWest.UseVisualStyleBackColor = true;
            this.btnNorthWest.Click += new System.EventHandler(this.btnNorthWest_Click);
            // 
            // btnReset
            // 
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.Location = new System.Drawing.Point(161, 210);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(44, 45);
            this.btnReset.TabIndex = 13;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.MouseHover += new System.EventHandler(this.btnReset_MouseHover);
            // 
            // windowPositionGuesser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(408, 369);
            this.Controls.Add(this.btnSouth);
            this.Controls.Add(this.btnWest);
            this.Controls.Add(this.btnSouthEast);
            this.Controls.Add(this.btnNorthWest);
            this.Controls.Add(this.btnSouthWest);
            this.Controls.Add(this.btnNorthEast);
            this.Controls.Add(this.btnEast);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnNorth);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblGuess);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "windowPositionGuesser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "windowPositionGuesser";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.windowPositionGuesser_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.windowPositionGuesser_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblGuess;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnNorth;
        private System.Windows.Forms.Button btnSouth;
        private System.Windows.Forms.Button btnEast;
        private System.Windows.Forms.Button btnWest;
        private System.Windows.Forms.Button btnSouthEast;
        private System.Windows.Forms.Button btnNorthEast;
        private System.Windows.Forms.Button btnSouthWest;
        private System.Windows.Forms.Button btnNorthWest;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}