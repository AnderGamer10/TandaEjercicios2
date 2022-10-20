using System.Globalization;

namespace TandaEjercicios2
{
    public partial class Ejercicio7 : Form
    {
        public Ejercicio7()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtAhora.Text = "";
            txtDifFechas.Text = "";
            txtHoraHoy.Text = "";
            txtHoy.Text = "";
            txtSumaFechas.Text = "";
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            txtAhora.Text = DateTime.Now.ToString();
            txtHoy.Text = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
            txtHoraHoy.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
            try
            {
                string fechaInicial = Microsoft.VisualBasic.Interaction.InputBox(
                "Ingrese una fecha de la forma dd/mm/aaaa",
                "Funcion SumaFechas",
                "");
                DateTime date1 = DateTime.ParseExact(fechaInicial, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                string sumaMeses = Microsoft.VisualBasic.Interaction.InputBox(
                    "Ingrese el numero de meses que se agrega a la fecha:",
                    "Meses",
                    "");

                txtSumaFechas.Text = "Fecha Inicio: " + fechaInicial + ", Meses a sumar: " + sumaMeses + ", Nueva Fecha: " + date1.AddMonths(Int32.Parse(sumaMeses)).ToString();

            }
            catch (Exception)
            {
                Microsoft.VisualBasic.Interaction.MsgBox(
                    "Introduzca los datos correctamente o pulse salir");
            }
            try
            {
                string fechaInicialDiff = Microsoft.VisualBasic.Interaction.InputBox(
                                "Ingrese la fecha inicial de la forma dd/mm/aaaa",
                                "Funcion DiferenciaFechas",
                                "");
                DateTime fechaInDiff = DateTime.ParseExact(fechaInicialDiff, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                string fechafinalDiff = Microsoft.VisualBasic.Interaction.InputBox(
                    "Ingrese la fecha final de la forma dd/mm/aaaa",
                    "Funcion DiferenciaFechas",
                    "");
                DateTime fechaFinDiff = DateTime.ParseExact(fechafinalDiff, "dd/MM/yyyy", CultureInfo.InvariantCulture);


                TimeSpan ts = fechaFinDiff - fechaInDiff;


                txtDifFechas.Text = "Desde " + fechaInicialDiff + " hasta " + fechafinalDiff + " hay " + ts.Days + " dias";

            }
            catch (Exception)
            {
                Microsoft.VisualBasic.Interaction.MsgBox(
                    "Introduzca los datos correctamente o pulse salir");
            }



        }
        private void Ejercicio8_Load(object sender, EventArgs e)
        {

        }
    }
}