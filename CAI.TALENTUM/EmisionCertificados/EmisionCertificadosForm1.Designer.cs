namespace CAI.TALENTUM;

partial class EmisionCertificadosForm1
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
        dtpEmision = new DateTimePicker();
        lbl4 = new Label();
        txtInstructor = new TextBox();
        lbl6 = new Label();
        txtAsistenciaMinima = new TextBox();
        lbl8 = new Label();
        txtNotaMinima = new TextBox();
        lbl10 = new Label();
        dgvResultados = new DataGridView();
        btnSeleccionar = new Button();
        lbl13 = new Label();
        txtEmpleado = new TextBox();
        lbl15 = new Label();
        txtCertificado = new TextBox();
        chkCumpleRequisitos = new CheckBox();
        btnCancelar = new Button();
        btnEmitir = new Button();
        dgvResultadosCol0 = new DataGridViewTextBoxColumn();
        dgvResultadosCol1 = new DataGridViewTextBoxColumn();
        dgvResultadosCol2 = new DataGridViewTextBoxColumn();
        dgvResultadosCol3 = new DataGridViewTextBoxColumn();
        dgvResultadosCol4 = new DataGridViewTextBoxColumn();
        dgvResultadosCol5 = new DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
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
        lbl2.Text = "Fecha de emisión";
        lbl2.AutoSize = false;
        // dtpEmision
        dtpEmision.Location = new Point(312, 48);
        dtpEmision.Name = "dtpEmision";
        dtpEmision.Size = new Size(264, 28);
        dtpEmision.TabIndex = 3;
        dtpEmision.Format = DateTimePickerFormat.Short;
        // lbl4
        lbl4.Location = new Point(600, 24);
        lbl4.Name = "lbl4";
        lbl4.Size = new Size(260, 22);
        lbl4.TabIndex = 4;
        lbl4.Text = "Instructor";
        lbl4.AutoSize = false;
        // txtInstructor
        txtInstructor.Location = new Point(600, 48);
        txtInstructor.Name = "txtInstructor";
        txtInstructor.Size = new Size(264, 28);
        txtInstructor.TabIndex = 5;
        txtInstructor.ReadOnly = true;
        txtInstructor.TabStop = false;
        // lbl6
        lbl6.Location = new Point(24, 96);
        lbl6.Name = "lbl6";
        lbl6.Size = new Size(260, 22);
        lbl6.TabIndex = 6;
        lbl6.Text = "Asistencia mínima (%)";
        lbl6.AutoSize = false;
        // txtAsistenciaMinima
        txtAsistenciaMinima.Location = new Point(24, 120);
        txtAsistenciaMinima.Name = "txtAsistenciaMinima";
        txtAsistenciaMinima.Size = new Size(264, 28);
        txtAsistenciaMinima.TabIndex = 7;
        txtAsistenciaMinima.ReadOnly = true;
        txtAsistenciaMinima.TabStop = false;
        // lbl8
        lbl8.Location = new Point(312, 96);
        lbl8.Name = "lbl8";
        lbl8.Size = new Size(260, 22);
        lbl8.TabIndex = 8;
        lbl8.Text = "Nota mínima";
        lbl8.AutoSize = false;
        // txtNotaMinima
        txtNotaMinima.Location = new Point(312, 120);
        txtNotaMinima.Name = "txtNotaMinima";
        txtNotaMinima.Size = new Size(264, 28);
        txtNotaMinima.TabIndex = 9;
        txtNotaMinima.ReadOnly = true;
        txtNotaMinima.TabStop = false;
        // lbl10
        lbl10.Location = new Point(24, 168);
        lbl10.Name = "lbl10";
        lbl10.Size = new Size(840, 22);
        lbl10.TabIndex = 10;
        lbl10.Text = "Resultados de participantes";
        lbl10.AutoSize = false;
        // dgvResultados
        dgvResultados.Location = new Point(24, 194);
        dgvResultados.Name = "dgvResultados";
        dgvResultados.Size = new Size(840, 210);
        dgvResultados.TabIndex = 11;
        dgvResultados.AllowUserToAddRows = false;
        dgvResultados.AllowUserToDeleteRows = false;
        dgvResultados.ReadOnly = true;
        dgvResultados.RowHeadersVisible = false;
        dgvResultados.MultiSelect = false;
        dgvResultados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvResultados.BackgroundColor = SystemColors.Window;
        dgvResultados.BorderStyle = BorderStyle.FixedSingle;
        dgvResultados.ColumnHeadersHeight = 32;
        dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dgvResultados.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        dgvResultados.Columns.AddRange(new DataGridViewColumn[] { dgvResultadosCol0, dgvResultadosCol1, dgvResultadosCol2, dgvResultadosCol3, dgvResultadosCol4, dgvResultadosCol5 });
        dgvResultadosCol0.HeaderText = "Legajo";
        dgvResultadosCol0.Name = "dgvResultadosCol0";
        dgvResultadosCol0.ReadOnly = true;
        dgvResultadosCol1.HeaderText = "Empleado";
        dgvResultadosCol1.Name = "dgvResultadosCol1";
        dgvResultadosCol1.ReadOnly = true;
        dgvResultadosCol2.HeaderText = "Asistencia (%)";
        dgvResultadosCol2.Name = "dgvResultadosCol2";
        dgvResultadosCol2.ReadOnly = true;
        dgvResultadosCol3.HeaderText = "Nota final";
        dgvResultadosCol3.Name = "dgvResultadosCol3";
        dgvResultadosCol3.ReadOnly = true;
        dgvResultadosCol4.HeaderText = "Resultado";
        dgvResultadosCol4.Name = "dgvResultadosCol4";
        dgvResultadosCol4.ReadOnly = true;
        dgvResultadosCol5.HeaderText = "Certificado";
        dgvResultadosCol5.Name = "dgvResultadosCol5";
        dgvResultadosCol5.ReadOnly = true;
        // btnSeleccionar
        btnSeleccionar.Location = new Point(24, 416);
        btnSeleccionar.Name = "btnSeleccionar";
        btnSeleccionar.Size = new Size(218, 32);
        btnSeleccionar.TabIndex = 12;
        btnSeleccionar.Text = "Seleccionar participante";
        btnSeleccionar.UseVisualStyleBackColor = true;
        // lbl13
        lbl13.Location = new Point(24, 466);
        lbl13.Name = "lbl13";
        lbl13.Size = new Size(260, 22);
        lbl13.TabIndex = 13;
        lbl13.Text = "Empleado seleccionado";
        lbl13.AutoSize = false;
        // txtEmpleado
        txtEmpleado.Location = new Point(24, 490);
        txtEmpleado.Name = "txtEmpleado";
        txtEmpleado.Size = new Size(264, 28);
        txtEmpleado.TabIndex = 14;
        txtEmpleado.ReadOnly = true;
        txtEmpleado.TabStop = false;
        // lbl15
        lbl15.Location = new Point(312, 466);
        lbl15.Name = "lbl15";
        lbl15.Size = new Size(260, 22);
        lbl15.TabIndex = 15;
        lbl15.Text = "Certificado N.º";
        lbl15.AutoSize = false;
        // txtCertificado
        txtCertificado.Location = new Point(312, 490);
        txtCertificado.Name = "txtCertificado";
        txtCertificado.Size = new Size(264, 28);
        txtCertificado.TabIndex = 16;
        // chkCumpleRequisitos
        chkCumpleRequisitos.Location = new Point(24, 538);
        chkCumpleRequisitos.Name = "chkCumpleRequisitos";
        chkCumpleRequisitos.Size = new Size(840, 28);
        chkCumpleRequisitos.TabIndex = 17;
        chkCumpleRequisitos.Text = "Cumple los requisitos de aprobación";
        chkCumpleRequisitos.UseVisualStyleBackColor = true;
        chkCumpleRequisitos.AutoCheck = false;
        // btnCancelar
        btnCancelar.Location = new Point(754, 592);
        btnCancelar.Name = "btnCancelar";
        btnCancelar.Size = new Size(110, 34);
        btnCancelar.TabIndex = 18;
        btnCancelar.Text = "Cancelar";
        btnCancelar.UseVisualStyleBackColor = true;
        btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        // btnEmitir
        btnEmitir.Location = new Point(576, 592);
        btnEmitir.Name = "btnEmitir";
        btnEmitir.Size = new Size(168, 34);
        btnEmitir.TabIndex = 19;
        btnEmitir.Text = "Emitir certificado";
        btnEmitir.UseVisualStyleBackColor = true;
        btnEmitir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoScroll = true;
        ClientSize = new Size(888, 656);
        Controls.Add(lbl0);
        Controls.Add(cboCurso);
        Controls.Add(lbl2);
        Controls.Add(dtpEmision);
        Controls.Add(lbl4);
        Controls.Add(txtInstructor);
        Controls.Add(lbl6);
        Controls.Add(txtAsistenciaMinima);
        Controls.Add(lbl8);
        Controls.Add(txtNotaMinima);
        Controls.Add(lbl10);
        Controls.Add(dgvResultados);
        Controls.Add(btnSeleccionar);
        Controls.Add(lbl13);
        Controls.Add(txtEmpleado);
        Controls.Add(lbl15);
        Controls.Add(txtCertificado);
        Controls.Add(chkCumpleRequisitos);
        Controls.Add(btnCancelar);
        Controls.Add(btnEmitir);
        MinimumSize = new Size(904, 695);
        Name = "FrmEmisionCertificados";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Emisión de certificados - Talentum S.A.";
        ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lbl0;
    private ComboBox cboCurso;
    private Label lbl2;
    private DateTimePicker dtpEmision;
    private Label lbl4;
    private TextBox txtInstructor;
    private Label lbl6;
    private TextBox txtAsistenciaMinima;
    private Label lbl8;
    private TextBox txtNotaMinima;
    private Label lbl10;
    private DataGridView dgvResultados;
    private Button btnSeleccionar;
    private Label lbl13;
    private TextBox txtEmpleado;
    private Label lbl15;
    private TextBox txtCertificado;
    private CheckBox chkCumpleRequisitos;
    private Button btnCancelar;
    private Button btnEmitir;
    private DataGridViewTextBoxColumn dgvResultadosCol0;
    private DataGridViewTextBoxColumn dgvResultadosCol1;
    private DataGridViewTextBoxColumn dgvResultadosCol2;
    private DataGridViewTextBoxColumn dgvResultadosCol3;
    private DataGridViewTextBoxColumn dgvResultadosCol4;
    private DataGridViewTextBoxColumn dgvResultadosCol5;
}
