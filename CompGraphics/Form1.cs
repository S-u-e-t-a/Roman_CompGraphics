using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CompGraphics
{
    public partial class Form1 : Form
    {
        private Button button1;
        private Label label1;


        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
        }


        /// <summary>
        ///     Clean up any resources being used.
        private void line(Pen pen, int x1, int y1, int x2, int y2)
        {
            var canvas = Graphics.FromHwnd(Handle);
            canvas.DrawLine(pen, x1, y1, x2, y2);
        }


        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        private void button1_Click(object sender,
            EventArgs e)

        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.FromArgb(1, 0, 0, 10);
            // this.Invalidate();

            ////////////// this.MaximizeBox = false;
            ///////////// this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            /* Установка параметров */
            int x0, y0, i;
            x0 = 110;
            y0 = 110;

            /* 1. Ввод значений исходных данных */
            var n = 14;


            var lines = new List<List<int>>
            {
                new List<int> {419, 384, 325, 384},
                new List<int> {207, 384, 112, 384},
                new List<int> {526, 596, 526, 148},
                new List<int> {6, 596, 207, 596},
                new List<int> {6, 148, 6, 596},
                new List<int> {112, 148, 112, 384},
                new List<int> {112, 148, 6, 148},
                new List<int> {419, 384, 419, 148},
                new List<int> {526, 148, 419, 148},
                new List<int> {325, 596, 526, 596},
                new List<int> {325, 6, 325, 596},
                new List<int> {207, 6, 207, 596},
                new List<int> {325, 6, 207, 6},
                new List<int> {325, 596, 207, 596},
                new List<int> {716, 596, 1306, 596},
                new List<int> {869, 148, 1153, 148},
                new List<int> {716, 596, 869, 148},
                new List<int> {1153, 148, 1306, 596},
                new List<int> {1306, 6, 716, 6},
                new List<int> {1306, 6, 1306, 596},
                new List<int> {716, 6, 716, 596},
                new List<int> {6, 1139, 6, 1423},
                new List<int> {526, 1423, 526, 1139},
                new List<int> {419, 1423, 419, 1139},
                new List<int> {112, 1139, 112, 1423},
                new List<int> {419, 1504, 325, 1504},
                new List<int> {207, 1504, 112, 1504},
                new List<int> {325, 1059, 419, 1059},
                new List<int> {6, 1139, 112, 1139},
                new List<int> {526, 1576, 526, 1423},
                new List<int> {6, 1576, 207, 1576},
                new List<int> {419, 1139, 526, 1139},
                new List<int> {6, 986, 6, 1139},
                new List<int> {207, 986, 6, 986},
                new List<int> {112, 1059, 207, 1059},
                new List<int> {6, 1423, 6, 1576},
                new List<int> {526, 1139, 526, 986},
                new List<int> {112, 1423, 112, 1504},
                new List<int> {112, 1423, 6, 1423},
                new List<int> {419, 1504, 419, 1423},
                new List<int> {526, 1423, 419, 1423},
                new List<int> {112, 1059, 112, 1139},
                new List<int> {526, 986, 325, 986},
                new List<int> {419, 1139, 419, 1059},
                new List<int> {325, 1576, 526, 1576},
                new List<int> {207, 986, 325, 986},
                new List<int> {207, 1576, 207, 986},
                new List<int> {325, 1576, 207, 1576},
                new List<int> {325, 986, 325, 1576},
                new List<int> {1072, 1683, 1490, 1442},
                new List<int> {1014, 926, 814, 1042},
                new List<int> {1181, 1254, 1381, 1138},
                new List<int> {1106, 1210, 1306, 1095},
                new List<int> {847, 1302, 832, 1311},
                new List<int> {1049, 1436, 982, 1398},
                new List<int> {847, 1320, 832, 1311},
                new List<int> {1014, 926, 1056, 950},
                new List<int> {1072, 1683, 1181, 1254},
                new List<int> {705, 1471, 847, 1553},
                new List<int> {1306, 1095, 1381, 1138},
                new List<int> {814, 1042, 705, 1471},
                new List<int> {1381, 1138, 1490, 1442},
                new List<int> {847, 1250, 832, 1311},
                new List<int> {855, 1066, 814, 1042},
                new List<int> {1049, 1436, 1106, 1210},
                new List<int> {1181, 1254, 1106, 1210},
                new List<int> {930, 1601, 1072, 1683},
                new List<int> {982, 1398, 1072, 1346},
                new List<int> {1264, 830, 1348, 878},
                new List<int> {847, 1071, 1264, 830},
                new List<int> {982, 1398, 930, 1601},
                new List<int> {930, 1119, 930, 1601},
                new List<int> {847, 1071, 847, 1553},
                new List<int> {930, 1119, 847, 1071},
                new List<int> {1348, 878, 930, 1119},
                new List<int> {1348, 878, 1348, 1119},
                new List<int> {930, 1601, 847, 1553}
            };
            var scale = 0.3;
            foreach (var line in lines)
            {
                for (var j = 0; j < line.Count; j++)
                {
                    line[j] = (int) (scale * line[j]);
                }
            }
            /* 2. Инициализация графики */

            var canvas = Graphics.FromHwnd(Handle);

            float w = 1.0f, w0 = 2.0f;
            var pen = new Pen(Color.Red, w0);
            var pen2 = new Pen(Color.Green, w);

            var b = new
                SolidBrush(Color.FromArgb(150, 0, 0, 255));
            var f = new Font("Arial", 15);
            var f2 = new Font("Arial", 8);

            /* Основные циклы вычислений проекции XOY*/
            foreach (var line in lines)
            {
                canvas.DrawLine(pen, line[0], line[1], line[2], line[3]);
            }


/* 4. Закрытие графического режима*/
        }


        private void Form1_Activated(object sender,
            EventArgs e)

        {
            button1_Click(null, null);
        }


        private void Form1_Load(object sender,
            EventArgs e)

        {
            StartPosition = FormStartPosition.CenterScreen;

            label1.Text = "";

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            var r = new Rectangle(0, 0, 500, 1000);
            r = Screen.PrimaryScreen.Bounds;

            var w = r.Width;
            var h = r.Height;
            var tw = Width;
            var th = Height;
            Left = (w - tw) / 2;
            Top = (h - th) / 2;
        }
    }
}