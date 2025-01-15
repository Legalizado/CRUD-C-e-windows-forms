using MySql.Data.MySqlClient;
using System.Drawing.Text;

namespace funcionario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {

                if (!txtNome.Text.Equals("") && !txtCpf.Text.Equals("") && !txtEmail.Text.Equals("") && !txtEndereco.Text.Equals("") && (generof.Checked || generom.Checked))
                {
                    Cadastro cad = new Cadastro();
                    cad.Nome = txtNome.Text;
                    cad.Cpf = txtCpf.Text;
                    cad.Email = txtEmail.Text;
                    cad.Endereco = txtEndereco.Text;


                    if (generof.Checked)
                    {
                        cad.Genero = "F";
                        generom.Checked = false;
                    }
                    else if (generom.Checked)
                    {
                        cad.Genero = "M";
                        generof.Checked = false;
                    }

                    if (cad.cadastrarFuncionarios())
                    {
                        MessageBox.Show($"O funcionario {cad.Nome} foi cadastrado com sucesso");
                        txtCpf.Clear();
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtEndereco.Clear();
                        generof.Checked = false;
                        generom.Checked = false;
                        txtNome.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao tentar cadastrar o funcionario");
                    }


                }
                else
                {
                    MessageBox.Show("Por favor, insira todos os campos");
                    txtCpf.Clear();
                    txtNome.Clear();
                    txtEmail.Clear();
                    txtEndereco.Clear();
                    generof.Checked = false;
                    generom.Checked = false;
                    txtNome.Focus();



                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao conectar ao banco de dados {ex.Message}");
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void generom_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void generof_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void h1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (!txtCpf.Text.Equals(""))
                {
                    Cadastro cad = new Cadastro();
                    cad.Cpf = txtCpf.Text;

                    MySqlDataReader pesquisar = cad.PesquisarFuncionario();

                    if (pesquisar == null)
                    {
                        MessageBox.Show("Funcionario não encontrado");
                        txtCpf.Clear();
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtEndereco.Clear();
                        generof.Checked = false;
                        generom.Checked = false;
                        txtNome.Focus();
                        txtCpf.Focus();
                    }
                    else
                    {
                        if (pesquisar.HasRows)
                        {
                            pesquisar.Read();
                            txtId.Text = pesquisar["id"].ToString();
                            txtNome.Text = pesquisar["nome"].ToString();
                            txtEmail.Text = pesquisar["email"].ToString();
                            txtEndereco.Text = pesquisar["endereco"].ToString();
                            generoconsulta.Text = pesquisar["genero"].ToString();
                            if (generoconsulta.Text == "F")
                            {
                                generof.Checked = true;
                                generom.Checked = false;
                            }
                            else if (generoconsulta.Text == "M")
                            {
                                generom.Checked = true;
                                generof.Checked = false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Funcionario não encontrado");
                            txtCpf.Clear();
                            txtNome.Clear();
                            txtEmail.Clear();
                            txtEndereco.Clear();
                            generof.Checked = false;
                            generom.Checked = false;
                            txtNome.Focus();
                            txtCpf.Focus();
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Insira todos os campos");
                    txtCpf.Clear();
                    txtNome.Clear();
                    txtEmail.Clear();
                    txtEndereco.Clear();
                    generof.Checked = false;
                    generom.Checked = false;
                    txtNome.Focus();
                    txtCpf.Focus();
                }




            }
            catch
            {


            }



        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void generoconsulta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCpf.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            generof.Checked = false;
            generom.Checked = false;
            txtNome.Focus();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                if (!txtCpf.Text.Equals("") && !txtNome.Text.Equals("") && !txtEmail.Text.Equals("") && !txtEndereco.Text.Equals(""))
                {
                    Cadastro cad = new Cadastro();
                    cad.Cpf = txtCpf.Text;
                    cad.Nome = txtNome.Text;
                    cad.Email = txtEmail.Text;
                    cad.Endereco = txtEndereco.Text;
                    if (generof.Checked)
                    {
                        cad.Genero = "F";
                    }
                    else if (generom.Checked)
                    {
                        cad.Genero = "M";
                    }
                    if (cad.AtualizarInformacoes())
                    {
                        MessageBox.Show("Funcionario atualizado com sucesso");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao tentar atualizar o funcionario");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, insira todos os campos");
                    ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar");
            };

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!txtCpf.Text.Equals(""))
            {
                Cadastro cad = new Cadastro();
                cad.Cpf = txtCpf.Text;
                if (cad.DeletarFuncionario())
                {
                    MessageBox.Show("Funcionario deletado com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro ao deletar o funcionario");
                }

            }
        }
    }
}
