namespace CAI.TALENTUM;

partial class FrmHistorialFormacion
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
        txtLegajo = new TextBox();
        lbl2 = new Label();
        txtBusqueda = new TextBox();
        lbl4 = new Label();
        cboArea = new ComboBox();
        btnBuscar = new Button();
        lbl7 = new Label();
        txtEmpleado = new TextBox();
        lbl9 = new Label();
        txtPerfil = new TextBox();
        lbl11 = new Label();
        dgvHistorial = new DataGridView();
        btnVerCertificado = new Button();
        lbl14 = new Label();
        txtHorasAprobadas = new TextBox();
        btnCerrar = new Button();
        dgvHistorialCol0 = new DataGridViewTextBoxColumn();
        dgvHistorialCol1 = new DataGridViewTextBoxColumn();
        dgvHistorialCol2 = new DataGridViewTextBoxColumn();
        dgvHistorialCol3 = new DataGridViewTextBoxColumn();
        dgvHistorialCol4 = new DataGridViewTextBoxColumn();
        dgvHistorialCol5 = new DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
        SuspendLayout();
        // lbl0
        lbl0.Location = new Point(24, 24);
        lbl0.Name = "lbl0";
        lbl0.Size = new Size(260, 22);
        lbl0.TabIndex = 0;
        lbl0.Text = "Legajo";
        lbl0.AutoSize = false;
        // txtLegajo
        txtLegajo.Location = new Point(24, 48);
        txtLegajo.Name = "txtLegajo";
        txtLegajo.Size = new Size(264, 28);
        txtLegajo.TabIndex = 1;
        // lbl2
        lbl2.Location = new Point(312, 24);
        lbl2.Name = "lbl2";
        lbl2.Size = new Size(260, 22);
        lbl2.TabIndex = 2;
        lbl2.Text = "Apellido y nombre";
        lbl2.AutoSize = false;
        // txtBusqueda
        txtBusqueda.Location = new Point(312, 48);
        txtBusqueda.Name = "txtBusqueda";
        txtBusqueda.Size = new Size(264, 28);
        txtBusqueda.TabIndex = 3;
        // lbl4
        lbl4.Location = new Point(600, 24);
        lbl4.Name = "lbl4";
        lbl4.Size = new Size(260, 22);
        lbl4.TabIndex = 4;
        lbl4.Text = "Área";
        lbl4.AutoSize = false;
        // cboArea
        cboArea.Location = new Point(600, 48);
        cboArea.Name = "cboArea";
        cboArea.Size = new Size(264, 28);
        cboArea.TabIndex = 5;
        cboArea.DropDownStyle = ComboBoxStyle.DropDownList;
        cboArea.FormattingEnabled = true;
        // btnBuscar
        btnBuscar.Location = new Point(24, 96);
        btnBuscar.Name = "btnBuscar";
        btnBuscar.Size = new Size(146, 32);
        btnBuscar.TabIndex = 6;
        btnBuscar.Text = "Buscar empleado";
        btnBuscar.UseVisualStyleBackColor = true;
        // lbl7
        lbl7.Location = new Point(24, 146);
        lbl7.Name = "lbl7";
        lbl7.Size = new Size(260, 22);
        lbl7.TabIndex = 7;
        lbl7.Text = "Empleado seleccionado";
        lbl7.AutoSize = false;
        // txtEmpleado
        txtEmpleado.Location = new Point(24, 170);
        txtEmpleado.Name = "txtEmpleado";
        txtEmpleado.Size = new Size(264, 28);
        txtEmpleado.TabIndex = 8;
        txtEmpleado.ReadOnly = true;
        txtEmpleado.TabStop = false;
        // lbl9
        lbl9.Location = new Point(312, 146);
        lbl9.Name = "lbl9";
        lbl9.Size = new Size(260, 22);
        lbl9.TabIndex = 9;
        lbl9.Text = "Perfil";
        lbl9.AutoSize = false;
        // txtPerfil
        txtPerfil.Location = new Point(312, 170);
        txtPerfil.Name = "txtPerfil";
        txtPerfil.Size = new Size(264, 28);
        txtPerfil.TabIndex = 10;
        txtPerfil.ReadOnly = true;
        txtPerfil.TabStop = false;
        // lbl11
        lbl11.Location = new Point(24, 218);
        lbl11.Name = "lbl11";
        lbl11.Size = new Size(840, 22);
        lbl11.TabIndex = 11;
        lbl11.Text = "Formación del empleado";
        lbl11.AutoSize = false;
        // dgvHistorial
        dgvHistorial.Location = new Point(24, 244);
        dgvHistorial.Name = "dgvHistorial";
        dgvHistorial.Size = new Size(840, 230);
        dgvHistorial.TabIndex = 12;
        dgvHistorial.AllowUserToAddRows = false;
        dgvHistorial.AllowUserToDeleteRows = false;
        dgvHistorial.ReadOnly = true;
        dgvHistorial.RowHeadersVisible = false;
        dgvHistorial.MultiSelect = false;
        dgvHistorial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvHistorial.BackgroundColor = SystemColors.Window;
        dgvHistorial.BorderStyle = BorderStyle.FixedSingle;
        dgvHistorial.ColumnHeadersHeight = 32;
        dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dgvHistorial.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        dgvHistorial.Columns.AddRange(new DataGridViewColumn[] { dgvHistorialCol0, dgvHistorialCol1, dgvHistorialCol2, dgvHistorialCol3, dgvHistorialCol4, dgvHistorialCol5 });
        dgvHistorialCol0.HeaderText = "Curso";
        dgvHistorialCol0.Name = "dgvHistorialCol0";
        dgvHistorialCol0.ReadOnly = true;
        dgvHistorialCol1.HeaderText = "Finalización";
        dgvHistorialCol1.Name = "dgvHistorialCol1";
        dgvHistorialCol1.ReadOnly = true;
        dgvHistorialCol2.HeaderText = "Horas";
        dgvHistorialCol2.Name = "dgvHistorialCol2";
        dgvHistorialCol2.ReadOnly = true;
        dgvHistorialCol3.HeaderText = "Asistencia (%)";
        dgvHistorialCol3.Name = "dgvHistorialCol3";
        dgvHistorialCol3.ReadOnly = true;
        dgvHistorialCol4.HeaderText = "Nota";
        dgvHistorialCol4.Name = "dgvHistorialCol4";
        dgvHistorialCol4.ReadOnly = true;
        dgvHistorialCol5.HeaderText = "Estado";
        dgvHistorialCol5.Name = "dgvHistorialCol5";
        dgvHistorialCol5.ReadOnly = true;
        // btnVerCertificado
        btnVerCertificado.Location = new Point(24, 486);
        btnVerCertificado.Name = "btnVerCertificado";
        btnVerCertificado.Size = new Size(146, 32);
        btnVerCertificado.TabIndex = 13;
        btnVerCertificado.Text = "Ver certificado";
        btnVerCertificado.UseVisualStyleBackColor = true;
        // lbl14
        lbl14.Location = new Point(24, 536);
        lbl14.Name = "lbl14";
        lbl14.Size = new Size(260, 22);
        lbl14.TabIndex = 14;
        lbl14.Text = "Horas de formación aprobadas";
        lbl14.AutoSize = false;
        // txtHorasAprobadas
        txtHorasAprobadas.Location = new Point(24, 560);
        txtHorasAprobadas.Name = "txtHorasAprobadas";
        txtHorasAprobadas.Size = new Size(264, 28);
        txtHorasAprobadas.TabIndex = 15;
        txtHorasAprobadas.ReadOnly = true;
        txtHorasAprobadas.TabStop = false;
        // btnCerrar
        btnCerrar.Location = new Point(754, 620);
        btnCerrar.Name = "btnCerrar";
        btnCerrar.Size = new Size(110, 34);
        btnCerrar.TabIndex = 16;
        btnCerrar.Text = "Cerrar";
        btnCerrar.UseVisualStyleBackColor = true;
        btnCerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoScroll = true;
        ClientSize = new Size(888, 684);
        Controls.Add(lbl0);
        Controls.Add(txtLegajo);
        Controls.Add(lbl2);
        Controls.Add(txtBusqueda);
        Controls.Add(lbl4);
        Controls.Add(cboArea);
        Controls.Add(btnBuscar);
        Controls.Add(lbl7);
        Controls.Add(txtEmpleado);
        Controls.Add(lbl9);
        Controls.Add(txtPerfil);
        Controls.Add(lbl11);
        Controls.Add(dgvHistorial);
        Controls.Add(btnVerCertificado);
        Controls.Add(lbl14);
        Controls.Add(txtHorasAprobadas);
        Controls.Add(btnCerrar);
        MinimumSize = new Size(904, 723);
        Name = "FrmHistorialFormacion";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Historial de formación - Talentum S.A.";
        ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lbl0;
    private TextBox txtLegajo;
    private Label lbl2;
    private TextBox txtBusqueda;
    private Label lbl4;
    private ComboBox cboArea;
    private Button btnBuscar;
    private Label lbl7;
    private TextBox txtEmpleado;
    private Label lbl9;
    private TextBox txtPerfil;
    private Label lbl11;
    private DataGridView dgvHistorial;
    private Button btnVerCertificado;
    private Label lbl14;
    private TextBox txtHorasAprobadas;
    private Button btnCerrar;
    private DataGridViewTextBoxColumn dgvHistorialCol0;
    private DataGridViewTextBoxColumn dgvHistorialCol1;
    private DataGridViewTextBoxColumn dgvHistorialCol2;
    private DataGridViewTextBoxColumn dgvHistorialCol3;
    private DataGridViewTextBoxColumn dgvHistorialCol4;
    private DataGridViewTextBoxColumn dgvHistorialCol5;
}
