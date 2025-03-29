namespace ProvaApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Usuario novoUsuario = new Usuario();


            if (!ValidaNome(txtNome.Text))
            {
                MessageBox.Show("Nome inválido");
                return;
            }

            novoUsuario.Nome = txtNome.Text;
            novoUsuario.Telefone = txtTelefone.Text;


            string telefone = txtTelefone.Text.Replace("(", "");
            telefone = telefone.Replace(")", "");
            telefone = telefone.Replace("-", "");

            bool sucesso = Database.SalvarUsuario(novoUsuario);

        }


        private static bool ValidaNome(string nome)
        {

            return !string.IsNullOrWhiteSpace(nome);
        }
        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números e tecla Backspace
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        { 
            if (txtTelefone.Text.Length > 11)
            {
                txtTelefone.Text = txtTelefone.Text.Substring(0, 11);
                txtTelefone.SelectionStart = txtTelefone.Text.Length; 
            }
        }
    }
}
