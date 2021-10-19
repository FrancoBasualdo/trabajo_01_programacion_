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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

       

        

        private void button1_Click(object sender, EventArgs e)
        {

            int valor;
            valor = System.Convert.ToInt32(valor_ingreso.Text);

           


            switch (valor)
            {


                case 1:
                    Form Gerentes = new Gerentes();
                    Gerentes.Show();
                    this.Close();
                    break;
                case 2:
                 Form Trabajadores_x_hora = new Trabajadores_x_hora();
                 Trabajadores_x_hora.Show();
                     this.Close();
                   break;
                 case 3:
                   Form Trabajadores_x_comision = new Trabajadores_x_comision();
                 Trabajadores_x_comision.Show();
                  this.Close();
                    break;
                
                default:
                    lbl_Indicacion_erronea.Text = "Opcion incorrecta\n\rIngrese nuevo valor";
                    break;
            }


        }

        private void btn_volver_inicio_Click(object sender, EventArgs e)
        {
            //Form Bienvenidos = new Bienvenidos();
            //Bienvenidos.Show();
            this.Close();
        }
    }
}
