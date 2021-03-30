namespace _210330_asyncawait
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
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pRobot, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pDoor1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pDoor2, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 14);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(264, 186);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pRobot
            // 
            this.pRobot.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pRobot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pRobot.Location = new System.Drawing.Point(53, 3);
            this.pRobot.Name = "pRobot";
            this.pRobot.Size = new System.Drawing.Size(158, 180);
            this.pRobot.TabIndex = 0;
            // 
            // pDoor1
            // 
            this.pDoor1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pDoor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDoor1.Location = new System.Drawing.Point(3, 3);
            this.pDoor1.Name = "pDoor1";
            this.pDoor1.Size = new System.Drawing.Size(44, 180);
            this.pDoor1.TabIndex = 1;
            // 
            // pDoor2
            // 
            this.pDoor2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pDoor2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDoor2.Location = new System.Drawing.Point(217, 3);
            this.pDoor2.Name = "pDoor2";
            this.pDoor2.Size = new System.Drawing.Size(44, 180);
            this.pDoor2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 212);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Display";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 550);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pRobot;
        private System.Windows.Forms.Panel pDoor1;
        private System.Windows.Forms.Panel pDoor2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

