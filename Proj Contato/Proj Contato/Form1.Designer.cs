namespace Proj_Contato
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_sair = new System.Windows.Forms.Button();
            this.button_adicionar_contato = new System.Windows.Forms.Button();
            this.button_pesquisar_contato = new System.Windows.Forms.Button();
            this.button_alterar_contato = new System.Windows.Forms.Button();
            this.button_remover_contato = new System.Windows.Forms.Button();
            this.button_listar_contato = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_sair
            // 
            this.button_sair.Location = new System.Drawing.Point(21, 20);
            this.button_sair.Name = "button_sair";
            this.button_sair.Size = new System.Drawing.Size(254, 38);
            this.button_sair.TabIndex = 0;
            this.button_sair.Text = "0. Sair";
            this.button_sair.UseVisualStyleBackColor = true;
            this.button_sair.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_adicionar_contato
            // 
            this.button_adicionar_contato.Location = new System.Drawing.Point(21, 77);
            this.button_adicionar_contato.Name = "button_adicionar_contato";
            this.button_adicionar_contato.Size = new System.Drawing.Size(254, 40);
            this.button_adicionar_contato.TabIndex = 1;
            this.button_adicionar_contato.Text = "1. Adicionar Contato";
            this.button_adicionar_contato.UseVisualStyleBackColor = true;
            this.button_adicionar_contato.Click += new System.EventHandler(this.button_adicionar_contato_Click);
            // 
            // button_pesquisar_contato
            // 
            this.button_pesquisar_contato.Location = new System.Drawing.Point(21, 139);
            this.button_pesquisar_contato.Name = "button_pesquisar_contato";
            this.button_pesquisar_contato.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_pesquisar_contato.Size = new System.Drawing.Size(254, 40);
            this.button_pesquisar_contato.TabIndex = 2;
            this.button_pesquisar_contato.Text = "2. Pesquisar Contato";
            this.button_pesquisar_contato.UseVisualStyleBackColor = true;
            // 
            // button_alterar_contato
            // 
            this.button_alterar_contato.Location = new System.Drawing.Point(21, 199);
            this.button_alterar_contato.Name = "button_alterar_contato";
            this.button_alterar_contato.Size = new System.Drawing.Size(254, 40);
            this.button_alterar_contato.TabIndex = 3;
            this.button_alterar_contato.Text = "3. Alterar Contato";
            this.button_alterar_contato.UseVisualStyleBackColor = true;
            // 
            // button_remover_contato
            // 
            this.button_remover_contato.Location = new System.Drawing.Point(21, 263);
            this.button_remover_contato.Name = "button_remover_contato";
            this.button_remover_contato.Size = new System.Drawing.Size(254, 40);
            this.button_remover_contato.TabIndex = 4;
            this.button_remover_contato.Text = "4. Remover Contato";
            this.button_remover_contato.UseVisualStyleBackColor = true;
            // 
            // button_listar_contato
            // 
            this.button_listar_contato.Location = new System.Drawing.Point(21, 332);
            this.button_listar_contato.Name = "button_listar_contato";
            this.button_listar_contato.Size = new System.Drawing.Size(254, 40);
            this.button_listar_contato.TabIndex = 5;
            this.button_listar_contato.Text = "5. Listar Contatos";
            this.button_listar_contato.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(454, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Data escolhida";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(454, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(355, 210);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_listar_contato);
            this.Controls.Add(this.button_remover_contato);
            this.Controls.Add(this.button_alterar_contato);
            this.Controls.Add(this.button_pesquisar_contato);
            this.Controls.Add(this.button_adicionar_contato);
            this.Controls.Add(this.button_sair);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_sair;
        private System.Windows.Forms.Button button_adicionar_contato;
        private System.Windows.Forms.Button button_pesquisar_contato;
        private System.Windows.Forms.Button button_alterar_contato;
        private System.Windows.Forms.Button button_remover_contato;
        private System.Windows.Forms.Button button_listar_contato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bs;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

