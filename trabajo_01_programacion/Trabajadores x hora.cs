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
    public partial class Trabajadores_x_hora : Form
    {

        int valor_hora;
        int cantidad_hora;
        int remuneracion;
        int pregunta_extra, extra;
        int hora_extra_valor, hora_extra_cantidad;

        public Trabajadores_x_hora()
        {
            InitializeComponent();

        }

        private void Volver_inicio_Click(object sender, EventArgs e)
        {
            Form Inicio = new Inicio();
            Inicio.Show();
            this.Close();
        }

        
        



            private void Carga_valor_hora_Click(object sender, EventArgs e)
            {
                valor_hora = System.Convert.ToInt32(txt_valor_hora.Text);
                cantidad_hora = System.Convert.ToInt32(txt_cantidad_hora.Text);
                pregunta_extra = System.Convert.ToInt32(txt_pregunta_horas_extras.Text);


                switch (pregunta_extra)
                {
                    case 1:
                        lbl_extra_valor_hora.Text = "Ingrese el valor de horas las\n\rextras";
                        lbl_extra_cantidad_hora.Text = "Ingrese cantidad de horas\n\r extras realizadas";
                        break;
                    case 2:
                        remuneracion = valor_hora * cantidad_hora;
                        lbl_extra_mostrar_resultado.Text = "La remuneracion correspondiente es:";
                        lbl_extra_resultado_final.Text = System.Convert.ToString(remuneracion);
                        break;
                    default:
                        break;
                }

            }

            private void carga_extra_Click(object sender, EventArgs e)
            {
                if (pregunta_extra == 1)
                {
                    hora_extra_valor = System.Convert.ToInt32(txt_extra_valor_hora.Text);
                    hora_extra_cantidad = System.Convert.ToInt32(txt_extra_cantidad_hora.Text);
                    extra = hora_extra_valor * hora_extra_cantidad;

                    remuneracion = (valor_hora * cantidad_hora) + extra;
                    lbl_extra_mostrar_resultado.Text = "La remuneracion correspondiente es:";
                    lbl_extra_resultado_final.Text = System.Convert.ToString(remuneracion);
                }
            }


        
    }

}
