namespace Boxe
{
    partial class PagIni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagIni));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNovo = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.tsbSalvar = new System.Windows.Forms.ToolStripButton();
            this.tsbAlterar = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblBusca = new System.Windows.Forms.ToolStripLabel();
            this.tstIdBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.tsbBuscar = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxrec = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.mtbCelular = new System.Windows.Forms.MaskedTextBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.rbMasc = new System.Windows.Forms.RadioButton();
            this.rbFem = new System.Windows.Forms.RadioButton();
            this.nudIdade = new System.Windows.Forms.NumericUpDown();
            this.nudLutas = new System.Windows.Forms.NumericUpDown();
            this.nudPeso = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.nudAltura = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.rbIdosos = new System.Windows.Forms.RadioButton();
            this.rbInfantil = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.rbNecEsp = new System.Windows.Forms.RadioButton();
            this.btnVerTodos = new System.Windows.Forms.Button();
            this.btnTurmasEspeciais = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLutas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAltura)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNovo,
            this.tsbCancelar,
            this.tsbSalvar,
            this.tsbAlterar,
            this.tsbDelete,
            this.toolStripSeparator1,
            this.lblBusca,
            this.tstIdBuscar,
            this.tsbBuscar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1050, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNovo
            // 
            this.tsbNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNovo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNovo.Image")));
            this.tsbNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNovo.Name = "tsbNovo";
            this.tsbNovo.Size = new System.Drawing.Size(23, 22);
            this.tsbNovo.Text = "Novo";
            this.tsbNovo.ToolTipText = "Novo cadastro\r\n";
            this.tsbNovo.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancelar.Image")));
            this.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(23, 22);
            this.tsbCancelar.Text = "Cancelar";
            this.tsbCancelar.Click += new System.EventHandler(this.tsbCancelar_Click);
            // 
            // tsbSalvar
            // 
            this.tsbSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSalvar.Image = ((System.Drawing.Image)(resources.GetObject("tsbSalvar.Image")));
            this.tsbSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalvar.Name = "tsbSalvar";
            this.tsbSalvar.Size = new System.Drawing.Size(23, 22);
            this.tsbSalvar.Text = "Salvar";
            this.tsbSalvar.Click += new System.EventHandler(this.tsbSalvar_Click);
            // 
            // tsbAlterar
            // 
            this.tsbAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAlterar.Image = ((System.Drawing.Image)(resources.GetObject("tsbAlterar.Image")));
            this.tsbAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAlterar.Name = "tsbAlterar";
            this.tsbAlterar.Size = new System.Drawing.Size(23, 22);
            this.tsbAlterar.Text = "Alterar";
            this.tsbAlterar.ToolTipText = "Alterar cadastro";
            this.tsbAlterar.Click += new System.EventHandler(this.tsbAlterar_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(23, 22);
            this.tsbDelete.Text = "Excluir";
            this.tsbDelete.ToolTipText = "Excluir ";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // lblBusca
            // 
            this.lblBusca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusca.Name = "lblBusca";
            this.lblBusca.Size = new System.Drawing.Size(85, 22);
            this.lblBusca.Text = "Buscar por ID:";
            // 
            // tstIdBuscar
            // 
            this.tstIdBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstIdBuscar.Name = "tstIdBuscar";
            this.tstIdBuscar.Size = new System.Drawing.Size(100, 25);
            this.tstIdBuscar.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // tsbBuscar
            // 
            this.tsbBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBuscar.Image = ((System.Drawing.Image)(resources.GetObject("tsbBuscar.Image")));
            this.tsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscar.Name = "tsbBuscar";
            this.tsbBuscar.Size = new System.Drawing.Size(23, 22);
            this.tsbBuscar.Text = "Buscar";
            this.tsbBuscar.Click += new System.EventHandler(this.tsbBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(12, 66);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(165, 22);
            this.txtId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "NOME:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(12, 114);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(165, 22);
            this.txtNome.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "IDADE: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "CELULAR:";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "CIDADE:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(9, 402);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(165, 22);
            this.txtCidade.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 427);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "ESTADO:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 475);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "LUTAS:";
            // 
            // txtBoxrec
            // 
            this.txtBoxrec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxrec.Location = new System.Drawing.Point(9, 546);
            this.txtBoxrec.Name = "txtBoxrec";
            this.txtBoxrec.Size = new System.Drawing.Size(165, 22);
            this.txtBoxrec.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 523);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "BOXREC:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 571);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "SEXO:";
            // 
            // mtbCelular
            // 
            this.mtbCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCelular.Location = new System.Drawing.Point(10, 306);
            this.mtbCelular.Mask = "(00) 00000-0000";
            this.mtbCelular.Name = "mtbCelular";
            this.mtbCelular.Size = new System.Drawing.Size(165, 22);
            this.mtbCelular.TabIndex = 20;
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbEstado.Location = new System.Drawing.Point(9, 450);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(165, 21);
            this.cbEstado.TabIndex = 21;
            // 
            // rbMasc
            // 
            this.rbMasc.AutoSize = true;
            this.rbMasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMasc.Location = new System.Drawing.Point(0, 3);
            this.rbMasc.Name = "rbMasc";
            this.rbMasc.Size = new System.Drawing.Size(82, 19);
            this.rbMasc.TabIndex = 22;
            this.rbMasc.TabStop = true;
            this.rbMasc.Text = "Masculino";
            this.rbMasc.UseVisualStyleBackColor = true;
            this.rbMasc.CheckedChanged += new System.EventHandler(this.rbMasc_CheckedChanged);
            // 
            // rbFem
            // 
            this.rbFem.AutoSize = true;
            this.rbFem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFem.Location = new System.Drawing.Point(91, 3);
            this.rbFem.Name = "rbFem";
            this.rbFem.Size = new System.Drawing.Size(77, 19);
            this.rbFem.TabIndex = 23;
            this.rbFem.TabStop = true;
            this.rbFem.Text = "Feminino";
            this.rbFem.UseVisualStyleBackColor = true;
            this.rbFem.CheckedChanged += new System.EventHandler(this.rbFem_CheckedChanged);
            // 
            // nudIdade
            // 
            this.nudIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudIdade.Location = new System.Drawing.Point(12, 162);
            this.nudIdade.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudIdade.Name = "nudIdade";
            this.nudIdade.Size = new System.Drawing.Size(165, 22);
            this.nudIdade.TabIndex = 24;
            // 
            // nudLutas
            // 
            this.nudLutas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLutas.Location = new System.Drawing.Point(9, 498);
            this.nudLutas.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudLutas.Name = "nudLutas";
            this.nudLutas.Size = new System.Drawing.Size(165, 22);
            this.nudLutas.TabIndex = 25;
            // 
            // nudPeso
            // 
            this.nudPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPeso.Location = new System.Drawing.Point(11, 210);
            this.nudPeso.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPeso.Name = "nudPeso";
            this.nudPeso.Size = new System.Drawing.Size(165, 22);
            this.nudPeso.TabIndex = 27;
            this.nudPeso.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 187);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "PESO (KG):";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(9, 354);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(165, 22);
            this.txtEmail.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 331);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 20);
            this.label12.TabIndex = 28;
            this.label12.Text = "EMAIL:";
            // 
            // nudAltura
            // 
            this.nudAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAltura.Location = new System.Drawing.Point(12, 258);
            this.nudAltura.Maximum = new decimal(new int[] {
            230,
            0,
            0,
            0});
            this.nudAltura.Name = "nudAltura";
            this.nudAltura.Size = new System.Drawing.Size(165, 22);
            this.nudAltura.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(9, 235);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 20);
            this.label13.TabIndex = 30;
            this.label13.Text = "ALTURA (CM):";
            // 
            // rbIdosos
            // 
            this.rbIdosos.AutoSize = true;
            this.rbIdosos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbIdosos.Location = new System.Drawing.Point(70, 4);
            this.rbIdosos.Name = "rbIdosos";
            this.rbIdosos.Size = new System.Drawing.Size(61, 19);
            this.rbIdosos.TabIndex = 34;
            this.rbIdosos.TabStop = true;
            this.rbIdosos.Text = "Idosos";
            this.rbIdosos.UseVisualStyleBackColor = true;
            this.rbIdosos.CheckedChanged += new System.EventHandler(this.rbIdosos_CheckedChanged);
            // 
            // rbInfantil
            // 
            this.rbInfantil.AutoSize = true;
            this.rbInfantil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInfantil.Location = new System.Drawing.Point(3, 4);
            this.rbInfantil.Name = "rbInfantil";
            this.rbInfantil.Size = new System.Drawing.Size(61, 19);
            this.rbInfantil.TabIndex = 33;
            this.rbInfantil.TabStop = true;
            this.rbInfantil.Text = "Infantil";
            this.rbInfantil.UseVisualStyleBackColor = true;
            this.rbInfantil.CheckedChanged += new System.EventHandler(this.rbInfantil_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 619);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(171, 20);
            this.label14.TabIndex = 32;
            this.label14.Text = "TURMAS ESPECIAIS:";
            // 
            // rbNecEsp
            // 
            this.rbNecEsp.AutoSize = true;
            this.rbNecEsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNecEsp.Location = new System.Drawing.Point(3, 29);
            this.rbNecEsp.Name = "rbNecEsp";
            this.rbNecEsp.Size = new System.Drawing.Size(158, 19);
            this.rbNecEsp.TabIndex = 35;
            this.rbNecEsp.TabStop = true;
            this.rbNecEsp.Text = "Necessidades especiais";
            this.rbNecEsp.UseVisualStyleBackColor = true;
            this.rbNecEsp.CheckedChanged += new System.EventHandler(this.rbNecEsp_CheckedChanged);
            // 
            // btnVerTodos
            // 
            this.btnVerTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTodos.Location = new System.Drawing.Point(869, 258);
            this.btnVerTodos.Name = "btnVerTodos";
            this.btnVerTodos.Size = new System.Drawing.Size(169, 70);
            this.btnVerTodos.TabIndex = 36;
            this.btnVerTodos.Text = "VISUALIZAR TODOS OS ALUNOS";
            this.btnVerTodos.UseVisualStyleBackColor = true;
            // 
            // btnTurmasEspeciais
            // 
            this.btnTurmasEspeciais.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurmasEspeciais.Location = new System.Drawing.Point(869, 354);
            this.btnTurmasEspeciais.Name = "btnTurmasEspeciais";
            this.btnTurmasEspeciais.Size = new System.Drawing.Size(169, 70);
            this.btnTurmasEspeciais.TabIndex = 37;
            this.btnTurmasEspeciais.Text = "VISUALIZAR TURMAS ESPECIAIS";
            this.btnTurmasEspeciais.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbMasc);
            this.panel1.Controls.Add(this.rbFem);
            this.panel1.Location = new System.Drawing.Point(9, 594);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 22);
            this.panel1.TabIndex = 38;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbInfantil);
            this.panel2.Controls.Add(this.rbIdosos);
            this.panel2.Controls.Add(this.rbNecEsp);
            this.panel2.Location = new System.Drawing.Point(9, 642);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 58);
            this.panel2.TabIndex = 39;
            // 
            // PagIni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1050, 711);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTurmasEspeciais);
            this.Controls.Add(this.btnVerTodos);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.nudAltura);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.nudPeso);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.nudLutas);
            this.Controls.Add(this.nudIdade);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.mtbCelular);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBoxrec);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PagIni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boxe UC12";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLutas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAltura)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNovo;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.ToolStripButton tsbSalvar;
        private System.Windows.Forms.ToolStripButton tsbAlterar;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel lblBusca;
        private System.Windows.Forms.ToolStripTextBox tstIdBuscar;
        private System.Windows.Forms.ToolStripButton tsbBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxrec;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mtbCelular;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.RadioButton rbFem;
        private System.Windows.Forms.RadioButton rbMasc;
        private System.Windows.Forms.NumericUpDown nudIdade;
        private System.Windows.Forms.NumericUpDown nudLutas;
        private System.Windows.Forms.NumericUpDown nudPeso;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nudAltura;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.RadioButton rbNecEsp;
        private System.Windows.Forms.RadioButton rbIdosos;
        private System.Windows.Forms.RadioButton rbInfantil;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnTurmasEspeciais;
        private System.Windows.Forms.Button btnVerTodos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

