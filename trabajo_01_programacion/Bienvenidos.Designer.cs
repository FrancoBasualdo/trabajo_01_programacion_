
namespace trabajo_01_programacion
{
    partial class Bienvenidos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bienvenidos));
            this.Indiador = new System.Windows.Forms.Label();
            this.Enter01 = new System.Windows.Forms.Button();
            this.indicacion_inicio = new System.Windows.Forms.Label();
            this.accion_iniciar = new System.Windows.Forms.Button();
            this.Hola = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Indiador
            // 
            this.Indiador.AutoSize = true;
            this.Indiador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Indiador.Location = new System.Drawing.Point(57, 283);
            this.Indiador.Name = "Indiador";
            this.Indiador.Size = new System.Drawing.Size(222, 40);
            this.Indiador.TabIndex = 0;
            this.Indiador.Text = "Para conocer este programa\r\nhaga clic en ver";
            // 
            // Enter01
            // 
            this.Enter01.BackColor = System.Drawing.Color.Cornsilk;
            this.Enter01.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter01.Location = new System.Drawing.Point(553, 283);
            this.Enter01.Name = "Enter01";
            this.Enter01.Size = new System.Drawing.Size(105, 37);
            this.Enter01.TabIndex = 2;
            this.Enter01.Text = "Ver";
            this.Enter01.UseVisualStyleBackColor = false;
            this.Enter01.Click += new System.EventHandler(this.Enter01_Click);
            // 
            // indicacion_inicio
            // 
            this.indicacion_inicio.AutoSize = true;
            this.indicacion_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indicacion_inicio.Location = new System.Drawing.Point(57, 371);
            this.indicacion_inicio.Name = "indicacion_inicio";
            this.indicacion_inicio.Size = new System.Drawing.Size(204, 40);
            this.indicacion_inicio.TabIndex = 3;
            this.indicacion_inicio.Text = "Para comenzar a trabajar \r\nhaga clic en en inicio";
            // 
            // accion_iniciar
            // 
            this.accion_iniciar.BackColor = System.Drawing.Color.AliceBlue;
            this.accion_iniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accion_iniciar.Location = new System.Drawing.Point(553, 371);
            this.accion_iniciar.Name = "accion_iniciar";
            this.accion_iniciar.Size = new System.Drawing.Size(105, 40);
            this.accion_iniciar.TabIndex = 4;
            this.accion_iniciar.Text = "Inicio";
            this.accion_iniciar.UseVisualStyleBackColor = false;
            this.accion_iniciar.Click += new System.EventHandler(this.accion_iniciar_Click);
            // 
            // Hola
            // 
            this.Hola.AutoSize = true;
            this.Hola.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hola.Location = new System.Drawing.Point(-242, 9);
            this.Hola.Name = "Hola";
            this.Hola.Size = new System.Drawing.Size(832, 54);
            this.Hola.TabIndex = 5;
            this.Hola.Text = "                                            Bienvenidos!!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(678, 125);
            this.label1.TabIndex = 6;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // Bienvenidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Hola);
            this.Controls.Add(this.accion_iniciar);
            this.Controls.Add(this.indicacion_inicio);
            this.Controls.Add(this.Enter01);
            this.Controls.Add(this.Indiador);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Bienvenidos";
            this.Text = "Bienvenidos¡ ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Indiador;
        private System.Windows.Forms.Button Enter01;
        private System.Windows.Forms.Label indicacion_inicio;
        private System.Windows.Forms.Button accion_iniciar;
        private System.Windows.Forms.Label Hola;
        private System.Windows.Forms.Label label1;
    }
}

