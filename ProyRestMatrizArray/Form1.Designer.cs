namespace ProyRestMatrizArray
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxPassUsuario = new System.Windows.Forms.TextBox();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.hora = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.Label();
            this.horayfecha = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxUsuario.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuario.Location = new System.Drawing.Point(497, 128);
            this.textBoxUsuario.Multiline = true;
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(174, 39);
            this.textBoxUsuario.TabIndex = 0;
            this.textBoxUsuario.Text = "Usuario";
            this.textBoxUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPassUsuario
            // 
            this.textBoxPassUsuario.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassUsuario.Location = new System.Drawing.Point(497, 195);
            this.textBoxPassUsuario.Multiline = true;
            this.textBoxPassUsuario.Name = "textBoxPassUsuario";
            this.textBoxPassUsuario.Size = new System.Drawing.Size(173, 39);
            this.textBoxPassUsuario.TabIndex = 1;
            this.textBoxPassUsuario.Text = "Contraseña";
            this.textBoxPassUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIngresar.Location = new System.Drawing.Point(496, 270);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(174, 39);
            this.buttonIngresar.TabIndex = 2;
            this.buttonIngresar.Text = "Ingresar";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // hora
            // 
            this.hora.AutoSize = true;
            this.hora.BackColor = System.Drawing.Color.Transparent;
            this.hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora.Location = new System.Drawing.Point(687, 9);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(48, 20);
            this.hora.TabIndex = 3;
            this.hora.Text = "Hora";
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.BackColor = System.Drawing.Color.Transparent;
            this.fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fecha.Location = new System.Drawing.Point(35, 9);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(59, 20);
            this.fecha.TabIndex = 4;
            this.fecha.Text = "Fecha";
            // 
            // horayfecha
            // 
            this.horayfecha.Enabled = true;
            this.horayfecha.Tick += new System.EventHandler(this.Horayfecha_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Rut sin puntos con guión y dígito verificador.";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Usuario y contraseña:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Tan;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 138);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1262, 660);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.hora);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.textBoxPassUsuario);
            this.Controls.Add(this.textBoxUsuario);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceso";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxPassUsuario;
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.Label hora;
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.Timer horayfecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

