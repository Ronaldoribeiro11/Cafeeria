using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CafeteriaCash.Cadcafe;

namespace CafeteriaCash
{
    public partial class Cadastro : Form
    {
        private int id;
        public Cadastro()
        {
            InitializeComponent();
        }
        public Cadastro(Usuario usuario)
        {
            InitializeComponent();
            txt1.Text = usuario.nome;
            txt2.Text = usuario.email;
            txtm.Text = usuario.numerocell;
            txt4.Text = usuario.senha;
            id = usuario.Id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroSteam cadastro = new CadastroSteam(txt1.Text, txt2.Text, txt3.Text, txt4.Text);
            cadastro.Cadastrar();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
