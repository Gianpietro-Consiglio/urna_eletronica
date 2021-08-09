using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace urnaeletronica
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.uiMode = "none";
            string path = AppDomain.CurrentDomain.BaseDirectory.ToString();
            path += "tapetao.mp4";
            axWindowsMediaPlayer1.URL = path;
        }

        int contador = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            contador++;
            if (contador == 10)
            {
                timer1.Enabled = false;
                Form2 vencedor = new Form2();
                vencedor.Show();
                Close();
            }

        }
    }
}
