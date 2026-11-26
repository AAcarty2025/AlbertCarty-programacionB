namespace Calificaciones
{
    public partial class Form1 : Form
    {
        private const double NOTA_APROBACION = 70;
        private const double NOTA_RECUPERACION = 60;
        private const int CANTIDAD_PERIODOS = 4;

        private double sumaPromedios;
        private int cantidadAsignaturas;
        private int cantidadAprobadas;
        private int cantidadRecuperacion;
        private int cantidadReprobadas;

        public Form1()
        {
            InitializeComponent();
          
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblPromedioGeneral_Click(object sender, EventArgs e)
        {
            double promedio = (double.Parse(txtP1.Text) + double.Parse(txtP2.Text) + double.Parse(txtP3.Text) + double.Parse(txtP4.Text)) / 4;
            lblPromedioGeneral.Text = promedio.ToString();
        }

        // Evento del botón Registrar.
private void btnRegistrar_Click(object sender, EventArgs e)
{
    if (string.IsNullOrWhiteSpace(txtEstudiante.Text))
    {
        lblSituacion.Text = "Escriba el nombre del estudiante.";
        txtEstudiante.Focus();
        return;
    }

    if (!rdbMatutina.Checked && !rdbVespertina.Checked)
    {
        lblSituacion.Text = "Seleccione una tanda.";
        return;
    }

    if (cmbAsignatura.SelectedIndex == -1)
    {
        lblSituacion.Text = "Seleccione una asignatura.";
        return;
    }

    if (!double.TryParse(
            txtP1.Text,
            System.Globalization.NumberStyles.Float,
            System.Globalization.CultureInfo.CurrentCulture,
            out double periodo1) || periodo1 < 0 || periodo1 > 100)
    {
        lblSituacion.Text = "La calificación del período 1 debe estar entre 0 y 100.";
        txtP1.Focus();
        return;
    }

    if (!double.TryParse(
            txtP2.Text,
            System.Globalization.NumberStyles.Float,
            System.Globalization.CultureInfo.CurrentCulture,
            out double periodo2) || periodo2 < 0 || periodo2 > 100)
    {
        lblSituacion.Text = "La calificación del período 2 debe estar entre 0 y 100.";
        txtP2.Focus();
        return;
    }

    if (!double.TryParse(
            txtP3.Text,
            System.Globalization.NumberStyles.Float,
            System.Globalization.CultureInfo.CurrentCulture,
            out double periodo3) || periodo3 < 0 || periodo3 > 100)
    {
        lblSituacion.Text = "La calificación del período 3 debe estar entre 0 y 100.";
        txtP3.Focus();
        return;
    }

    if (!double.TryParse(
            txtP4.Text,
            System.Globalization.NumberStyles.Float,
            System.Globalization.CultureInfo.CurrentCulture,
            out double periodo4) || periodo4 < 0 || periodo4 > 100)
    {
        lblSituacion.Text = "La calificación del período 4 debe estar entre 0 y 100.";
        txtP4.Focus();
        return;
    }

    double promedio = (periodo1 + periodo2 + periodo3 + periodo4)
                      / CANTIDAD_PERIODOS;

    string situacion;

    if (!chkAsistencia.Checked)
    {
        situacion = "Reprobada por asistencia";
        cantidadReprobadas++;
    }
    else if (promedio >= NOTA_APROBACION)
    {
        situacion = "Aprobada";
        cantidadAprobadas++;
    }
    else if (promedio >= NOTA_RECUPERACION)
    {
        situacion = "En recuperación";
        cantidadRecuperacion++;
    }
    else
    {
        situacion = "Reprobada";
        cantidadReprobadas++;
    }

    cantidadAsignaturas++;
    sumaPromedios += promedio;

    string tanda = rdbMatutina.Checked ? "Matutina" : "Vespertina";

    lstBoletin.Items.Add(
        $"{cmbAsignatura.Text} - {tanda} - Promedio: {promedio:F2} - {situacion}");

    ActualizarContadores();
    LimpiarCalificaciones();

    lblSituacion.Text = "Asignatura registrada correctamente.";
}


// Evento del botón Resumen.
private void btnResumen_Click(object sender, EventArgs e)
{
    if (cantidadAsignaturas == 0)
    {
        lblSituacion.Text = "Debe registrar al menos una asignatura.";
        return;
    }

    double promedioGeneral = sumaPromedios / cantidadAsignaturas;

    lblPromedioGeneral.Text = $"{promedioGeneral:F2}";
    lblAprobadas.Text = cantidadAprobadas.ToString();
    lblRecuperacion.Text = cantidadRecuperacion.ToString();
    lblReprobadas.Text = cantidadReprobadas.ToString();

    if (cantidadReprobadas > 0)
    {
        lblSituacion.Text = "Tiene asignaturas reprobadas";
    }
    else if (cantidadRecuperacion > 0)
    {
        lblSituacion.Text = "Tiene asignaturas en recuperación";
    }
    else
    {
        lblSituacion.Text = "Aprobó todas las asignaturas";
    }
}


// Evento del botón Limpiar.
private void btnLimpiar_Click(object sender, EventArgs e)
{
    txtEstudiante.Clear();

    rdbMatutina.Checked = false;
    rdbVespertina.Checked = false;

    cmbAsignatura.SelectedIndex = -1;
    chkAsistencia.Checked = false;

    LimpiarCalificaciones();

    lstBoletin.Items.Clear();

    sumaPromedios = 0;
    cantidadAsignaturas = 0;
    cantidadAprobadas = 0;
    cantidadRecuperacion = 0;
    cantidadReprobadas = 0;

    lblPromedioGeneral.Text = "0.00";
    lblAprobadas.Text = "0";
    lblRecuperacion.Text = "0";
    lblReprobadas.Text = "0";
    lblSituacion.Text = string.Empty;

    txtEstudiante.Focus();
}


// Evento del botón Salir.
private void btnSalir_Click(object sender, EventArgs e)
{
    Close();
}


// Limpia las calificaciones de los cuatro períodos.
private void LimpiarCalificaciones()
{
    txtP1.Clear();
    txtP2.Clear();
    txtP3.Clear();
    txtP4.Clear();
}


// Actualiza los contadores mostrados en el formulario.
private void ActualizarContadores()
{
    lblAprobadas.Text = cantidadAprobadas.ToString();
    lblRecuperacion.Text = cantidadRecuperacion.ToString();
    lblReprobadas.Text = cantidadReprobadas.ToString();
}
    }
}

 