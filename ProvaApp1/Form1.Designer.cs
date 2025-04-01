namespace ProvaApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNome = new TextBox();
            Telefone = new Label();
            txtTelefone = new TextBox();
            btnSalvar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(165, 167);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(196, 23);
            txtNome.TabIndex = 1;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // Telefone
            // 
            Telefone.AutoSize = true;
            Telefone.Location = new Point(165, 214);
            Telefone.Name = "Telefone";
            Telefone.Size = new Size(51, 15);
            Telefone.TabIndex = 2;
            Telefone.Text = "Telefone";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(165, 232);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(196, 23);
            txtTelefone.TabIndex = 3;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(227, 279);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(165, 149);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 5;
            label1.Text = "Nome";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnSalvar);
            Controls.Add(txtTelefone);
            Controls.Add(Telefone);
            Controls.Add(txtNome);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private Label Telefone;
        private TextBox txtTelefone;
        private Button btnSalvar;
        private Label label1;
    }
}
