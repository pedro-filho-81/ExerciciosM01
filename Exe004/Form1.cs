using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe004
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblMsg_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // cria variável
            float num = 0;
            // usuário atribui valor a num
            float.TryParse(txtBox.Text, out num);

            // mostra do resultado
            lblMsg1.Text = $"Você digitou o valor {num}";
            lblMsg2.Text = $"A parte inteira é {(int)num}";
            lblMsg3.Text = $"Arredondando, temos {Convert.ToInt16(num)}";
        }
    }
}
