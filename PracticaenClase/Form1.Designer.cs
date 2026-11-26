namespace Calificaciones
{
    partial class Form1
    { 
        private System.ComponentModel.IContainer components = null;

     
        /// <param name="disposing"> 
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtEstudiante = new TextBox();
            cmbAsignatura = new ComboBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            rdbVespertina = new RadioButton();
            rdbMatutina = new RadioButton();
            groupBox2 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            btnRegistrar = new Button();
            chkAsistencia = new CheckBox();
            txtP4 = new TextBox();
            txtP3 = new TextBox();
            txtP2 = new TextBox();
            txtP1 = new TextBox();
            btnResumen = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            groupBox3 = new GroupBox();
            lstBoletin = new ListBox();
            groupBox4 = new GroupBox();
            lblSituacion = new Label();
            lblReprobadas = new Label();
            lblRecuperacion = new Label();
            lblAprobadas = new Label();
            lblPromedioGeneral = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // txtEstudiante
            // 
            txtEstudiante.Location = new Point(162, 45);
            txtEstudiante.Name = "txtEstudiante";
            txtEstudiante.Size = new Size(230, 31);
            txtEstudiante.TabIndex = 0;
            // 
            // cmbAsignatura
            // 
            cmbAsignatura.FormattingEnabled = true;
            cmbAsignatura.Items.AddRange(new object[] { "Lengua Espa;ola", "Matematicas", "Ciencias Sociales", "Ciencias Naturales" });
            cmbAsignatura.Location = new Point(143, 39);
            cmbAsignatura.Name = "cmbAsignatura";
            cmbAsignatura.Size = new Size(308, 33);
            cmbAsignatura.TabIndex = 1;
            cmbAsignatura.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(rdbVespertina);
            groupBox1.Controls.Add(rdbMatutina);
            groupBox1.Controls.Add(txtEstudiante);
            groupBox1.Location = new Point(32, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(505, 197);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Calificaciones";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 132);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 6;
            label2.Text = "Tanda";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 45);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // rdbVespertina
            // 
            rdbVespertina.AutoSize = true;
            rdbVespertina.Location = new Point(254, 132);
            rdbVespertina.Name = "rdbVespertina";
            rdbVespertina.Size = new Size(119, 29);
            rdbVespertina.TabIndex = 5;
            rdbVespertina.TabStop = true;
            rdbVespertina.Text = "Vespertina";
            rdbVespertina.UseVisualStyleBackColor = true;
            // 
            // rdbMatutina
            // 
            rdbMatutina.AutoSize = true;
            rdbMatutina.Location = new Point(105, 132);
            rdbMatutina.Name = "rdbMatutina";
            rdbMatutina.Size = new Size(107, 29);
            rdbMatutina.TabIndex = 4;
            rdbMatutina.TabStop = true;
            rdbMatutina.Text = "Matutina";
            rdbMatutina.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(btnRegistrar);
            groupBox2.Controls.Add(chkAsistencia);
            groupBox2.Controls.Add(txtP4);
            groupBox2.Controls.Add(txtP3);
            groupBox2.Controls.Add(txtP2);
            groupBox2.Controls.Add(cmbAsignatura);
            groupBox2.Controls.Add(txtP1);
            groupBox2.Location = new Point(32, 300);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(505, 411);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Registro de asignatura";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 102);
            label4.Name = "label4";
            label4.Size = new Size(199, 25);
            label4.TabIndex = 13;
            label4.Text = "Calificacion por Periodo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 42);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 7;
            label3.Text = "label3";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(52, 340);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(378, 34);
            btnRegistrar.TabIndex = 12;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // chkAsistencia
            // 
            chkAsistencia.AutoSize = true;
            chkAsistencia.Location = new Point(16, 266);
            chkAsistencia.Name = "chkAsistencia";
            chkAsistencia.Size = new Size(355, 29);
            chkAsistencia.TabIndex = 4;
            chkAsistencia.Text = "Cumple con la calificacion minima (80%)";
            chkAsistencia.UseVisualStyleBackColor = true;
            // 
            // txtP4
            // 
            txtP4.Location = new Point(372, 164);
            txtP4.Name = "txtP4";
            txtP4.Size = new Size(79, 31);
            txtP4.TabIndex = 11;
            // 
            // txtP3
            // 
            txtP3.Location = new Point(254, 164);
            txtP3.Name = "txtP3";
            txtP3.Size = new Size(79, 31);
            txtP3.TabIndex = 10;
            // 
            // txtP2
            // 
            txtP2.Location = new Point(143, 164);
            txtP2.Name = "txtP2";
            txtP2.Size = new Size(79, 31);
            txtP2.TabIndex = 9;
            // 
            // txtP1
            // 
            txtP1.Location = new Point(16, 164);
            txtP1.Name = "txtP1";
            txtP1.Size = new Size(79, 31);
            txtP1.TabIndex = 7;
            // 
            // btnResumen
            // 
            btnResumen.Location = new Point(105, 773);
            btnResumen.Name = "btnResumen";
            btnResumen.Size = new Size(187, 34);
            btnResumen.TabIndex = 14;
            btnResumen.Text = "Mostrar Resumen";
            btnResumen.UseVisualStyleBackColor = true;
            btnResumen.Click += btnResumen_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(383, 773);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(187, 34);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(641, 773);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(187, 34);
            btnSalir.TabIndex = 16;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lstBoletin);
            groupBox3.Location = new Point(571, 37);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(484, 240);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            groupBox3.Text = "Boletin de estudiante";
            // 
            // lstBoletin
            // 
            lstBoletin.FormattingEnabled = true;
            lstBoletin.Location = new Point(19, 32);
            lstBoletin.Name = "lstBoletin";
            lstBoletin.Size = new Size(445, 179);
            lstBoletin.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lblSituacion);
            groupBox4.Controls.Add(lblReprobadas);
            groupBox4.Controls.Add(lblRecuperacion);
            groupBox4.Controls.Add(lblAprobadas);
            groupBox4.Controls.Add(lblPromedioGeneral);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(label5);
            groupBox4.Location = new Point(571, 314);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(484, 336);
            groupBox4.TabIndex = 18;
            groupBox4.TabStop = false;
            groupBox4.Text = "Resumen";
            // 
            // lblSituacion
            // 
            lblSituacion.AutoSize = true;
            lblSituacion.Location = new Point(252, 280);
            lblSituacion.Name = "lblSituacion";
            lblSituacion.Size = new Size(69, 25);
            lblSituacion.TabIndex = 22;
            lblSituacion.Text = "label14";
            // 
            // lblReprobadas
            // 
            lblReprobadas.AutoSize = true;
            lblReprobadas.Location = new Point(252, 225);
            lblReprobadas.Name = "lblReprobadas";
            lblReprobadas.Size = new Size(25, 25);
            lblReprobadas.TabIndex = 21;
            lblReprobadas.Text = "0";
            // 
            // lblRecuperacion
            // 
            lblRecuperacion.AutoSize = true;
            lblRecuperacion.Location = new Point(252, 174);
            lblRecuperacion.Name = "lblRecuperacion";
            lblRecuperacion.Size = new Size(25, 25);
            lblRecuperacion.TabIndex = 20;
            lblRecuperacion.Text = "0";
            // 
            // lblAprobadas
            // 
            lblAprobadas.AutoSize = true;
            lblAprobadas.Location = new Point(252, 125);
            lblAprobadas.Name = "lblAprobadas";
            lblAprobadas.Size = new Size(25, 25);
            lblAprobadas.TabIndex = 19;
            lblAprobadas.Text = "0";
            // 
            // lblPromedioGeneral
            // 
            lblPromedioGeneral.AutoSize = true;
            lblPromedioGeneral.Location = new Point(252, 79);
            lblPromedioGeneral.Name = "lblPromedioGeneral";
            lblPromedioGeneral.Size = new Size(50, 25);
            lblPromedioGeneral.TabIndex = 14;
            lblPromedioGeneral.Text = "0.00";
            lblPromedioGeneral.Click += lblPromedioGeneral_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 280);
            label9.Name = "label9";
            label9.Size = new Size(88, 25);
            label9.TabIndex = 18;
            label9.Text = "Situacion:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 225);
            label8.Name = "label8";
            label8.Size = new Size(111, 25);
            label8.TabIndex = 17;
            label8.Text = "Reprobadas:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 174);
            label7.Name = "label7";
            label7.Size = new Size(145, 25);
            label7.TabIndex = 16;
            label7.Text = "En Recuperacion:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 125);
            label6.Name = "label6";
            label6.Size = new Size(104, 25);
            label6.TabIndex = 15;
            label6.Text = "Aprobadas:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 79);
            label5.Name = "label5";
            label5.Size = new Size(158, 25);
            label5.TabIndex = 14;
            label5.Text = "Promedio General:";
            label5.Click += label5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 892);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnResumen);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtEstudiante;
        private ComboBox cmbAsignatura;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private RadioButton rdbVespertina;
        private RadioButton rdbMatutina;
        private GroupBox groupBox2;
        private TextBox txtP2;
        private TextBox txtP1;
        private TextBox txtP4;
        private TextBox txtP3;
        private Label label4;
        private Label label3;
        private Button btnRegistrar;
        private CheckBox chkAsistencia;
        private Button btnResumen;
        private Button btnLimpiar;
        private Button btnSalir;
        private GroupBox groupBox3;
        private ListBox lstBoletin;
        private GroupBox groupBox4;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label lblSituacion;
        private Label lblReprobadas;
        private Label lblRecuperacion;
        private Label lblAprobadas;
        private Label lblPromedioGeneral;
    }
}
