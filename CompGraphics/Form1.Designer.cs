
namespace CompGraphics
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }


        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // button1
            //
            this.button1.Cursor =
                System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new
                System.Drawing.Point(48, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128,
                23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1 Показать";
            this.button1.Click += new
                System.EventHandler(this.button1_Click);
            //
            // label1
            //
            this.label1.Location = new
                System.Drawing.Point(224, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272,
                16);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            //
            // Form1
            //
            this.AutoScaleBaseSize = new
                System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(512,
                334);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "g1511XXs1_Фамилия Самостоятельная работа No1 12.12.2006";
            this.Load += new
                System.EventHandler(this.Form1_Load);
            this.Activated += new
                System.EventHandler(this.Form1_Activated);
            this.ResumeLayout(false);


            #endregion
        }
    }
}

