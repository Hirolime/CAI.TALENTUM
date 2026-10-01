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
        lbl30 = new Label();
        numAsistencia = new NumericUpDown();
        lbl32 = new Label();
        numNota = new NumericUpDown();
        btnCancelar = new Button();
        btnGuardar = new Button();
        groupBox1 = new GroupBox();
        listView1 = new ListView();
        columnHeader1 = new ColumnHeader();
        columnHeader2 = new ColumnHeader();
        columnHeader3 = new ColumnHeader();
        columnHeader4 = new ColumnHeader();
        columnHeader5 = new ColumnHeader();
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
        btnModificarSesion = new Button();
        btnQuitarSesion = new Button();
        button1 = new Button();
        ((System.ComponentModel.ISupportInitialize)numCupo).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numAsistencia).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numNota).BeginInit();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numHoras).BeginInit();
        SuspendLayout();
        // 
        // lbl0
        // 
        lbl0.Location = new Point(24, 24);
        lbl0.Name = "lbl0";
        lbl0.Size = new Size(260, 22);
        lbl0.TabIndex = 0;
        lbl0.Text = "Curso N.º";
        // 
        // txtCurso
        // 
        txtCurso.Location = new Point(24, 48);
        txtCurso.Name = "txtCurso";
        txtCurso.ReadOnly = true;
        txtCurso.Size = new Size(264, 23);
        txtCurso.TabIndex = 1;
        txtCurso.TabStop = false;
        // 
        // lbl2
        // 
        lbl2.Location = new Point(312, 24);
        lbl2.Name = "lbl2";
        lbl2.Size = new Size(260, 22);
        lbl2.TabIndex = 2;
        lbl2.Text = "Nombre del curso";
        // 
        // txtNombre
        // 
        txtNombre.Location = new Point(312, 48);
        txtNombre.Name = "txtNombre";
        txtNombre.Size = new Size(264, 23);
        txtNombre.TabIndex = 3;
        // 
        // lbl4
        // 
        lbl4.Location = new Point(600, 24);
        lbl4.Name = "lbl4";
        lbl4.Size = new Size(260, 22);
        lbl4.TabIndex = 4;
        lbl4.Text = "Modalidad";
        // 
        // cboModalidad
        // 
        cboModalidad.DropDownStyle = ComboBoxStyle.DropDownList;
        cboModalidad.FormattingEnabled = true;
        cboModalidad.Items.AddRange(new object[] { "Presencial", "Virtual", "Mixta" });
        cboModalidad.Location = new Point(600, 48);
        cboModalidad.Name = "cboModalidad";
        cboModalidad.Size = new Size(306, 23);
        cboModalidad.TabIndex = 5;
        // 
        // lbl6
        // 
        lbl6.Location = new Point(24, 96);
        lbl6.Name = "lbl6";
        lbl6.Size = new Size(260, 22);
        lbl6.TabIndex = 6;
        lbl6.Text = "Instructor";
        // 
        // cboInstructor
        // 
        cboInstructor.DropDownStyle = ComboBoxStyle.DropDownList;
        cboInstructor.FormattingEnabled = true;
        cboInstructor.Location = new Point(24, 120);
        cboInstructor.Name = "cboInstructor";
        cboInstructor.Size = new Size(264, 23);
        cboInstructor.TabIndex = 7;
        // 
        // lbl8
        // 
        lbl8.Location = new Point(312, 96);
        lbl8.Name = "lbl8";
        lbl8.Size = new Size(260, 22);
        lbl8.TabIndex = 8;
        lbl8.Text = "Perfil destinatario";
        // 
        // cboPerfil
        // 
        cboPerfil.DropDownStyle = ComboBoxStyle.DropDownList;
        cboPerfil.FormattingEnabled = true;
        cboPerfil.Location = new Point(312, 120);
        cboPerfil.Name = "cboPerfil";
        cboPerfil.Size = new Size(264, 23);
        cboPerfil.TabIndex = 9;
        // 
        // lbl10
        // 
        lbl10.Location = new Point(600, 96);
        lbl10.Name = "lbl10";
        lbl10.Size = new Size(260, 22);
        lbl10.TabIndex = 10;
        lbl10.Text = "Cupo máximo";
        // 
        // numCupo
        // 
        numCupo.Location = new Point(600, 120);
        numCupo.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
        numCupo.Name = "numCupo";
        numCupo.Size = new Size(306, 23);
        numCupo.TabIndex = 11;
        numCupo.ThousandsSeparator = true;
        // 
        // lbl12
        // 
        lbl12.Location = new Point(24, 224);
        lbl12.Name = "lbl12";
        lbl12.Size = new Size(840, 22);
        lbl12.TabIndex = 12;
        lbl12.Text = "Objetivos y requisitos";
        // 
        // txtObjetivos
        // 
        txtObjetivos.Location = new Point(24, 248);
        txtObjetivos.Multiline = true;
        txtObjetivos.Name = "txtObjetivos";
        txtObjetivos.ScrollBars = ScrollBars.Vertical;
        txtObjetivos.Size = new Size(882, 95);
        txtObjetivos.TabIndex = 13;
        // 
        // lbl30
        // 
        lbl30.Location = new Point(24, 162);
        lbl30.Name = "lbl30";
        lbl30.Size = new Size(260, 22);
        lbl30.TabIndex = 30;
        lbl30.Text = "Asistencia mínima (%)";
        // 
        // numAsistencia
        // 
        numAsistencia.Location = new Point(24, 186);
        numAsistencia.Name = "numAsistencia";
        numAsistencia.Size = new Size(421, 23);
        numAsistencia.TabIndex = 31;
        numAsistencia.ThousandsSeparator = true;
        // 
        // lbl32
        // 
        lbl32.Location = new Point(451, 161);
        lbl32.Name = "lbl32";
        lbl32.Size = new Size(260, 22);
        lbl32.TabIndex = 32;
        lbl32.Text = "Nota mínima (0 a 10)";
        // 
        // numNota
        // 
        numNota.Location = new Point(451, 186);
        numNota.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
        numNota.Name = "numNota";
        numNota.Size = new Size(455, 23);
        numNota.TabIndex = 33;
        numNota.ThousandsSeparator = true;
        // 
        // btnCancelar
        // 
        btnCancelar.Anchor = AnchorStyles.Bottom;
        btnCancelar.Location = new Point(767, 770);
        btnCancelar.Name = "btnCancelar";
        btnCancelar.Size = new Size(110, 34);
        btnCancelar.TabIndex = 34;
        btnCancelar.Text = "Cancelar";
        btnCancelar.UseVisualStyleBackColor = true;
        // 
        // btnGuardar
        // 
        btnGuardar.Anchor = AnchorStyles.Bottom;
        btnGuardar.Location = new Point(633, 770);
        btnGuardar.Name = "btnGuardar";
        btnGuardar.Size = new Size(128, 34);
        btnGuardar.TabIndex = 35;
        btnGuardar.Text = "Guardar curso";
        btnGuardar.UseVisualStyleBackColor = true;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(button1);
        groupBox1.Controls.Add(listView1);
        groupBox1.Controls.Add(lbl15);
        groupBox1.Controls.Add(dtpFecha);
        groupBox1.Controls.Add(lbl17);
        groupBox1.Controls.Add(dtpInicio);
        groupBox1.Controls.Add(lbl19);
        groupBox1.Controls.Add(dtpFin);
        groupBox1.Controls.Add(lbl21);
        groupBox1.Controls.Add(txtLugar);
        groupBox1.Controls.Add(lbl23);
        groupBox1.Controls.Add(numHoras);
        groupBox1.Controls.Add(btnAgregarSesion);
        groupBox1.Controls.Add(lbl26);
        groupBox1.Controls.Add(btnModificarSesion);
        groupBox1.Controls.Add(btnQuitarSesion);
        groupBox1.Location = new Point(24, 361);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(882, 403);
        groupBox1.TabIndex = 37;
        groupBox1.TabStop = false;
        groupBox1.Text = "Sesiones";
        // 
        // listView1
        // 
        listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
        listView1.Location = new Point(18, 255);
        listView1.Name = "listView1";
        listView1.Size = new Size(840, 97);
        listView1.TabIndex = 51;
        listView1.UseCompatibleStateImageBehavior = false;
        listView1.View = View.Details;
        // 
        // columnHeader1
        // 
        columnHeader1.Text = "Fecha";
        columnHeader1.Width = 120;
        // 
        // columnHeader2
        // 
        columnHeader2.Text = "Inicio";
        columnHeader2.Width = 120;
        // 
        // columnHeader3
        // 
        columnHeader3.Text = "Fin";
        columnHeader3.Width = 120;
        // 
        // columnHeader4
        // 
        columnHeader4.Text = "Aula";
        columnHeader4.TextAlign = HorizontalAlignment.Right;
        columnHeader4.Width = 190;
        // 
        // columnHeader5
        // 
        columnHeader5.Text = "Enlace";
        columnHeader5.Width = 190;
        // 
        // lbl15
        // 
        lbl15.Location = new Point(18, 36);
        lbl15.Name = "lbl15";
        lbl15.Size = new Size(260, 22);
        lbl15.TabIndex = 37;
        lbl15.Text = "Fecha";
        // 
        // dtpFecha
        // 
        dtpFecha.Format = DateTimePickerFormat.Short;
        dtpFecha.Location = new Point(18, 60);
        dtpFecha.Name = "dtpFecha";
        dtpFecha.Size = new Size(264, 23);
        dtpFecha.TabIndex = 38;
        // 
        // lbl17
        // 
        lbl17.Location = new Point(306, 36);
        lbl17.Name = "lbl17";
        lbl17.Size = new Size(260, 22);
        lbl17.TabIndex = 39;
        lbl17.Text = "Hora de inicio";
        // 
        // dtpInicio
        // 
        dtpInicio.CustomFormat = "HH:mm";
        dtpInicio.Format = DateTimePickerFormat.Custom;
        dtpInicio.Location = new Point(306, 60);
        dtpInicio.Name = "dtpInicio";
        dtpInicio.ShowUpDown = true;
        dtpInicio.Size = new Size(264, 23);
        dtpInicio.TabIndex = 40;
        // 
        // lbl19
        // 
        lbl19.Location = new Point(594, 36);
        lbl19.Name = "lbl19";
        lbl19.Size = new Size(260, 22);
        lbl19.TabIndex = 41;
        lbl19.Text = "Hora de fin";
        // 
        // dtpFin
        // 
        dtpFin.CustomFormat = "HH:mm";
        dtpFin.Format = DateTimePickerFormat.Custom;
        dtpFin.Location = new Point(594, 60);
        dtpFin.Name = "dtpFin";
        dtpFin.ShowUpDown = true;
        dtpFin.Size = new Size(264, 23);
        dtpFin.TabIndex = 42;
        // 
        // lbl21
        // 
        lbl21.Location = new Point(18, 108);
        lbl21.Name = "lbl21";
        lbl21.Size = new Size(260, 22);
        lbl21.TabIndex = 43;
        lbl21.Text = "Aula / enlace";
        // 
        // txtLugar
        // 
        txtLugar.Location = new Point(18, 132);
        txtLugar.Name = "txtLugar";
        txtLugar.Size = new Size(421, 23);
        txtLugar.TabIndex = 44;
        // 
        // lbl23
        // 
        lbl23.Location = new Point(445, 108);
        lbl23.Name = "lbl23";
        lbl23.Size = new Size(260, 22);
        lbl23.TabIndex = 45;
        lbl23.Text = "Carga horaria total";
        // 
        // numHoras
        // 
        numHoras.Location = new Point(445, 133);
        numHoras.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
        numHoras.Name = "numHoras";
        numHoras.Size = new Size(413, 23);
        numHoras.TabIndex = 46;
        numHoras.ThousandsSeparator = true;
        // 
        // btnAgregarSesion
        // 
        btnAgregarSesion.Location = new Point(18, 179);
        btnAgregarSesion.Name = "btnAgregarSesion";
        btnAgregarSesion.Size = new Size(421, 32);
        btnAgregarSesion.TabIndex = 47;
        btnAgregarSesion.Text = "Aceptar Agregar/Modificar sesión";
        btnAgregarSesion.UseVisualStyleBackColor = true;
        // 
        // lbl26
        // 
        lbl26.Location = new Point(18, 230);
        lbl26.Name = "lbl26";
        lbl26.Size = new Size(840, 22);
        lbl26.TabIndex = 48;
        lbl26.Text = "Sesiones programadas";
        // 
        // btnModificarSesion
        // 
        btnModificarSesion.Location = new Point(18, 362);
        btnModificarSesion.Name = "btnModificarSesion";
        btnModificarSesion.Size = new Size(421, 32);
        btnModificarSesion.TabIndex = 49;
        btnModificarSesion.Text = "Modificar sesión";
        btnModificarSesion.UseVisualStyleBackColor = true;
        // 
        // btnQuitarSesion
        // 
        btnQuitarSesion.Location = new Point(445, 362);
        btnQuitarSesion.Name = "btnQuitarSesion";
        btnQuitarSesion.Size = new Size(413, 32);
        btnQuitarSesion.TabIndex = 50;
        btnQuitarSesion.Text = "Quitar sesión";
        btnQuitarSesion.UseVisualStyleBackColor = true;
        // 
        // button1
        // 
        button1.Location = new Point(445, 179);
        button1.Name = "button1";
        button1.Size = new Size(413, 32);
        button1.TabIndex = 52;
        button1.Text = "Cancelar Modificar sesion (sólo habilitado despues de modificar)";
        button1.UseVisualStyleBackColor = true;
        // 
        // PlanificacionCursosForm1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoScroll = true;
        ClientSize = new Size(922, 816);
        Controls.Add(groupBox1);
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
        Controls.Add(lbl30);
        Controls.Add(numAsistencia);
        Controls.Add(lbl32);
        Controls.Add(numNota);
        Controls.Add(btnCancelar);
        Controls.Add(btnGuardar);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MinimumSize = new Size(904, 855);
        Name = "PlanificacionCursosForm1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Planificación de cursos y sesiones - Talentum S.A.";
        Load += PlanificacionCursosForm1_Load;
        ((System.ComponentModel.ISupportInitialize)numCupo).EndInit();
        ((System.ComponentModel.ISupportInitialize)numAsistencia).EndInit();
        ((System.ComponentModel.ISupportInitialize)numNota).EndInit();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numHoras).EndInit();
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
    private Label lbl30;
    private NumericUpDown numAsistencia;
    private Label lbl32;
    private NumericUpDown numNota;
    private Button btnCancelar;
    private Button btnGuardar;
    private GroupBox groupBox1;
    private ListView listView1;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private ColumnHeader columnHeader3;
    private ColumnHeader columnHeader4;
    private ColumnHeader columnHeader5;
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
    private Button btnModificarSesion;
    private Button btnQuitarSesion;
    private Button button1;
}
