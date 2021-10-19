
namespace trabajo_01_programacion
{
    partial class program_descrip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(program_descrip));
            this.description_program = new System.Windows.Forms.Label();
            this.vuelve_form1_inicio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // description_program
            // 
            this.description_program.AutoSize = true;
            this.description_program.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_program.Location = new System.Drawing.Point(109, 60);
            this.description_program.Name = "description_program";
            this.description_program.Size = new System.Drawing.Size(580, 200);
            this.description_program.TabIndex = 0;
            this.description_program.Text = resources.GetString("description_program.Text");
            // 
            // vuelve_form1_inicio
            // 
            this.vuelve_form1_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vuelve_form1_inicio.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.vuelve_form1_inicio.Location = new System.Drawing.Point(329, 308);
            this.vuelve_form1_inicio.Name = "vuelve_form1_inicio";
            this.vuelve_form1_inicio.Size = new System.Drawing.Size(84, 34);
            this.vuelve_form1_inicio.TabIndex = 2;
            this.vuelve_form1_inicio.Text = "Atras";
            this.vuelve_form1_inicio.UseVisualStyleBackColor = true;
            this.vuelve_form1_inicio.Click += new System.EventHandler(this.vuelve_form1_inicio_Click);
            // 
            // program_descrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vuelve_form1_inicio);
            this.Controls.Add(this.description_program);
            this.Name = "program_descrip";
            this.Text = "Descripcion de programa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label description_program;
        private System.Windows.Forms.Button vuelve_form1_inicio;
    }
}