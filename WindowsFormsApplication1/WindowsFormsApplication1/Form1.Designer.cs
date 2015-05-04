namespace WindowsFormsApplication1
{
    partial class leftbomb
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelAngle = new System.Windows.Forms.Label();
            this.labelWind = new System.Windows.Forms.Label();
            this.player1 = new System.Windows.Forms.PictureBox();
            this.player2 = new System.Windows.Forms.PictureBox();
            this.angleValue = new System.Windows.Forms.Label();
            this.windValue = new System.Windows.Forms.Label();
            this.hp2label = new System.Windows.Forms.Label();
            this.hp1label = new System.Windows.Forms.Label();
            this.windlabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.powerlabel = new System.Windows.Forms.Label();
            this.BOMB = new System.Windows.Forms.PictureBox();
            this.fire = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BOMB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fire)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAngle
            // 
            this.labelAngle.AutoSize = true;
            this.labelAngle.BackColor = System.Drawing.Color.Transparent;
            this.labelAngle.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelAngle.Location = new System.Drawing.Point(421, 415);
            this.labelAngle.Name = "labelAngle";
            this.labelAngle.Size = new System.Drawing.Size(52, 21);
            this.labelAngle.TabIndex = 1;
            this.labelAngle.Text = "각도";
            // 
            // labelWind
            // 
            this.labelWind.AutoSize = true;
            this.labelWind.BackColor = System.Drawing.Color.Transparent;
            this.labelWind.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelWind.Location = new System.Drawing.Point(827, 468);
            this.labelWind.Name = "labelWind";
            this.labelWind.Size = new System.Drawing.Size(58, 24);
            this.labelWind.TabIndex = 2;
            this.labelWind.Text = "바람";
            // 
            // player1
            // 
            this.player1.BackColor = System.Drawing.Color.Transparent;
            this.player1.Image = global::WindowsFormsApplication1.Properties.Resources.tank2_right;
            this.player1.Location = new System.Drawing.Point(217, 324);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(36, 34);
            this.player1.TabIndex = 5;
            this.player1.TabStop = false;
            // 
            // player2
            // 
            this.player2.BackColor = System.Drawing.Color.Transparent;
            this.player2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.player2.Image = global::WindowsFormsApplication1.Properties.Resources.wait;
            this.player2.Location = new System.Drawing.Point(586, 304);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(69, 54);
            this.player2.TabIndex = 4;
            this.player2.TabStop = false;
            // 
            // angleValue
            // 
            this.angleValue.AutoSize = true;
            this.angleValue.BackColor = System.Drawing.Color.Transparent;
            this.angleValue.Location = new System.Drawing.Point(443, 451);
            this.angleValue.Name = "angleValue";
            this.angleValue.Size = new System.Drawing.Size(0, 12);
            this.angleValue.TabIndex = 6;
            // 
            // windValue
            // 
            this.windValue.AutoSize = true;
            this.windValue.BackColor = System.Drawing.Color.Transparent;
            this.windValue.Location = new System.Drawing.Point(856, 503);
            this.windValue.Name = "windValue";
            this.windValue.Size = new System.Drawing.Size(0, 12);
            this.windValue.TabIndex = 7;
            // 
            // hp2label
            // 
            this.hp2label.AutoSize = true;
            this.hp2label.Location = new System.Drawing.Point(606, 361);
            this.hp2label.Name = "hp2label";
            this.hp2label.Size = new System.Drawing.Size(49, 12);
            this.hp2label.TabIndex = 8;
            this.hp2label.Text = "HP:1500";
            // 
            // hp1label
            // 
            this.hp1label.AutoSize = true;
            this.hp1label.Location = new System.Drawing.Point(215, 361);
            this.hp1label.Name = "hp1label";
            this.hp1label.Size = new System.Drawing.Size(49, 12);
            this.hp1label.TabIndex = 9;
            this.hp1label.Text = "HP:1500";
            // 
            // windlabel
            // 
            this.windlabel.AutoSize = true;
            this.windlabel.Location = new System.Drawing.Point(845, 503);
            this.windlabel.Name = "windlabel";
            this.windlabel.Size = new System.Drawing.Size(11, 12);
            this.windlabel.TabIndex = 10;
            this.windlabel.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // powerlabel
            // 
            this.powerlabel.AutoSize = true;
            this.powerlabel.Location = new System.Drawing.Point(25, 488);
            this.powerlabel.Name = "powerlabel";
            this.powerlabel.Size = new System.Drawing.Size(11, 12);
            this.powerlabel.TabIndex = 13;
            this.powerlabel.Text = "0";
            // 
            // BOMB
            // 
            this.BOMB.BackColor = System.Drawing.Color.Transparent;
            this.BOMB.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.RED;
            this.BOMB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BOMB.Location = new System.Drawing.Point(243, 296);
            this.BOMB.Name = "BOMB";
            this.BOMB.Size = new System.Drawing.Size(41, 42);
            this.BOMB.TabIndex = 11;
            this.BOMB.TabStop = false;
            this.BOMB.Visible = false;
            // 
            // fire
            // 
            this.fire.AccessibleRole = System.Windows.Forms.AccessibleRole.Equation;
            this.fire.BackColor = System.Drawing.Color.Transparent;
            this.fire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fire.Image = global::WindowsFormsApplication1.Properties.Resources.fire;
            this.fire.Location = new System.Drawing.Point(308, 68);
            this.fire.Name = "fire";
            this.fire.Size = new System.Drawing.Size(199, 80);
            this.fire.TabIndex = 14;
            this.fire.TabStop = false;
            this.fire.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // leftbomb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 540);
            this.Controls.Add(this.fire);
            this.Controls.Add(this.powerlabel);
            this.Controls.Add(this.BOMB);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.windlabel);
            this.Controls.Add(this.hp1label);
            this.Controls.Add(this.hp2label);
            this.Controls.Add(this.windValue);
            this.Controls.Add(this.angleValue);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.labelWind);
            this.Controls.Add(this.labelAngle);
            this.Name = "leftbomb";
            this.Text = "l";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BOMB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAngle;
        private System.Windows.Forms.Label labelWind;
        private System.Windows.Forms.PictureBox player2;
        private System.Windows.Forms.Label angleValue;
        private System.Windows.Forms.Label windValue;
        private System.Windows.Forms.Label hp2label;
        private System.Windows.Forms.Label hp1label;
        private System.Windows.Forms.Label windlabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label powerlabel;
        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.PictureBox BOMB;
        private System.Windows.Forms.PictureBox fire;
        private System.Windows.Forms.Timer timer2;
    }
}

