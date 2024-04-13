namespace Login {
	public partial class Form1 : Form {
		FormMenu menu = new FormMenu();

		public Form1() {
			InitializeComponent();
		}

		public void ValidarUsuario(string _usuario, string _password) {
			if ((_usuario == "admin") & (_password == "admin")) {
				menu.FormClosed += (s, args) => this.Close();
				menu.Show();
				this.Hide();
			}
		}

		private void btn_log_iniciar_Click(object sender, EventArgs e) {
			ValidarUsuario(tb_log_user.Text, tb_log_pass.Text);
		}

		private void tb_log_user_KeyPress(object sender, KeyPressEventArgs e) {
			if (e.KeyChar == (char)Keys.Enter) {
				ValidarUsuario(tb_log_user.Text, tb_log_pass.Text);
			}
		}

		private void tb_log_pass_KeyPress(object sender, KeyPressEventArgs e) {
			if (e.KeyChar == (char)Keys.Enter) {
				ValidarUsuario(tb_log_user.Text, tb_log_pass.Text);
			}
		}
	}
}