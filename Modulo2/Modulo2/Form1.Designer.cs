namespace Modulo2
{
    partial class Empleados
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.RBACTIVO = new System.Windows.Forms.RadioButton();
            this.RBBAJA = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CMDINSERTAR = new System.Windows.Forms.Button();
            this.CMDMODIFICAR = new System.Windows.Forms.Button();
            this.CMDCONSULTAR = new System.Windows.Forms.Button();
            this.CMDELIMINAR = new System.Windows.Forms.Button();
            this.CMDSALIR = new System.Windows.Forms.Button();
            this.TXTID = new System.Windows.Forms.TextBox();
            this.TXTNOMBRE = new System.Windows.Forms.TextBox();
            this.TXTAPP = new System.Windows.Forms.TextBox();
            this.TXTAPM = new System.Windows.Forms.TextBox();
            this.TXTTELEFONO = new System.Windows.Forms.TextBox();
            this.TXTDOMICILIO = new System.Windows.Forms.TextBox();
            this.TXTCORREO = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLAVE EMPLEADO :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "APELLIDO PATERNO :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "APELLIDO MATERNO :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "TELEFONO :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(367, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "EMAIL:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "DOMICILIO :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(53, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "STATUS :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // RBACTIVO
            // 
            this.RBACTIVO.AutoSize = true;
            this.RBACTIVO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBACTIVO.Location = new System.Drawing.Point(8, 45);
            this.RBACTIVO.Name = "RBACTIVO";
            this.RBACTIVO.Size = new System.Drawing.Size(70, 17);
            this.RBACTIVO.TabIndex = 8;
            this.RBACTIVO.TabStop = true;
            this.RBACTIVO.Text = "ACTIVO";
            this.RBACTIVO.UseVisualStyleBackColor = true;
            this.RBACTIVO.CheckedChanged += new System.EventHandler(this.RBACTIVO_CheckedChanged);
            // 
            // RBBAJA
            // 
            this.RBBAJA.AutoSize = true;
            this.RBBAJA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBBAJA.Location = new System.Drawing.Point(84, 45);
            this.RBBAJA.Name = "RBBAJA";
            this.RBBAJA.Size = new System.Drawing.Size(55, 17);
            this.RBBAJA.TabIndex = 9;
            this.RBBAJA.TabStop = true;
            this.RBBAJA.Text = "BAJA";
            this.RBBAJA.UseVisualStyleBackColor = true;
            this.RBBAJA.CheckedChanged += new System.EventHandler(this.RBBAJA_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(232, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "FECHA REGISTRO :";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(169, 41);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(233, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // CMDINSERTAR
            // 
            this.CMDINSERTAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMDINSERTAR.Location = new System.Drawing.Point(8, 319);
            this.CMDINSERTAR.Name = "CMDINSERTAR";
            this.CMDINSERTAR.Size = new System.Drawing.Size(144, 37);
            this.CMDINSERTAR.TabIndex = 12;
            this.CMDINSERTAR.Text = "INSERTAR";
            this.CMDINSERTAR.UseVisualStyleBackColor = true;
            this.CMDINSERTAR.Click += new System.EventHandler(this.CMDINSERTAR_Click);
            // 
            // CMDMODIFICAR
            // 
            this.CMDMODIFICAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMDMODIFICAR.Location = new System.Drawing.Point(156, 319);
            this.CMDMODIFICAR.Name = "CMDMODIFICAR";
            this.CMDMODIFICAR.Size = new System.Drawing.Size(144, 37);
            this.CMDMODIFICAR.TabIndex = 13;
            this.CMDMODIFICAR.Text = "ACTUALIZAR";
            this.CMDMODIFICAR.UseVisualStyleBackColor = true;
            this.CMDMODIFICAR.Click += new System.EventHandler(this.CMDMODIFICAR_Click);
            // 
            // CMDCONSULTAR
            // 
            this.CMDCONSULTAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMDCONSULTAR.Location = new System.Drawing.Point(304, 319);
            this.CMDCONSULTAR.Name = "CMDCONSULTAR";
            this.CMDCONSULTAR.Size = new System.Drawing.Size(144, 37);
            this.CMDCONSULTAR.TabIndex = 14;
            this.CMDCONSULTAR.Text = "BUSCAR";
            this.CMDCONSULTAR.UseVisualStyleBackColor = true;
            this.CMDCONSULTAR.Click += new System.EventHandler(this.CMDCONSULTAR_Click);
            // 
            // CMDELIMINAR
            // 
            this.CMDELIMINAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMDELIMINAR.Location = new System.Drawing.Point(452, 319);
            this.CMDELIMINAR.Name = "CMDELIMINAR";
            this.CMDELIMINAR.Size = new System.Drawing.Size(144, 37);
            this.CMDELIMINAR.TabIndex = 15;
            this.CMDELIMINAR.Text = "ELIMINAR";
            this.CMDELIMINAR.UseVisualStyleBackColor = true;
            this.CMDELIMINAR.Click += new System.EventHandler(this.CMDELIMINAR_Click);
            // 
            // CMDSALIR
            // 
            this.CMDSALIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMDSALIR.Location = new System.Drawing.Point(452, 277);
            this.CMDSALIR.Name = "CMDSALIR";
            this.CMDSALIR.Size = new System.Drawing.Size(144, 37);
            this.CMDSALIR.TabIndex = 16;
            this.CMDSALIR.Text = "SALIR";
            this.CMDSALIR.UseVisualStyleBackColor = true;
            this.CMDSALIR.Click += new System.EventHandler(this.CMDSALIR_Click);
            // 
            // TXTID
            // 
            this.TXTID.Location = new System.Drawing.Point(234, 39);
            this.TXTID.Name = "TXTID";
            this.TXTID.Size = new System.Drawing.Size(152, 20);
            this.TXTID.TabIndex = 17;
            // 
            // TXTNOMBRE
            // 
            this.TXTNOMBRE.Location = new System.Drawing.Point(170, 71);
            this.TXTNOMBRE.Name = "TXTNOMBRE";
            this.TXTNOMBRE.Size = new System.Drawing.Size(275, 20);
            this.TXTNOMBRE.TabIndex = 18;
            // 
            // TXTAPP
            // 
            this.TXTAPP.Location = new System.Drawing.Point(170, 97);
            this.TXTAPP.Name = "TXTAPP";
            this.TXTAPP.Size = new System.Drawing.Size(275, 20);
            this.TXTAPP.TabIndex = 19;
            // 
            // TXTAPM
            // 
            this.TXTAPM.Location = new System.Drawing.Point(170, 123);
            this.TXTAPM.Name = "TXTAPM";
            this.TXTAPM.Size = new System.Drawing.Size(273, 20);
            this.TXTAPM.TabIndex = 20;
            // 
            // TXTTELEFONO
            // 
            this.TXTTELEFONO.Location = new System.Drawing.Point(170, 151);
            this.TXTTELEFONO.Name = "TXTTELEFONO";
            this.TXTTELEFONO.Size = new System.Drawing.Size(160, 20);
            this.TXTTELEFONO.TabIndex = 21;
            // 
            // TXTDOMICILIO
            // 
            this.TXTDOMICILIO.Location = new System.Drawing.Point(171, 177);
            this.TXTDOMICILIO.Name = "TXTDOMICILIO";
            this.TXTDOMICILIO.Size = new System.Drawing.Size(273, 20);
            this.TXTDOMICILIO.TabIndex = 22;
            // 
            // TXTCORREO
            // 
            this.TXTCORREO.Location = new System.Drawing.Point(423, 151);
            this.TXTCORREO.Name = "TXTCORREO";
            this.TXTCORREO.Size = new System.Drawing.Size(170, 20);
            this.TXTCORREO.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.TXTCORREO);
            this.groupBox1.Controls.Add(this.TXTDOMICILIO);
            this.groupBox1.Controls.Add(this.TXTTELEFONO);
            this.groupBox1.Controls.Add(this.TXTAPM);
            this.groupBox1.Controls.Add(this.TXTAPP);
            this.groupBox1.Controls.Add(this.TXTNOMBRE);
            this.groupBox1.Controls.Add(this.TXTID);
            this.groupBox1.Controls.Add(this.CMDSALIR);
            this.groupBox1.Controls.Add(this.CMDELIMINAR);
            this.groupBox1.Controls.Add(this.CMDCONSULTAR);
            this.groupBox1.Controls.Add(this.CMDMODIFICAR);
            this.groupBox1.Controls.Add(this.CMDINSERTAR);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 364);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EMPLEADO";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.RBBAJA);
            this.groupBox2.Controls.Add(this.RBACTIVO);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(13, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(429, 77);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(634, 389);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Empleados";
            this.Text = " + + +  EMPLEADO + + +";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton RBACTIVO;
        private System.Windows.Forms.RadioButton RBBAJA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button CMDINSERTAR;
        private System.Windows.Forms.Button CMDMODIFICAR;
        private System.Windows.Forms.Button CMDCONSULTAR;
        private System.Windows.Forms.Button CMDELIMINAR;
        private System.Windows.Forms.Button CMDSALIR;
        private System.Windows.Forms.TextBox TXTID;
        private System.Windows.Forms.TextBox TXTNOMBRE;
        private System.Windows.Forms.TextBox TXTAPP;
        private System.Windows.Forms.TextBox TXTAPM;
        private System.Windows.Forms.TextBox TXTTELEFONO;
        private System.Windows.Forms.TextBox TXTDOMICILIO;
        private System.Windows.Forms.TextBox TXTCORREO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

