namespace MyWinformProject
{
    partial class FrmLotto
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
            this.label1 = new System.Windows.Forms.Label();
            this.btMainMenu = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslbUsername = new System.Windows.Forms.ToolStripLabel();
            this.tslbDateTime = new System.Windows.Forms.ToolStripLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rdClose = new System.Windows.Forms.RadioButton();
            this.rdOpen = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btLotto2Bottom = new System.Windows.Forms.Button();
            this.lbLotto2Bottom = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbLotto3Bottom02 = new System.Windows.Forms.Label();
            this.btLotto3Bottom = new System.Windows.Forms.Button();
            this.lbLotto3Bottom01 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbLotto3Top02 = new System.Windows.Forms.Label();
            this.btLotto3Top = new System.Windows.Forms.Button();
            this.lbLotto3Top01 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btLotto1 = new System.Windows.Forms.Button();
            this.lbLotto1 = new System.Windows.Forms.Label();
            this.dtpLotto = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(583, 63);
            this.label1.TabIndex = 21;
            this.label1.Text = "LOTTO หวยออนไลน์";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btMainMenu
            // 
            this.btMainMenu.Image = global::MyWinformProject.Properties.Resources.pevious1;
            this.btMainMenu.Location = new System.Drawing.Point(630, 18);
            this.btMainMenu.Name = "btMainMenu";
            this.btMainMenu.Size = new System.Drawing.Size(148, 63);
            this.btMainMenu.TabIndex = 22;
            this.btMainMenu.Text = "หน้าจอหลัก";
            this.btMainMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btMainMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btMainMenu.UseVisualStyleBackColor = true;
            this.btMainMenu.Click += new System.EventHandler(this.btMainMenu_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslbUsername,
            this.tslbDateTime});
            this.toolStrip1.Location = new System.Drawing.Point(0, 515);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 58;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tslbUsername
            // 
            this.tslbUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslbUsername.ForeColor = System.Drawing.Color.Blue;
            this.tslbUsername.Name = "tslbUsername";
            this.tslbUsername.Size = new System.Drawing.Size(43, 22);
            this.tslbUsername.Text = "name?";
            // 
            // tslbDateTime
            // 
            this.tslbDateTime.Name = "tslbDateTime";
            this.tslbDateTime.Size = new System.Drawing.Size(59, 22);
            this.tslbDateTime.Text = "datetime?";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rdClose
            // 
            this.rdClose.AutoSize = true;
            this.rdClose.Checked = true;
            this.rdClose.Location = new System.Drawing.Point(476, 452);
            this.rdClose.Name = "rdClose";
            this.rdClose.Size = new System.Drawing.Size(104, 17);
            this.rdClose.TabIndex = 68;
            this.rdClose.TabStop = true;
            this.rdClose.Text = "ปิดการออกรางวัล";
            this.rdClose.UseVisualStyleBackColor = true;
            this.rdClose.Click += new System.EventHandler(this.rdClose_Click);
            // 
            // rdOpen
            // 
            this.rdOpen.AutoSize = true;
            this.rdOpen.Location = new System.Drawing.Point(476, 412);
            this.rdOpen.Name = "rdOpen";
            this.rdOpen.Size = new System.Drawing.Size(109, 17);
            this.rdOpen.TabIndex = 67;
            this.rdOpen.TabStop = true;
            this.rdOpen.Text = "เปิดการออกรางวัล";
            this.rdOpen.UseVisualStyleBackColor = true;
            this.rdOpen.Click += new System.EventHandler(this.rdOpen_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btLotto2Bottom);
            this.groupBox4.Controls.Add(this.lbLotto2Bottom);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(156, 402);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(275, 78);
            this.groupBox4.TabIndex = 64;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "รางวัลเลขท้าย 2 ตัวล่าง";
            // 
            // btLotto2Bottom
            // 
            this.btLotto2Bottom.Enabled = false;
            this.btLotto2Bottom.Image = global::MyWinformProject.Properties.Resources.start2;
            this.btLotto2Bottom.Location = new System.Drawing.Point(170, 20);
            this.btLotto2Bottom.Name = "btLotto2Bottom";
            this.btLotto2Bottom.Size = new System.Drawing.Size(50, 47);
            this.btLotto2Bottom.TabIndex = 23;
            this.btLotto2Bottom.UseVisualStyleBackColor = true;
            this.btLotto2Bottom.Click += new System.EventHandler(this.btLotto2Bottom_Click);
            // 
            // lbLotto2Bottom
            // 
            this.lbLotto2Bottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLotto2Bottom.ForeColor = System.Drawing.Color.Red;
            this.lbLotto2Bottom.Location = new System.Drawing.Point(20, 19);
            this.lbLotto2Bottom.Name = "lbLotto2Bottom";
            this.lbLotto2Bottom.Size = new System.Drawing.Size(144, 48);
            this.lbLotto2Bottom.TabIndex = 22;
            this.lbLotto2Bottom.Text = "??";
            this.lbLotto2Bottom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbLotto3Bottom02);
            this.groupBox3.Controls.Add(this.btLotto3Bottom);
            this.groupBox3.Controls.Add(this.lbLotto3Bottom01);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(379, 239);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(289, 137);
            this.groupBox3.TabIndex = 66;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "รางวัล 3 ตัวล่าง";
            // 
            // lbLotto3Bottom02
            // 
            this.lbLotto3Bottom02.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLotto3Bottom02.ForeColor = System.Drawing.Color.Red;
            this.lbLotto3Bottom02.Location = new System.Drawing.Point(50, 74);
            this.lbLotto3Bottom02.Name = "lbLotto3Bottom02";
            this.lbLotto3Bottom02.Size = new System.Drawing.Size(134, 48);
            this.lbLotto3Bottom02.TabIndex = 24;
            this.lbLotto3Bottom02.Text = "???";
            this.lbLotto3Bottom02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btLotto3Bottom
            // 
            this.btLotto3Bottom.Enabled = false;
            this.btLotto3Bottom.Image = global::MyWinformProject.Properties.Resources.start2;
            this.btLotto3Bottom.Location = new System.Drawing.Point(190, 46);
            this.btLotto3Bottom.Name = "btLotto3Bottom";
            this.btLotto3Bottom.Size = new System.Drawing.Size(50, 47);
            this.btLotto3Bottom.TabIndex = 23;
            this.btLotto3Bottom.UseVisualStyleBackColor = true;
            this.btLotto3Bottom.Click += new System.EventHandler(this.btLotto3Bottom_Click);
            // 
            // lbLotto3Bottom01
            // 
            this.lbLotto3Bottom01.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLotto3Bottom01.ForeColor = System.Drawing.Color.Red;
            this.lbLotto3Bottom01.Location = new System.Drawing.Point(50, 21);
            this.lbLotto3Bottom01.Name = "lbLotto3Bottom01";
            this.lbLotto3Bottom01.Size = new System.Drawing.Size(134, 48);
            this.lbLotto3Bottom01.TabIndex = 22;
            this.lbLotto3Bottom01.Text = "???";
            this.lbLotto3Bottom01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbLotto3Top02);
            this.groupBox2.Controls.Add(this.btLotto3Top);
            this.groupBox2.Controls.Add(this.lbLotto3Top01);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(40, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 137);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "รางวัล 3 ตัวบน";
            // 
            // lbLotto3Top02
            // 
            this.lbLotto3Top02.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLotto3Top02.ForeColor = System.Drawing.Color.Red;
            this.lbLotto3Top02.Location = new System.Drawing.Point(50, 74);
            this.lbLotto3Top02.Name = "lbLotto3Top02";
            this.lbLotto3Top02.Size = new System.Drawing.Size(144, 48);
            this.lbLotto3Top02.TabIndex = 24;
            this.lbLotto3Top02.Text = "???";
            this.lbLotto3Top02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btLotto3Top
            // 
            this.btLotto3Top.Enabled = false;
            this.btLotto3Top.Image = global::MyWinformProject.Properties.Resources.start2;
            this.btLotto3Top.Location = new System.Drawing.Point(200, 46);
            this.btLotto3Top.Name = "btLotto3Top";
            this.btLotto3Top.Size = new System.Drawing.Size(50, 47);
            this.btLotto3Top.TabIndex = 23;
            this.btLotto3Top.UseVisualStyleBackColor = true;
            this.btLotto3Top.Click += new System.EventHandler(this.btLotto3Top_Click);
            // 
            // lbLotto3Top01
            // 
            this.lbLotto3Top01.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLotto3Top01.ForeColor = System.Drawing.Color.Red;
            this.lbLotto3Top01.Location = new System.Drawing.Point(50, 21);
            this.lbLotto3Top01.Name = "lbLotto3Top01";
            this.lbLotto3Top01.Size = new System.Drawing.Size(144, 48);
            this.lbLotto3Top01.TabIndex = 22;
            this.lbLotto3Top01.Text = "???";
            this.lbLotto3Top01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btLotto1);
            this.groupBox1.Controls.Add(this.lbLotto1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(156, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 78);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "รางวัลที่ 1 ";
            // 
            // btLotto1
            // 
            this.btLotto1.Enabled = false;
            this.btLotto1.Image = global::MyWinformProject.Properties.Resources.start2;
            this.btLotto1.Location = new System.Drawing.Point(277, 18);
            this.btLotto1.Name = "btLotto1";
            this.btLotto1.Size = new System.Drawing.Size(50, 47);
            this.btLotto1.TabIndex = 23;
            this.btLotto1.UseVisualStyleBackColor = true;
            this.btLotto1.Click += new System.EventHandler(this.btLotto1_Click);
            // 
            // lbLotto1
            // 
            this.lbLotto1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLotto1.ForeColor = System.Drawing.Color.Red;
            this.lbLotto1.Location = new System.Drawing.Point(124, 18);
            this.lbLotto1.Name = "lbLotto1";
            this.lbLotto1.Size = new System.Drawing.Size(144, 48);
            this.lbLotto1.TabIndex = 22;
            this.lbLotto1.Text = "??????";
            this.lbLotto1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpLotto
            // 
            this.dtpLotto.Location = new System.Drawing.Point(409, 100);
            this.dtpLotto.Name = "dtpLotto";
            this.dtpLotto.Size = new System.Drawing.Size(200, 20);
            this.dtpLotto.TabIndex = 62;
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(297, 97);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(93, 23);
            this.label23.TabIndex = 61;
            this.label23.Text = "ประจำงวดวันที่";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmLotto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.rdClose);
            this.Controls.Add(this.rdOpen);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpLotto);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btMainMenu);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmLotto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lotto - DTI Soft V.1.0";
            this.Load += new System.EventHandler(this.FrmLotto_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btMainMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslbUsername;
        private System.Windows.Forms.ToolStripLabel tslbDateTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton rdClose;
        private System.Windows.Forms.RadioButton rdOpen;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btLotto2Bottom;
        private System.Windows.Forms.Label lbLotto2Bottom;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbLotto3Bottom02;
        private System.Windows.Forms.Button btLotto3Bottom;
        private System.Windows.Forms.Label lbLotto3Bottom01;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbLotto3Top02;
        private System.Windows.Forms.Button btLotto3Top;
        private System.Windows.Forms.Label lbLotto3Top01;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btLotto1;
        private System.Windows.Forms.Label lbLotto1;
        private System.Windows.Forms.DateTimePicker dtpLotto;
        private System.Windows.Forms.Label label23;
    }
}