namespace Exec02Leaf
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
            button1 = new Button();
            textBoxSenha = new TextBox();
            textBoxUsuario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(323, 284);
            button1.Name = "button1";
            button1.Size = new Size(144, 29);
            button1.TabIndex = 0;
            button1.Text = "SOLICITAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonConsultar_Click;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(323, 216);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(144, 27);
            textBoxSenha.TabIndex = 1;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(323, 153);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(144, 27);
            textBoxUsuario.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(255, 156);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 3;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(255, 219);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 4;
            label2.Text = "Senha:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxUsuario);
            Controls.Add(textBoxSenha);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBoxSenha;
        private TextBox textBoxUsuario;
        private Label label1;
        private Label label2;
    }
}