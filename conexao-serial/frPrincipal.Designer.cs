namespace conexao_serial
{
    partial class frPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lPortaCom = new System.Windows.Forms.Label();
            this.cbPortaCom = new System.Windows.Forms.ComboBox();
            this.btAbrirPorta = new System.Windows.Forms.Button();
            this.spComunica = new System.IO.Ports.SerialPort(this.components);
            this.lDadosEnviar = new System.Windows.Forms.Label();
            this.tbEnviaDados = new System.Windows.Forms.TextBox();
            this.btEnviarDados = new System.Windows.Forms.Button();
            this.lDadosRecebidos = new System.Windows.Forms.Label();
            this.tbDadosRecebidos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lPortaCom
            // 
            this.lPortaCom.AutoSize = true;
            this.lPortaCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPortaCom.Location = new System.Drawing.Point(47, 61);
            this.lPortaCom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPortaCom.Name = "lPortaCom";
            this.lPortaCom.Size = new System.Drawing.Size(91, 20);
            this.lPortaCom.TabIndex = 0;
            this.lPortaCom.Text = "Porta COM:";
            // 
            // cbPortaCom
            // 
            this.cbPortaCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPortaCom.FormattingEnabled = true;
            this.cbPortaCom.Location = new System.Drawing.Point(188, 58);
            this.cbPortaCom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPortaCom.Name = "cbPortaCom";
            this.cbPortaCom.Size = new System.Drawing.Size(248, 28);
            this.cbPortaCom.TabIndex = 1;
            // 
            // btAbrirPorta
            // 
            this.btAbrirPorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAbrirPorta.Location = new System.Drawing.Point(444, 51);
            this.btAbrirPorta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btAbrirPorta.Name = "btAbrirPorta";
            this.btAbrirPorta.Size = new System.Drawing.Size(202, 40);
            this.btAbrirPorta.TabIndex = 2;
            this.btAbrirPorta.Text = "Abrir";
            this.btAbrirPorta.UseVisualStyleBackColor = true;
            this.btAbrirPorta.Click += new System.EventHandler(this.btAbrirPorta_Click);
            // 
            // spComunica
            // 
            this.spComunica.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.spComunica_DataReceived);
            // 
            // lDadosEnviar
            // 
            this.lDadosEnviar.AutoSize = true;
            this.lDadosEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDadosEnviar.Location = new System.Drawing.Point(47, 118);
            this.lDadosEnviar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDadosEnviar.Name = "lDadosEnviar";
            this.lDadosEnviar.Size = new System.Drawing.Size(119, 20);
            this.lDadosEnviar.TabIndex = 3;
            this.lDadosEnviar.Text = "Dados a enviar:";
            // 
            // tbEnviaDados
            // 
            this.tbEnviaDados.Enabled = false;
            this.tbEnviaDados.Location = new System.Drawing.Point(188, 118);
            this.tbEnviaDados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbEnviaDados.Name = "tbEnviaDados";
            this.tbEnviaDados.Size = new System.Drawing.Size(398, 26);
            this.tbEnviaDados.TabIndex = 4;
            // 
            // btEnviarDados
            // 
            this.btEnviarDados.Enabled = false;
            this.btEnviarDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnviarDados.Location = new System.Drawing.Point(594, 111);
            this.btEnviarDados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btEnviarDados.Name = "btEnviarDados";
            this.btEnviarDados.Size = new System.Drawing.Size(174, 40);
            this.btEnviarDados.TabIndex = 5;
            this.btEnviarDados.Text = "Enviar";
            this.btEnviarDados.UseVisualStyleBackColor = true;
            this.btEnviarDados.Click += new System.EventHandler(this.btEnviarDados_Click);
            // 
            // lDadosRecebidos
            // 
            this.lDadosRecebidos.AutoSize = true;
            this.lDadosRecebidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDadosRecebidos.Location = new System.Drawing.Point(47, 233);
            this.lDadosRecebidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDadosRecebidos.Name = "lDadosRecebidos";
            this.lDadosRecebidos.Size = new System.Drawing.Size(133, 20);
            this.lDadosRecebidos.TabIndex = 6;
            this.lDadosRecebidos.Text = "Dados recebidos:";
            // 
            // tbDadosRecebidos
            // 
            this.tbDadosRecebidos.Enabled = false;
            this.tbDadosRecebidos.Location = new System.Drawing.Point(188, 233);
            this.tbDadosRecebidos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDadosRecebidos.Name = "tbDadosRecebidos";
            this.tbDadosRecebidos.Size = new System.Drawing.Size(398, 26);
            this.tbDadosRecebidos.TabIndex = 7;
            // 
            // frPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(821, 317);
            this.Controls.Add(this.tbDadosRecebidos);
            this.Controls.Add(this.lDadosRecebidos);
            this.Controls.Add(this.btEnviarDados);
            this.Controls.Add(this.tbEnviaDados);
            this.Controls.Add(this.lDadosEnviar);
            this.Controls.Add(this.btAbrirPorta);
            this.Controls.Add(this.cbPortaCom);
            this.Controls.Add(this.lPortaCom);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frPrincipal";
            this.Load += new System.EventHandler(this.frPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lPortaCom;
        private System.Windows.Forms.ComboBox cbPortaCom;
        private System.Windows.Forms.Button btAbrirPorta;
        private System.IO.Ports.SerialPort spComunica;
        private System.Windows.Forms.Label lDadosEnviar;
        private System.Windows.Forms.TextBox tbEnviaDados;
        private System.Windows.Forms.Button btEnviarDados;
        private System.Windows.Forms.Label lDadosRecebidos;
        private System.Windows.Forms.TextBox tbDadosRecebidos;
    }
}

