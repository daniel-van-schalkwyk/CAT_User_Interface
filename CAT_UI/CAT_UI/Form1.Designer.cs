
namespace CAT_UI
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
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.BtnGetPortNames = new System.Windows.Forms.Button();
            this.BtnGetData = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnGetPortNames
            // 
            this.BtnGetPortNames.Location = new System.Drawing.Point(123, 109);
            this.BtnGetPortNames.Name = "BtnGetPortNames";
            this.BtnGetPortNames.Size = new System.Drawing.Size(117, 23);
            this.BtnGetPortNames.TabIndex = 0;
            this.BtnGetPortNames.Text = "Get Port Names";
            this.BtnGetPortNames.UseVisualStyleBackColor = true;
            this.BtnGetPortNames.Click += new System.EventHandler(this.btnGetPortNames_Click);
            // 
            // BtnGetData
            // 
            this.BtnGetData.Location = new System.Drawing.Point(263, 109);
            this.BtnGetData.Name = "BtnGetData";
            this.BtnGetData.Size = new System.Drawing.Size(75, 23);
            this.BtnGetData.TabIndex = 1;
            this.BtnGetData.Text = "Get Data";
            this.BtnGetData.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(123, 192);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(856, 259);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(377, 109);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 541);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.BtnGetData);
            this.Controls.Add(this.BtnGetPortNames);
            this.Name = "Form1";
            this.Text = "CAT_UI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button BtnGetPortNames;
        private System.Windows.Forms.Button BtnGetData;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button BtnClose;
    }
}

