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
    public partial class registro : ContentPage
    {
        public registro(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = "Usuario Conectado: "+ usuario;
        }

       

        private void btnCalCuotaMensual_Clicked(object sender, EventArgs e)
        {
            try 
            {
                double precio = Convert.ToDouble(txtMontoInicial.Text);

                double valor = 4000 - precio;

                double interes = 200;

                double valorSobrante = valor;

                double valorMensual = valor + interes;

                double valorCuotas = valorMensual / 5;

                if (precio < 4000)
                {
                    txtResCuotaMensual.Text = valorCuotas.ToString();
                }
                else {

                    DisplayAlert("Alerta", "El precio excede el valor base.", "Cerrar");
                }
                
            }
            catch(Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "Cerrar");
            }

        }

        private void bntCalcular_Clicked(object sender, EventArgs e)
        {
            string datos = lblUsuario.Text;
            string nombreEstudiante = txtNombre.Text;

            double precio = Convert.ToDouble(txtMontoInicial.Text);

            double valor = 4000 - precio;

            double interes = 200;

            double valorSobrante = valor;

            double valorMensual = valor + interes;

            double valorCuotas = valorMensual / 5;

            double montoCuotas = valorCuotas * 5;

            double montoTotal = montoCuotas + precio;
            Navigation.PushAsync(new resumen(datos, nombreEstudiante, valorCuotas, montoTotal));
        }
    }
}