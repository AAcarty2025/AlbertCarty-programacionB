namespace Examen_Cafeteria_Albert
{
    partial class frmPedidos
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblEncabezado;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code


        private void InitializeComponent()
        {
            Label lblEncabezado;
            Label lblItbis;
            TxtCliente = new TextBox();
            dtpFecha = new DateTimePicker();
            checkBox1 = new CheckBox();
            txtProducto = new TextBox();
            txtPrecio = new TextBox();
            nudCantidad = new NumericUpDown();
            grBx1 = new GroupBox();
            rbtGrande = new RadioButton();
            rbtNormal = new RadioButton();
            ChkFrecuente = new CheckBox();
            grBx2 = new GroupBox();
            rbtLlevar = new RadioButton();
            rbtLocal = new RadioButton();
            lblTotal = new Label();
            lstPedido = new ListBox();
            lblSubtotal = new Label();
            lblDescuento = new Label();
            lblEmpaque = new Label();
            btnCalcular = new Button();
            btnAgregar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            lblEncabezado = new Label();
            lblItbis = new Label();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            grBx1.SuspendLayout();
            grBx2.SuspendLayout();
            SuspendLayout();
            // 
            // lblEncabezado
            // 
            lblEncabezado.AutoSize = true;
            lblEncabezado.Location = new Point(758, 87);
            lblEncabezado.Name = "lblEncabezado";
            lblEncabezado.Size = new Size(113, 25);
            lblEncabezado.TabIndex = 11;
            lblEncabezado.Text = "Emcabezado";
            lblEncabezado.Click += label2_Click;
            // 
            // lblItbis
            // 
            lblItbis.AutoSize = true;
            lblItbis.Location = new Point(1041, 457);
            lblItbis.Name = "lblItbis";
            lblItbis.Size = new Size(59, 25);
            lblItbis.TabIndex = 15;
            lblItbis.Text = "label6";
            // 
            // TxtCliente
            // 
            TxtCliente.Location = new Point(194, 12);
            TxtCliente.Name = "TxtCliente";
            TxtCliente.Size = new Size(296, 31);
            TxtCliente.TabIndex = 0;
            TxtCliente.TextAlign = HorizontalAlignment.Right;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(194, 113);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(296, 31);
            dtpFecha.TabIndex = 1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(20, 470);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(162, 29);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "chkPorcionExtra";
            checkBox1.TextAlign = ContentAlignment.MiddleRight;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(194, 162);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(296, 31);
            txtProducto.TabIndex = 3;
            txtProducto.TextAlign = HorizontalAlignment.Right;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(194, 211);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(296, 31);
            txtPrecio.TabIndex = 4;
            txtPrecio.TextAlign = HorizontalAlignment.Right;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(194, 264);
            nudCantidad.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(296, 31);
            nudCantidad.TabIndex = 5;
            nudCantidad.TextAlign = HorizontalAlignment.Right;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // grBx1
            // 
            grBx1.Controls.Add(rbtGrande);
            grBx1.Controls.Add(rbtNormal);
            grBx1.Location = new Point(5, 316);
            grBx1.Name = "grBx1";
            grBx1.Size = new Size(300, 138);
            grBx1.TabIndex = 6;
            grBx1.TabStop = false;
            // 
            // rbtGrande
            // 
            rbtGrande.AutoSize = true;
            rbtGrande.Location = new Point(6, 76);
            rbtGrande.Name = "rbtGrande";
            rbtGrande.Size = new Size(170, 29);
            rbtGrande.TabIndex = 1;
            rbtGrande.TabStop = true;
            rbtGrande.Text = "Grande(+RD$25)";
            rbtGrande.UseVisualStyleBackColor = true;
            // 
            // rbtNormal
            // 
            rbtNormal.AutoSize = true;
            rbtNormal.Location = new Point(6, 41);
            rbtNormal.Name = "rbtNormal";
            rbtNormal.Size = new Size(96, 29);
            rbtNormal.TabIndex = 0;
            rbtNormal.TabStop = true;
            rbtNormal.Text = "Normal";
            rbtNormal.UseVisualStyleBackColor = true;
            // 
            // ChkFrecuente
            // 
            ChkFrecuente.AutoSize = true;
            ChkFrecuente.Location = new Point(194, 64);
            ChkFrecuente.Name = "ChkFrecuente";
            ChkFrecuente.Size = new Size(172, 29);
            ChkFrecuente.TabIndex = 7;
            ChkFrecuente.Text = "Cliente Frecuente";
            ChkFrecuente.UseVisualStyleBackColor = true;
            // 
            // grBx2
            // 
            grBx2.Controls.Add(rbtLlevar);
            grBx2.Controls.Add(rbtLocal);
            grBx2.Location = new Point(323, 316);
            grBx2.Name = "grBx2";
            grBx2.Size = new Size(278, 138);
            grBx2.TabIndex = 8;
            grBx2.TabStop = false;
            // 
            // rbtLlevar
            // 
            rbtLlevar.AutoSize = true;
            rbtLlevar.Location = new Point(19, 76);
            rbtLlevar.Name = "rbtLlevar";
            rbtLlevar.Size = new Size(192, 29);
            rbtLlevar.TabIndex = 1;
            rbtLlevar.TabStop = true;
            rbtLlevar.Text = "Para llevar(+RD$20)";
            rbtLlevar.UseVisualStyleBackColor = true;
            // 
            // rbtLocal
            // 
            rbtLocal.AutoSize = true;
            rbtLocal.Location = new Point(19, 30);
            rbtLocal.Name = "rbtLocal";
            rbtLocal.Size = new Size(178, 29);
            rbtLocal.TabIndex = 0;
            rbtLocal.TabStop = true;
            rbtLocal.Text = "Consumir en local";
            rbtLocal.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(1041, 498);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(59, 25);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "label1";
            // 
            // lstPedido
            // 
            lstPedido.FormattingEnabled = true;
            lstPedido.Location = new Point(758, 137);
            lstPedido.Name = "lstPedido";
            lstPedido.Size = new Size(336, 179);
            lstPedido.TabIndex = 10;
            lstPedido.SelectedIndexChanged += lstPedido_SelectedIndexChanged;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(1041, 346);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(59, 25);
            lblSubtotal.TabIndex = 12;
            lblSubtotal.Text = "label3";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(1041, 381);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(59, 25);
            lblDescuento.TabIndex = 13;
            lblDescuento.Text = "label4";
            // 
            // lblEmpaque
            // 
            lblEmpaque.AutoSize = true;
            lblEmpaque.Location = new Point(1041, 416);
            lblEmpaque.Name = "lblEmpaque";
            lblEmpaque.Size = new Size(59, 25);
            lblEmpaque.TabIndex = 14;
            lblEmpaque.Text = "label5";
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold | FontStyle.Italic);
            btnCalcular.Location = new Point(239, 485);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(176, 72);
            btnCalcular.TabIndex = 16;
            btnCalcular.Text = "Calcular Total";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(758, 12);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(390, 72);
            btnAgregar.TabIndex = 17;
            btnAgregar.Text = "Agregar al pedido";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold | FontStyle.Italic);
            btnLimpiar.Location = new Point(457, 485);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(209, 72);
            btnLimpiar.TabIndex = 18;
            btnLimpiar.Text = "Nuevo Pedido";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold | FontStyle.Italic);
            btnSalir.Location = new Point(692, 485);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(140, 72);
            btnSalir.TabIndex = 19;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            label1.Location = new Point(853, 341);
            label1.Name = "label1";
            label1.Size = new Size(105, 30);
            label1.TabIndex = 20;
            label1.Text = "Subtotal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            label2.Location = new Point(853, 376);
            label2.Name = "label2";
            label2.Size = new Size(127, 30);
            label2.TabIndex = 21;
            label2.Text = "Descuento";
            label2.Click += label2_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            label3.Location = new Point(853, 416);
            label3.Name = "label3";
            label3.Size = new Size(112, 30);
            label3.TabIndex = 22;
            label3.Text = "Empaque";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            label4.Location = new Point(853, 452);
            label4.Name = "label4";
            label4.Size = new Size(124, 30);
            label4.TabIndex = 23;
            label4.Text = "Itbis(18%)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            label5.Location = new Point(853, 493);
            label5.Name = "label5";
            label5.Size = new Size(155, 30);
            label5.TabIndex = 24;
            label5.Text = "Total a Pagar";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 12);
            label6.Name = "label6";
            label6.Size = new Size(65, 25);
            label6.TabIndex = 25;
            label6.Text = "Cliente";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 119);
            label7.Name = "label7";
            label7.Size = new Size(48, 25);
            label7.TabIndex = 26;
            label7.Text = "Fech";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(28, 168);
            label8.Name = "label8";
            label8.Size = new Size(85, 25);
            label8.TabIndex = 27;
            label8.Text = "Producto";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(28, 217);
            label9.Name = "label9";
            label9.Size = new Size(60, 25);
            label9.TabIndex = 28;
            label9.Text = "Precio";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(33, 267);
            label10.Name = "label10";
            label10.Size = new Size(83, 25);
            label10.TabIndex = 29;
            label10.Text = "Cantidad";
            // 
            // frmPedidos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1228, 609);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAgregar);
            Controls.Add(btnCalcular);
            Controls.Add(lblItbis);
            Controls.Add(lblEmpaque);
            Controls.Add(lblDescuento);
            Controls.Add(lblSubtotal);
            Controls.Add(lblEncabezado);
            Controls.Add(lstPedido);
            Controls.Add(lblTotal);
            Controls.Add(grBx2);
            Controls.Add(ChkFrecuente);
            Controls.Add(grBx1);
            Controls.Add(nudCantidad);
            Controls.Add(txtPrecio);
            Controls.Add(txtProducto);
            Controls.Add(checkBox1);
            Controls.Add(dtpFecha);
            Controls.Add(TxtCliente);
            Name = "frmPedidos";
            Text = "Cafeteria";
            Load += frmPedidos_Load;
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            grBx1.ResumeLayout(false);
            grBx1.PerformLayout();
            grBx2.ResumeLayout(false);
            grBx2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtCliente;
        private DateTimePicker dtpFecha;
        private CheckBox checkBox1;
        private TextBox txtProducto;
        private TextBox txtPrecio;
        private NumericUpDown nudCantidad;
        private GroupBox grBx1;
        private RadioButton rbtGrande;
        private RadioButton rbtNormal;
        private CheckBox ChkFrecuente;
        private GroupBox grBx2;
        private RadioButton rbtLlevar;
        private RadioButton rbtLocal;
        private Label lblTotal;
        private ListBox lstPedido;
        private Label lblSubtotal;
        private Label lblDescuento;
        private Label lblEmpaque;
        private Label lblItbis;
        private Button btnCalcular;
        private Button btnAgregar;
        private Button btnLimpiar;
        private Button btnSalir;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}
