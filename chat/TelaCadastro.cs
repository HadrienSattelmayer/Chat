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
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection("Server=localhost;Database=chat;Trusted_Connection=True;");
            conn.Open();
            SqlCommand sc = new SqlCommand("select * from departamento", conn);
            SqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("id_dep", typeof(string));
            dt.Columns.Add("nome_dep", typeof(string));
            dt.Load(reader);

            comboBoxDPTO.ValueMember = "id_dep";
            comboBoxDPTO.DisplayMember = "nome_dep("+comboBoxDPTO.ValueMember+")";
            comboBoxDPTO.DataSource = dt;

            conn.Close();
            /*
             * InitializeComponent();
            SqlConnection conn = new SqlConnection("Server=localhost;Database=chat;Trusted_Connection=True;");
            conn.Open();
            SqlCommand sc = new SqlCommand("select * from usuario order by departamento", conn);
            SqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("id_dep", typeof(string));
            dt.Columns.Add("nome_dep", typeof(string));
            dt.Load(reader);

            comboBoxDPTO.ValueMember = "id_dep";
            comboBoxDPTO.DisplayMember = "nome_dep";
            comboBoxDPTO.DataSource = dt;

            conn.Close();
            */
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //PASSA COMO ARGUMENTO A STRING DE CONEXAO COM O BANCO DE DADOS
            SqlConnection conexao = new SqlConnection("Server=localhost;Database=chat;Trusted_Connection=True;");
            
            //SE NENHUM DOS CAMPOS FOREM DE VALOR NULO...
            if(tbLogin != null && tbNome != null && tbSenha != null && tbLogin != null && comboBoxDPTO != null && comboBoxSexo != null && foto != null)
            {
                //EXECUTA COMANDO DE INSERIR DADOS NA TABELA USUARIO
                SqlCommand comando = new SqlCommand("INSERT INTO usuario (nome_usr, login, departamento, sexo, senha, foto) VALUES (@nome, @login, @departamento, @sexo, @senha, @foto) " , conexao);
                //DEFINE OS PARAMETROS USADOS NO COMANDO
                comando.Parameters.AddWithValue("@nome", tbNome.Text);
                comando.Parameters.AddWithValue("@login", tbLogin.Text);
                comando.Parameters.AddWithValue("@departamento",int.Parse(comboBoxDPTO.SelectedValue.ToString()));
                comando.Parameters.AddWithValue("@sexo", comboBoxSexo.SelectedItem.ToString());
                comando.Parameters.AddWithValue("@senha", tbSenha.Text);
                comando.Parameters.AddWithValue("@foto", foto.ImageLocation);

                //TENTA ABRIR CONEXÃO COM O BD PARA REALIZAR O COMANDO
                try
                {
                    conexao.Open();
                    comando.ExecuteNonQuery();
                    //ABRE A TELA PRINCIPAL DO APLICATIVO
                    TelaPrincipal principal = new TelaPrincipal();
                    principal.Show();
                   
                    this.Visible = false;

                }
                catch(SqlException) //CASO ENFRENTE ERRO DE CONEXÃO
                {
                    throw;
                }
                //FECHA CONEXÃO COM O BD
                conexao.Close();
            }
            

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TelaCadastro_FormClosing(object sender, FormClosingEventArgs e)
        {
            //FINALIZA APLICAÇÃO CASO USUÁRIO CLIQUE NO X
            Application.Exit();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureAvatar_Click(object sender, EventArgs e)
        {
            //ABRE UMA TELA PARA ESCOLHER A FOTO DE PERFIL
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "jpg|*.jpg";
            if (file.ShowDialog() == DialogResult.OK)
            {
                foto.ImageLocation = file.FileName;
            }
        }
    }
}
