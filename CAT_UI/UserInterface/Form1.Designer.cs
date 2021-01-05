
namespace UserInterface
{
    partial class CAT_UI
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
            this.gbData = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbPress = new System.Windows.Forms.TextBox();
            this.tbTemp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbControls = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.gbNitrogen = new System.Windows.Forms.GroupBox();
            this.cbNV2 = new System.Windows.Forms.ComboBox();
            this.tbNV2Pos = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbNV1 = new System.Windows.Forms.ComboBox();
            this.tbNV1Pos = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.gbOxygen = new System.Windows.Forms.GroupBox();
            this.cbPV = new System.Windows.Forms.ComboBox();
            this.tbPVPos = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbOV3 = new System.Windows.Forms.ComboBox();
            this.tbOV3Pos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbOV2 = new System.Windows.Forms.ComboBox();
            this.tbOV2Pos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbOV1 = new System.Windows.Forms.ComboBox();
            this.tbOV1Pos = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gbFuel = new System.Windows.Forms.GroupBox();
            this.cbFV3 = new System.Windows.Forms.ComboBox();
            this.tbFV3Pos = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbFV2 = new System.Windows.Forms.ComboBox();
            this.tbFV2Pos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbFV1 = new System.Windows.Forms.ComboBox();
            this.tbFV1Pos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbData.SuspendLayout();
            this.gbControls.SuspendLayout();
            this.gbNitrogen.SuspendLayout();
            this.gbOxygen.SuspendLayout();
            this.gbFuel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.button2);
            this.gbData.Controls.Add(this.button1);
            this.gbData.Controls.Add(this.tbPress);
            this.gbData.Controls.Add(this.tbTemp);
            this.gbData.Controls.Add(this.label2);
            this.gbData.Controls.Add(this.label1);
            this.gbData.Location = new System.Drawing.Point(14, 12);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(415, 520);
            this.gbData.TabIndex = 0;
            this.gbData.TabStop = false;
            this.gbData.Text = "Data";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(372, 67);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(372, 67);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbPress
            // 
            this.tbPress.Location = new System.Drawing.Point(192, 115);
            this.tbPress.Name = "tbPress";
            this.tbPress.Size = new System.Drawing.Size(201, 22);
            this.tbPress.TabIndex = 3;
            // 
            // tbTemp
            // 
            this.tbTemp.Location = new System.Drawing.Point(192, 45);
            this.tbTemp.Name = "tbTemp";
            this.tbTemp.Size = new System.Drawing.Size(201, 22);
            this.tbTemp.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pressure";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperature";
            // 
            // gbControls
            // 
            this.gbControls.Controls.Add(this.btnReset);
            this.gbControls.Controls.Add(this.gbNitrogen);
            this.gbControls.Controls.Add(this.gbOxygen);
            this.gbControls.Controls.Add(this.gbFuel);
            this.gbControls.Location = new System.Drawing.Point(435, 12);
            this.gbControls.Name = "gbControls";
            this.gbControls.Size = new System.Drawing.Size(666, 521);
            this.gbControls.TabIndex = 1;
            this.gbControls.TabStop = false;
            this.gbControls.Text = "Controls";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(522, 482);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(138, 33);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // gbNitrogen
            // 
            this.gbNitrogen.Controls.Add(this.cbNV2);
            this.gbNitrogen.Controls.Add(this.tbNV2Pos);
            this.gbNitrogen.Controls.Add(this.label12);
            this.gbNitrogen.Controls.Add(this.cbNV1);
            this.gbNitrogen.Controls.Add(this.tbNV1Pos);
            this.gbNitrogen.Controls.Add(this.label13);
            this.gbNitrogen.Controls.Add(this.label14);
            this.gbNitrogen.Location = new System.Drawing.Point(6, 360);
            this.gbNitrogen.Name = "gbNitrogen";
            this.gbNitrogen.Size = new System.Drawing.Size(654, 120);
            this.gbNitrogen.TabIndex = 1;
            this.gbNitrogen.TabStop = false;
            this.gbNitrogen.Text = "Nitrogen";
            // 
            // cbNV2
            // 
            this.cbNV2.FormattingEnabled = true;
            this.cbNV2.Items.AddRange(new object[] {
            "Open",
            "Close"});
            this.cbNV2.Location = new System.Drawing.Point(362, 80);
            this.cbNV2.Name = "cbNV2";
            this.cbNV2.Size = new System.Drawing.Size(237, 24);
            this.cbNV2.TabIndex = 18;
            this.cbNV2.Tag = "";
            // 
            // tbNV2Pos
            // 
            this.tbNV2Pos.Location = new System.Drawing.Point(149, 81);
            this.tbNV2Pos.Name = "tbNV2Pos";
            this.tbNV2Pos.Size = new System.Drawing.Size(198, 22);
            this.tbNV2Pos.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(94, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 17);
            this.label12.TabIndex = 16;
            this.label12.Text = "NV2:";
            // 
            // cbNV1
            // 
            this.cbNV1.FormattingEnabled = true;
            this.cbNV1.Items.AddRange(new object[] {
            "Open",
            "Close"});
            this.cbNV1.Location = new System.Drawing.Point(362, 51);
            this.cbNV1.Name = "cbNV1";
            this.cbNV1.Size = new System.Drawing.Size(237, 24);
            this.cbNV1.TabIndex = 15;
            this.cbNV1.Tag = "";
            // 
            // tbNV1Pos
            // 
            this.tbNV1Pos.Location = new System.Drawing.Point(149, 52);
            this.tbNV1Pos.Name = "tbNV1Pos";
            this.tbNV1Pos.Size = new System.Drawing.Size(198, 22);
            this.tbNV1Pos.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(192, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 17);
            this.label13.TabIndex = 13;
            this.label13.Text = "Current Position:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(94, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 17);
            this.label14.TabIndex = 12;
            this.label14.Text = "NV1:";
            // 
            // gbOxygen
            // 
            this.gbOxygen.Controls.Add(this.cbPV);
            this.gbOxygen.Controls.Add(this.tbPVPos);
            this.gbOxygen.Controls.Add(this.label11);
            this.gbOxygen.Controls.Add(this.cbOV3);
            this.gbOxygen.Controls.Add(this.tbOV3Pos);
            this.gbOxygen.Controls.Add(this.label5);
            this.gbOxygen.Controls.Add(this.cbOV2);
            this.gbOxygen.Controls.Add(this.tbOV2Pos);
            this.gbOxygen.Controls.Add(this.label7);
            this.gbOxygen.Controls.Add(this.cbOV1);
            this.gbOxygen.Controls.Add(this.tbOV1Pos);
            this.gbOxygen.Controls.Add(this.label9);
            this.gbOxygen.Controls.Add(this.label10);
            this.gbOxygen.Location = new System.Drawing.Point(6, 199);
            this.gbOxygen.Name = "gbOxygen";
            this.gbOxygen.Size = new System.Drawing.Size(654, 155);
            this.gbOxygen.TabIndex = 1;
            this.gbOxygen.TabStop = false;
            this.gbOxygen.Text = "Oxygen";
            // 
            // cbPV
            // 
            this.cbPV.FormattingEnabled = true;
            this.cbPV.Items.AddRange(new object[] {
            "Open",
            "Close"});
            this.cbPV.Location = new System.Drawing.Point(362, 116);
            this.cbPV.Name = "cbPV";
            this.cbPV.Size = new System.Drawing.Size(237, 24);
            this.cbPV.TabIndex = 24;
            this.cbPV.Tag = "";
            // 
            // tbPVPos
            // 
            this.tbPVPos.Location = new System.Drawing.Point(149, 117);
            this.tbPVPos.Name = "tbPVPos";
            this.tbPVPos.Size = new System.Drawing.Size(198, 22);
            this.tbPVPos.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(103, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "PV:";
            // 
            // cbOV3
            // 
            this.cbOV3.FormattingEnabled = true;
            this.cbOV3.Items.AddRange(new object[] {
            "Open",
            "Close"});
            this.cbOV3.Location = new System.Drawing.Point(362, 88);
            this.cbOV3.Name = "cbOV3";
            this.cbOV3.Size = new System.Drawing.Size(237, 24);
            this.cbOV3.TabIndex = 21;
            this.cbOV3.Tag = "";
            // 
            // tbOV3Pos
            // 
            this.tbOV3Pos.Location = new System.Drawing.Point(149, 89);
            this.tbOV3Pos.Name = "tbOV3Pos";
            this.tbOV3Pos.Size = new System.Drawing.Size(198, 22);
            this.tbOV3Pos.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "OV3:";
            // 
            // cbOV2
            // 
            this.cbOV2.FormattingEnabled = true;
            this.cbOV2.Items.AddRange(new object[] {
            "Open",
            "Close"});
            this.cbOV2.Location = new System.Drawing.Point(362, 60);
            this.cbOV2.Name = "cbOV2";
            this.cbOV2.Size = new System.Drawing.Size(237, 24);
            this.cbOV2.TabIndex = 18;
            this.cbOV2.Tag = "";
            // 
            // tbOV2Pos
            // 
            this.tbOV2Pos.Location = new System.Drawing.Point(149, 61);
            this.tbOV2Pos.Name = "tbOV2Pos";
            this.tbOV2Pos.Size = new System.Drawing.Size(198, 22);
            this.tbOV2Pos.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(103, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "OV2:";
            // 
            // cbOV1
            // 
            this.cbOV1.FormattingEnabled = true;
            this.cbOV1.Items.AddRange(new object[] {
            "Isolate",
            "Feed",
            "Vent"});
            this.cbOV1.Location = new System.Drawing.Point(362, 31);
            this.cbOV1.Name = "cbOV1";
            this.cbOV1.Size = new System.Drawing.Size(237, 24);
            this.cbOV1.TabIndex = 15;
            this.cbOV1.Tag = "";
            // 
            // tbOV1Pos
            // 
            this.tbOV1Pos.Location = new System.Drawing.Point(149, 32);
            this.tbOV1Pos.Name = "tbOV1Pos";
            this.tbOV1Pos.Size = new System.Drawing.Size(198, 22);
            this.tbOV1Pos.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(192, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Current Position:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(103, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "OV1:";
            // 
            // gbFuel
            // 
            this.gbFuel.Controls.Add(this.cbFV3);
            this.gbFuel.Controls.Add(this.tbFV3Pos);
            this.gbFuel.Controls.Add(this.label8);
            this.gbFuel.Controls.Add(this.cbFV2);
            this.gbFuel.Controls.Add(this.tbFV2Pos);
            this.gbFuel.Controls.Add(this.label6);
            this.gbFuel.Controls.Add(this.cbFV1);
            this.gbFuel.Controls.Add(this.tbFV1Pos);
            this.gbFuel.Controls.Add(this.label4);
            this.gbFuel.Controls.Add(this.label3);
            this.gbFuel.Location = new System.Drawing.Point(6, 38);
            this.gbFuel.Name = "gbFuel";
            this.gbFuel.Size = new System.Drawing.Size(654, 155);
            this.gbFuel.TabIndex = 0;
            this.gbFuel.TabStop = false;
            this.gbFuel.Text = "Fuel";
            // 
            // cbFV3
            // 
            this.cbFV3.FormattingEnabled = true;
            this.cbFV3.Items.AddRange(new object[] {
            "Open",
            "Close"});
            this.cbFV3.Location = new System.Drawing.Point(362, 111);
            this.cbFV3.Name = "cbFV3";
            this.cbFV3.Size = new System.Drawing.Size(237, 24);
            this.cbFV3.TabIndex = 11;
            this.cbFV3.Tag = "";
            // 
            // tbFV3Pos
            // 
            this.tbFV3Pos.Location = new System.Drawing.Point(149, 112);
            this.tbFV3Pos.Name = "tbFV3Pos";
            this.tbFV3Pos.Size = new System.Drawing.Size(198, 22);
            this.tbFV3Pos.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(106, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "FV3:";
            // 
            // cbFV2
            // 
            this.cbFV2.FormattingEnabled = true;
            this.cbFV2.Items.AddRange(new object[] {
            "Open",
            "Close"});
            this.cbFV2.Location = new System.Drawing.Point(362, 83);
            this.cbFV2.Name = "cbFV2";
            this.cbFV2.Size = new System.Drawing.Size(237, 24);
            this.cbFV2.TabIndex = 7;
            this.cbFV2.Tag = "";
            // 
            // tbFV2Pos
            // 
            this.tbFV2Pos.Location = new System.Drawing.Point(149, 84);
            this.tbFV2Pos.Name = "tbFV2Pos";
            this.tbFV2Pos.Size = new System.Drawing.Size(198, 22);
            this.tbFV2Pos.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "FV2:";
            // 
            // cbFV1
            // 
            this.cbFV1.FormattingEnabled = true;
            this.cbFV1.Items.AddRange(new object[] {
            "Isolate",
            "Feed",
            "Vent"});
            this.cbFV1.Location = new System.Drawing.Point(362, 54);
            this.cbFV1.Name = "cbFV1";
            this.cbFV1.Size = new System.Drawing.Size(237, 24);
            this.cbFV1.TabIndex = 3;
            this.cbFV1.Tag = "";
            // 
            // tbFV1Pos
            // 
            this.tbFV1Pos.Location = new System.Drawing.Point(149, 55);
            this.tbFV1Pos.Name = "tbFV1Pos";
            this.tbFV1Pos.Size = new System.Drawing.Size(198, 22);
            this.tbFV1Pos.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Current Position:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "FV1:";
            // 
            // CAT_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 545);
            this.Controls.Add(this.gbControls);
            this.Controls.Add(this.gbData);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CAT_UI";
            this.Text = "CAT_UI";
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            this.gbControls.ResumeLayout(false);
            this.gbNitrogen.ResumeLayout(false);
            this.gbNitrogen.PerformLayout();
            this.gbOxygen.ResumeLayout(false);
            this.gbOxygen.PerformLayout();
            this.gbFuel.ResumeLayout(false);
            this.gbFuel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbPress;
        private System.Windows.Forms.TextBox tbTemp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbControls;
        private System.Windows.Forms.GroupBox gbNitrogen;
        private System.Windows.Forms.GroupBox gbOxygen;
        private System.Windows.Forms.GroupBox gbFuel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbFV1;
        private System.Windows.Forms.TextBox tbFV1Pos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFV3;
        private System.Windows.Forms.TextBox tbFV3Pos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbFV2;
        private System.Windows.Forms.TextBox tbFV2Pos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cbNV2;
        private System.Windows.Forms.TextBox tbNV2Pos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbNV1;
        private System.Windows.Forms.TextBox tbNV1Pos;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbPV;
        private System.Windows.Forms.TextBox tbPVPos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbOV3;
        private System.Windows.Forms.TextBox tbOV3Pos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbOV2;
        private System.Windows.Forms.TextBox tbOV2Pos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbOV1;
        private System.Windows.Forms.TextBox tbOV1Pos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

