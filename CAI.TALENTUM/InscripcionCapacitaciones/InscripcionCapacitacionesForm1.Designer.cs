namespace CAI.TALENTUM;

partial class InscripcionCapacitacionesForm1
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
        txtEmpleado = new TextBox();
        lbl2 = new Label();
        txtArea = new TextBox();
        lbl4 = new Label();
        txtPerfil = new TextBox();
        lbl6 = new Label();
        txtBusqueda = new TextBox();
        lbl8 = new Label();
        cboModalidad = new ComboBox();
        btnBuscar = new Button();
        lbl11 = new Label();
        dgvCursos = new DataGridView();
        btnVerCurso = new Button();
        lbl14 = new Label();
        txtCurso = new TextBox();
        lbl16 = new Label();
        txtInstructor = new TextBox();
        lbl18 = new Label();
        txtHoras = new TextBox();
        lbl20 = new Label();
        txtRequisitos = new TextBox();
        lbl22 = new Label();
        dgvSesiones = new DataGridView();
        lbl24 = new Label();
        dgvInscripciones = new DataGridView();
        btnCancelarInscripcion = new Button();
        btnCerrar = new Button();
        btnInscribirme = new Button();
        dgvCursosCol0 = new DataGridViewTextBoxColumn();
        dgvCursosCol1 = new DataGridViewTextBoxColumn();
        dgvCursosCol2 = new DataGridViewTextBoxColumn();
        dgvCursosCol3 = new DataGridViewTextBoxColumn();
        dgvCursosCol4 = new DataGridViewTextBoxColumn();
        dgvSesionesCol0 = new DataGridViewTextBoxColumn();
        dgvSesionesCol1 = new DataGridViewTextBoxColumn();
        dgvSesionesCol2 = new DataGridViewTextBoxColumn();
        dgvSesionesCol3 = new DataGridViewTextBoxColumn();
        dgvInscripcionesCol0 = new DataGridViewTextBoxColumn();
        dgvInscripcionesCol1 = new DataGridViewTextBoxColumn();
        dgvInscripcionesCol2 = new DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)dgvCursos).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dgvSesiones).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dgvInscripciones).BeginInit();
        SuspendLayout();
        // lbl0
        lbl0.Location = new Point(24, 24);
        lbl0.Name = "lbl0";
        lbl0.Size = new Size(260, 22);
        lbl0.TabIndex = 0;
        lbl0.Text = "Empleado";
        lbl0.AutoSize = false;
        // txtEmpleado
        txtEmpleado.Location = new Point(24, 48);
        txtEmpleado.Name = "txtEmpleado";
        txtEmpleado.Size = new Size(264, 28);
        txtEmpleado.TabIndex = 1;
        txtEmpleado.ReadOnly = true;
        txtEmpleado.TabStop = false;
        // lbl2
        lbl2.Location = new Point(312, 24);
        lbl2.Name = "lbl2";
        lbl2.Size = new Size(260, 22);
        lbl2.TabIndex = 2;
        lbl2.Text = "Área";
        lbl2.AutoSize = false;
        // txtArea
        txtArea.Location = new Point(312, 48);
        txtArea.Name = "txtArea";
        txtArea.Size = new Size(264, 28);
        txtArea.TabIndex = 3;
        txtArea.ReadOnly = true;
        txtArea.TabStop = false;
        // lbl4
        lbl4.Location = new Point(600, 24);
        lbl4.Name = "lbl4";
        lbl4.Size = new Size(260, 22);
        lbl4.TabIndex = 4;
        lbl4.Text = "Perfil";
        lbl4.AutoSize = false;
        // txtPerfil
        txtPerfil.Location = new Point(600, 48);
        txtPerfil.Name = "txtPerfil";
        txtPerfil.Size = new Size(264, 28);
        txtPerfil.TabIndex = 5;
        txtPerfil.ReadOnly = true;
        txtPerfil.TabStop = false;
        // lbl6
        lbl6.Location = new Point(24, 96);
        lbl6.Name = "lbl6";
        lbl6.Size = new Size(260, 22);
        lbl6.TabIndex = 6;
        lbl6.Text = "Nombre / tema";
        lbl6.AutoSize = false;
        // txtBusqueda
        txtBusqueda.Location = new Point(24, 120);
        txtBusqueda.Name = "txtBusqueda";
        txtBusqueda.Size = new Size(264, 28);
        txtBusqueda.TabIndex = 7;
        // lbl8
        lbl8.Location = new Point(312, 96);
        lbl8.Name = "lbl8";
        lbl8.Size = new Size(260, 22);
        lbl8.TabIndex = 8;
        lbl8.Text = "Modalidad";
        lbl8.AutoSize = false;
        // cboModalidad
        cboModalidad.Location = new Point(312, 120);
        cboModalidad.Name = "cboModalidad";
        cboModalidad.Size = new Size(264, 28);
        cboModalidad.TabIndex = 9;
        cboModalidad.DropDownStyle = ComboBoxStyle.DropDownList;
        cboModalidad.FormattingEnabled = true;
        cboModalidad.Items.AddRange(new object[] { "Todas", "Presencial", "Virtual", "Mixta" });
        // btnBuscar
        btnBuscar.Location = new Point(24, 168);
        btnBuscar.Name = "btnBuscar";
        btnBuscar.Size = new Size(130, 32);
        btnBuscar.TabIndex = 10;
        btnBuscar.Text = "Buscar";
        btnBuscar.UseVisualStyleBackColor = true;
        // lbl11
        lbl11.Location = new Point(24, 218);
        lbl11.Name = "lbl11";
        lbl11.Size = new Size(840, 22);
        lbl11.TabIndex = 11;
        lbl11.Text = "Cursos disponibles para mi perfil";
        lbl11.AutoSize = false;
        // dgvCursos
        dgvCursos.Location = new Point(24, 244);
        dgvCursos.Name = "dgvCursos";
        dgvCursos.Size = new Size(840, 95);
        dgvCursos.TabIndex = 12;
        dgvCursos.AllowUserToAddRows = false;
        dgvCursos.AllowUserToDeleteRows = false;
        dgvCursos.ReadOnly = true;
        dgvCursos.RowHeadersVisible = false;
        dgvCursos.MultiSelect = false;
        dgvCursos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvCursos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvCursos.BackgroundColor = SystemColors.Window;
        dgvCursos.BorderStyle = BorderStyle.FixedSingle;
        dgvCursos.ColumnHeadersHeight = 32;
        dgvCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dgvCursos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        dgvCursos.Columns.AddRange(new DataGridViewColumn[] { dgvCursosCol0, dgvCursosCol1, dgvCursosCol2, dgvCursosCol3, dgvCursosCol4 });
        dgvCursosCol0.HeaderText = "Curso";
        dgvCursosCol0.Name = "dgvCursosCol0";
        dgvCursosCol0.ReadOnly = true;
        dgvCursosCol1.HeaderText = "Perfil requerido";
        dgvCursosCol1.Name = "dgvCursosCol1";
        dgvCursosCol1.ReadOnly = true;
        dgvCursosCol2.HeaderText = "Inicio";
        dgvCursosCol2.Name = "dgvCursosCol2";
        dgvCursosCol2.ReadOnly = true;
        dgvCursosCol3.HeaderText = "Modalidad";
        dgvCursosCol3.Name = "dgvCursosCol3";
        dgvCursosCol3.ReadOnly = true;
        dgvCursosCol4.HeaderText = "Vacantes";
        dgvCursosCol4.Name = "dgvCursosCol4";
        dgvCursosCol4.ReadOnly = true;
        // btnVerCurso
        btnVerCurso.Location = new Point(24, 351);
        btnVerCurso.Name = "btnVerCurso";
        btnVerCurso.Size = new Size(130, 32);
        btnVerCurso.TabIndex = 13;
        btnVerCurso.Text = "Ver curso";
        btnVerCurso.UseVisualStyleBackColor = true;
        // lbl14
        lbl14.Location = new Point(24, 401);
        lbl14.Name = "lbl14";
        lbl14.Size = new Size(260, 22);
        lbl14.TabIndex = 14;
        lbl14.Text = "Curso seleccionado";
        lbl14.AutoSize = false;
        // txtCurso
        txtCurso.Location = new Point(24, 425);
        txtCurso.Name = "txtCurso";
        txtCurso.Size = new Size(264, 28);
        txtCurso.TabIndex = 15;
        txtCurso.ReadOnly = true;
        txtCurso.TabStop = false;
        // lbl16
        lbl16.Location = new Point(312, 401);
        lbl16.Name = "lbl16";
        lbl16.Size = new Size(260, 22);
        lbl16.TabIndex = 16;
        lbl16.Text = "Instructor";
        lbl16.AutoSize = false;
        // txtInstructor
        txtInstructor.Location = new Point(312, 425);
        txtInstructor.Name = "txtInstructor";
        txtInstructor.Size = new Size(264, 28);
        txtInstructor.TabIndex = 17;
        txtInstructor.ReadOnly = true;
        txtInstructor.TabStop = false;
        // lbl18
        lbl18.Location = new Point(600, 401);
        lbl18.Name = "lbl18";
        lbl18.Size = new Size(260, 22);
        lbl18.TabIndex = 18;
        lbl18.Text = "Carga horaria";
        lbl18.AutoSize = false;
        // txtHoras
        txtHoras.Location = new Point(600, 425);
        txtHoras.Name = "txtHoras";
        txtHoras.Size = new Size(264, 28);
        txtHoras.TabIndex = 19;
        txtHoras.ReadOnly = true;
        txtHoras.TabStop = false;
        // lbl20
        lbl20.Location = new Point(24, 473);
        lbl20.Name = "lbl20";
        lbl20.Size = new Size(840, 22);
        lbl20.TabIndex = 20;
        lbl20.Text = "Objetivos y requisitos del curso";
        lbl20.AutoSize = false;
        // txtRequisitos
        txtRequisitos.Location = new Point(24, 497);
        txtRequisitos.Name = "txtRequisitos";
        txtRequisitos.Size = new Size(840, 44);
        txtRequisitos.TabIndex = 21;
        txtRequisitos.Multiline = true;
        txtRequisitos.ScrollBars = ScrollBars.Vertical;
        txtRequisitos.ReadOnly = true;
        // lbl22
        lbl22.Location = new Point(24, 559);
        lbl22.Name = "lbl22";
        lbl22.Size = new Size(840, 22);
        lbl22.TabIndex = 22;
        lbl22.Text = "Sesiones del curso";
        lbl22.AutoSize = false;
        // dgvSesiones
        dgvSesiones.Location = new Point(24, 585);
        dgvSesiones.Name = "dgvSesiones";
        dgvSesiones.Size = new Size(840, 80);
        dgvSesiones.TabIndex = 23;
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
        // lbl24
        lbl24.Location = new Point(24, 677);
        lbl24.Name = "lbl24";
        lbl24.Size = new Size(840, 22);
        lbl24.TabIndex = 24;
        lbl24.Text = "Mis inscripciones";
        lbl24.AutoSize = false;
        // dgvInscripciones
        dgvInscripciones.Location = new Point(24, 703);
        dgvInscripciones.Name = "dgvInscripciones";
        dgvInscripciones.Size = new Size(840, 80);
        dgvInscripciones.TabIndex = 25;
        dgvInscripciones.AllowUserToAddRows = false;
        dgvInscripciones.AllowUserToDeleteRows = false;
        dgvInscripciones.ReadOnly = true;
        dgvInscripciones.RowHeadersVisible = false;
        dgvInscripciones.MultiSelect = false;
        dgvInscripciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvInscripciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvInscripciones.BackgroundColor = SystemColors.Window;
        dgvInscripciones.BorderStyle = BorderStyle.FixedSingle;
        dgvInscripciones.ColumnHeadersHeight = 32;
        dgvInscripciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dgvInscripciones.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        dgvInscripciones.Columns.AddRange(new DataGridViewColumn[] { dgvInscripcionesCol0, dgvInscripcionesCol1, dgvInscripcionesCol2 });
        dgvInscripcionesCol0.HeaderText = "Curso";
        dgvInscripcionesCol0.Name = "dgvInscripcionesCol0";
        dgvInscripcionesCol0.ReadOnly = true;
        dgvInscripcionesCol1.HeaderText = "Inicio";
        dgvInscripcionesCol1.Name = "dgvInscripcionesCol1";
        dgvInscripcionesCol1.ReadOnly = true;
        dgvInscripcionesCol2.HeaderText = "Estado";
        dgvInscripcionesCol2.Name = "dgvInscripcionesCol2";
        dgvInscripcionesCol2.ReadOnly = true;
        // btnCancelarInscripcion
        btnCancelarInscripcion.Location = new Point(24, 795);
        btnCancelarInscripcion.Name = "btnCancelarInscripcion";
        btnCancelarInscripcion.Size = new Size(186, 32);
        btnCancelarInscripcion.TabIndex = 26;
        btnCancelarInscripcion.Text = "Cancelar inscripción";
        btnCancelarInscripcion.UseVisualStyleBackColor = true;
        // btnCerrar
        btnCerrar.Location = new Point(754, 857);
        btnCerrar.Name = "btnCerrar";
        btnCerrar.Size = new Size(110, 34);
        btnCerrar.TabIndex = 27;
        btnCerrar.Text = "Cerrar";
        btnCerrar.UseVisualStyleBackColor = true;
        btnCerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        // btnInscribirme
        btnInscribirme.Location = new Point(632, 857);
        btnInscribirme.Name = "btnInscribirme";
        btnInscribirme.Size = new Size(112, 34);
        btnInscribirme.TabIndex = 28;
        btnInscribirme.Text = "Inscribirme";
        btnInscribirme.UseVisualStyleBackColor = true;
        btnInscribirme.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoScroll = true;
        ClientSize = new Size(888, 921);
        Controls.Add(lbl0);
        Controls.Add(txtEmpleado);
        Controls.Add(lbl2);
        Controls.Add(txtArea);
        Controls.Add(lbl4);
        Controls.Add(txtPerfil);
        Controls.Add(lbl6);
        Controls.Add(txtBusqueda);
        Controls.Add(lbl8);
        Controls.Add(cboModalidad);
        Controls.Add(btnBuscar);
        Controls.Add(lbl11);
        Controls.Add(dgvCursos);
        Controls.Add(btnVerCurso);
        Controls.Add(lbl14);
        Controls.Add(txtCurso);
        Controls.Add(lbl16);
        Controls.Add(txtInstructor);
        Controls.Add(lbl18);
        Controls.Add(txtHoras);
        Controls.Add(lbl20);
        Controls.Add(txtRequisitos);
        Controls.Add(lbl22);
        Controls.Add(dgvSesiones);
        Controls.Add(lbl24);
        Controls.Add(dgvInscripciones);
        Controls.Add(btnCancelarInscripcion);
        Controls.Add(btnCerrar);
        Controls.Add(btnInscribirme);
        MinimumSize = new Size(904, 960);
        Name = "FrmInscripcionCapacitaciones";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Inscripción a capacitaciones - Talentum S.A.";
        ((System.ComponentModel.ISupportInitialize)dgvCursos).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgvSesiones).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgvInscripciones).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lbl0;
    private TextBox txtEmpleado;
    private Label lbl2;
    private TextBox txtArea;
    private Label lbl4;
    private TextBox txtPerfil;
    private Label lbl6;
    private TextBox txtBusqueda;
    private Label lbl8;
    private ComboBox cboModalidad;
    private Button btnBuscar;
    private Label lbl11;
    private DataGridView dgvCursos;
    private Button btnVerCurso;
    private Label lbl14;
    private TextBox txtCurso;
    private Label lbl16;
    private TextBox txtInstructor;
    private Label lbl18;
    private TextBox txtHoras;
    private Label lbl20;
    private TextBox txtRequisitos;
    private Label lbl22;
    private DataGridView dgvSesiones;
    private Label lbl24;
    private DataGridView dgvInscripciones;
    private Button btnCancelarInscripcion;
    private Button btnCerrar;
    private Button btnInscribirme;
    private DataGridViewTextBoxColumn dgvCursosCol0;
    private DataGridViewTextBoxColumn dgvCursosCol1;
    private DataGridViewTextBoxColumn dgvCursosCol2;
    private DataGridViewTextBoxColumn dgvCursosCol3;
    private DataGridViewTextBoxColumn dgvCursosCol4;
    private DataGridViewTextBoxColumn dgvSesionesCol0;
    private DataGridViewTextBoxColumn dgvSesionesCol1;
    private DataGridViewTextBoxColumn dgvSesionesCol2;
    private DataGridViewTextBoxColumn dgvSesionesCol3;
    private DataGridViewTextBoxColumn dgvInscripcionesCol0;
    private DataGridViewTextBoxColumn dgvInscripcionesCol1;
    private DataGridViewTextBoxColumn dgvInscripcionesCol2;
}
