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
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //сюда свои значения
            var lines = new List<List<int>>
            {
               new List<int>{424, 467, 341, 6, },
new List<int>{128, 6, 50, 467, },
new List<int>{341, 6, 128, 6, },
new List<int>{424, 467, 463, 680, },
new List<int>{357, 680, 357, 562, },
new List<int>{120, 680, 14, 680, },
new List<int>{120, 562, 120, 680, },
new List<int>{424, 467, 50, 467, },
new List<int>{14, 680, 50, 467, },
new List<int>{357, 562, 120, 562, },
new List<int>{463, 680, 357, 680, },
new List<int>{14, 850, 14, 968, },
new List<int>{424, 1204, 341, 1204, },
new List<int>{463, 850, 403, 850, },
new List<int>{128, 1086, 128, 1204, },
new List<int>{128, 1204, 50, 1204, },
new List<int>{341, 1086, 341, 1204, },
new List<int>{70, 850, 14, 850, },
new List<int>{341, 1204, 128, 1204, },
new List<int>{463, 850, 463, 968, },
new List<int>{424, 968, 463, 968, },
new List<int>{424, 968, 424, 1204, },
new List<int>{50, 1204, 50, 968, },
new List<int>{14, 968, 50, 968, },
new List<int>{128, 1086, 70, 1086, },
new List<int>{403, 1086, 341, 1086, },
new List<int>{341, 1086, 128, 1086, },
new List<int>{70, 850, 70, 1086, },
new List<int>{70, 850, 403, 850, },
new List<int>{403, 1086, 403, 850, },
new List<int>{191, 1086, 191, 944, },
new List<int>{191, 944, 286, 944, },
new List<int>{286, 944, 286, 1086, },
new List<int>{704, 680, 823, 680, },
new List<int>{941, 6, 1059, 6, },
new List<int>{1059, 6, 1059, 467, },
new List<int>{704, 349, 704, 680, },
new List<int>{1059, 467, 823, 467, },
new List<int>{823, 680, 823, 467, },
new List<int>{941, 6, 941, 349, },
new List<int>{704, 349, 941, 349, },
new List<int>{941, 89, 799, 349, },
new List<int>{947, 1454, 888, 1043, },
new List<int>{1225, 1498, 1182, 1204, },
new List<int>{821, 908, 737, 956, },
new List<int>{737, 956, 682, 1301, },
new List<int>{971, 995, 888, 1043, },
new List<int>{888, 1043, 737, 956, },
new List<int>{1225, 1498, 1141, 1547, },
new List<int>{1114, 1357, 1141, 1547, },
new List<int>{1114, 1357, 947, 1454, },
new List<int>{1066, 1503, 1066, 1407, },
new List<int>{947, 1454, 682, 1301, },
new List<int>{1066, 1407, 1047, 1396, },
new List<int>{1141, 1547, 1066, 1503, },
new List<int>{1015, 1300, 971, 995, },
new List<int>{971, 995, 821, 908, },
new List<int>{1002, 1212, 1033, 1195, },
new List<int>{985, 1090, 1182, 1204, },
new List<int>{1015, 1300, 1182, 1204, },
new List<int>{1033, 1195, 991, 1130, },

            };
            var scale = 0.3;
            foreach (var line in lines)
            {
                for (var j = 0; j < line.Count; j++)
                {
                    line[j] = (int)(scale * line[j]);
                }
            }
            /* 2. Инициализация графики */

            var canvas = Graphics.FromHwnd(Handle);

            float w0 = 2.0f;
            var pen = new Pen(Color.Red, w0);

            /* Основные циклы вычислений проекции XOY*/
            foreach (var line in lines)
            {
                canvas.DrawLine(pen, line[0], line[1], line[2], line[3]);
            }
        }

    }
}