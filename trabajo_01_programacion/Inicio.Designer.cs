
namespace trabajo_01_programacion
{
    partial class Inicio
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
            this.instruccion_01 = new System.Windows.Forms.Label();
            this.indicacion_gerentes = new System.Windows.Forms.Label();
            this.indicacion_trabajadores_hora = new System.Windows.Forms.Label();
            this.indicaciones_trabajadores_comision = new System.Windows.Forms.Label();
            this.valor_ingreso = new System.Windows.Forms.TextBox();
            this.lbl_Indicacion_erronea = new System.Windows.Forms.Label();
            this.Ingreso_valor = new System.Windows.Forms.Button();
            this.btn_volver_inicio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instruccion_01
            // 
            this.instruccion_01.AutoSize = true;
            this.instruccion_01.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruccion_01.Location = new System.Drawing.Point(104, 21);
            this.instruccion_01.Name = "instruccion_01";
            this.instruccion_01.Size = new System.Drawing.Size(514, 75);
            this.instruccion_01.TabIndex = 0;
            this.instruccion_01.Text = "\r\nIngrese la opción correspondiente a cada empleado.\r\n\r\n";
            // 
            // indicacion_gerentes
            // 
            this.indicacion_gerentes.AutoSize = true;
            this.indicacion_gerentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indicacion_gerentes.Location = new System.Drawing.Point(106, 127);
            this.indicacion_gerentes.Name = "indicacion_gerentes";
            this.indicacion_gerentes.Size = new System.Drawing.Size(138, 17);
            this.indicacion_gerentes.TabIndex = 5;
            this.indicacion_gerentes.Text = "Gerentes. Ingrese: 1";
            // 
            // indicacion_trabajadores_hora
            // 
            this.indicacion_trabajadores_hora.AutoSize = true;
            this.indicacion_trabajadores_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indicacion_trabajadores_hora.Location = new System.Drawing.Point(106, 178);
            this.indicacion_trabajadores_hora.Name = "indicacion_trabajadores_hora";
            this.indicacion_trabajadores_hora.Size = new System.Drawing.Size(222, 17);
            this.indicacion_trabajadores_hora.TabIndex = 6;
            this.indicacion_trabajadores_hora.Text = "Trabajadores por hora. Ingrese: 2";
            // 
            // indicaciones_trabajadores_comision
            // 
            this.indicaciones_trabajadores_comision.AutoSize = true;
            this.indicaciones_trabajadores_comision.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indicaciones_trabajadores_comision.Location = new System.Drawing.Point(106, 230);
            this.indicaciones_trabajadores_comision.Name = "indicaciones_trabajadores_comision";
            this.indicaciones_trabajadores_comision.Size = new System.Drawing.Size(252, 17);
            this.indicaciones_trabajadores_comision.TabIndex = 7;
            this.indicaciones_trabajadores_comision.Text = "Trabajadores por comision. Ingrese : 3\r\n";
            // 
            // valor_ingreso
            // 
            this.valor_ingreso.Location = new System.Drawing.Point(375, 349);
            this.valor_ingreso.Name = "valor_ingreso";
            this.valor_ingreso.Size = new System.Drawing.Size(100, 20);
            this.valor_ingreso.TabIndex = 9;
            // 
            // lbl_Indicacion_erronea
            // 
            this.lbl_Indicacion_erronea.AutoSize = true;
            this.lbl_Indicacion_erronea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Indicacion_erronea.Location = new System.Drawing.Point(624, 349);
            this.lbl_Indicacion_erronea.Name = "lbl_Indicacion_erronea";
            this.lbl_Indicacion_erronea.Size = new System.Drawing.Size(0, 17);
            this.lbl_Indicacion_erronea.TabIndex = 10;
            // 
            // Ingreso_valor
            // 
            this.Ingreso_valor.Location = new System.Drawing.Point(481, 349);
            this.Ingreso_valor.Name = "Ingreso_valor";
            this.Ingreso_valor.Size = new System.Drawing.Size(75, 23);
            this.Ingreso_valor.TabIndex = 11;
            this.Ingreso_valor.Text = "Enter";
            this.Ingreso_valor.UseVisualStyleBackColor = true;
            this.Ingreso_valor.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_volver_inicio
            // 
            this.btn_volver_inicio.Location = new System.Drawing.Point(646, 349);
            this.btn_volver_inicio.Name = "btn_volver_inicio";
            this.btn_volver_inicio.Size = new System.Drawing.Size(75, 23);
            this.btn_volver_inicio.TabIndex = 12;
            this.btn_volver_inicio.Text = "Volver";
            this.btn_volver_inicio.UseVisualStyleBackColor = true;
            this.btn_volver_inicio.Click += new System.EventHandler(this.btn_volver_inicio_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_volver_inicio);
            this.Controls.Add(this.Ingreso_valor);
            this.Controls.Add(this.lbl_Indicacion_erronea);
            this.Controls.Add(this.valor_ingreso);
            this.Controls.Add(this.indicaciones_trabajadores_comision);
            this.Controls.Add(this.indicacion_trabajadores_hora);
            this.Controls.Add(this.indicacion_gerentes);
            this.Controls.Add(this.instruccion_01);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instruccion_01;
        private System.Windows.Forms.Label indicacion_gerentes;
        private System.Windows.Forms.Label indicacion_trabajadores_hora;
        private System.Windows.Forms.Label indicaciones_trabajadores_comision;
        private System.Windows.Forms.TextBox valor_ingreso;
        private System.Windows.Forms.Label lbl_Indicacion_erronea;
        private System.Windows.Forms.Button Ingreso_valor;
        private System.Windows.Forms.Button btn_volver_inicio;
    }
}