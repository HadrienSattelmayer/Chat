using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace chat
{

    public partial class TelaLogin : Form
    {



        public TelaLogin()
        {
            InitializeComponent();
               
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            //CASO O USUÁRIO NÃO TENHA CADASTRO E CLICAR NA LABEL SERÁ DIRECIONADO PARA A TELA DE CADASTRO
            TelaCadastro cadastro = new TelaCadastro();
            cadastro.Show();

            this.Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void botaoEntrar_Click(object sender, EventArgs e)
        {
            //PASSAR COMO ARGUMENTO A STRING DE CONEXAO COM O BD
            SqlConnection conexao = new SqlConnection("Server=localhost;Database=chat;Trusted_Connection=True;");

            //COMANDO SQL PARA VERIFICAÇÃO SE O LOGIN E SENHA EXISTEM
            SqlCommand comando = new SqlCommand("SELECT COUNT (*) FROM usuario WHERE login = @login AND senha = @senha" , conexao);
            comando.Parameters.AddWithValue("@login", tbLogin.Text);
            comando.Parameters.AddWithValue("@senha", tbSenha.Text);

            

            try
            {
                //ABRE A CONEXAO COM O BD
                conexao.Open();

                //CRIA UMA TABELA
                DataTable dtable = new DataTable();

                SqlDataAdapter dadapter = new SqlDataAdapter(comando);

                //PREENCHE ESSA NOVA TABELA COM A SAÍDA DO COMANDO ANTERIOR
                dadapter.Fill(dtable);

                //PARA CADA LISTA DA TABELA CRIADA
                foreach(DataRow list in dtable.Rows)
                {
                    //CONVERTE PARA INTEIRO
                    if (Convert.ToInt32(list.ItemArray[0]) >0)
                    {
                        //CASO O USUARIO EXISTA A TELA PRINCIPAL É ABERTA E A TELA ATUAL SOME.
                        TelaPrincipal principal = new TelaPrincipal();
                        principal.Show();

                        this.Visible = false;
                    }
                    else
                    {
                        //CASO O USUÁRIO NÃO EXISTA EXIBE UMA MENSAGEM DE ERRO.
                        string message = "usuário não cadastrado";
                        string title = "Falha na autenticação";
                        MessageBox.Show(message, title);
                    }
                }
            }
            catch(SqlException) //ERRO DE CONEXÃO COM O BANCO DE DADOS
            {
                throw;
            }

            conexao.Close(); //FECHA CONEXÃO
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }

        private void TelaLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); //CASO O USUÁRIO CLIQUE NO X O APLICATIVO É ENCERRADO
        }
        
        private void painelLogin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
