namespace SysAnd_v1._8___Cadastro_de_Aparelhos
{
    partial class frmRegistro
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pessoasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.newDataBaseTestDataSet = new SysAnd_v1._8___Cadastro_de_Aparelhos.NewDataBaseTestDataSet();
            this.pessoasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoasTableAdapter = new SysAnd_v1._8___Cadastro_de_Aparelhos.NewDataBaseTestDataSetTableAdapters.pessoasTableAdapter();
            this.dgvTabela = new System.Windows.Forms.DataGridView();
            this.fixManutencaoDBDataSet = new SysAnd_v1._8___Cadastro_de_Aparelhos.FixManutencaoDBDataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new SysAnd_v1._8___Cadastro_de_Aparelhos.FixManutencaoDBDataSetTableAdapters.TableTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEntrada = new System.Windows.Forms.MaskedTextBox();
            this.cbEntrada = new System.Windows.Forms.CheckBox();
            this.cbSaida = new System.Windows.Forms.CheckBox();
            this.txtSaida = new System.Windows.Forms.MaskedTextBox();
            this.txtOS = new System.Windows.Forms.TextBox();
            this.txtPatrimonio = new System.Windows.Forms.TextBox();
            this.cbModelo = new System.Windows.Forms.ComboBox();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.gbGarantia = new System.Windows.Forms.GroupBox();
            this.rbNãoGarantia = new System.Windows.Forms.RadioButton();
            this.rbSimGarantia = new System.Windows.Forms.RadioButton();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbNãoLaudo = new System.Windows.Forms.RadioButton();
            this.rbSImLaudo = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbDefeito = new System.Windows.Forms.CheckedListBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtReparo = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newDataBaseTestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixManutencaoDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.gbGarantia.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pessoasBindingSource1
            // 
            this.pessoasBindingSource1.DataMember = "pessoas";
            this.pessoasBindingSource1.DataSource = this.newDataBaseTestDataSet;
            // 
            // newDataBaseTestDataSet
            // 
            this.newDataBaseTestDataSet.DataSetName = "NewDataBaseTestDataSet";
            this.newDataBaseTestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pessoasBindingSource
            // 
            this.pessoasBindingSource.DataMember = "pessoas";
            this.pessoasBindingSource.DataSource = this.newDataBaseTestDataSet;
            // 
            // pessoasTableAdapter
            // 
            this.pessoasTableAdapter.ClearBeforeFill = true;
            // 
            // dgvTabela
            // 
            this.dgvTabela.AllowUserToAddRows = false;
            this.dgvTabela.AllowUserToDeleteRows = false;
            this.dgvTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabela.Location = new System.Drawing.Point(3, 226);
            this.dgvTabela.Name = "dgvTabela";
            this.dgvTabela.ReadOnly = true;
            this.dgvTabela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTabela.Size = new System.Drawing.Size(417, 421);
            this.dgvTabela.TabIndex = 0;
            this.dgvTabela.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabela_CellContentClick);
            this.dgvTabela.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvTabela_MouseDoubleClick);
            // 
            // fixManutencaoDBDataSet
            // 
            this.fixManutencaoDBDataSet.DataSetName = "FixManutencaoDBDataSet";
            this.fixManutencaoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.fixManutencaoDBDataSet;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Malgun Gothic", 11F);
            this.txtID.Location = new System.Drawing.Point(48, 20);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(57, 27);
            this.txtID.TabIndex = 2;
            this.txtID.Text = "00";
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.label3.Location = new System.Drawing.Point(319, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "OS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.label4.Location = new System.Drawing.Point(17, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Patrimônio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.label8.Location = new System.Drawing.Point(688, 393);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "Obs";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.label9.Location = new System.Drawing.Point(611, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 21);
            this.label9.TabIndex = 17;
            this.label9.Text = "Status";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.label10.Location = new System.Drawing.Point(428, 393);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 21);
            this.label10.TabIndex = 19;
            this.label10.Text = "Reparo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.label12.Location = new System.Drawing.Point(471, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 21);
            this.label12.TabIndex = 23;
            this.label12.Text = "Cor";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.label13.Location = new System.Drawing.Point(213, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 21);
            this.label13.TabIndex = 25;
            this.label13.Text = "Modelo";
            // 
            // txtEntrada
            // 
            this.txtEntrada.Enabled = false;
            this.txtEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtEntrada.Location = new System.Drawing.Point(196, 22);
            this.txtEntrada.Mask = "00/00/0000 00:00";
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(116, 23);
            this.txtEntrada.TabIndex = 26;
            // 
            // cbEntrada
            // 
            this.cbEntrada.AutoSize = true;
            this.cbEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbEntrada.Location = new System.Drawing.Point(111, 22);
            this.cbEntrada.Name = "cbEntrada";
            this.cbEntrada.Size = new System.Drawing.Size(85, 24);
            this.cbEntrada.TabIndex = 27;
            this.cbEntrada.Text = "Entrada";
            this.cbEntrada.UseVisualStyleBackColor = true;
            this.cbEntrada.CheckedChanged += new System.EventHandler(this.cbEntrada_CheckedChanged);
            // 
            // cbSaida
            // 
            this.cbSaida.AutoSize = true;
            this.cbSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbSaida.Location = new System.Drawing.Point(730, 23);
            this.cbSaida.Name = "cbSaida";
            this.cbSaida.Size = new System.Drawing.Size(69, 24);
            this.cbSaida.TabIndex = 29;
            this.cbSaida.Text = "Saida";
            this.cbSaida.UseVisualStyleBackColor = true;
            this.cbSaida.CheckedChanged += new System.EventHandler(this.cbSaida_CheckedChanged);
            // 
            // txtSaida
            // 
            this.txtSaida.Enabled = false;
            this.txtSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSaida.Location = new System.Drawing.Point(799, 22);
            this.txtSaida.Mask = "00/00/0000 00:00";
            this.txtSaida.Name = "txtSaida";
            this.txtSaida.Size = new System.Drawing.Size(116, 23);
            this.txtSaida.TabIndex = 28;
            // 
            // txtOS
            // 
            this.txtOS.Font = new System.Drawing.Font("Malgun Gothic", 11F);
            this.txtOS.Location = new System.Drawing.Point(353, 20);
            this.txtOS.Name = "txtOS";
            this.txtOS.Size = new System.Drawing.Size(57, 27);
            this.txtOS.TabIndex = 30;
            this.txtOS.Text = "000000";
            this.txtOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOS.Click += new System.EventHandler(this.textBox1_Click);
            this.txtOS.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtOS_MouseClick);
            // 
            // txtPatrimonio
            // 
            this.txtPatrimonio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPatrimonio.Location = new System.Drawing.Point(105, 87);
            this.txtPatrimonio.Name = "txtPatrimonio";
            this.txtPatrimonio.Size = new System.Drawing.Size(100, 20);
            this.txtPatrimonio.TabIndex = 31;
            // 
            // cbModelo
            // 
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.Items.AddRange(new object[] {
            "Galaxy A01 Core (A013)",
            "Galaxy A03s (A037)",
            "Galaxy A10s (A107)",
            "Galaxy A11 (A115)",
            "Galaxy J5 Prime (G570)",
            "Galaxy J5 Pro (J530)",
            "Galaxy J7 Metal (J710)",
            "Galaxy J7 Prime (G610M)",
            "Galaxy J7 Prime 2 (G611)",
            "Galaxy S10e (G970)",
            "Galaxy S20 (G980)",
            "Galaxy S6 (G920)",
            "Galaxy S7 (G930)",
            "Galaxy S7 Edge (G935)",
            "Galaxy S8 (G950)",
            "Galaxy TAB A - 10.5\" (T590)",
            "Galaxy Tab A 10.1\" (T510)",
            "Galaxy TAB A 8\" (T290)",
            "Galaxy Tab A 9.7\" (P555)",
            "Galaxy Tab A6 7\" (T280)",
            "Galaxy Tab Active 2 (T395)",
            "Galaxy TAB E - 9.6\" (T561M)",
            "iPad Air - 9.7\" Wi-fi (A1475)",
            "iPad Air 2 - 9.7\" 4G (A1396)",
            "iPhone 11 (A2111)",
            "iPhone 11 Pro Max (A2218)",
            "iPhone 6 (A1549)",
            "iPhone 7 (A1660)",
            "iPhone 8 (A1864)",
            "iPhone X (A1865)",
            "iPhone XS Max (A1921)",
            "Moto E6 Plus (XT2025)",
            "Moto E7 Plus (XT2081)",
            "Moto G5S Plus (XT1802)",
            "Moto G6 Play (XT1922)",
            "Moto G8 Play (XT2015)",
            "Galaxy A02 (A022)"});
            this.cbModelo.Location = new System.Drawing.Point(279, 86);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(188, 21);
            this.cbModelo.TabIndex = 32;
            this.cbModelo.Tag = "Modelo";
            // 
            // cbColor
            // 
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Items.AddRange(new object[] {
            "Ametista",
            "Azul",
            "Branco",
            "Cinza",
            "Cinza Metálico",
            "Dourado",
            "Indigo",
            "Marrom",
            "Prata",
            "Preto",
            "Vermelho"});
            this.cbColor.Location = new System.Drawing.Point(504, 86);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(101, 21);
            this.cbColor.TabIndex = 33;
            this.cbColor.Tag = "Modelo";
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Aguardando Análise",
            "Aguardando Compra",
            "Aguardando Garantia",
            "Aguardando Reparo",
            "Garantia",
            "Reparo Finalizado",
            "Reparo Iniciado - Jhow",
            "Sucatas"});
            this.cbStatus.Location = new System.Drawing.Point(672, 86);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(155, 21);
            this.cbStatus.TabIndex = 34;
            this.cbStatus.Tag = "Modelo";
            // 
            // gbGarantia
            // 
            this.gbGarantia.Controls.Add(this.rbNãoGarantia);
            this.gbGarantia.Controls.Add(this.rbSimGarantia);
            this.gbGarantia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbGarantia.Location = new System.Drawing.Point(27, 127);
            this.gbGarantia.Name = "gbGarantia";
            this.gbGarantia.Size = new System.Drawing.Size(109, 81);
            this.gbGarantia.TabIndex = 36;
            this.gbGarantia.TabStop = false;
            this.gbGarantia.Text = "Garantia";
            // 
            // rbNãoGarantia
            // 
            this.rbNãoGarantia.AutoSize = true;
            this.rbNãoGarantia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rbNãoGarantia.Location = new System.Drawing.Point(32, 50);
            this.rbNãoGarantia.Name = "rbNãoGarantia";
            this.rbNãoGarantia.Size = new System.Drawing.Size(48, 19);
            this.rbNãoGarantia.TabIndex = 1;
            this.rbNãoGarantia.TabStop = true;
            this.rbNãoGarantia.Text = "Não";
            this.rbNãoGarantia.UseVisualStyleBackColor = true;
            // 
            // rbSimGarantia
            // 
            this.rbSimGarantia.AutoSize = true;
            this.rbSimGarantia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rbSimGarantia.Location = new System.Drawing.Point(32, 29);
            this.rbSimGarantia.Name = "rbSimGarantia";
            this.rbSimGarantia.Size = new System.Drawing.Size(47, 19);
            this.rbSimGarantia.TabIndex = 0;
            this.rbSimGarantia.TabStop = true;
            this.rbSimGarantia.Text = "Sim";
            this.rbSimGarantia.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSalvar.Location = new System.Drawing.Point(520, 600);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 28);
            this.btnSalvar.TabIndex = 37;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbNãoLaudo);
            this.groupBox2.Controls.Add(this.rbSImLaudo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.Location = new System.Drawing.Point(146, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(109, 81);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Laudo";
            // 
            // rbNãoLaudo
            // 
            this.rbNãoLaudo.AutoSize = true;
            this.rbNãoLaudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rbNãoLaudo.Location = new System.Drawing.Point(30, 50);
            this.rbNãoLaudo.Name = "rbNãoLaudo";
            this.rbNãoLaudo.Size = new System.Drawing.Size(48, 19);
            this.rbNãoLaudo.TabIndex = 3;
            this.rbNãoLaudo.TabStop = true;
            this.rbNãoLaudo.Text = "Não";
            this.rbNãoLaudo.UseVisualStyleBackColor = true;
            // 
            // rbSImLaudo
            // 
            this.rbSImLaudo.AutoSize = true;
            this.rbSImLaudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rbSImLaudo.Location = new System.Drawing.Point(30, 29);
            this.rbSImLaudo.Name = "rbSImLaudo";
            this.rbSImLaudo.Size = new System.Drawing.Size(47, 19);
            this.rbSImLaudo.TabIndex = 2;
            this.rbSImLaudo.TabStop = true;
            this.rbSImLaudo.Text = "Sim";
            this.rbSImLaudo.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbDefeito);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox3.Location = new System.Drawing.Point(426, 159);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(489, 222);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Defeito";
            // 
            // cbDefeito
            // 
            this.cbDefeito.BackColor = System.Drawing.SystemColors.Control;
            this.cbDefeito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cbDefeito.CheckOnClick = true;
            this.cbDefeito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cbDefeito.FormattingEnabled = true;
            this.cbDefeito.Location = new System.Drawing.Point(6, 25);
            this.cbDefeito.Name = "cbDefeito";
            this.cbDefeito.Size = new System.Drawing.Size(477, 192);
            this.cbDefeito.TabIndex = 35;
            this.cbDefeito.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbDefeito_MouseClick);
            // 
            // txtObs
            // 
            this.txtObs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtObs.Location = new System.Drawing.Point(692, 417);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(228, 149);
            this.txtObs.TabIndex = 38;
            // 
            // txtReparo
            // 
            this.txtReparo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtReparo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtReparo.Location = new System.Drawing.Point(432, 417);
            this.txtReparo.Multiline = true;
            this.txtReparo.Name = "txtReparo";
            this.txtReparo.Size = new System.Drawing.Size(228, 149);
            this.txtReparo.TabIndex = 39;
            // 
            // btnNovo
            // 
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnNovo.Location = new System.Drawing.Point(432, 600);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 28);
            this.btnNovo.TabIndex = 40;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.txtReparo);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gbGarantia);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.cbModelo);
            this.Controls.Add(this.txtPatrimonio);
            this.Controls.Add(this.txtOS);
            this.Controls.Add(this.cbSaida);
            this.Controls.Add(this.txtSaida);
            this.Controls.Add(this.cbEntrada);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTabela);
            this.Name = "frmRegistro";
            this.Size = new System.Drawing.Size(954, 662);
            this.Load += new System.EventHandler(this.frmRegistro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newDataBaseTestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixManutencaoDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.gbGarantia.ResumeLayout(false);
            this.gbGarantia.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource pessoasBindingSource;
        private NewDataBaseTestDataSet newDataBaseTestDataSet;
        private NewDataBaseTestDataSetTableAdapters.pessoasTableAdapter pessoasTableAdapter;
        private System.Windows.Forms.BindingSource pessoasBindingSource1;
        private System.Windows.Forms.DataGridView dgvTabela;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private FixManutencaoDBDataSet fixManutencaoDBDataSet;
        private FixManutencaoDBDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox txtEntrada;
        private System.Windows.Forms.CheckBox cbEntrada;
        private System.Windows.Forms.CheckBox cbSaida;
        private System.Windows.Forms.MaskedTextBox txtSaida;
        private System.Windows.Forms.TextBox txtOS;
        private System.Windows.Forms.TextBox txtPatrimonio;
        private System.Windows.Forms.ComboBox cbModelo;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.GroupBox gbGarantia;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckedListBox cbDefeito;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.TextBox txtReparo;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.RadioButton rbNãoGarantia;
        private System.Windows.Forms.RadioButton rbSimGarantia;
        private System.Windows.Forms.RadioButton rbNãoLaudo;
        private System.Windows.Forms.RadioButton rbSImLaudo;
    }
}
