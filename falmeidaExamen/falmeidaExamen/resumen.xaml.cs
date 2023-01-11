using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace falmeidaExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class resumen : ContentPage
    {
        public resumen(string datos,string nombreEstudiante, double valorCuotas, double montoTotal)
        {
            InitializeComponent();
            lblUsuario.Text = datos;
            lblnombreEstudiante.Text = nombreEstudiante;
            lblmontoTotal.Text = montoTotal.ToString();
            lblmensuales.Text = valorCuotas.ToString();
        }

        private void btnInformacion_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Información","Este proyecto fue desarrollado por: Fausto Almeida de 9no A Sistemas de la Información.", "Cerrar");
        }
    }
}