namespace CAI.TALENTUM;

partial class AsistenciaCalificacionesForm1
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
        cboCurso = new ComboBox();
        lbl2 = new Label();
        cboSesion = new ComboBox();
        lbl4 = new Label();
        dtpFecha = new DateTimePicker();
        lbl6 = new Label();
        dgvParticipantes = new DataGridView();
        lbl8 = new Label();
        lbl9 = new Label();
        txtEmpleado = new TextBox();
        lbl11 = new Label();
        cboAsistencia = new ComboBox();
        lbl13 = new Label();
        numNota = new NumericUpDown();
        lbl15 = new Label();
        txtObservacion = new TextBox();
        btnActualizarParticipante = new Button();
        btnCancelar = new Button();
        btnGuardar = new Button();
        dgvParticipantesCol0 = new DataGridViewTextBoxColumn();
        dgvParticipantesCol1 = new DataGridViewTextBoxColumn();
        dgvParticipantesCol2 = new DataGridViewTextBoxColumn();
        dgvParticipantesCol3 = new DataGridViewTextBoxColumn();
        dgvParticipantesCol4 = new DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)dgvParticipantes).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numNota).BeginInit();
        SuspendLayout();
        // lbl0
        lbl0.Location = new Point(24, 24);
        lbl0.Name = "lbl0";
        lbl0.Size = new Size(260, 22);
        lbl0.TabIndex = 0;
        lbl0.Text = "Curso";
        lbl0.AutoSize = false;
        // cboCurso
        cboCurso.Location = new Point(24, 48);
        cboCurso.Name = "cboCurso";
        cboCurso.Size = new Size(264, 28);
        cboCurso.TabIndex = 1;
        cboCurso.DropDownStyle = ComboBoxStyle.DropDownList;
        cboCurso.FormattingEnabled = true;
        // lbl2
        lbl2.Location = new Point(312, 24);
        lbl2.Name = "lbl2";
        lbl2.Size = new Size(260, 22);
        lbl2.TabIndex = 2;
        lbl2.Text = "Sesión";
        lbl2.AutoSize = false;
        // cboSesion
        cboSesion.Location = new Point(312, 48);
        cboSesion.Name = "cboSesion";
        cboSesion.Size = new Size(264, 28);
        cboSesion.TabIndex = 3;
        cboSesion.DropDownStyle = ComboBoxStyle.DropDownList;
        cboSesion.FormattingEnabled = true;
        // lbl4
        lbl4.Location = new Point(600, 24);
        lbl4.Name = "lbl4";
        lbl4.Size = new Size(260, 22);
        lbl4.TabIndex = 4;
        lbl4.Text = "Fecha";
        lbl4.AutoSize = false;
        // dtpFecha
        dtpFecha.Location = new Point(600, 48);
        dtpFecha.Name = "dtpFecha";
        dtpFecha.Size = new Size(264, 28);
        dtpFecha.TabIndex = 5;
        dtpFecha.Format = DateTimePickerFormat.Short;
        // lbl6
        lbl6.Location = new Point(24, 96);
        lbl6.Name = "lbl6";
        lbl6.Size = new Size(840, 22);
        lbl6.TabIndex = 6;
        lbl6.Text = "Participantes inscriptos";
        lbl6.AutoSize = false;
        // dgvParticipantes
        dgvParticipantes.Location = new Point(24, 122);
        dgvParticipantes.Name = "dgvParticipantes";
        dgvParticipantes.Size = new Size(840, 210);
        dgvParticipantes.TabIndex = 7;
        dgvParticipantes.AllowUserToAddRows = false;
        dgvParticipantes.AllowUserToDeleteRows = false;
        dgvParticipantes.ReadOnly = true;
        dgvParticipantes.RowHeadersVisible = false;
        dgvParticipantes.MultiSelect = false;
        dgvParticipantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvParticipantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvParticipantes.BackgroundColor = SystemColors.Window;
        dgvParticipantes.BorderStyle = BorderStyle.FixedSingle;
        dgvParticipantes.ColumnHeadersHeight = 32;
        dgvParticipantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dgvParticipantes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        dgvParticipantes.Columns.AddRange(new DataGridViewColumn[] { dgvParticipantesCol0, dgvParticipantesCol1, dgvParticipantesCol2, dgvParticipantesCol3, dgvParticipantesCol4 });
        dgvParticipantesCol0.HeaderText = "Legajo";
        dgvParticipantesCol0.Name = "dgvParticipantesCol0";
        dgvParticipantesCol0.ReadOnly = true;
        dgvParticipantesCol1.HeaderText = "Empleado";
        dgvParticipantesCol1.Name = "dgvParticipantesCol1";
        dgvParticipantesCol1.ReadOnly = true;
        dgvParticipantesCol2.HeaderText = "Asistencia";
        dgvParticipantesCol2.Name = "dgvParticipantesCol2";
        dgvParticipantesCol2.ReadOnly = true;
        dgvParticipantesCol3.HeaderText = "Calificación";
        dgvParticipantesCol3.Name = "dgvParticipantesCol3";
        dgvParticipantesCol3.ReadOnly = true;
        dgvParticipantesCol4.HeaderText = "Observación";
        dgvParticipantesCol4.Name = "dgvParticipantesCol4";
        dgvParticipantesCol4.ReadOnly = true;
        // lbl8
        lbl8.Location = new Point(24, 344);
        lbl8.Name = "lbl8";
        lbl8.Size = new Size(840, 22);
        lbl8.TabIndex = 8;
        lbl8.Text = "Participante seleccionado";
        lbl8.AutoSize = false;
        // lbl9
        lbl9.Location = new Point(24, 372);
        lbl9.Name = "lbl9";
        lbl9.Size = new Size(260, 22);
        lbl9.TabIndex = 9;
        lbl9.Text = "Empleado";
        lbl9.AutoSize = false;
        // txtEmpleado
        txtEmpleado.Location = new Point(24, 396);
        txtEmpleado.Name = "txtEmpleado";
        txtEmpleado.Size = new Size(264, 28);
        txtEmpleado.TabIndex = 10;
        txtEmpleado.ReadOnly = true;
        txtEmpleado.TabStop = false;
        // lbl11
        lbl11.Location = new Point(312, 372);
        lbl11.Name = "lbl11";
        lbl11.Size = new Size(260, 22);
        lbl11.TabIndex = 11;
        lbl11.Text = "Asistencia";
        lbl11.AutoSize = false;
        // cboAsistencia
        cboAsistencia.Location = new Point(312, 396);
        cboAsistencia.Name = "cboAsistencia";
        cboAsistencia.Size = new Size(264, 28);
        cboAsistencia.TabIndex = 12;
        cboAsistencia.DropDownStyle = ComboBoxStyle.DropDownList;
        cboAsistencia.FormattingEnabled = true;
        cboAsistencia.Items.AddRange(new object[] { "Presente", "Ausente", "Justificado" });
        // lbl13
        lbl13.Location = new Point(600, 372);
        lbl13.Name = "lbl13";
        lbl13.Size = new Size(260, 22);
        lbl13.TabIndex = 13;
        lbl13.Text = "Calificación (0 a 10)";
        lbl13.AutoSize = false;
        // numNota
        numNota.Location = new Point(600, 396);
        numNota.Name = "numNota";
        numNota.Size = new Size(264, 28);
        numNota.TabIndex = 14;
        numNota.Maximum = 10M;
        numNota.ThousandsSeparator = true;
        numNota.DecimalPlaces = 2;
        // lbl15
        lbl15.Location = new Point(24, 444);
        lbl15.Name = "lbl15";
        lbl15.Size = new Size(840, 22);
        lbl15.TabIndex = 15;
        lbl15.Text = "Observación";
        lbl15.AutoSize = false;
        // txtObservacion
        txtObservacion.Location = new Point(24, 468);
        txtObservacion.Name = "txtObservacion";
        txtObservacion.Size = new Size(840, 66);
        txtObservacion.TabIndex = 16;
        txtObservacion.Multiline = true;
        txtObservacion.ScrollBars = ScrollBars.Vertical;
        // btnActualizarParticipante
        btnActualizarParticipante.Location = new Point(24, 552);
        btnActualizarParticipante.Name = "btnActualizarParticipante";
        btnActualizarParticipante.Size = new Size(210, 32);
        btnActualizarParticipante.TabIndex = 17;
        btnActualizarParticipante.Text = "Actualizar participante";
        btnActualizarParticipante.UseVisualStyleBackColor = true;
        // btnCancelar
        btnCancelar.Location = new Point(754, 614);
        btnCancelar.Name = "btnCancelar";
        btnCancelar.Size = new Size(110, 34);
        btnCancelar.TabIndex = 18;
        btnCancelar.Text = "Cancelar";
        btnCancelar.UseVisualStyleBackColor = true;
        btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        // btnGuardar
        btnGuardar.Location = new Point(592, 614);
        btnGuardar.Name = "btnGuardar";
        btnGuardar.Size = new Size(152, 34);
        btnGuardar.TabIndex = 19;
        btnGuardar.Text = "Guardar registro";
        btnGuardar.UseVisualStyleBackColor = true;
        btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoScroll = true;
        ClientSize = new Size(888, 678);
        Controls.Add(lbl0);
        Controls.Add(cboCurso);
        Controls.Add(lbl2);
        Controls.Add(cboSesion);
        Controls.Add(lbl4);
        Controls.Add(dtpFecha);
        Controls.Add(lbl6);
        Controls.Add(dgvParticipantes);
        Controls.Add(lbl8);
        Controls.Add(lbl9);
        Controls.Add(txtEmpleado);
        Controls.Add(lbl11);
        Controls.Add(cboAsistencia);
        Controls.Add(lbl13);
        Controls.Add(numNota);
        Controls.Add(lbl15);
        Controls.Add(txtObservacion);
        Controls.Add(btnActualizarParticipante);
        Controls.Add(btnCancelar);
        Controls.Add(btnGuardar);
        MinimumSize = new Size(904, 717);
        Name = "FrmAsistenciaCalificaciones";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Asistencia y calificaciones - Talentum S.A.";
        ((System.ComponentModel.ISupportInitialize)dgvParticipantes).EndInit();
        ((System.ComponentModel.ISupportInitialize)numNota).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lbl0;
    private ComboBox cboCurso;
    private Label lbl2;
    private ComboBox cboSesion;
    private Label lbl4;
    private DateTimePicker dtpFecha;
    private Label lbl6;
    private DataGridView dgvParticipantes;
    private Label lbl8;
    private Label lbl9;
    private TextBox txtEmpleado;
    private Label lbl11;
    private ComboBox cboAsistencia;
    private Label lbl13;
    private NumericUpDown numNota;
    private Label lbl15;
    private TextBox txtObservacion;
    private Button btnActualizarParticipante;
    private Button btnCancelar;
    private Button btnGuardar;
    private DataGridViewTextBoxColumn dgvParticipantesCol0;
    private DataGridViewTextBoxColumn dgvParticipantesCol1;
    private DataGridViewTextBoxColumn dgvParticipantesCol2;
    private DataGridViewTextBoxColumn dgvParticipantesCol3;
    private DataGridViewTextBoxColumn dgvParticipantesCol4;
}
