namespace EstruturaRepetição
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = "fulano.tal";
            string senha = "Semsenha999@";

            if (usuario == txtUsuario.Text && senha == txtSenha.Text){
                MessageBox.Show("Seja bem-vindo ao nosso sistema, " + usuario);
            }
            else
            {
                MessageBox.Show("Acesso negado !!!");
            }
        }
    }
}
