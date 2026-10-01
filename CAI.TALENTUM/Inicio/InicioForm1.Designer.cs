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
        btnPlanificacion = new Button();
        btnInscripcion = new Button();
        btnAsistencia = new Button();
        btnCertificados = new Button();
        btnHistorial = new Button();
        btnSalir = new Button();
        SuspendLayout();
        // 
        // lblEmpresa
        // 
        lblEmpresa.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
        lblEmpresa.Location = new Point(24, 36);
        lblEmpresa.Name = "lblEmpresa";
        lblEmpresa.Size = new Size(840, 54);
        lblEmpresa.TabIndex = 0;
        lblEmpresa.Text = "Talentum S.A.";
        lblEmpresa.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // btnPlanificacion
        // 
        btnPlanificacion.Font = new Font("Segoe UI", 11F);
        btnPlanificacion.Location = new Point(204, 154);
        btnPlanificacion.Name = "btnPlanificacion";
        btnPlanificacion.Size = new Size(480, 46);
        btnPlanificacion.TabIndex = 2;
        btnPlanificacion.Text = "Planificación de cursos y sesiones";
        btnPlanificacion.UseVisualStyleBackColor = true;
        // 
        // btnInscripcion
        // 
        btnInscripcion.Font = new Font("Segoe UI", 11F);
        btnInscripcion.Location = new Point(204, 218);
        btnInscripcion.Name = "btnInscripcion";
        btnInscripcion.Size = new Size(480, 46);
        btnInscripcion.TabIndex = 3;
        btnInscripcion.Text = "Inscripción a capacitaciones";
        btnInscripcion.UseVisualStyleBackColor = true;
        // 
        // btnAsistencia
        // 
        btnAsistencia.Font = new Font("Segoe UI", 11F);
        btnAsistencia.Location = new Point(204, 282);
        btnAsistencia.Name = "btnAsistencia";
        btnAsistencia.Size = new Size(480, 46);
        btnAsistencia.TabIndex = 4;
        btnAsistencia.Text = "Asistencia y calificaciones";
        btnAsistencia.UseVisualStyleBackColor = true;
        // 
        // btnCertificados
        // 
        btnCertificados.Font = new Font("Segoe UI", 11F);
        btnCertificados.Location = new Point(204, 346);
        btnCertificados.Name = "btnCertificados";
        btnCertificados.Size = new Size(480, 46);
        btnCertificados.TabIndex = 5;
        btnCertificados.Text = "Emisión de certificados";
        btnCertificados.UseVisualStyleBackColor = true;
        // 
        // btnHistorial
        // 
        btnHistorial.Font = new Font("Segoe UI", 11F);
        btnHistorial.Location = new Point(204, 410);
        btnHistorial.Name = "btnHistorial";
        btnHistorial.Size = new Size(480, 46);
        btnHistorial.TabIndex = 6;
        btnHistorial.Text = "Historial de formación";
        btnHistorial.UseVisualStyleBackColor = true;
        // 
        // btnSalir
        // 
        btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnSalir.Location = new Point(754, 502);
        btnSalir.Name = "btnSalir";
        btnSalir.Size = new Size(110, 34);
        btnSalir.TabIndex = 7;
        btnSalir.Text = "Salir";
        btnSalir.UseVisualStyleBackColor = true;
        // 
        // InicioForm1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoScroll = true;
        ClientSize = new Size(888, 566);
        Controls.Add(lblEmpresa);
        Controls.Add(btnPlanificacion);
        Controls.Add(btnInscripcion);
        Controls.Add(btnAsistencia);
        Controls.Add(btnCertificados);
        Controls.Add(btnHistorial);
        Controls.Add(btnSalir);
        MinimumSize = new Size(904, 605);
        Name = "InicioForm1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Inicio - Talentum S.A.";
        ResumeLayout(false);
    }

    #endregion

    private Label lblEmpresa;
    private Button btnPlanificacion;
    private Button btnInscripcion;
    private Button btnAsistencia;
    private Button btnCertificados;
    private Button btnHistorial;
    private Button btnSalir;
}
