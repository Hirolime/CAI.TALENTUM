namespace CAI.TALENTUM;

partial class PlanificacionCursosForm1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
            components.Dispose();
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        lbl0 = new Label();
        txtCurso = new TextBox();
        lbl2 = new Label();
        txtNombre = new TextBox();
        lbl4 = new Label();
        cboModalidad = new ComboBox();
        lbl6 = new Label();
        cboInstructor = new ComboBox();
        lbl8 = new Label();
        cboPerfil = new ComboBox();
        lbl10 = new Label();
        numCupo = new NumericUpDown();
        lbl12 = new Label();
        txtObjetivos = new TextBox();
        lbl14 = new Label();
        lbl15 = new Label();
        dtpFecha = new DateTimePicker();
        lbl17 = new Label();
        dtpInicio = new DateTimePicker();
        lbl19 = new Label();
        dtpFin = new DateTimePicker();
        lbl21 = new Label();
        txtLugar = new TextBox();
        lbl23 = new Label();
        numHoras = new NumericUpDown();
        btnAgregarSesion = new Button();
        lbl26 = new Label();
        dgvSesiones = new DataGridView();
        btnModificarSesion = new Button();
        btnQuitarSesion = new Button();
        lbl30 = new Label();
        numAsistencia = new NumericUpDown();
        lbl32 = new Label();
        numNota = new NumericUpDown();
        btnCancelar = new Button();
        btnGuardar = new Button();
        dgvSesionesCol0 = new DataGridViewTextBoxColumn();
        dgvSesionesCol1 = new DataGridViewTextBoxColumn();
        dgvSesionesCol2 = new DataGridViewTextBoxColumn();
        dgvSesionesCol3 = new DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)numCupo).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numHoras).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dgvSesiones).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numAsistencia).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numNota).BeginInit();
        SuspendLayout();
        // lbl0
        lbl0.Location = new Point(24, 24);
        lbl0.Name = "lbl0";
        lbl0.Size = new Size(260, 22);
        lbl0.TabIndex = 0;
        lbl0.Text = "Curso N.º";
        lbl0.AutoSize = false;
        // txtCurso
        txtCurso.Location = new Point(24, 48);
        txtCurso.Name = "txtCurso";
        txtCurso.Size = new Size(264, 28);
        txtCurso.TabIndex = 1;
        txtCurso.ReadOnly = true;
        txtCurso.TabStop = false;
        // lbl2
        lbl2.Location = new Point(312, 24);
        lbl2.Name = "lbl2";
        lbl2.Size = new Size(260, 22);
        lbl2.TabIndex = 2;
        lbl2.Text = "Nombre del curso";
        lbl2.AutoSize = false;
        // txtNombre
        txtNombre.Location = new Point(312, 48);
        txtNombre.Name = "txtNombre";
        txtNombre.Size = new Size(264, 28);
        txtNombre.TabIndex = 3;
        // lbl4
        lbl4.Location = new Point(600, 24);
        lbl4.Name = "lbl4";
        lbl4.Size = new Size(260, 22);
        lbl4.TabIndex = 4;
        lbl4.Text = "Modalidad";
        lbl4.AutoSize = false;
        // cboModalidad
        cboModalidad.Location = new Point(600, 48);
        cboModalidad.Name = "cboModalidad";
        cboModalidad.Size = new Size(264, 28);
        cboModalidad.TabIndex = 5;
        cboModalidad.DropDownStyle = ComboBoxStyle.DropDownList;
        cboModalidad.FormattingEnabled = true;
        cboModalidad.Items.AddRange(new object[] { "Presencial", "Virtual", "Mixta" });
        // lbl6
        lbl6.Location = new Point(24, 96);
        lbl6.Name = "lbl6";
        lbl6.Size = new Size(260, 22);
        lbl6.TabIndex = 6;
        lbl6.Text = "Instructor";
        lbl6.AutoSize = false;
        // cboInstructor
        cboInstructor.Location = new Point(24, 120);
        cboInstructor.Name = "cboInstructor";
        cboInstructor.Size = new Size(264, 28);
        cboInstructor.TabIndex = 7;
        cboInstructor.DropDownStyle = ComboBoxStyle.DropDownList;
        cboInstructor.FormattingEnabled = true;
        // lbl8
        lbl8.Location = new Point(312, 96);
        lbl8.Name = "lbl8";
        lbl8.Size = new Size(260, 22);
        lbl8.TabIndex = 8;
        lbl8.Text = "Perfil destinatario";
        lbl8.AutoSize = false;
        // cboPerfil
        cboPerfil.Location = new Point(312, 120);
        cboPerfil.Name = "cboPerfil";
        cboPerfil.Size = new Size(264, 28);
        cboPerfil.TabIndex = 9;
        cboPerfil.DropDownStyle = ComboBoxStyle.DropDownList;
        cboPerfil.FormattingEnabled = true;
        // lbl10
        lbl10.Location = new Point(600, 96);
        lbl10.Name = "lbl10";
        lbl10.Size = new Size(260, 22);
        lbl10.TabIndex = 10;
        lbl10.Text = "Cupo máximo";
        lbl10.AutoSize = false;
        // numCupo
        numCupo.Location = new Point(600, 120);
        numCupo.Name = "numCupo";
        numCupo.Size = new Size(264, 28);
        numCupo.TabIndex = 11;
        numCupo.Maximum = 100000000M;
        numCupo.ThousandsSeparator = true;
        // lbl12
        lbl12.Location = new Point(24, 168);
        lbl12.Name = "lbl12";
        lbl12.Size = new Size(840, 22);
        lbl12.TabIndex = 12;
        lbl12.Text = "Objetivos y requisitos";
        lbl12.AutoSize = false;
        // txtObjetivos
        txtObjetivos.Location = new Point(24, 192);
        txtObjetivos.Name = "txtObjetivos";
        txtObjetivos.Size = new Size(840, 48);
        txtObjetivos.TabIndex = 13;
        txtObjetivos.Multiline = true;
        txtObjetivos.ScrollBars = ScrollBars.Vertical;
        // lbl14
        lbl14.Location = new Point(24, 258);
        lbl14.Name = "lbl14";
        lbl14.Size = new Size(840, 22);
        lbl14.TabIndex = 14;
        lbl14.Text = "Agregar sesión";
        lbl14.AutoSize = false;
        // lbl15
        lbl15.Location = new Point(24, 286);
        lbl15.Name = "lbl15";
        lbl15.Size = new Size(260, 22);
        lbl15.TabIndex = 15;
        lbl15.Text = "Fecha";
        lbl15.AutoSize = false;
        // dtpFecha
        dtpFecha.Location = new Point(24, 310);
        dtpFecha.Name = "dtpFecha";
        dtpFecha.Size = new Size(264, 28);
        dtpFecha.TabIndex = 16;
        dtpFecha.Format = DateTimePickerFormat.Short;
        // lbl17
        lbl17.Location = new Point(312, 286);
        lbl17.Name = "lbl17";
        lbl17.Size = new Size(260, 22);
        lbl17.TabIndex = 17;
        lbl17.Text = "Hora de inicio";
        lbl17.AutoSize = false;
        // dtpInicio
        dtpInicio.Location = new Point(312, 310);
        dtpInicio.Name = "dtpInicio";
        dtpInicio.Size = new Size(264, 28);
        dtpInicio.TabIndex = 18;
        dtpInicio.Format = DateTimePickerFormat.Custom;
        dtpInicio.CustomFormat = "HH:mm";
        dtpInicio.ShowUpDown = true;
        // lbl19
        lbl19.Location = new Point(600, 286);
        lbl19.Name = "lbl19";
        lbl19.Size = new Size(260, 22);
        lbl19.TabIndex = 19;
        lbl19.Text = "Hora de fin";
        lbl19.AutoSize = false;
        // dtpFin
        dtpFin.Location = new Point(600, 310);
        dtpFin.Name = "dtpFin";
        dtpFin.Size = new Size(264, 28);
        dtpFin.TabIndex = 20;
        dtpFin.Format = DateTimePickerFormat.Custom;
        dtpFin.CustomFormat = "HH:mm";
        dtpFin.ShowUpDown = true;
        // lbl21
        lbl21.Location = new Point(24, 358);
        lbl21.Name = "lbl21";
        lbl21.Size = new Size(260, 22);
        lbl21.TabIndex = 21;
        lbl21.Text = "Aula / enlace";
        lbl21.AutoSize = false;
        // txtLugar
        txtLugar.Location = new Point(24, 382);
        txtLugar.Name = "txtLugar";
        txtLugar.Size = new Size(264, 28);
        txtLugar.TabIndex = 22;
        // lbl23
        lbl23.Location = new Point(312, 358);
        lbl23.Name = "lbl23";
        lbl23.Size = new Size(260, 22);
        lbl23.TabIndex = 23;
        lbl23.Text = "Carga horaria total";
        lbl23.AutoSize = false;
        // numHoras
        numHoras.Location = new Point(312, 382);
        numHoras.Name = "numHoras";
        numHoras.Size = new Size(264, 28);
        numHoras.TabIndex = 24;
        numHoras.Maximum = 100000000M;
        numHoras.ThousandsSeparator = true;
        // btnAgregarSesion
        btnAgregarSesion.Location = new Point(24, 430);
        btnAgregarSesion.Name = "btnAgregarSesion";
        btnAgregarSesion.Size = new Size(138, 32);
        btnAgregarSesion.TabIndex = 25;
        btnAgregarSesion.Text = "Agregar sesión";
        btnAgregarSesion.UseVisualStyleBackColor = true;
        // lbl26
        lbl26.Location = new Point(24, 480);
        lbl26.Name = "lbl26";
        lbl26.Size = new Size(840, 22);
        lbl26.TabIndex = 26;
        lbl26.Text = "Sesiones programadas";
        lbl26.AutoSize = false;
        // dgvSesiones
        dgvSesiones.Location = new Point(24, 506);
        dgvSesiones.Name = "dgvSesiones";
        dgvSesiones.Size = new Size(840, 100);
        dgvSesiones.TabIndex = 27;
        dgvSesiones.AllowUserToAddRows = false;
        dgvSesiones.AllowUserToDeleteRows = false;
        dgvSesiones.ReadOnly = true;
        dgvSesiones.RowHeadersVisible = false;
        dgvSesiones.MultiSelect = false;
        dgvSesiones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvSesiones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvSesiones.BackgroundColor = SystemColors.Window;
        dgvSesiones.BorderStyle = BorderStyle.FixedSingle;
        dgvSesiones.ColumnHeadersHeight = 32;
        dgvSesiones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dgvSesiones.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        dgvSesiones.Columns.AddRange(new DataGridViewColumn[] { dgvSesionesCol0, dgvSesionesCol1, dgvSesionesCol2, dgvSesionesCol3 });
        dgvSesionesCol0.HeaderText = "Fecha";
        dgvSesionesCol0.Name = "dgvSesionesCol0";
        dgvSesionesCol0.ReadOnly = true;
        dgvSesionesCol1.HeaderText = "Inicio";
        dgvSesionesCol1.Name = "dgvSesionesCol1";
        dgvSesionesCol1.ReadOnly = true;
        dgvSesionesCol2.HeaderText = "Fin";
        dgvSesionesCol2.Name = "dgvSesionesCol2";
        dgvSesionesCol2.ReadOnly = true;
        dgvSesionesCol3.HeaderText = "Aula / enlace";
        dgvSesionesCol3.Name = "dgvSesionesCol3";
        dgvSesionesCol3.ReadOnly = true;
        // btnModificarSesion
        btnModificarSesion.Location = new Point(24, 618);
        btnModificarSesion.Name = "btnModificarSesion";
        btnModificarSesion.Size = new Size(154, 32);
        btnModificarSesion.TabIndex = 28;
        btnModificarSesion.Text = "Modificar sesión";
        btnModificarSesion.UseVisualStyleBackColor = true;
        // btnQuitarSesion
        btnQuitarSesion.Location = new Point(188, 618);
        btnQuitarSesion.Name = "btnQuitarSesion";
        btnQuitarSesion.Size = new Size(130, 32);
        btnQuitarSesion.TabIndex = 29;
        btnQuitarSesion.Text = "Quitar sesión";
        btnQuitarSesion.UseVisualStyleBackColor = true;
        // lbl30
        lbl30.Location = new Point(24, 668);
        lbl30.Name = "lbl30";
        lbl30.Size = new Size(260, 22);
        lbl30.TabIndex = 30;
        lbl30.Text = "Asistencia mínima (%)";
        lbl30.AutoSize = false;
        // numAsistencia
        numAsistencia.Location = new Point(24, 692);
        numAsistencia.Name = "numAsistencia";
        numAsistencia.Size = new Size(264, 28);
        numAsistencia.TabIndex = 31;
        numAsistencia.Maximum = 100M;
        numAsistencia.ThousandsSeparator = true;
        // lbl32
        lbl32.Location = new Point(312, 668);
        lbl32.Name = "lbl32";
        lbl32.Size = new Size(260, 22);
        lbl32.TabIndex = 32;
        lbl32.Text = "Nota mínima (0 a 10)";
        lbl32.AutoSize = false;
        // numNota
        numNota.Location = new Point(312, 692);
        numNota.Name = "numNota";
        numNota.Size = new Size(264, 28);
        numNota.TabIndex = 33;
        numNota.Maximum = 10M;
        numNota.ThousandsSeparator = true;
        // btnCancelar
        btnCancelar.Location = new Point(754, 752);
        btnCancelar.Name = "btnCancelar";
        btnCancelar.Size = new Size(110, 34);
        btnCancelar.TabIndex = 34;
        btnCancelar.Text = "Cancelar";
        btnCancelar.UseVisualStyleBackColor = true;
        btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        // btnGuardar
        btnGuardar.Location = new Point(616, 752);
        btnGuardar.Name = "btnGuardar";
        btnGuardar.Size = new Size(128, 34);
        btnGuardar.TabIndex = 35;
        btnGuardar.Text = "Guardar curso";
        btnGuardar.UseVisualStyleBackColor = true;
        btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoScroll = true;
        ClientSize = new Size(888, 816);
        Controls.Add(lbl0);
        Controls.Add(txtCurso);
        Controls.Add(lbl2);
        Controls.Add(txtNombre);
        Controls.Add(lbl4);
        Controls.Add(cboModalidad);
        Controls.Add(lbl6);
        Controls.Add(cboInstructor);
        Controls.Add(lbl8);
        Controls.Add(cboPerfil);
        Controls.Add(lbl10);
        Controls.Add(numCupo);
        Controls.Add(lbl12);
        Controls.Add(txtObjetivos);
        Controls.Add(lbl14);
        Controls.Add(lbl15);
        Controls.Add(dtpFecha);
        Controls.Add(lbl17);
        Controls.Add(dtpInicio);
        Controls.Add(lbl19);
        Controls.Add(dtpFin);
        Controls.Add(lbl21);
        Controls.Add(txtLugar);
        Controls.Add(lbl23);
        Controls.Add(numHoras);
        Controls.Add(btnAgregarSesion);
        Controls.Add(lbl26);
        Controls.Add(dgvSesiones);
        Controls.Add(btnModificarSesion);
        Controls.Add(btnQuitarSesion);
        Controls.Add(lbl30);
        Controls.Add(numAsistencia);
        Controls.Add(lbl32);
        Controls.Add(numNota);
        Controls.Add(btnCancelar);
        Controls.Add(btnGuardar);
        MinimumSize = new Size(904, 855);
        Name = "FrmPlanificacionCursos";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Planificación de cursos y sesiones - Talentum S.A.";
        ((System.ComponentModel.ISupportInitialize)numCupo).EndInit();
        ((System.ComponentModel.ISupportInitialize)numHoras).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgvSesiones).EndInit();
        ((System.ComponentModel.ISupportInitialize)numAsistencia).EndInit();
        ((System.ComponentModel.ISupportInitialize)numNota).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lbl0;
    private TextBox txtCurso;
    private Label lbl2;
    private TextBox txtNombre;
    private Label lbl4;
    private ComboBox cboModalidad;
    private Label lbl6;
    private ComboBox cboInstructor;
    private Label lbl8;
    private ComboBox cboPerfil;
    private Label lbl10;
    private NumericUpDown numCupo;
    private Label lbl12;
    private TextBox txtObjetivos;
    private Label lbl14;
    private Label lbl15;
    private DateTimePicker dtpFecha;
    private Label lbl17;
    private DateTimePicker dtpInicio;
    private Label lbl19;
    private DateTimePicker dtpFin;
    private Label lbl21;
    private TextBox txtLugar;
    private Label lbl23;
    private NumericUpDown numHoras;
    private Button btnAgregarSesion;
    private Label lbl26;
    private DataGridView dgvSesiones;
    private Button btnModificarSesion;
    private Button btnQuitarSesion;
    private Label lbl30;
    private NumericUpDown numAsistencia;
    private Label lbl32;
    private NumericUpDown numNota;
    private Button btnCancelar;
    private Button btnGuardar;
    private DataGridViewTextBoxColumn dgvSesionesCol0;
    private DataGridViewTextBoxColumn dgvSesionesCol1;
    private DataGridViewTextBoxColumn dgvSesionesCol2;
    private DataGridViewTextBoxColumn dgvSesionesCol3;
}
