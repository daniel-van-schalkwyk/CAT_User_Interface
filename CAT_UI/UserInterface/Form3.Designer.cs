﻿
namespace UserInterface
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbValveName = new System.Windows.Forms.ComboBox();
            this.cbValvePosition = new System.Windows.Forms.ComboBox();
            this.btnActuate = new System.Windows.Forms.Button();
            this.cbFormat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Which valve do you want to actuate?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valve";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(394, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Position";
            // 
            // cbValveName
            // 
            this.cbValveName.FormattingEnabled = true;
            this.cbValveName.Location = new System.Drawing.Point(41, 113);
            this.cbValveName.Name = "cbValveName";
            this.cbValveName.Size = new System.Drawing.Size(144, 24);
            this.cbValveName.TabIndex = 4;
            this.cbValveName.SelectedIndexChanged += new System.EventHandler(this.cbValveName_SelectedIndexChanged);
            // 
            // cbValvePosition
            // 
            this.cbValvePosition.FormattingEnabled = true;
            this.cbValvePosition.Location = new System.Drawing.Point(351, 113);
            this.cbValvePosition.Name = "cbValvePosition";
            this.cbValvePosition.Size = new System.Drawing.Size(154, 24);
            this.cbValvePosition.TabIndex = 5;
            // 
            // btnActuate
            // 
            this.btnActuate.Location = new System.Drawing.Point(511, 113);
            this.btnActuate.Name = "btnActuate";
            this.btnActuate.Size = new System.Drawing.Size(154, 24);
            this.btnActuate.TabIndex = 6;
            this.btnActuate.Text = "Actuate";
            this.btnActuate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnActuate.UseVisualStyleBackColor = true;
            this.btnActuate.Click += new System.EventHandler(this.btnActuate_Click);
            // 
            // cbFormat
            // 
            this.cbFormat.FormattingEnabled = true;
            this.cbFormat.Items.AddRange(new object[] {
            "State",
            "Degrees"});
            this.cbFormat.Location = new System.Drawing.Point(191, 113);
            this.cbFormat.Name = "cbFormat";
            this.cbFormat.Size = new System.Drawing.Size(154, 24);
            this.cbFormat.TabIndex = 7;
            this.cbFormat.SelectedIndexChanged += new System.EventHandler(this.cbFormat_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(234, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Format";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 182);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbFormat);
            this.Controls.Add(this.btnActuate);
            this.Controls.Add(this.cbValvePosition);
            this.Controls.Add(this.cbValveName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbValveName;
        private System.Windows.Forms.ComboBox cbValvePosition;
        public System.Windows.Forms.Button btnActuate;
        private System.Windows.Forms.ComboBox cbFormat;
        private System.Windows.Forms.Label label4;
    }
}