namespace Sync_Ansync
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pRobot = new System.Windows.Forms.Panel();
            this.pDoor1 = new System.Windows.Forms.Panel();
            this.pDoor2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInit = new System.Windows.Forms.Button();
            this.btnSimulation = new System.Windows.Forms.Button();
            this.btnSimulationAsync = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxDelay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnD1Open = new System.Windows.Forms.Button();
            this.btnD1Close = new System.Windows.Forms.Button();
            this.btnD2Open = new System.Windows.Forms.Button();
            this.btnD2Close = new System.Windows.Forms.Button();
            this.btnRobotExtend = new System.Windows.Forms.Button();
            this.btnRobotRetract = new System.Windows.Forms.Button();
            this.btnRobotRotate = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lboxLog = new System.Windows.Forms.ListView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pRobot, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pDoor1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pDoor2, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 14);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(300, 186);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pRobot
            // 
            this.pRobot.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pRobot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pRobot.Location = new System.Drawing.Point(53, 3);
            this.pRobot.Name = "pRobot";
            this.pRobot.Size = new System.Drawing.Size(194, 180);
            this.pRobot.TabIndex = 0;
            // 
            // pDoor1
            // 
            this.pDoor1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pDoor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDoor1.Location = new System.Drawing.Point(3, 3);
            this.pDoor1.Name = "pDoor1";
            this.pDoor1.Size = new System.Drawing.Size(44, 180);
            this.pDoor1.TabIndex = 1;
            // 
            // pDoor2
            // 
            this.pDoor2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pDoor2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDoor2.Location = new System.Drawing.Point(253, 3);
            this.pDoor2.Name = "pDoor2";
            this.pDoor2.Size = new System.Drawing.Size(44, 180);
            this.pDoor2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 212);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Display";
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(21, 17);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(155, 30);
            this.btnInit.TabIndex = 2;
            this.btnInit.Text = "초기 화면 표시";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnSimulation
            // 
            this.btnSimulation.Location = new System.Drawing.Point(21, 105);
            this.btnSimulation.Name = "btnSimulation";
            this.btnSimulation.Size = new System.Drawing.Size(155, 42);
            this.btnSimulation.TabIndex = 3;
            this.btnSimulation.Text = "동기 동작 진행";
            this.btnSimulation.UseVisualStyleBackColor = true;
            this.btnSimulation.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnSimulationAsync
            // 
            this.btnSimulationAsync.Location = new System.Drawing.Point(21, 158);
            this.btnSimulationAsync.Name = "btnSimulationAsync";
            this.btnSimulationAsync.Size = new System.Drawing.Size(155, 42);
            this.btnSimulationAsync.TabIndex = 4;
            this.btnSimulationAsync.Text = "비동기 동작 진행";
            this.btnSimulationAsync.UseVisualStyleBackColor = true;
            this.btnSimulationAsync.Click += new System.EventHandler(this.btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "동작 Delay :";
            // 
            // tboxDelay
            // 
            this.tboxDelay.Location = new System.Drawing.Point(97, 62);
            this.tboxDelay.Name = "tboxDelay";
            this.tboxDelay.Size = new System.Drawing.Size(44, 21);
            this.tboxDelay.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "m/s";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tboxDelay);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnSimulationAsync);
            this.groupBox2.Controls.Add(this.btnSimulation);
            this.groupBox2.Controls.Add(this.btnInit);
            this.groupBox2.Location = new System.Drawing.Point(333, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(196, 211);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "전체 동작";
            // 
            // btnD1Open
            // 
            this.btnD1Open.Location = new System.Drawing.Point(26, 14);
            this.btnD1Open.Name = "btnD1Open";
            this.btnD1Open.Size = new System.Drawing.Size(97, 37);
            this.btnD1Open.TabIndex = 9;
            this.btnD1Open.Text = "Door Open";
            this.btnD1Open.UseVisualStyleBackColor = true;
            this.btnD1Open.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnD1Close
            // 
            this.btnD1Close.Location = new System.Drawing.Point(26, 57);
            this.btnD1Close.Name = "btnD1Close";
            this.btnD1Close.Size = new System.Drawing.Size(97, 37);
            this.btnD1Close.TabIndex = 10;
            this.btnD1Close.Text = "Door Close";
            this.btnD1Close.UseVisualStyleBackColor = true;
            this.btnD1Close.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnD2Open
            // 
            this.btnD2Open.Location = new System.Drawing.Point(129, 14);
            this.btnD2Open.Name = "btnD2Open";
            this.btnD2Open.Size = new System.Drawing.Size(97, 37);
            this.btnD2Open.TabIndex = 11;
            this.btnD2Open.Text = "Door2 Open";
            this.btnD2Open.UseVisualStyleBackColor = true;
            this.btnD2Open.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnD2Close
            // 
            this.btnD2Close.Location = new System.Drawing.Point(129, 57);
            this.btnD2Close.Name = "btnD2Close";
            this.btnD2Close.Size = new System.Drawing.Size(97, 37);
            this.btnD2Close.TabIndex = 11;
            this.btnD2Close.Text = "Door2 Close";
            this.btnD2Close.UseVisualStyleBackColor = true;
            this.btnD2Close.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnRobotExtend
            // 
            this.btnRobotExtend.Location = new System.Drawing.Point(26, 102);
            this.btnRobotExtend.Name = "btnRobotExtend";
            this.btnRobotExtend.Size = new System.Drawing.Size(200, 30);
            this.btnRobotExtend.TabIndex = 10;
            this.btnRobotExtend.Text = "Robot Arm Extend";
            this.btnRobotExtend.UseVisualStyleBackColor = true;
            this.btnRobotExtend.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnRobotRetract
            // 
            this.btnRobotRetract.Location = new System.Drawing.Point(26, 138);
            this.btnRobotRetract.Name = "btnRobotRetract";
            this.btnRobotRetract.Size = new System.Drawing.Size(200, 30);
            this.btnRobotRetract.TabIndex = 10;
            this.btnRobotRetract.Text = "Robot Arm Retract";
            this.btnRobotRetract.UseVisualStyleBackColor = true;
            this.btnRobotRetract.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnRobotRotate
            // 
            this.btnRobotRotate.Location = new System.Drawing.Point(26, 174);
            this.btnRobotRotate.Name = "btnRobotRotate";
            this.btnRobotRotate.Size = new System.Drawing.Size(200, 30);
            this.btnRobotRotate.TabIndex = 10;
            this.btnRobotRotate.Text = "Robot Rotate";
            this.btnRobotRotate.UseVisualStyleBackColor = true;
            this.btnRobotRotate.Click += new System.EventHandler(this.btn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnD2Close);
            this.groupBox3.Controls.Add(this.btnD2Open);
            this.groupBox3.Controls.Add(this.btnRobotRotate);
            this.groupBox3.Controls.Add(this.btnRobotRetract);
            this.groupBox3.Controls.Add(this.btnRobotExtend);
            this.groupBox3.Controls.Add(this.btnD1Close);
            this.groupBox3.Controls.Add(this.btnD1Open);
            this.groupBox3.Location = new System.Drawing.Point(535, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(251, 211);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "단위동작";
            // 
            // lboxLog
            // 
            this.lboxLog.FullRowSelect = true;
            this.lboxLog.HideSelection = false;
            this.lboxLog.Location = new System.Drawing.Point(7, 18);
            this.lboxLog.Name = "lboxLog";
            this.lboxLog.Size = new System.Drawing.Size(761, 288);
            this.lboxLog.TabIndex = 13;
            this.lboxLog.UseCompatibleStateImageBehavior = false;
            this.lboxLog.View = System.Windows.Forms.View.List;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lboxLog);
            this.groupBox4.Location = new System.Drawing.Point(12, 230);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(774, 316);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Log View";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 550);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pRobot;
        private System.Windows.Forms.Panel pDoor1;
        private System.Windows.Forms.Panel pDoor2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Button btnSimulation;
        private System.Windows.Forms.Button btnSimulationAsync;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxDelay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnD1Open;
        private System.Windows.Forms.Button btnD1Close;
        private System.Windows.Forms.Button btnD2Open;
        private System.Windows.Forms.Button btnD2Close;
        private System.Windows.Forms.Button btnRobotExtend;
        private System.Windows.Forms.Button btnRobotRetract;
        private System.Windows.Forms.Button btnRobotRotate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lboxLog;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

