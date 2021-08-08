using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace urnaeletronica
{
    public partial class Form1 : Form
    {
        SoundPlayer audio = new SoundPlayer(Properties.Resources.botaoNumerico);
        
        public Form1()
        {
            InitializeComponent();
            
        }
        

        /// <summary>
        /// 
        /// </summary>
        /// <param name="valor"></param>



       public void AddNumero(string valor)
        {
                        
            if (textBox2.Text == "")
            {
                textBox2.Text = valor;
            }

            else if (textBox3.Text == "")
            {
                textBox3.Text = valor; 
            }

            else
            {
                MessageBox.Show("Candidato já escolhido!");
            }

            if (textBox3.Text != "")
            {
                if (textBox2.Text == "1" && textBox3.Text == "7")
                {
                    pictureBox1.Image = Properties.Resources.bolso;
                    textBox1.Text = "Jair Bolsonaro";
                }

                else if (textBox2.Text == "1" && textBox3.Text == "3")
                {
                    pictureBox1.Image = Properties.Resources.lulinha;
                    textBox1.Text = "Luiz Inacio Lula Da Silva"; 
                }

                else if (textBox2.Text == "4" && textBox3.Text == "4")
                {
                    pictureBox1.Image = Properties.Resources.adelio;
                    textBox1.Text = "Adelio Bispo";
                }

                
            }


        }

        
        private void button12_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Clear();
            pictureBox1.Image = null;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Voto em branco";
            textBox2.Text = "0";
            textBox3.Text = "0";
            pictureBox1.Image = Properties.Resources.branco;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            SoundPlayer audio1 = new SoundPlayer(Properties.Resources.confirma_urna);
            
            if (textBox2.Text != "" && textBox3.Text != "" )
            {
                int bolso, adelio, lula, branco;
                bolso = 0;
                adelio = 0;
                lula = 0;
                branco = 0;
                if (textBox2.Text == "1" && textBox3.Text == "7")
                {
                    audio1.Play();
                    bolso += 1;
                }

                else if (textBox2.Text == "1" && textBox3.Text == "3")
                {
                    audio1.Play();
                    lula += 1;
                }

                else if (textBox2.Text == "4" && textBox3.Text == "4")
                {
                    audio1.Play();
                    adelio += 1; 
                }

                else if (textBox2.Text == "0" && textBox3.Text == "0")
                {
                    audio1.Play();
                    branco += 1;
                }

                else
                {
                    MessageBox.Show("CANDIDATO NÃO ENCONTRADO!");
                    textBox2.Clear();
                    textBox3.Clear();
                }

               




            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNumero("1");
            audio.Play();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddNumero("2");
            audio.Play();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddNumero("3");
            audio.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddNumero("4");
            audio.Play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddNumero("5");
            audio.Play();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddNumero("6");
            audio.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddNumero("7");
            audio.Play();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddNumero("8");
            audio.Play();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AddNumero("9");
            audio.Play();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddNumero("0");
            audio.Play();
        }
    }
}
