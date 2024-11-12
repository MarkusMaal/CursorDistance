namespace CursorDistance
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
            this.pixelCount = new System.Windows.Forms.Label();
            this.secondCount = new System.Windows.Forms.Label();
            this.speedAverage = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.currentSpeed = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pixelCount
            // 
            this.pixelCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pixelCount.BackColor = System.Drawing.Color.Transparent;
            this.pixelCount.ForeColor = System.Drawing.Color.White;
            this.pixelCount.Location = new System.Drawing.Point(12, 385);
            this.pixelCount.Name = "pixelCount";
            this.pixelCount.Size = new System.Drawing.Size(599, 13);
            this.pixelCount.TabIndex = 0;
            this.pixelCount.Text = "Pixels travelled: 0 px";
            // 
            // secondCount
            // 
            this.secondCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.secondCount.BackColor = System.Drawing.Color.Transparent;
            this.secondCount.ForeColor = System.Drawing.Color.White;
            this.secondCount.Location = new System.Drawing.Point(12, 398);
            this.secondCount.Name = "secondCount";
            this.secondCount.Size = new System.Drawing.Size(665, 13);
            this.secondCount.TabIndex = 1;
            this.secondCount.Text = "Time: 0 seconds";
            // 
            // speedAverage
            // 
            this.speedAverage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.speedAverage.BackColor = System.Drawing.Color.Transparent;
            this.speedAverage.ForeColor = System.Drawing.Color.White;
            this.speedAverage.Location = new System.Drawing.Point(12, 411);
            this.speedAverage.Name = "speedAverage";
            this.speedAverage.Size = new System.Drawing.Size(665, 13);
            this.speedAverage.TabIndex = 2;
            this.speedAverage.Text = "Average speed: 0 px/s";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 16;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 50;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // currentSpeed
            // 
            this.currentSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.currentSpeed.BackColor = System.Drawing.Color.Transparent;
            this.currentSpeed.ForeColor = System.Drawing.Color.White;
            this.currentSpeed.Location = new System.Drawing.Point(12, 424);
            this.currentSpeed.Name = "currentSpeed";
            this.currentSpeed.Size = new System.Drawing.Size(672, 13);
            this.currentSpeed.TabIndex = 3;
            this.currentSpeed.Text = "Current speed: 0 px/s";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(413, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 28);
            this.label1.TabIndex = 4;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseClick);
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.SeaGreen;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(728, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mouse and keyboard testing utility - Press Alt+F4 to exit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentSpeed);
            this.Controls.Add(this.speedAverage);
            this.Controls.Add(this.secondCount);
            this.Controls.Add(this.pixelCount);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label pixelCount;
        private System.Windows.Forms.Label secondCount;
        private System.Windows.Forms.Label speedAverage;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label currentSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

