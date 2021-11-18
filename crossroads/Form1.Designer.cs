
namespace crossroads
{
    partial class crossroads
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.RowLight = new System.Windows.Forms.PictureBox();
            this.ColumnLight = new System.Windows.Forms.PictureBox();
            this.TrafficLight = new System.Windows.Forms.Timer(this.components);
            this.VehicleTimer = new System.Windows.Forms.Timer(this.components);
            this.road = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.RandomTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RowLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.road)).BeginInit();
            this.SuspendLayout();
            // 
            // RowLight
            // 
            this.RowLight.Image = global::crossroads.Properties.Resources.green1;
            this.RowLight.Location = new System.Drawing.Point(52, 101);
            this.RowLight.Name = "RowLight";
            this.RowLight.Size = new System.Drawing.Size(54, 152);
            this.RowLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RowLight.TabIndex = 3;
            this.RowLight.TabStop = false;
            // 
            // ColumnLight
            // 
            this.ColumnLight.Image = global::crossroads.Properties.Resources.red;
            this.ColumnLight.Location = new System.Drawing.Point(427, 73);
            this.ColumnLight.Name = "ColumnLight";
            this.ColumnLight.Size = new System.Drawing.Size(152, 54);
            this.ColumnLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ColumnLight.TabIndex = 1;
            this.ColumnLight.TabStop = false;
            // 
            // TrafficLight
            // 
            this.TrafficLight.Interval = 1000;
            this.TrafficLight.Tick += new System.EventHandler(this.TrafficLight_Tick);
            // 
            // VehicleTimer
            // 
            this.VehicleTimer.Interval = 10;
            this.VehicleTimer.Tick += new System.EventHandler(this.VehicleTimer_Tick);
            // 
            // road
            // 
            this.road.Image = global::crossroads.Properties.Resources.road;
            this.road.Location = new System.Drawing.Point(0, 0);
            this.road.Name = "road";
            this.road.Size = new System.Drawing.Size(703, 703);
            this.road.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.road.TabIndex = 5;
            this.road.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(734, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(743, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 34);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RandomTimer
            // 
            this.RandomTimer.Interval = 1000;
            this.RandomTimer.Tick += new System.EventHandler(this.RandomTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(749, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // crossroads
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 703);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ColumnLight);
            this.Controls.Add(this.RowLight);
            this.Controls.Add(this.road);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "crossroads";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RowLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.road)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox ColumnLight;
        private System.Windows.Forms.PictureBox RowLight;
        private System.Windows.Forms.Timer TrafficLight;
        private System.Windows.Forms.Timer VehicleTimer;
        private System.Windows.Forms.PictureBox road;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer RandomTimer;
        private System.Windows.Forms.Label label1;
    }
}

