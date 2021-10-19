using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabajo_01_programacion
{
    public partial class Trabajadores_x_comision : Form
    {

        int cantidad_dias;
        int pregunta_ventas;
        float valor_ventas;
        int cantidad_ventas;
        int remuneracion;
        float porcentaje;
        float valor_comision;
        public Trabajadores_x_comision()
        {
            InitializeComponent();
        }

        private void Carga_días_respuesta_Click(object sender, EventArgs e)
        {
            cantidad_dias = System.Convert.ToInt32(txt_dias_cantidad.Text);
            pregunta_ventas = System.Convert.ToInt32(txt_pregunta_ventas.Text);


            switch (pregunta_ventas)
            {
                case 1:
                    lbl_valor_venta.Text = "Ingrese el valor de la venta :";
                    lbl_cantidad_ventas.Text = "Ingrese la cantidad de ventas";



                    break;
                case 2:     
                    remuneracion = 50 * cantidad_dias;
                    lbl_remuneracio_muestra.Text = "La remuneración de esta semana\n\r es:";
                    lbl_muestra_valor_remuneracion.Text = System.Convert.ToString(remuneracion);
                        

                    break;
                        
                default:
                    break;
            }
        }

        private void btn_carga_comision_Click(object sender, EventArgs e)
        {
            if (pregunta_ventas == 1) 
            {
                valor_ventas = (float)System.Convert.ToDecimal(txt_valor_ventas.Text);
                cantidad_ventas = System.Convert.ToInt32(txt_cantidad_ventas.Text);

                porcentaje = (float)((valor_ventas * 5.7) / 100.0);
                valor_comision = (float)(porcentaje * cantidad_ventas);

                remuneracion = (int)(cantidad_dias * 50 + valor_comision);



                lbl_remuneracio_muestra.Text = "La remuneración de esta semana\n\r es:";
                lbl_muestra_valor_remuneracion.Text = System.Convert.ToString(remuneracion);

            }
        }

        private void btn_volver_inicio_Click(object sender, EventArgs e)
        {
            Form Inicio = new Inicio();
            Inicio.Show();
            this.Close();
        }
    }
}
