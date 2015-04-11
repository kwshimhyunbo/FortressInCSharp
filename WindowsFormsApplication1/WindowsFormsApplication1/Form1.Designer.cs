namespace WindowsFormsApplication1
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelAngle = new System.Windows.Forms.Label();
            this.labelWind = new System.Windows.Forms.Label();
            this.player1 = new System.Windows.Forms.PictureBox();
            this.player2 = new System.Windows.Forms.PictureBox();
            this.angleValue = new System.Windows.Forms.Label();
            this.windValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAngle
            // 
            this.labelAngle.AutoSize = true;
            this.labelAngle.BackColor = System.Drawing.Color.Transparent;
            this.labelAngle.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelAngle.Location = new System.Drawing.Point(419, 417);
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
            this.player1.Image = ((System.Drawing.Image)(resources.GetObject("player1.Image")));
            this.player1.Location = new System.Drawing.Point(217, 324);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(44, 34);
            this.player1.TabIndex = 5;
            this.player1.TabStop = false;
            // 
            // player2
            // 
            this.player2.BackColor = System.Drawing.Color.Transparent;
            this.player2.Image = global::WindowsFormsApplication1.Properties.Resources.tank_left;
            this.player2.Location = new System.Drawing.Point(606, 324);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(38, 34);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 540);
            this.Controls.Add(this.windValue);
            this.Controls.Add(this.angleValue);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.labelWind);
            this.Controls.Add(this.labelAngle);
            this.Name = "Form1";
            this.Text = "r";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAngle;
        private System.Windows.Forms.Label labelWind;
        private System.Windows.Forms.PictureBox player2;
        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.Label angleValue;
        private System.Windows.Forms.Label windValue;
    }
}

