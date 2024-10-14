using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_Contato
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            /*listaCoisas = new List<Coisa>();

            listaCoisas.Add(new Coisa(1, "Coisa Um"));
            listaCoisas.Add(new Coisa(2, "Coisa Dois"));
            listaCoisas.Add(new Coisa(3, "Coisa Três"));
            listaCoisas.Add(new Coisa(4, "Coisa Quatro"));
            atualizaCoisas();
            */
        }

        /*private void atualizaCoisas()
        {
            bs = new BindingSource();
            bs.DataSource = listaContatos;
            dataGridView1.DataSource = bs;
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            Data data1 = new Data();
            data1.setData(14, 10, 2024);
            data1.ToString();
            label1.Text = data1.ToString();

            Telefone telefone1 = new Telefone();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_adicionar_contato_Click(object sender, EventArgs e)
        {
            Data data1 = new Data();
            data1.setData(20, 9, 2012);
            List<Telefone> listaTelefones = new List<Telefone>();
            listaTelefones.Add(new Telefone("Celular", "13 83462-1258", true));
            listaTelefones.Add(new Telefone("Casa", "55 24427-6409", false));
            listaTelefones.Add(new Telefone("Rádio", "13 93261-4568", false));
            Contato contato = new Contato("email@mail.com", "João Duarte", data1, listaTelefones);

            label2.Text = contato.ToString();

        }
    }
}
