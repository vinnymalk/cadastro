using CadastroProj;

namespace CADASTROprot
{
    public partial class cadastro : Form
    {
        public cadastro()
        {
            InitializeComponent();
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Pessoa> lista = UtilBd.Selecionar<Pessoa>("select * from pessoa");

                //Validacao();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void Validacao()
        {
            if (TxtNome.Text == "")
            {
                throw new Exception("Campo de Nome vazio");
            }

            if (TxtCpf.Text == "")
            {
                throw new Exception("Campo de Cpf vazio");
            }

            if (TxtIdade.Text == "")
            {
                throw new Exception("Campo de Idade vazio");
            }

            if (TxtEmail.Text == "")
            {
                throw new Exception("Campo de Email vazio");
            }

            if (TxtEndereco.Text == "")
            {
                throw new Exception("Campo de Endereço vazio");
            }
        }

        private void BtnApagar_Click(object sender, EventArgs e)
        {
            TxtNome.Text = "";
            TxtCpf.Text = "";
            TxtIdade.Text = "";
            TxtEmail.Text = "";
            TxtEndereco.Text = "";
        }
    }
}