namespace CAI.TALENTUM;

partial class InicioForm1
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
        lblEmpresa = new Label();
        lblSubtitulo = new Label();
        btnPlanificacion = new Button();
        btnInscripcion = new Button();
        btnAsistencia = new Button();
        btnCertificados = new Button();
        btnHistorial = new Button();
        btnSalir = new Button();
        SuspendLayout();
        // lblEmpresa
        lblEmpresa.Location = new Point(24, 36);
        lblEmpresa.Name = "lblEmpresa";
        lblEmpresa.Size = new Size(840, 54);
        lblEmpresa.TabIndex = 0;
        lblEmpresa.Text = "Talentum S.A.";
        lblEmpresa.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
        lblEmpresa.TextAlign = ContentAlignment.MiddleCenter;
        lblEmpresa.AutoSize = false;
        // lblSubtitulo
        lblSubtitulo.Location = new Point(24, 98);
        lblSubtitulo.Name = "lblSubtitulo";
        lblSubtitulo.Size = new Size(840, 28);
        lblSubtitulo.TabIndex = 1;
        lblSubtitulo.Text = "Gestión de capacitaciones corporativas";
        lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
        lblSubtitulo.AutoSize = false;
        // btnPlanificacion
        btnPlanificacion.Location = new Point(204, 154);
        btnPlanificacion.Name = "btnPlanificacion";
        btnPlanificacion.Size = new Size(480, 46);
        btnPlanificacion.TabIndex = 2;
        btnPlanificacion.Text = "Planificación de cursos y sesiones";
        btnPlanificacion.UseVisualStyleBackColor = true;
        btnPlanificacion.Font = new Font("Segoe UI", 11F);
        // btnInscripcion
        btnInscripcion.Location = new Point(204, 218);
        btnInscripcion.Name = "btnInscripcion";
        btnInscripcion.Size = new Size(480, 46);
        btnInscripcion.TabIndex = 3;
        btnInscripcion.Text = "Inscripción a capacitaciones";
        btnInscripcion.UseVisualStyleBackColor = true;
        btnInscripcion.Font = new Font("Segoe UI", 11F);
        // btnAsistencia
        btnAsistencia.Location = new Point(204, 282);
        btnAsistencia.Name = "btnAsistencia";
        btnAsistencia.Size = new Size(480, 46);
        btnAsistencia.TabIndex = 4;
        btnAsistencia.Text = "Asistencia y calificaciones";
        btnAsistencia.UseVisualStyleBackColor = true;
        btnAsistencia.Font = new Font("Segoe UI", 11F);
        // btnCertificados
        btnCertificados.Location = new Point(204, 346);
        btnCertificados.Name = "btnCertificados";
        btnCertificados.Size = new Size(480, 46);
        btnCertificados.TabIndex = 5;
        btnCertificados.Text = "Emisión de certificados";
        btnCertificados.UseVisualStyleBackColor = true;
        btnCertificados.Font = new Font("Segoe UI", 11F);
        // btnHistorial
        btnHistorial.Location = new Point(204, 410);
        btnHistorial.Name = "btnHistorial";
        btnHistorial.Size = new Size(480, 46);
        btnHistorial.TabIndex = 6;
        btnHistorial.Text = "Historial de formación";
        btnHistorial.UseVisualStyleBackColor = true;
        btnHistorial.Font = new Font("Segoe UI", 11F);
        // btnSalir
        btnSalir.Location = new Point(754, 502);
        btnSalir.Name = "btnSalir";
        btnSalir.Size = new Size(110, 34);
        btnSalir.TabIndex = 7;
        btnSalir.Text = "Salir";
        btnSalir.UseVisualStyleBackColor = true;
        btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoScroll = true;
        ClientSize = new Size(888, 566);
        Controls.Add(lblEmpresa);
        Controls.Add(lblSubtitulo);
        Controls.Add(btnPlanificacion);
        Controls.Add(btnInscripcion);
        Controls.Add(btnAsistencia);
        Controls.Add(btnCertificados);
        Controls.Add(btnHistorial);
        Controls.Add(btnSalir);
        MinimumSize = new Size(904, 605);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Inicio - Talentum S.A.";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblEmpresa;
    private Label lblSubtitulo;
    private Button btnPlanificacion;
    private Button btnInscripcion;
    private Button btnAsistencia;
    private Button btnCertificados;
    private Button btnHistorial;
    private Button btnSalir;
}
