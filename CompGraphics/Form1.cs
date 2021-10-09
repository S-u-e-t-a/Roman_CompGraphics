using System;
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

            int[] xn = {40, 0, 20, 40, 0, 20, 25, 22, 22, 25, 18, 18, 15, 15};
            int[] yn = {10, 10, 40, 10, 10, 40, 22, 22, 25, 28, 28, 22, 22, 28};
            int[] zn = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
            int[] xk = {0, 20, 40, 20, 20, 20, 22, 22, 25, 22, 18, 15, 15, 18};
            int[] yk = {10, 40, 10, 20, 20, 20, 22, 25, 28, 28, 22, 22, 28, 28};
            int[] zk = {0, 0, 0, 40, 40, 40, 0, 0, 0, 0, 0, 0, 0, 0};

            /* 2. Инициализация графики */

            var canvas = Graphics.FromHwnd(Handle);

            float w = 1.0f, w0 = 2.0f;
            var pen = new Pen(Color.Red, w0);
            var pen2 = new Pen(Color.Green, w);

            var b = new
                SolidBrush(Color.FromArgb(150, 0, 0, 255));
            var f = new Font("Arial", 15);
            var f2 = new Font("Arial", 8);
            /* вычерчивание рамки формата А4*/
            canvas.DrawRectangle(pen2, 2, 2, 210, 297);
            canvas.DrawRectangle(pen2, 20, 5, 185, 287);
            line(pen2, 20, 297 - 55, 205, 297 - 55);

            /* Оси координат и их обозначение */
            line(pen2, x0 - 70, y0, x0 + 70, y0);
            line(pen2, x0, y0 - 70, x0, y0 + 70);
            canvas.DrawString("X", new
                Font("Areal", 15), b, x0 - 70, y0 + 10);
            canvas.DrawString("Y", f, b, x0 + 70, y0 + 10);
            canvas.DrawString("Z", f, b, x0 + 10, y0 - 70);
            canvas.DrawString("Y", f, b, x0 + 10, y0 + 70);
            canvas.DrawString(" Ортогональные проекции", f2, b, 25, 270);

            /* Основные циклы вычислений проекции XOY*/
            for (i = 0; i < n; i++)
            {
                //DrawLine(pen,int,int,int,int)
                canvas.DrawLine(pen, x0 - xn[i], y0 + yn[i], x0 -
                                                             xk[i], y0 + yk[i]);
            }

            ;
            /* Основные циклы вычислений проекции XOZ*/
            for (i = 0; i < n; i++)
            {
                //My function line(pen,int,int,int,int)


                line(pen, x0 - xn[i], y0 - zn[i], x0 - xk[i], y0 - zk[i]
                );
            }

            ;
            /* Основные циклы вычислений проекции ZOY*/
            var k = 1.0f; // масштаб
            for (i = 0; i < n; i++)
            {
                //DrawLine(pen,float,float,float,float)
                canvas.DrawLine(pen, 1.0f * (x0 + (k * yn[i])), y0 -
                                                                (k * zn[i]), x0 + (k * yk[i]), y0 - (k * zk[i]));
            }

            ;

            // Аксонометрическая проекция
            /* Установка параметров */
            int dx = 300, dy = 0;
            int sx0, sy0;
            double kx, ky, kz;
            double ax, ay, az, sxn, syn, sxk, syk;
            double sin30, cos30;

            sx0 = 110 + dx;
            sy0 = y0 + dy;
            kx = 0.82;
            ky = 0.82;
            kz = 0.82;
            sin30 = Math.Sin((30.0 / 180.0) * 3.1415);
            cos30 = Math.Cos((30.0 / 180.0) * 3.1415);

            /* вычерчивание рамки формата А4*/
            canvas.DrawRectangle(pen2, 0 + dx, 2, 210, 297);
            canvas.DrawRectangle(pen2, 20 + dx, 5, 185, 287);
            line(pen2, 20 + dx, 297 - 55, 205 + dx, 297 - 55);

            /* оси координат и их обозначение */
            ax = 50;
            ay = 0;
            az = 0;
            sxk = (sx0 - (ax * kx * cos30)) +
                  (ay * ky * cos30);

            syk = sy0 - ((az * kz) - (ax * kx * sin30) - (ay * ky * sin30));
            line(pen2, sx0, sy0, (int) sxk, (int) syk);


            canvas.DrawString("X", f, b, (float) sxk -
                                         20, (float) syk);

            // Canvas->TextOutA( "X");
            ax = 0;
            ay = 50;
            az = 0;
            sxk = (sx0 - (ax * kx * cos30)) +
                  (ay * ky * cos30);

            syk = sy0 - ((az * kz) - (ax * kx * sin30) - (ay * ky * sin30));
            line(pen2, sx0, sy0, (int) sxk, (int) syk);
            canvas.DrawString("Y", f, b, (float) sxk + 10, (float) syk);

            // Canvas->TextOutA(sxk+10,syk,"Y");
            ax = 0;
            ay = 0;
            az = 50;
            sxk = (sx0 - (ax * kx * cos30)) +
                  (ay * ky * cos30);

            syk = sy0 - ((az * kz) - (ax * kx * sin30) - (ay * ky * sin30));
            line(pen2, sx0, sy0, (int) sxk, (int) syk);

            canvas.DrawString("Z", f, b, (float) sxk, (float) syk -
                                                      10);

            // Canvas->TextOutA(sxk,syk-10,"Z");

            canvas.DrawString("Аксонометрическая проекция", f2, b, 25 + dx, 270);
            /* 3. Организация основных циклов вычислений
    линии ребер каркасной модели */
            for (i = 0; i < n; i++)
            {
                ax = 1.3 * xn[i];
                ay = yn[i];
                az = zn[i];
                sxn = (sx0 - (ax * kx * cos30)) + (ay * ky * cos30);
                syn = sy0 - ((az * kz) - (ax * kx * sin30) - (ay * ky * sin30));
                ax = xk[i] * 1.3;
                ay = yk[i];
                az = zk[i];
                sxk = (sx0 - (ax * kx * cos30)) + (ay * ky * cos30);
                syk = sy0 - ((az * kz) - (ax * kx * sin30) - (ay * ky * sin30));
                line(pen, (int) sxn, (int) syn, (int) sxk, (int) syk);
            }

            ; /*next i*/


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

            var r = new Rectangle(0, 0, 200, 300);
            r = Screen.PrimaryScreen.Bounds;

            var w = r.Width;
            var h = r.Height;
            var tw = Width;
            var th = Height;
            Left = (w - tw) / 2;
            Top = (h - th) / 2;
        }


        /// </summary>


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        #endregion
    }
}