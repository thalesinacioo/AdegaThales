
namespace Adega
{
    partial class FormAdega
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbCategoria = new System.Windows.Forms.TextBox();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.tbAno = new System.Windows.Forms.TextBox();
            this.btLimpar = new System.Windows.Forms.Button();
            this.dgAdega = new System.Windows.Forms.DataGridView();
            this.btInserir = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnalterar = new System.Windows.Forms.Button();
            this.btndeletar = new System.Windows.Forms.Button();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgAdega)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(344, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Categoria:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descrição:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(607, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ano:";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(81, 79);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(257, 20);
            this.tbNome.TabIndex = 4;
            this.tbNome.TextChanged += new System.EventHandler(this.tbNome_TextChanged);
            // 
            // tbCategoria
            // 
            this.tbCategoria.Location = new System.Drawing.Point(415, 79);
            this.tbCategoria.Name = "tbCategoria";
            this.tbCategoria.Size = new System.Drawing.Size(187, 20);
            this.tbCategoria.TabIndex = 5;
            // 
            // tbDescricao
            // 
            this.tbDescricao.AllowDrop = true;
            this.tbDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescricao.Location = new System.Drawing.Point(81, 111);
            this.tbDescricao.Multiline = true;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbDescricao.Size = new System.Drawing.Size(629, 83);
            this.tbDescricao.TabIndex = 6;
            // 
            // tbAno
            // 
            this.tbAno.Location = new System.Drawing.Point(643, 79);
            this.tbAno.Name = "tbAno";
            this.tbAno.Size = new System.Drawing.Size(67, 20);
            this.tbAno.TabIndex = 7;
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.Color.Linen;
            this.btLimpar.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.btLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimpar.Location = new System.Drawing.Point(635, 22);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 31);
            this.btLimpar.TabIndex = 8;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // dgAdega
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Orange;
            this.dgAdega.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgAdega.BackgroundColor = System.Drawing.Color.Orange;
            this.dgAdega.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgAdega.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAdega.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgAdega.ColumnHeadersHeight = 25;
            this.dgAdega.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colNome,
            this.colCategoria,
            this.colDescricao,
            this.colAno});
            this.dgAdega.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgAdega.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgAdega.EnableHeadersVisualStyles = false;
            this.dgAdega.GridColor = System.Drawing.Color.DimGray;
            this.dgAdega.Location = new System.Drawing.Point(1, 210);
            this.dgAdega.Name = "dgAdega";
            this.dgAdega.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAdega.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgAdega.RowHeadersVisible = false;
            this.dgAdega.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Orange;
            this.dgAdega.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgAdega.Size = new System.Drawing.Size(768, 228);
            this.dgAdega.TabIndex = 9;
            this.dgAdega.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAdega_CellContentClick);
            // 
            // btInserir
            // 
            this.btInserir.BackColor = System.Drawing.Color.Linen;
            this.btInserir.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btInserir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.btInserir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.btInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInserir.Location = new System.Drawing.Point(365, 22);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(75, 31);
            this.btInserir.TabIndex = 10;
            this.btInserir.Text = "Inserir";
            this.btInserir.UseVisualStyleBackColor = false;
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // tbID
            // 
            this.tbID.BackColor = System.Drawing.Color.DarkOrange;
            this.tbID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbID.Enabled = false;
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(204, 28);
            this.tbID.MaxLength = 9;
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(109, 24);
            this.tbID.TabIndex = 11;
            this.tbID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbID.TextChanged += new System.EventHandler(this.tbID_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkOrange;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(94, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Identificador:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnalterar
            // 
            this.btnalterar.BackColor = System.Drawing.Color.Linen;
            this.btnalterar.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnalterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.btnalterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.btnalterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnalterar.Location = new System.Drawing.Point(446, 22);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(75, 31);
            this.btnalterar.TabIndex = 13;
            this.btnalterar.Text = "Alterar";
            this.btnalterar.UseVisualStyleBackColor = false;
            this.btnalterar.Click += new System.EventHandler(this.btnalterar_Click);
            // 
            // btndeletar
            // 
            this.btndeletar.BackColor = System.Drawing.Color.Linen;
            this.btndeletar.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btndeletar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.btndeletar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.btndeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndeletar.Location = new System.Drawing.Point(527, 22);
            this.btndeletar.Name = "btndeletar";
            this.btndeletar.Size = new System.Drawing.Size(75, 31);
            this.btndeletar.TabIndex = 14;
            this.btndeletar.Text = "Deletar";
            this.btndeletar.UseVisualStyleBackColor = false;
            this.btndeletar.Click += new System.EventHandler(this.btndeletar_Click);
            // 
            // colID
            // 
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colID.DefaultCellStyle = dataGridViewCellStyle15;
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.Width = 40;
            // 
            // colNome
            // 
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.Width = 150;
            // 
            // colCategoria
            // 
            this.colCategoria.HeaderText = "Categoria";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.Width = 150;
            // 
            // colDescricao
            // 
            this.colDescricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDescricao.HeaderText = "Descrição";
            this.colDescricao.Name = "colDescricao";
            // 
            // colAno
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colAno.DefaultCellStyle = dataGridViewCellStyle16;
            this.colAno.HeaderText = "Ano";
            this.colAno.Name = "colAno";
            this.colAno.Width = 95;
            // 
            // FormAdega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(770, 450);
            this.Controls.Add(this.btndeletar);
            this.Controls.Add(this.btnalterar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.btInserir);
            this.Controls.Add(this.dgAdega);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.tbAno);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.tbCategoria);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAdega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adega";
            this.Load += new System.EventHandler(this.FormAdega_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAdega)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbCategoria;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.TextBox tbAno;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.DataGridView dgAdega;
        private System.Windows.Forms.Button btInserir;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.Button btndeletar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAno;
    }
}

