
namespace WindowsFormsApp8
{
    partial class windowEncryption
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(windowEncryption));
            this.btnClose = new System.Windows.Forms.Button();
            this.txtAlphabet = new System.Windows.Forms.TextBox();
            this.lblAlphabet = new System.Windows.Forms.Label();
            this.btnChangeAlphabet = new System.Windows.Forms.Button();
            this.grpAlgorithm = new System.Windows.Forms.GroupBox();
            this.radioVigenereCipher = new System.Windows.Forms.RadioButton();
            this.radioCeaserCipher = new System.Windows.Forms.RadioButton();
            this.grpEncryption = new System.Windows.Forms.GroupBox();
            this.radioDecrypt = new System.Windows.Forms.RadioButton();
            this.radioEncrypt = new System.Windows.Forms.RadioButton();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpAlgorithm.SuspendLayout();
            this.grpEncryption.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(765, -2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 43);
            this.btnClose.TabIndex = 6;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtAlphabet
            // 
            this.txtAlphabet.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAlphabet.Location = new System.Drawing.Point(285, 401);
            this.txtAlphabet.Name = "txtAlphabet";
            this.txtAlphabet.Size = new System.Drawing.Size(257, 27);
            this.txtAlphabet.TabIndex = 4;
            this.txtAlphabet.TextChanged += new System.EventHandler(this.txtAlphabet_TextChanged);
            // 
            // lblAlphabet
            // 
            this.lblAlphabet.AutoSize = true;
            this.lblAlphabet.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlphabet.Location = new System.Drawing.Point(281, 369);
            this.lblAlphabet.Name = "lblAlphabet";
            this.lblAlphabet.Size = new System.Drawing.Size(195, 20);
            this.lblAlphabet.TabIndex = 12;
            this.lblAlphabet.Text = "Change Alphabet(Optional):";
            // 
            // btnChangeAlphabet
            // 
            this.btnChangeAlphabet.Enabled = false;
            this.btnChangeAlphabet.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnChangeAlphabet.Location = new System.Drawing.Point(373, 443);
            this.btnChangeAlphabet.Name = "btnChangeAlphabet";
            this.btnChangeAlphabet.Size = new System.Drawing.Size(101, 27);
            this.btnChangeAlphabet.TabIndex = 5;
            this.btnChangeAlphabet.Text = "Change";
            this.btnChangeAlphabet.UseVisualStyleBackColor = true;
            this.btnChangeAlphabet.Click += new System.EventHandler(this.btnChangeAlphabet_Click);
            // 
            // grpAlgorithm
            // 
            this.grpAlgorithm.Controls.Add(this.radioVigenereCipher);
            this.grpAlgorithm.Controls.Add(this.radioCeaserCipher);
            this.grpAlgorithm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpAlgorithm.Location = new System.Drawing.Point(285, 44);
            this.grpAlgorithm.Name = "grpAlgorithm";
            this.grpAlgorithm.Size = new System.Drawing.Size(217, 144);
            this.grpAlgorithm.TabIndex = 2;
            this.grpAlgorithm.TabStop = false;
            this.grpAlgorithm.Text = "Select Algorithm";
            // 
            // radioVigenereCipher
            // 
            this.radioVigenereCipher.AutoSize = true;
            this.radioVigenereCipher.Location = new System.Drawing.Point(39, 95);
            this.radioVigenereCipher.Name = "radioVigenereCipher";
            this.radioVigenereCipher.Size = new System.Drawing.Size(140, 25);
            this.radioVigenereCipher.TabIndex = 1;
            this.radioVigenereCipher.Text = "Vigenère Cipher";
            this.radioVigenereCipher.UseVisualStyleBackColor = true;
            this.radioVigenereCipher.CheckedChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // radioCeaserCipher
            // 
            this.radioCeaserCipher.AutoSize = true;
            this.radioCeaserCipher.Checked = true;
            this.radioCeaserCipher.Location = new System.Drawing.Point(39, 54);
            this.radioCeaserCipher.Name = "radioCeaserCipher";
            this.radioCeaserCipher.Size = new System.Drawing.Size(125, 25);
            this.radioCeaserCipher.TabIndex = 0;
            this.radioCeaserCipher.TabStop = true;
            this.radioCeaserCipher.Text = "Ceaser Cipher";
            this.radioCeaserCipher.UseVisualStyleBackColor = true;
            this.radioCeaserCipher.CheckedChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // grpEncryption
            // 
            this.grpEncryption.Controls.Add(this.radioDecrypt);
            this.grpEncryption.Controls.Add(this.radioEncrypt);
            this.grpEncryption.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpEncryption.Location = new System.Drawing.Point(526, 44);
            this.grpEncryption.Name = "grpEncryption";
            this.grpEncryption.Size = new System.Drawing.Size(217, 144);
            this.grpEncryption.TabIndex = 3;
            this.grpEncryption.TabStop = false;
            this.grpEncryption.Text = "Select Encryption";
            // 
            // radioDecrypt
            // 
            this.radioDecrypt.AutoSize = true;
            this.radioDecrypt.Location = new System.Drawing.Point(39, 95);
            this.radioDecrypt.Name = "radioDecrypt";
            this.radioDecrypt.Size = new System.Drawing.Size(82, 25);
            this.radioDecrypt.TabIndex = 1;
            this.radioDecrypt.Text = "Decrypt";
            this.radioDecrypt.UseVisualStyleBackColor = true;
            this.radioDecrypt.CheckedChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // radioEncrypt
            // 
            this.radioEncrypt.AutoSize = true;
            this.radioEncrypt.Checked = true;
            this.radioEncrypt.Location = new System.Drawing.Point(39, 54);
            this.radioEncrypt.Name = "radioEncrypt";
            this.radioEncrypt.Size = new System.Drawing.Size(80, 25);
            this.radioEncrypt.TabIndex = 0;
            this.radioEncrypt.TabStop = true;
            this.radioEncrypt.Text = "Encrypt";
            this.radioEncrypt.UseVisualStyleBackColor = true;
            this.radioEncrypt.CheckedChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblResult.Location = new System.Drawing.Point(359, 259);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 25);
            this.lblResult.TabIndex = 12;
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtInput.Location = new System.Drawing.Point(16, 81);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(222, 27);
            this.txtInput.TabIndex = 0;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInput.Location = new System.Drawing.Point(12, 58);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(146, 20);
            this.lblInput.TabIndex = 12;
            this.lblInput.Text = "Enter text to encrypt:";
            // 
            // txtKey
            // 
            this.txtKey.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKey.Location = new System.Drawing.Point(16, 134);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(222, 27);
            this.txtKey.TabIndex = 1;
            this.txtKey.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKey.Location = new System.Drawing.Point(12, 111);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(72, 20);
            this.lblKey.TabIndex = 12;
            this.lblKey.Text = "Enter key:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(215, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 12;
            // 
            // windowEncryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(803, 486);
            this.Controls.Add(this.grpEncryption);
            this.Controls.Add(this.grpAlgorithm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.lblAlphabet);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.btnChangeAlphabet);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.txtAlphabet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "windowEncryption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "windowEncryption";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.windowApplicationSelection_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.windowApplicationSelection_MouseMove);
            this.grpAlgorithm.ResumeLayout(false);
            this.grpAlgorithm.PerformLayout();
            this.grpEncryption.ResumeLayout(false);
            this.grpEncryption.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtAlphabet;
        private System.Windows.Forms.Label lblAlphabet;
        private System.Windows.Forms.Button btnChangeAlphabet;
        private System.Windows.Forms.GroupBox grpAlgorithm;
        private System.Windows.Forms.RadioButton radioVigenereCipher;
        private System.Windows.Forms.RadioButton radioCeaserCipher;
        private System.Windows.Forms.GroupBox grpEncryption;
        private System.Windows.Forms.RadioButton radioDecrypt;
        private System.Windows.Forms.RadioButton radioEncrypt;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label label1;
    }
}