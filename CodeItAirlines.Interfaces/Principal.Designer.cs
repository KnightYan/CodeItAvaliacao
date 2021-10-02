namespace CodeItAirlines.Interfaces
{
    partial class Principal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.dgv_carrinho = new System.Windows.Forms.DataGridView();
            this.imagemDataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoTripulanteDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tripulanteDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgv_aviao = new System.Windows.Forms.DataGridView();
            this.imagemDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoTripulanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeComCargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_aeroporto = new System.Windows.Forms.DataGridView();
            this.imagemDataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.nomeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoTripulanteDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeComCargoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_Log = new System.Windows.Forms.RichTextBox();
            this.img_fim = new System.Windows.Forms.PictureBox();
            this.lbl_fim = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_carrinho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripulanteDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aviao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aeroporto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_fim)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_fim);
            this.panel1.Controls.Add(this.img_fim);
            this.panel1.Controls.Add(this.btn_iniciar);
            this.panel1.Controls.Add(this.dgv_carrinho);
            this.panel1.Controls.Add(this.dgv_aviao);
            this.panel1.Controls.Add(this.dgv_aeroporto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1548, 636);
            this.panel1.TabIndex = 3;
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iniciar.Location = new System.Drawing.Point(642, 296);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(276, 140);
            this.btn_iniciar.TabIndex = 7;
            this.btn_iniciar.Text = "Iniciar!";
            this.btn_iniciar.UseVisualStyleBackColor = true;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // dgv_carrinho
            // 
            this.dgv_carrinho.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_carrinho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_carrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_carrinho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imagemDataGridViewImageColumn2,
            this.dataGridViewTextBoxColumn3,
            this.nomeDataGridViewTextBoxColumn2,
            this.tipoTripulanteDataGridViewTextBoxColumn2});
            this.dgv_carrinho.DataSource = this.tripulanteDtoBindingSource;
            this.dgv_carrinho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_carrinho.Location = new System.Drawing.Point(492, 0);
            this.dgv_carrinho.Name = "dgv_carrinho";
            this.dgv_carrinho.RowTemplate.Height = 60;
            this.dgv_carrinho.Size = new System.Drawing.Size(564, 636);
            this.dgv_carrinho.TabIndex = 6;
            // 
            // imagemDataGridViewImageColumn2
            // 
            this.imagemDataGridViewImageColumn2.DataPropertyName = "Imagem";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.imagemDataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.imagemDataGridViewImageColumn2.HeaderText = "";
            this.imagemDataGridViewImageColumn2.Name = "imagemDataGridViewImageColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NomeComCargo";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn3.HeaderText = "Tripulantes no Smart Fortwo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn2
            // 
            this.nomeDataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn2.Name = "nomeDataGridViewTextBoxColumn2";
            this.nomeDataGridViewTextBoxColumn2.Visible = false;
            // 
            // tipoTripulanteDataGridViewTextBoxColumn2
            // 
            this.tipoTripulanteDataGridViewTextBoxColumn2.DataPropertyName = "TipoTripulante";
            this.tipoTripulanteDataGridViewTextBoxColumn2.HeaderText = "TipoTripulante";
            this.tipoTripulanteDataGridViewTextBoxColumn2.Name = "tipoTripulanteDataGridViewTextBoxColumn2";
            this.tipoTripulanteDataGridViewTextBoxColumn2.Visible = false;
            // 
            // tripulanteDtoBindingSource
            // 
            this.tripulanteDtoBindingSource.DataSource = typeof(CodeItAirlines.Domain.Dtos.TripulanteDto);
            // 
            // dgv_aviao
            // 
            this.dgv_aviao.AutoGenerateColumns = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_aviao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_aviao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_aviao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imagemDataGridViewImageColumn,
            this.dataGridViewTextBoxColumn6,
            this.nomeDataGridViewTextBoxColumn,
            this.tipoTripulanteDataGridViewTextBoxColumn,
            this.nomeComCargoDataGridViewTextBoxColumn});
            this.dgv_aviao.DataSource = this.tripulanteDtoBindingSource;
            this.dgv_aviao.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgv_aviao.Location = new System.Drawing.Point(1056, 0);
            this.dgv_aviao.Name = "dgv_aviao";
            this.dgv_aviao.RowTemplate.Height = 60;
            this.dgv_aviao.Size = new System.Drawing.Size(492, 636);
            this.dgv_aviao.TabIndex = 5;
            // 
            // imagemDataGridViewImageColumn
            // 
            this.imagemDataGridViewImageColumn.DataPropertyName = "Imagem";
            this.imagemDataGridViewImageColumn.HeaderText = "";
            this.imagemDataGridViewImageColumn.Name = "imagemDataGridViewImageColumn";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NomeComCargo";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn6.HeaderText = "Tripulantes no Avião";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.Visible = false;
            // 
            // tipoTripulanteDataGridViewTextBoxColumn
            // 
            this.tipoTripulanteDataGridViewTextBoxColumn.DataPropertyName = "TipoTripulante";
            this.tipoTripulanteDataGridViewTextBoxColumn.HeaderText = "TipoTripulante";
            this.tipoTripulanteDataGridViewTextBoxColumn.Name = "tipoTripulanteDataGridViewTextBoxColumn";
            this.tipoTripulanteDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomeComCargoDataGridViewTextBoxColumn
            // 
            this.nomeComCargoDataGridViewTextBoxColumn.DataPropertyName = "NomeComCargo";
            this.nomeComCargoDataGridViewTextBoxColumn.HeaderText = "NomeComCargo";
            this.nomeComCargoDataGridViewTextBoxColumn.Name = "nomeComCargoDataGridViewTextBoxColumn";
            this.nomeComCargoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeComCargoDataGridViewTextBoxColumn.Visible = false;
            // 
            // dgv_aeroporto
            // 
            this.dgv_aeroporto.AutoGenerateColumns = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_aeroporto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_aeroporto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_aeroporto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imagemDataGridViewImageColumn1,
            this.nomeDataGridViewTextBoxColumn1,
            this.tipoTripulanteDataGridViewTextBoxColumn1,
            this.nomeComCargoDataGridViewTextBoxColumn1});
            this.dgv_aeroporto.DataSource = this.tripulanteDtoBindingSource;
            this.dgv_aeroporto.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgv_aeroporto.Location = new System.Drawing.Point(0, 0);
            this.dgv_aeroporto.Name = "dgv_aeroporto";
            this.dgv_aeroporto.RowTemplate.Height = 60;
            this.dgv_aeroporto.Size = new System.Drawing.Size(492, 636);
            this.dgv_aeroporto.TabIndex = 3;
            // 
            // imagemDataGridViewImageColumn1
            // 
            this.imagemDataGridViewImageColumn1.DataPropertyName = "Imagem";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.imagemDataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle7;
            this.imagemDataGridViewImageColumn1.HeaderText = "";
            this.imagemDataGridViewImageColumn1.Name = "imagemDataGridViewImageColumn1";
            // 
            // nomeDataGridViewTextBoxColumn1
            // 
            this.nomeDataGridViewTextBoxColumn1.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn1.Name = "nomeDataGridViewTextBoxColumn1";
            this.nomeDataGridViewTextBoxColumn1.Visible = false;
            // 
            // tipoTripulanteDataGridViewTextBoxColumn1
            // 
            this.tipoTripulanteDataGridViewTextBoxColumn1.DataPropertyName = "TipoTripulante";
            this.tipoTripulanteDataGridViewTextBoxColumn1.HeaderText = "TipoTripulante";
            this.tipoTripulanteDataGridViewTextBoxColumn1.Name = "tipoTripulanteDataGridViewTextBoxColumn1";
            this.tipoTripulanteDataGridViewTextBoxColumn1.Visible = false;
            // 
            // nomeComCargoDataGridViewTextBoxColumn1
            // 
            this.nomeComCargoDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeComCargoDataGridViewTextBoxColumn1.DataPropertyName = "NomeComCargo";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeComCargoDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle8;
            this.nomeComCargoDataGridViewTextBoxColumn1.HeaderText = "Tripulantes no Terminal";
            this.nomeComCargoDataGridViewTextBoxColumn1.Name = "nomeComCargoDataGridViewTextBoxColumn1";
            this.nomeComCargoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tb_Log
            // 
            this.tb_Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Log.Location = new System.Drawing.Point(0, 636);
            this.tb_Log.Name = "tb_Log";
            this.tb_Log.Size = new System.Drawing.Size(1548, 202);
            this.tb_Log.TabIndex = 4;
            this.tb_Log.Text = "";
            // 
            // img_fim
            // 
            this.img_fim.BackgroundImage = global::CodeItAirlines.Interfaces.Properties.Resources.flying;
            this.img_fim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.img_fim.Location = new System.Drawing.Point(561, 148);
            this.img_fim.Name = "img_fim";
            this.img_fim.Size = new System.Drawing.Size(447, 389);
            this.img_fim.TabIndex = 8;
            this.img_fim.TabStop = false;
            this.img_fim.Visible = false;
            // 
            // lbl_fim
            // 
            this.lbl_fim.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_fim.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fim.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_fim.Location = new System.Drawing.Point(559, 536);
            this.lbl_fim.Name = "lbl_fim";
            this.lbl_fim.Size = new System.Drawing.Size(450, 67);
            this.lbl_fim.TabIndex = 10;
            this.lbl_fim.Text = "Avião Decolado!";
            this.lbl_fim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_fim.Visible = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1548, 838);
            this.Controls.Add(this.tb_Log);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CodeIT Airlines";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_carrinho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripulanteDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aviao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aeroporto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_fim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource tripulanteDtoBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_aeroporto;
        private System.Windows.Forms.RichTextBox tb_Log;
        private System.Windows.Forms.DataGridView dgv_carrinho;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dgv_aviao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn iconeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.DataGridViewImageColumn imagemDataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoTripulanteDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewImageColumn imagemDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoTripulanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeComCargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imagemDataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoTripulanteDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeComCargoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.PictureBox img_fim;
        private System.Windows.Forms.Label lbl_fim;
    }
}

