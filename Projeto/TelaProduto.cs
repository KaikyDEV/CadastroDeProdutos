using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class TelaProduto : Form
    {
        public TelaProduto()
        {
            InitializeComponent();
        }

        Conexao con = new Conexao();

        private void TelaProduto_Load(object sender, EventArgs e)
        {
            cbxcategoria.DataSource = null;
            cbxcategoria.DataSource = con.Retorna(
                "select * from tb01_categoria");
            cbxcategoria.DisplayMember = "tb01_descricao";
            cbxcategoria.ValueMember = "tb01_id";
        }

        private void cbxcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                DataTable dados = con.Retorna(
                    $"SELECT * FROM tb02_produto WHERE tb02_codigo={txtCodigo.Text}"
                    );
                txtNome.Text = dados.Rows[0]["tb02_nome"].ToString();
                txtDescricao.Text = dados.Rows[0]["tb02_descricao"].ToString();
                
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string insere = $"insert into tb02_produto(idtb02_codigo, tb02_nome, tb02_descricao, tb02_categoria) values({txtCodigo.Text},{txtNome.Text}, " +
                $"{txtDescricao}, {txtValor.Text})";

            if (con.Executa(insere))
            {
                MessageBox.Show("Cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Não salvou");
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string atualiza = $"update tb02_prodeuto set tb02_nome='{txtNome.Text}'," +
                $"tb02_descricao='{txtDescricao.Text}', tb02_categoria='{txtValor}'";

            if (con.Executa(atualiza))
                MessageBox.Show("Atualizado");
            else
                MessageBox.Show("Não deu");
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {

        }
    }
}
