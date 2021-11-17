using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crossroads
{
    public partial class crossroads : Form
    {
        public crossroads()
        {
            InitializeComponent();
        }
        //測試git上傳
        //測試git上傳2
        //測試git上傳3
        private PictureBox vehicle = new PictureBox();//動態生成車子
        private PictureBox vehicle1 = new PictureBox();

        private int total = 1;
        private int car = 1;

        private void Form1_Load(object sender, EventArgs e)
        {
            TrafficLight.Enabled = true;
            VehicleTimer.Enabled = true;
        }

        private void TrafficLight_Tick(object sender, EventArgs e)
        {//紅綠燈
            if (total > 0 && total <= 10)
            {//行綠列紅
                ColumnLight.Image = Properties.Resources.red;
                RowLight.Image = Properties.Resources.green1;
            }
            else if (total > 10 && total <= 12)
            {//行黃
                RowLight.Image = Properties.Resources.yellow1;
            }
            else if (total > 12 && total <= 14)
            {//行列皆紅
                RowLight.Image = Properties.Resources.red1;
            }
            else if (total > 14 && total <= 24)
            {//行紅列綠
                ColumnLight.Image = Properties.Resources.green;
            }
            else if (total > 24 && total <= 26)
            {//列黃
                ColumnLight.Image = Properties.Resources.yellow;
            }
            else if (total > 26 && total <= 28)
            {//行列皆紅
                ColumnLight.Image = Properties.Resources.red;
            }
            else
            {//初始化
                RowLight.Image = Properties.Resources.green1;
                total = 1;
            }
            label1.Text = total.ToString();
            total++;
        }

        private void VehicleTimer_Tick(object sender, EventArgs e)
        {//車子
            if (total > 0 && total <= 11)
            {
                //左右車子通行
                driving(vehicle, -2);
                driving(vehicle1, 2);
            }
            else if (total > 11 && total <= 14)
            {
                //停止通行
                if (vehicle.Left != 460 && vehicle.SizeMode == PictureBoxSizeMode.StretchImage)
                    driving(vehicle,-2);
                if (vehicle1.Left + 75 != 190 && vehicle1.SizeMode == PictureBoxSizeMode.StretchImage)
                    driving(vehicle1, 2);
            }
            else if (total > 14 && total <= 25)
            {
                //上下車通行
                if (vehicle.Left != 460 && vehicle.SizeMode == PictureBoxSizeMode.StretchImage)
                    driving(vehicle, -2);
                if (vehicle1.Left + 75 != 190 && vehicle1.SizeMode == PictureBoxSizeMode.StretchImage)
                    driving(vehicle1, 2);
            }
            else if (total > 25 && total <= 28)
            {
                //停止通行
                if (vehicle.Left != 460 && vehicle.SizeMode == PictureBoxSizeMode.StretchImage)
                    driving(vehicle, -2);
                if (vehicle1.Left + 75 != 190 && vehicle1.SizeMode == PictureBoxSizeMode.StretchImage)
                    driving(vehicle1, 2);
            }
            else
            {
                //初始化
            }
        }

        private void driving(object sender, int i)
        {
            //先用sender取得控制項名稱，再將sender的類型object轉成該控制項的類型picture
            //，然後讓vehicle變數接收
            PictureBox vehicle = (PictureBox)sender;

            vehicle.Left += i;
            if (vehicle.Left + 74 <= road.Left || vehicle.Left >= 701)
                road.Controls.Remove(vehicle);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vehicle.Location = new Point(700, 275);//位置
            vehicle.Image = Properties.Resources.redcar;//圖片
            vehicle.Size = new Size(75, 52);//尺寸
            vehicle.SizeMode = PictureBoxSizeMode.StretchImage;//填滿
            vehicle.Parent = road;//父元件(配合透明)
            vehicle.BackColor = Color.Transparent;//透明
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vehicle1.Location = new Point(-75, 360);//位置
            vehicle1.Image = Properties.Resources.redcar;//圖片
            vehicle1.Size = new Size(75, 52);//尺寸
            vehicle1.SizeMode = PictureBoxSizeMode.StretchImage;//填滿
            vehicle1.Parent = road;//父元件(配合透明)
            vehicle1.BackColor = Color.Transparent;//透明
        }

        private void RandomTimer_Tick(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
