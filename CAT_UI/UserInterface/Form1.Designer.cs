
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
            this.components = new System.ComponentModel.Container();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnReConnect = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbPress6 = new System.Windows.Forms.TextBox();
            this.tbPress5 = new System.Windows.Forms.TextBox();
            this.tbPress4 = new System.Windows.Forms.TextBox();
            this.tbPress3 = new System.Windows.Forms.TextBox();
            this.tbPress2 = new System.Windows.Forms.TextBox();
            this.tbTemp2 = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbPress1 = new System.Windows.Forms.TextBox();
            this.tbTemp1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbControls = new System.Windows.Forms.GroupBox();
            this.btnActuate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.gbNitrogen = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.tbNV2State = new System.Windows.Forms.TextBox();
            this.tbNV1State = new System.Windows.Forms.TextBox();
            this.tbNV2Pos = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbNV1Pos = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.gbOxygen = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.tbPVState = new System.Windows.Forms.TextBox();
            this.tbOV3State = new System.Windows.Forms.TextBox();
            this.tbOV2State = new System.Windows.Forms.TextBox();
            this.tbOV1State = new System.Windows.Forms.TextBox();
            this.tbPVPos = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbOV3Pos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbOV2Pos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbOV1Pos = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gbFuel = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.tbFV3State = new System.Windows.Forms.TextBox();
            this.tbFV2State = new System.Windows.Forms.TextBox();
            this.tbFV1State = new System.Windows.Forms.TextBox();
            this.tbFV3Pos = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbFV2Pos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbFV1Pos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mySerialPort = new System.IO.Ports.SerialPort(this.components);
            this.label23 = new System.Windows.Forms.Label();
            this.gbData.SuspendLayout();
            this.gbControls.SuspendLayout();
            this.gbNitrogen.SuspendLayout();
            this.gbOxygen.SuspendLayout();
            this.gbFuel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.btnStop);
            this.gbData.Controls.Add(this.btnReConnect);
            this.gbData.Controls.Add(this.label22);
            this.gbData.Controls.Add(this.label21);
            this.gbData.Controls.Add(this.label20);
            this.gbData.Controls.Add(this.label19);
            this.gbData.Controls.Add(this.label18);
            this.gbData.Controls.Add(this.label17);
            this.gbData.Controls.Add(this.label16);
            this.gbData.Controls.Add(this.label15);
            this.gbData.Controls.Add(this.tbPress6);
            this.gbData.Controls.Add(this.tbPress5);
            this.gbData.Controls.Add(this.tbPress4);
            this.gbData.Controls.Add(this.tbPress3);
            this.gbData.Controls.Add(this.tbPress2);
            this.gbData.Controls.Add(this.tbTemp2);
            this.gbData.Controls.Add(this.btnStart);
            this.gbData.Controls.Add(this.tbPress1);
            this.gbData.Controls.Add(this.tbTemp1);
            this.gbData.Controls.Add(this.label2);
            this.gbData.Controls.Add(this.label1);
            this.gbData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbData.Location = new System.Drawing.Point(14, 126);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(415, 407);
            this.gbData.TabIndex = 0;
            this.gbData.TabStop = false;
            this.gbData.Text = "Data";
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(215, 368);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(177, 33);
            this.btnStop.TabIndex = 21;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnReConnect
            // 
            this.btnReConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReConnect.Location = new System.Drawing.Point(20, 329);
            this.btnReConnect.Name = "btnReConnect";
            this.btnReConnect.Size = new System.Drawing.Size(372, 33);
            this.btnReConnect.TabIndex = 20;
            this.btnReConnect.Text = "Reconnect";
            this.btnReConnect.UseVisualStyleBackColor = true;
            this.btnReConnect.Click += new System.EventHandler(this.btnReConnect_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(15, 286);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 17);
            this.label22.TabIndex = 19;
            this.label22.Text = "Sensor 6";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(15, 258);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 17);
            this.label21.TabIndex = 18;
            this.label21.Text = "Sensor 5";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(15, 230);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 17);
            this.label20.TabIndex = 17;
            this.label20.Text = "Sensor 4";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(15, 202);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 17);
            this.label19.TabIndex = 16;
            this.label19.Text = "Sensor 3";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 174);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 17);
            this.label18.TabIndex = 15;
            this.label18.Text = "Sensor 2";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 144);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 17);
            this.label17.TabIndex = 14;
            this.label17.Text = "Sensor 1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 69);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 17);
            this.label16.TabIndex = 13;
            this.label16.Text = "Sensor 2";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 41);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 17);
            this.label15.TabIndex = 12;
            this.label15.Text = "Sensor 1";
            // 
            // tbPress6
            // 
            this.tbPress6.Location = new System.Drawing.Point(86, 283);
            this.tbPress6.Name = "tbPress6";
            this.tbPress6.Size = new System.Drawing.Size(306, 22);
            this.tbPress6.TabIndex = 11;
            // 
            // tbPress5
            // 
            this.tbPress5.Location = new System.Drawing.Point(86, 255);
            this.tbPress5.Name = "tbPress5";
            this.tbPress5.Size = new System.Drawing.Size(306, 22);
            this.tbPress5.TabIndex = 10;
            // 
            // tbPress4
            // 
            this.tbPress4.Location = new System.Drawing.Point(86, 227);
            this.tbPress4.Name = "tbPress4";
            this.tbPress4.Size = new System.Drawing.Size(306, 22);
            this.tbPress4.TabIndex = 9;
            // 
            // tbPress3
            // 
            this.tbPress3.Location = new System.Drawing.Point(86, 199);
            this.tbPress3.Name = "tbPress3";
            this.tbPress3.Size = new System.Drawing.Size(306, 22);
            this.tbPress3.TabIndex = 8;
            // 
            // tbPress2
            // 
            this.tbPress2.Location = new System.Drawing.Point(86, 171);
            this.tbPress2.Name = "tbPress2";
            this.tbPress2.Size = new System.Drawing.Size(306, 22);
            this.tbPress2.TabIndex = 7;
            // 
            // tbTemp2
            // 
            this.tbTemp2.Location = new System.Drawing.Point(86, 66);
            this.tbTemp2.Name = "tbTemp2";
            this.tbTemp2.Size = new System.Drawing.Size(306, 22);
            this.tbTemp2.TabIndex = 6;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(20, 368);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(189, 33);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbPress1
            // 
            this.tbPress1.Location = new System.Drawing.Point(86, 141);
            this.tbPress1.Name = "tbPress1";
            this.tbPress1.Size = new System.Drawing.Size(306, 22);
            this.tbPress1.TabIndex = 3;
            // 
            // tbTemp1
            // 
            this.tbTemp1.Location = new System.Drawing.Point(86, 38);
            this.tbTemp1.Name = "tbTemp1";
            this.tbTemp1.Size = new System.Drawing.Size(306, 22);
            this.tbTemp1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(174, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pressure";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperature";
            // 
            // gbControls
            // 
            this.gbControls.Controls.Add(this.btnActuate);
            this.gbControls.Controls.Add(this.btnReset);
            this.gbControls.Controls.Add(this.gbNitrogen);
            this.gbControls.Controls.Add(this.gbOxygen);
            this.gbControls.Controls.Add(this.gbFuel);
            this.gbControls.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbControls.Location = new System.Drawing.Point(435, 12);
            this.gbControls.Name = "gbControls";
            this.gbControls.Size = new System.Drawing.Size(395, 521);
            this.gbControls.TabIndex = 1;
            this.gbControls.TabStop = false;
            this.gbControls.Text = "Controls";
            // 
            // btnActuate
            // 
            this.btnActuate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActuate.Location = new System.Drawing.Point(107, 482);
            this.btnActuate.Name = "btnActuate";
            this.btnActuate.Size = new System.Drawing.Size(138, 33);
            this.btnActuate.TabIndex = 3;
            this.btnActuate.Text = "Actuate";
            this.btnActuate.UseVisualStyleBackColor = true;
            this.btnActuate.Click += new System.EventHandler(this.btnActuate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(251, 482);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(138, 33);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // gbNitrogen
            // 
            this.gbNitrogen.Controls.Add(this.label26);
            this.gbNitrogen.Controls.Add(this.tbNV2State);
            this.gbNitrogen.Controls.Add(this.tbNV1State);
            this.gbNitrogen.Controls.Add(this.tbNV2Pos);
            this.gbNitrogen.Controls.Add(this.label12);
            this.gbNitrogen.Controls.Add(this.tbNV1Pos);
            this.gbNitrogen.Controls.Add(this.label13);
            this.gbNitrogen.Controls.Add(this.label14);
            this.gbNitrogen.Location = new System.Drawing.Point(6, 350);
            this.gbNitrogen.Name = "gbNitrogen";
            this.gbNitrogen.Size = new System.Drawing.Size(383, 120);
            this.gbNitrogen.TabIndex = 1;
            this.gbNitrogen.TabStop = false;
            this.gbNitrogen.Text = "Nitrogen";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(255, 18);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(46, 17);
            this.label26.TabIndex = 29;
            this.label26.Text = "State";
            // 
            // tbNV2State
            // 
            this.tbNV2State.Location = new System.Drawing.Point(180, 79);
            this.tbNV2State.Name = "tbNV2State";
            this.tbNV2State.Size = new System.Drawing.Size(197, 22);
            this.tbNV2State.TabIndex = 29;
            // 
            // tbNV1State
            // 
            this.tbNV1State.Location = new System.Drawing.Point(180, 50);
            this.tbNV1State.Name = "tbNV1State";
            this.tbNV1State.Size = new System.Drawing.Size(197, 22);
            this.tbNV1State.TabIndex = 28;
            // 
            // tbNV2Pos
            // 
            this.tbNV2Pos.Location = new System.Drawing.Point(54, 79);
            this.tbNV2Pos.Name = "tbNV2Pos";
            this.tbNV2Pos.Size = new System.Drawing.Size(120, 22);
            this.tbNV2Pos.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 17);
            this.label12.TabIndex = 16;
            this.label12.Text = "NV2:";
            // 
            // tbNV1Pos
            // 
            this.tbNV1Pos.Location = new System.Drawing.Point(54, 50);
            this.tbNV1Pos.Name = "tbNV1Pos";
            this.tbNV1Pos.Size = new System.Drawing.Size(120, 22);
            this.tbNV1Pos.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(49, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 17);
            this.label13.TabIndex = 13;
            this.label13.Text = "Current Position:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 53);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 17);
            this.label14.TabIndex = 12;
            this.label14.Text = "NV1:";
            // 
            // gbOxygen
            // 
            this.gbOxygen.Controls.Add(this.label25);
            this.gbOxygen.Controls.Add(this.tbPVState);
            this.gbOxygen.Controls.Add(this.tbOV3State);
            this.gbOxygen.Controls.Add(this.tbOV2State);
            this.gbOxygen.Controls.Add(this.tbOV1State);
            this.gbOxygen.Controls.Add(this.tbPVPos);
            this.gbOxygen.Controls.Add(this.label11);
            this.gbOxygen.Controls.Add(this.tbOV3Pos);
            this.gbOxygen.Controls.Add(this.label5);
            this.gbOxygen.Controls.Add(this.tbOV2Pos);
            this.gbOxygen.Controls.Add(this.label7);
            this.gbOxygen.Controls.Add(this.tbOV1Pos);
            this.gbOxygen.Controls.Add(this.label9);
            this.gbOxygen.Controls.Add(this.label10);
            this.gbOxygen.Location = new System.Drawing.Point(6, 189);
            this.gbOxygen.Name = "gbOxygen";
            this.gbOxygen.Size = new System.Drawing.Size(383, 155);
            this.gbOxygen.TabIndex = 1;
            this.gbOxygen.TabStop = false;
            this.gbOxygen.Text = "Oxygen";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(255, 18);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(46, 17);
            this.label25.TabIndex = 28;
            this.label25.Text = "State";
            // 
            // tbPVState
            // 
            this.tbPVState.Location = new System.Drawing.Point(180, 127);
            this.tbPVState.Name = "tbPVState";
            this.tbPVState.Size = new System.Drawing.Size(197, 22);
            this.tbPVState.TabIndex = 27;
            // 
            // tbOV3State
            // 
            this.tbOV3State.Location = new System.Drawing.Point(180, 99);
            this.tbOV3State.Name = "tbOV3State";
            this.tbOV3State.Size = new System.Drawing.Size(197, 22);
            this.tbOV3State.TabIndex = 26;
            // 
            // tbOV2State
            // 
            this.tbOV2State.Location = new System.Drawing.Point(180, 70);
            this.tbOV2State.Name = "tbOV2State";
            this.tbOV2State.Size = new System.Drawing.Size(197, 22);
            this.tbOV2State.TabIndex = 25;
            // 
            // tbOV1State
            // 
            this.tbOV1State.Location = new System.Drawing.Point(180, 42);
            this.tbOV1State.Name = "tbOV1State";
            this.tbOV1State.Size = new System.Drawing.Size(197, 22);
            this.tbOV1State.TabIndex = 24;
            // 
            // tbPVPos
            // 
            this.tbPVPos.Location = new System.Drawing.Point(54, 127);
            this.tbPVPos.Name = "tbPVPos";
            this.tbPVPos.Size = new System.Drawing.Size(120, 22);
            this.tbPVPos.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "PV:";
            // 
            // tbOV3Pos
            // 
            this.tbOV3Pos.Location = new System.Drawing.Point(54, 99);
            this.tbOV3Pos.Name = "tbOV3Pos";
            this.tbOV3Pos.Size = new System.Drawing.Size(120, 22);
            this.tbOV3Pos.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "OV3:";
            // 
            // tbOV2Pos
            // 
            this.tbOV2Pos.Location = new System.Drawing.Point(54, 71);
            this.tbOV2Pos.Name = "tbOV2Pos";
            this.tbOV2Pos.Size = new System.Drawing.Size(120, 22);
            this.tbOV2Pos.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "OV2:";
            // 
            // tbOV1Pos
            // 
            this.tbOV1Pos.Location = new System.Drawing.Point(54, 42);
            this.tbOV1Pos.Name = "tbOV1Pos";
            this.tbOV1Pos.Size = new System.Drawing.Size(120, 22);
            this.tbOV1Pos.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(49, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Current Position:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "OV1:";
            // 
            // gbFuel
            // 
            this.gbFuel.Controls.Add(this.label24);
            this.gbFuel.Controls.Add(this.tbFV3State);
            this.gbFuel.Controls.Add(this.tbFV2State);
            this.gbFuel.Controls.Add(this.tbFV1State);
            this.gbFuel.Controls.Add(this.tbFV3Pos);
            this.gbFuel.Controls.Add(this.label8);
            this.gbFuel.Controls.Add(this.tbFV2Pos);
            this.gbFuel.Controls.Add(this.label6);
            this.gbFuel.Controls.Add(this.tbFV1Pos);
            this.gbFuel.Controls.Add(this.label4);
            this.gbFuel.Controls.Add(this.label3);
            this.gbFuel.Location = new System.Drawing.Point(6, 38);
            this.gbFuel.Name = "gbFuel";
            this.gbFuel.Size = new System.Drawing.Size(383, 145);
            this.gbFuel.TabIndex = 0;
            this.gbFuel.TabStop = false;
            this.gbFuel.Text = "Fuel";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(255, 23);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(46, 17);
            this.label24.TabIndex = 14;
            this.label24.Text = "State";
            // 
            // tbFV3State
            // 
            this.tbFV3State.Location = new System.Drawing.Point(180, 113);
            this.tbFV3State.Name = "tbFV3State";
            this.tbFV3State.Size = new System.Drawing.Size(197, 22);
            this.tbFV3State.TabIndex = 13;
            // 
            // tbFV2State
            // 
            this.tbFV2State.Location = new System.Drawing.Point(180, 85);
            this.tbFV2State.Name = "tbFV2State";
            this.tbFV2State.Size = new System.Drawing.Size(197, 22);
            this.tbFV2State.TabIndex = 12;
            // 
            // tbFV1State
            // 
            this.tbFV1State.Location = new System.Drawing.Point(180, 56);
            this.tbFV1State.Name = "tbFV1State";
            this.tbFV1State.Size = new System.Drawing.Size(197, 22);
            this.tbFV1State.TabIndex = 11;
            // 
            // tbFV3Pos
            // 
            this.tbFV3Pos.Location = new System.Drawing.Point(54, 113);
            this.tbFV3Pos.Name = "tbFV3Pos";
            this.tbFV3Pos.Size = new System.Drawing.Size(120, 22);
            this.tbFV3Pos.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "FV3:";
            // 
            // tbFV2Pos
            // 
            this.tbFV2Pos.Location = new System.Drawing.Point(54, 85);
            this.tbFV2Pos.Name = "tbFV2Pos";
            this.tbFV2Pos.Size = new System.Drawing.Size(120, 22);
            this.tbFV2Pos.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "FV2:";
            // 
            // tbFV1Pos
            // 
            this.tbFV1Pos.Location = new System.Drawing.Point(54, 56);
            this.tbFV1Pos.Name = "tbFV1Pos";
            this.tbFV1Pos.Size = new System.Drawing.Size(120, 22);
            this.tbFV1Pos.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Current Position";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "FV1:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label23.Location = new System.Drawing.Point(14, 42);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(371, 42);
            this.label23.TabIndex = 2;
            this.label23.Text = "Test Station Monitor";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CAT_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(843, 545);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.gbControls);
            this.Controls.Add(this.gbData);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CAT_UI";
            this.Text = "CAT_UI";
            this.Load += new System.EventHandler(this.CAT_UI_Load);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.TextBox tbPress1;
        private System.Windows.Forms.TextBox tbTemp1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbControls;
        private System.Windows.Forms.GroupBox gbNitrogen;
        private System.Windows.Forms.GroupBox gbOxygen;
        private System.Windows.Forms.GroupBox gbFuel;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbFV1Pos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFV3Pos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbFV2Pos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox tbNV2Pos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbNV1Pos;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbPVPos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbOV3Pos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbOV2Pos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbOV1Pos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbPress6;
        private System.Windows.Forms.TextBox tbPress5;
        private System.Windows.Forms.TextBox tbPress4;
        private System.Windows.Forms.TextBox tbPress3;
        private System.Windows.Forms.TextBox tbPress2;
        private System.Windows.Forms.TextBox tbTemp2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.Button btnReConnect;
        private System.IO.Ports.SerialPort mySerialPort;
        private System.Windows.Forms.Button btnActuate;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tbNV2State;
        private System.Windows.Forms.TextBox tbNV1State;
        private System.Windows.Forms.TextBox tbPVState;
        private System.Windows.Forms.TextBox tbOV3State;
        private System.Windows.Forms.TextBox tbOV2State;
        private System.Windows.Forms.TextBox tbOV1State;
        private System.Windows.Forms.TextBox tbFV3State;
        private System.Windows.Forms.TextBox tbFV2State;
        private System.Windows.Forms.TextBox tbFV1State;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnStop;
    }
}

