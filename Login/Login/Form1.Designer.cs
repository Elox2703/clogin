namespace Login {
	partial class Form1 {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			lb_log_titulo = new Label();
			lb_log_usuario = new Label();
			lb_log_password = new Label();
			tb_log_user = new TextBox();
			panel1 = new Panel();
			panel2 = new Panel();
			panel4 = new Panel();
			tb_log_pass = new TextBox();
			btn_log_iniciar = new Button();
			panel3 = new Panel();
			panel2.SuspendLayout();
			panel4.SuspendLayout();
			panel3.SuspendLayout();
			SuspendLayout();
			// 
			// lb_log_titulo
			// 
			lb_log_titulo.AutoSize = true;
			lb_log_titulo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
			lb_log_titulo.Location = new Point(107, 42);
			lb_log_titulo.Name = "lb_log_titulo";
			lb_log_titulo.Size = new Size(154, 32);
			lb_log_titulo.TabIndex = 0;
			lb_log_titulo.Text = "Iniciar Sesión";
			// 
			// lb_log_usuario
			// 
			lb_log_usuario.AutoSize = true;
			lb_log_usuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			lb_log_usuario.Location = new Point(61, 267);
			lb_log_usuario.Name = "lb_log_usuario";
			lb_log_usuario.Size = new Size(59, 20);
			lb_log_usuario.TabIndex = 1;
			lb_log_usuario.Text = "Usuario";
			// 
			// lb_log_password
			// 
			lb_log_password.AutoSize = true;
			lb_log_password.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			lb_log_password.Location = new Point(61, 327);
			lb_log_password.Name = "lb_log_password";
			lb_log_password.Size = new Size(83, 20);
			lb_log_password.TabIndex = 2;
			lb_log_password.Text = "Contraseña";
			// 
			// tb_log_user
			// 
			tb_log_user.BorderStyle = BorderStyle.None;
			tb_log_user.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			tb_log_user.Location = new Point(8, 6);
			tb_log_user.Name = "tb_log_user";
			tb_log_user.Size = new Size(250, 20);
			tb_log_user.TabIndex = 3;
			tb_log_user.TextChanged += btn_log_iniciar_Click;
			tb_log_user.KeyPress += tb_log_user_KeyPress;
			// 
			// panel1
			// 
			panel1.BackgroundImage = Properties.Resources.bg_login;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(400, 461);
			panel1.TabIndex = 4;
			// 
			// panel2
			// 
			panel2.BackColor = Color.OldLace;
			panel2.Controls.Add(lb_log_titulo);
			panel2.Controls.Add(panel4);
			panel2.Controls.Add(btn_log_iniciar);
			panel2.Controls.Add(lb_log_usuario);
			panel2.Controls.Add(panel3);
			panel2.Controls.Add(lb_log_password);
			panel2.Location = new Point(400, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(384, 461);
			panel2.TabIndex = 5;
			// 
			// panel4
			// 
			panel4.BackColor = Color.White;
			panel4.Controls.Add(tb_log_pass);
			panel4.Location = new Point(61, 350);
			panel4.Name = "panel4";
			panel4.Size = new Size(266, 31);
			panel4.TabIndex = 7;
			// 
			// tb_log_pass
			// 
			tb_log_pass.BorderStyle = BorderStyle.None;
			tb_log_pass.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			tb_log_pass.Location = new Point(9, 6);
			tb_log_pass.Name = "tb_log_pass";
			tb_log_pass.PasswordChar = '•';
			tb_log_pass.Size = new Size(250, 20);
			tb_log_pass.TabIndex = 4;
			tb_log_pass.KeyPress += tb_log_pass_KeyPress;
			// 
			// btn_log_iniciar
			// 
			btn_log_iniciar.BackColor = Color.Snow;
			btn_log_iniciar.BackgroundImageLayout = ImageLayout.None;
			btn_log_iniciar.FlatAppearance.BorderColor = Color.OldLace;
			btn_log_iniciar.FlatStyle = FlatStyle.Flat;
			btn_log_iniciar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			btn_log_iniciar.Location = new Point(223, 387);
			btn_log_iniciar.Name = "btn_log_iniciar";
			btn_log_iniciar.Size = new Size(104, 31);
			btn_log_iniciar.TabIndex = 5;
			btn_log_iniciar.Text = "Iniciar";
			btn_log_iniciar.UseVisualStyleBackColor = false;
			btn_log_iniciar.Click += btn_log_iniciar_Click;
			// 
			// panel3
			// 
			panel3.BackColor = Color.White;
			panel3.Controls.Add(tb_log_user);
			panel3.Location = new Point(61, 290);
			panel3.Name = "panel3";
			panel3.Size = new Size(266, 31);
			panel3.TabIndex = 6;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(784, 461);
			Controls.Add(panel2);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Login";
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			panel4.ResumeLayout(false);
			panel4.PerformLayout();
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Label lb_log_titulo;
		private Label lb_log_usuario;
		private Label lb_log_password;
		private TextBox tb_log_user;
		private Panel panel1;
		private Panel panel2;
		private TextBox tb_log_pass;
		private Button btn_log_iniciar;
		private Panel panel4;
		private Panel panel3;
	}
}