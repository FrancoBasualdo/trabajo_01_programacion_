
namespace trabajo_01_programacion
{
    partial class Trabajadores_x_hora
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
            this.Caracteristicas_cobro = new System.Windows.Forms.Label();
            this.lbl_costo_hora = new System.Windows.Forms.Label();
            this.lbl_cantidad_horas = new System.Windows.Forms.Label();
            this.lbl_pregunta_horas_extras = new System.Windows.Forms.Label();
            this.Carga_valor_hora = new System.Windows.Forms.Button();
            this.txt_valor_hora = new System.Windows.Forms.TextBox();
            this.txt_cantidad_hora = new System.Windows.Forms.TextBox();
            this.txt_pregunta_horas_extras = new System.Windows.Forms.TextBox();
            this.Volver_inicio = new System.Windows.Forms.Button();
            this.lbl_extra_valor_hora = new System.Windows.Forms.Label();
            this.lbl_extra_cantidad_hora = new System.Windows.Forms.Label();
            this.carga_extra = new System.Windows.Forms.Button();
            this.lbl_extra_mostrar_resultado = new System.Windows.Forms.Label();
            this.txt_extra_valor_hora = new System.Windows.Forms.TextBox();
            this.txt_extra_cantidad_hora = new System.Windows.Forms.TextBox();
            this.lbl_extra_resultado_final = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Caracteristicas_cobro
            // 
            this.Caracteristicas_cobro.AutoSize = true;
            this.Caracteristicas_cobro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Caracteristicas_cobro.Location = new System.Drawing.Point(168, 9);
            this.Caracteristicas_cobro.Name = "Caracteristicas_cobro";
            this.Caracteristicas_cobro.Size = new System.Drawing.Size(431, 60);
            this.Caracteristicas_cobro.TabIndex = 0;
            this.Caracteristicas_cobro.Text = "Los trabajadores por hora, cobran un salario fijo\r\ny se le incrmenta las horas ex" +
    "tras en el caso de que las \r\nhayan trabajado";
            // 
            // lbl_costo_hora
            // 
            this.lbl_costo_hora.AutoSize = true;
            this.lbl_costo_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_costo_hora.Location = new System.Drawing.Point(67, 168);
            this.lbl_costo_hora.Name = "lbl_costo_hora";
            this.lbl_costo_hora.Size = new System.Drawing.Size(181, 17);
            this.lbl_costo_hora.TabIndex = 1;
            this.lbl_costo_hora.Text = "Ingrese el valor de la hora :";
            // 
            // lbl_cantidad_horas
            // 
            this.lbl_cantidad_horas.AutoSize = true;
            this.lbl_cantidad_horas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad_horas.Location = new System.Drawing.Point(67, 211);
            this.lbl_cantidad_horas.Name = "lbl_cantidad_horas";
            this.lbl_cantidad_horas.Size = new System.Drawing.Size(181, 17);
            this.lbl_cantidad_horas.TabIndex = 2;
            this.lbl_cantidad_horas.Text = "Ingrese cantidad de horas :";
            // 
            // lbl_pregunta_horas_extras
            // 
            this.lbl_pregunta_horas_extras.AutoSize = true;
            this.lbl_pregunta_horas_extras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pregunta_horas_extras.Location = new System.Drawing.Point(67, 267);
            this.lbl_pregunta_horas_extras.Name = "lbl_pregunta_horas_extras";
            this.lbl_pregunta_horas_extras.Size = new System.Drawing.Size(208, 34);
            this.lbl_pregunta_horas_extras.TabIndex = 3;
            this.lbl_pregunta_horas_extras.Text = "Realizo horas extras ?  :\r\n( ingrese 1 para SI, 2 para NO) ";
            // 
            // Carga_valor_hora
            // 
            this.Carga_valor_hora.Location = new System.Drawing.Point(444, 267);
            this.Carga_valor_hora.Name = "Carga_valor_hora";
            this.Carga_valor_hora.Size = new System.Drawing.Size(75, 23);
            this.Carga_valor_hora.TabIndex = 4;
            this.Carga_valor_hora.Text = "Cargar";
            this.Carga_valor_hora.UseVisualStyleBackColor = true;
            this.Carga_valor_hora.Click += new System.EventHandler(this.Carga_valor_hora_Click);
            // 
            // txt_valor_hora
            // 
            this.txt_valor_hora.Location = new System.Drawing.Point(298, 164);
            this.txt_valor_hora.Name = "txt_valor_hora";
            this.txt_valor_hora.Size = new System.Drawing.Size(82, 20);
            this.txt_valor_hora.TabIndex = 5;
            // 
            // txt_cantidad_hora
            // 
            this.txt_cantidad_hora.Location = new System.Drawing.Point(298, 211);
            this.txt_cantidad_hora.Name = "txt_cantidad_hora";
            this.txt_cantidad_hora.Size = new System.Drawing.Size(82, 20);
            this.txt_cantidad_hora.TabIndex = 6;
            // 
            // txt_pregunta_horas_extras
            // 
            this.txt_pregunta_horas_extras.Location = new System.Drawing.Point(298, 281);
            this.txt_pregunta_horas_extras.Name = "txt_pregunta_horas_extras";
            this.txt_pregunta_horas_extras.Size = new System.Drawing.Size(82, 20);
            this.txt_pregunta_horas_extras.TabIndex = 7;
            // 
            // Volver_inicio
            // 
            this.Volver_inicio.Location = new System.Drawing.Point(663, 388);
            this.Volver_inicio.Name = "Volver_inicio";
            this.Volver_inicio.Size = new System.Drawing.Size(75, 23);
            this.Volver_inicio.TabIndex = 8;
            this.Volver_inicio.Text = "Volver";
            this.Volver_inicio.UseVisualStyleBackColor = true;
            this.Volver_inicio.Click += new System.EventHandler(this.Volver_inicio_Click);
            // 
            // lbl_extra_valor_hora
            // 
            this.lbl_extra_valor_hora.AutoSize = true;
            this.lbl_extra_valor_hora.Location = new System.Drawing.Point(68, 337);
            this.lbl_extra_valor_hora.Name = "lbl_extra_valor_hora";
            this.lbl_extra_valor_hora.Size = new System.Drawing.Size(0, 13);
            this.lbl_extra_valor_hora.TabIndex = 9;
            // 
            // lbl_extra_cantidad_hora
            // 
            this.lbl_extra_cantidad_hora.AutoSize = true;
            this.lbl_extra_cantidad_hora.Location = new System.Drawing.Point(67, 357);
            this.lbl_extra_cantidad_hora.Name = "lbl_extra_cantidad_hora";
            this.lbl_extra_cantidad_hora.Size = new System.Drawing.Size(0, 13);
            this.lbl_extra_cantidad_hora.TabIndex = 10;
            // 
            // carga_extra
            // 
            this.carga_extra.Location = new System.Drawing.Point(444, 388);
            this.carga_extra.Name = "carga_extra";
            this.carga_extra.Size = new System.Drawing.Size(75, 23);
            this.carga_extra.TabIndex = 11;
            this.carga_extra.Text = "Calcular";
            this.carga_extra.UseVisualStyleBackColor = true;
            this.carga_extra.Click += new System.EventHandler(this.carga_extra_Click);
            // 
            // lbl_extra_mostrar_resultado
            // 
            this.lbl_extra_mostrar_resultado.AutoSize = true;
            this.lbl_extra_mostrar_resultado.Location = new System.Drawing.Point(68, 415);
            this.lbl_extra_mostrar_resultado.Name = "lbl_extra_mostrar_resultado";
            this.lbl_extra_mostrar_resultado.Size = new System.Drawing.Size(0, 13);
            this.lbl_extra_mostrar_resultado.TabIndex = 12;
            // 
            // txt_extra_valor_hora
            // 
            this.txt_extra_valor_hora.BackColor = System.Drawing.Color.Chocolate;
            this.txt_extra_valor_hora.Location = new System.Drawing.Point(299, 330);
            this.txt_extra_valor_hora.Name = "txt_extra_valor_hora";
            this.txt_extra_valor_hora.Size = new System.Drawing.Size(82, 20);
            this.txt_extra_valor_hora.TabIndex = 13;
            // 
            // txt_extra_cantidad_hora
            // 
            this.txt_extra_cantidad_hora.BackColor = System.Drawing.Color.Chocolate;
            this.txt_extra_cantidad_hora.Location = new System.Drawing.Point(299, 365);
            this.txt_extra_cantidad_hora.Name = "txt_extra_cantidad_hora";
            this.txt_extra_cantidad_hora.Size = new System.Drawing.Size(82, 20);
            this.txt_extra_cantidad_hora.TabIndex = 14;
            // 
            // lbl_extra_resultado_final
            // 
            this.lbl_extra_resultado_final.AutoSize = true;
            this.lbl_extra_resultado_final.Location = new System.Drawing.Point(305, 415);
            this.lbl_extra_resultado_final.Name = "lbl_extra_resultado_final";
            this.lbl_extra_resultado_final.Size = new System.Drawing.Size(0, 13);
            this.lbl_extra_resultado_final.TabIndex = 15;
            // 
            // Trabajadores_x_hora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_extra_resultado_final);
            this.Controls.Add(this.txt_extra_cantidad_hora);
            this.Controls.Add(this.txt_extra_valor_hora);
            this.Controls.Add(this.lbl_extra_mostrar_resultado);
            this.Controls.Add(this.carga_extra);
            this.Controls.Add(this.lbl_extra_cantidad_hora);
            this.Controls.Add(this.lbl_extra_valor_hora);
            this.Controls.Add(this.Volver_inicio);
            this.Controls.Add(this.txt_pregunta_horas_extras);
            this.Controls.Add(this.txt_cantidad_hora);
            this.Controls.Add(this.txt_valor_hora);
            this.Controls.Add(this.Carga_valor_hora);
            this.Controls.Add(this.lbl_pregunta_horas_extras);
            this.Controls.Add(this.lbl_cantidad_horas);
            this.Controls.Add(this.lbl_costo_hora);
            this.Controls.Add(this.Caracteristicas_cobro);
            this.Name = "Trabajadores_x_hora";
            this.Text = "Trabajadores_x_hora";
          
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Caracteristicas_cobro;
        private System.Windows.Forms.Label lbl_costo_hora;
        private System.Windows.Forms.Label lbl_cantidad_horas;
        private System.Windows.Forms.Label lbl_pregunta_horas_extras;
        private System.Windows.Forms.Button Carga_valor_hora;
        private System.Windows.Forms.TextBox txt_valor_hora;
        private System.Windows.Forms.TextBox txt_cantidad_hora;
        private System.Windows.Forms.TextBox txt_pregunta_horas_extras;
        private System.Windows.Forms.Button Volver_inicio;
        private System.Windows.Forms.Label lbl_extra_valor_hora;
        private System.Windows.Forms.Label lbl_extra_cantidad_hora;
        private System.Windows.Forms.Button carga_extra;
        private System.Windows.Forms.Label lbl_extra_mostrar_resultado;
        private System.Windows.Forms.TextBox txt_extra_valor_hora;
        private System.Windows.Forms.TextBox txt_extra_cantidad_hora;
        private System.Windows.Forms.Label lbl_extra_resultado_final;
    }
}