
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DovzenokKino
{
    public partial class Form1 : Form
    {
        int i, j;
        Label lbl;
        Button btn1, btn2, btn3;
        public Form1()
        {
            this.BackgroundImage = Properties.Resources.fon1;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            Height = 170;
            Width = 300;
            Text = "Выберите зал для просмотра";

            lbl = new Label();
            lbl.Text = "Выберите фильм:";
            lbl.Size = new Size(120, 20);
            lbl.Location = new Point(20, 10);
            Controls.Add(lbl);

            btn3 = new Button();
            btn3.Text = "Hõbedased uisud";
            btn3.Size = new Size(100, 30);
            btn3.Location = new Point(100, 30);
            btn3.Click += Btn3_Click;
            Controls.Add(btn3);

            btn2 = new Button();
            btn2.Text = "Tom ja Jerry";
            btn2.Size = new Size(100, 30);
            btn2.Location = new Point(100, 60);
            btn2.Click += Btn2_Click;
            Controls.Add(btn2);

            btn1 = new Button();
            btn1.Text = "Tenet";
            btn1.Size = new Size(100, 30);
            btn1.Location = new Point(100, 90);
            btn1.Click += Btn1_Click;
            Controls.Add(btn1);
        }
        private void Btn3_Click(object sender, EventArgs e)
        {
            i = 5; j = 5;
            Kino hall = new Kino(i, j);
            hall.Show();
            this.BackgroundImage = Properties.Resources.hb;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            Hide();
        }


        private void Btn2_Click(object sender, EventArgs e)
        {
            i = 10; j = 10;
            Kino hall = new Kino(i, j);
            hall.Show();
            Hide();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            i = 15; j = 15;
            Kino hall = new Kino(i, j);
            hall.Show();
            Hide();
        }
    }
}