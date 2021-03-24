using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void btn_Click(object sender, EventArgs e)
        {
            // atribuindo valores
            lblMeu.Text = "MEU";
            lblBrasil.Text = "BRASIL";
            lblBrasileiro.Text = "BRASILEIRO";

            // espera 1 segundo
            await Task.Delay(2000);
            // muda a cor do fundo para azul
            lblMeu.BackColor = Color.Blue;
            // muda a cor da letra para branco
            lblMeu.ForeColor = Color.White;

            // espera 1 segundo
            await Task.Delay(2000);
            // muda a cor do fundo para azul
            lblBrasil.BackColor = Color.Yellow;
            // muda a cor da letra para branco
            lblBrasil.ForeColor = Color.Green;
            
            // espera 1 segundo
            await Task.Delay(2000);
            // muda a cor do fundo para azul
            lblBrasileiro.BackColor = Color.Green;
            // muda a cor da letra para branco
            lblBrasileiro.ForeColor = Color.Yellow;



        }
    }
}
