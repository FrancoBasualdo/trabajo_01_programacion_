
namespace trabajo_01_programacion
{
    partial class Gerentes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>


     

        
        
        
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.In_costo_hora = new System.Windows.Forms.Label();
            this.Caracteristicas_cobro = new System.Windows.Forms.Label();
            this.lbl_ingreso_hora = new System.Windows.Forms.Label();
            this.txt_valor_hora = new System.Windows.Forms.TextBox();
            this.txt_cantidad_hora = new System.Windows.Forms.TextBox();
            this.resultado_cobro = new System.Windows.Forms.Label();
            this.mostrar_resultado = new System.Windows.Forms.Label();
            this.Calcular = new System.Windows.Forms.Button();
            this.Volver_inicio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // In_costo_hora
            // 
            this.In_costo_hora.AutoSize = true;
            this.In_costo_hora.Location = new System.Drawing.Point(96, 135);
            this.In_costo_hora.Name = "In_costo_hora";
            this.In_costo_hora.Size = new System.Drawing.Size(129, 13);
            this.In_costo_hora.TabIndex = 0;
            this.In_costo_hora.Text = "Ingrese el valor de la hora";
            // 
            // Caracteristicas_cobro
            // 
            this.Caracteristicas_cobro.AutoSize = true;
            this.Caracteristicas_cobro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Caracteristicas_cobro.Location = new System.Drawing.Point(290, 26);
            this.Caracteristicas_cobro.Name = "Caracteristicas_cobro";
            this.Caracteristicas_cobro.Size = new System.Drawing.Size(340, 20);
            this.Caracteristicas_cobro.TabIndex = 1;
            this.Caracteristicas_cobro.Text = "Los gerentes reciben un salario semanal fijo";
            // 
            // lbl_ingreso_hora
            // 
            this.lbl_ingreso_hora.AutoSize = true;
            this.lbl_ingreso_hora.Location = new System.Drawing.Point(96, 229);
            this.lbl_ingreso_hora.Name = "lbl_ingreso_hora";
            this.lbl_ingreso_hora.Size = new System.Drawing.Size(197, 26);
            this.lbl_ingreso_hora.TabIndex = 2;
            this.lbl_ingreso_hora.Text = "Ingrese la cantidad de horas realizadas  \r\nesta semana ";
            // 
            // txt_valor_hora
            // 
            this.txt_valor_hora.Location = new System.Drawing.Point(410, 132);
            this.txt_valor_hora.Name = "txt_valor_hora";
            this.txt_valor_hora.Size = new System.Drawing.Size(100, 20);
            this.txt_valor_hora.TabIndex = 3;
            // 
            // txt_cantidad_hora
            // 
            this.txt_cantidad_hora.Location = new System.Drawing.Point(410, 235);
            this.txt_cantidad_hora.Name = "txt_cantidad_hora";
            this.txt_cantidad_hora.Size = new System.Drawing.Size(100, 20);
            this.txt_cantidad_hora.TabIndex = 4;
            // 
            // resultado_cobro
            // 
            this.resultado_cobro.AutoSize = true;
            this.resultado_cobro.Location = new System.Drawing.Point(96, 339);
            this.resultado_cobro.Name = "resultado_cobro";
            this.resultado_cobro.Size = new System.Drawing.Size(187, 13);
            this.resultado_cobro.TabIndex = 5;
            this.resultado_cobro.Text = "La remuneración de esta semana es : ";
            // 
            // mostrar_resultado
            // 
            this.mostrar_resultado.AutoSize = true;
            this.mostrar_resultado.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mostrar_resultado.Location = new System.Drawing.Point(431, 339);
            this.mostrar_resultado.Name = "mostrar_resultado";
            this.mostrar_resultado.Size = new System.Drawing.Size(0, 13);
            this.mostrar_resultado.TabIndex = 6;
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(623, 178);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(94, 27);
            this.Calcular.TabIndex = 7;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // Volver_inicio
            // 
            this.Volver_inicio.Location = new System.Drawing.Point(623, 377);
            this.Volver_inicio.Name = "Volver_inicio";
            this.Volver_inicio.Size = new System.Drawing.Size(94, 27);
            this.Volver_inicio.TabIndex = 8;
            this.Volver_inicio.Text = "Volver";
            this.Volver_inicio.UseVisualStyleBackColor = true;
            this.Volver_inicio.Click += new System.EventHandler(this.button2_Click);
            // 
            // Gerentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Volver_inicio);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.mostrar_resultado);
            this.Controls.Add(this.resultado_cobro);
            this.Controls.Add(this.txt_cantidad_hora);
            this.Controls.Add(this.txt_valor_hora);
            this.Controls.Add(this.lbl_ingreso_hora);
            this.Controls.Add(this.Caracteristicas_cobro);
            this.Controls.Add(this.In_costo_hora);
            this.Name = "Gerentes";
            this.Text = "Gerentes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
     







        private System.Windows.Forms.Label In_costo_hora;
        private System.Windows.Forms.Label Caracteristicas_cobro;
        private System.Windows.Forms.Label lbl_ingreso_hora;
        private System.Windows.Forms.TextBox txt_valor_hora;
        private System.Windows.Forms.TextBox txt_cantidad_hora;
        private System.Windows.Forms.Label resultado_cobro;
        private System.Windows.Forms.Label mostrar_resultado;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.Button Volver_inicio;
    }
}