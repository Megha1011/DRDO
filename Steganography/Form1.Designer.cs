namespace Steganography
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonOpenfile = new System.Windows.Forms.Button();
            this.buttonEcode = new System.Windows.Forms.Button();
            this.buttonDecode = new System.Windows.Forms.Button();
            this.textFilePath = new System.Windows.Forms.TextBox();
            this.textMessageBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(265, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(414, 236);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonOpenfile
            // 
            this.buttonOpenfile.Location = new System.Drawing.Point(270, 299);
            this.buttonOpenfile.Name = "buttonOpenfile";
            this.buttonOpenfile.Size = new System.Drawing.Size(102, 28);
            this.buttonOpenfile.TabIndex = 1;
            this.buttonOpenfile.Text = "OpenFile";
            this.buttonOpenfile.UseVisualStyleBackColor = true;
            this.buttonOpenfile.Click += new System.EventHandler(this.buttonOpenfile_Click);
            // 
            // buttonEcode
            // 
            this.buttonEcode.Location = new System.Drawing.Point(280, 387);
            this.buttonEcode.Name = "buttonEcode";
            this.buttonEcode.Size = new System.Drawing.Size(150, 36);
            this.buttonEcode.TabIndex = 2;
            this.buttonEcode.Text = "Encode";
            this.buttonEcode.UseVisualStyleBackColor = true;
            this.buttonEcode.Click += new System.EventHandler(this.buttonEcode_Click);
            // 
            // buttonDecode
            // 
            this.buttonDecode.Location = new System.Drawing.Point(281, 444);
            this.buttonDecode.Name = "buttonDecode";
            this.buttonDecode.Size = new System.Drawing.Size(148, 37);
            this.buttonDecode.TabIndex = 3;
            this.buttonDecode.Text = "Decode";
            this.buttonDecode.UseVisualStyleBackColor = true;
            this.buttonDecode.Click += new System.EventHandler(this.buttonDecode_Click);
            // 
            // textFilePath
            // 
            this.textFilePath.Location = new System.Drawing.Point(404, 304);
            this.textFilePath.Name = "textFilePath";
            this.textFilePath.Size = new System.Drawing.Size(217, 22);
            this.textFilePath.TabIndex = 4;
            this.textFilePath.TextChanged += new System.EventHandler(this.textFilePath_TextChanged);
            // 
            // textMessageBox
            // 
            this.textMessageBox.Location = new System.Drawing.Point(567, 422);
            this.textMessageBox.Name = "textMessageBox";
            this.textMessageBox.Size = new System.Drawing.Size(245, 22);
            this.textMessageBox.TabIndex = 5;
            this.textMessageBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(470, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Message";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 534);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textMessageBox);
            this.Controls.Add(this.textFilePath);
            this.Controls.Add(this.buttonDecode);
            this.Controls.Add(this.buttonEcode);
            this.Controls.Add(this.buttonOpenfile);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonOpenfile;
        private System.Windows.Forms.Button buttonEcode;
        private System.Windows.Forms.Button buttonDecode;
        private System.Windows.Forms.TextBox textFilePath;
        private System.Windows.Forms.TextBox textMessageBox;
        private System.Windows.Forms.Label label1;
    }
}

