namespace Modulo2
{
    partial class Productos_Familia
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CMDINSERTAR = new System.Windows.Forms.Button();
            this.CMDMODIFICAR = new System.Windows.Forms.Button();
            this.CMDBUSCAR = new System.Windows.Forms.Button();
            this.CMDELIMINAR = new System.Windows.Forms.Button();
            this.CMDSALIR = new System.Windows.Forms.Button();
            this.TXTCLAVEFAM = new System.Windows.Forms.TextBox();
            this.TXTNOMBRE = new System.Windows.Forms.TextBox();
            this.RBACTIVO = new System.Windows.Forms.RadioButton();
            this.RBBAJA = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLAVE FAMILIA :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 73);
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
            this.label3.Location = new System.Drawing.Point(83, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "STATUS :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(296, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "FECHA DE REGISTRO :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // CMDINSERTAR
            // 
            this.CMDINSERTAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMDINSERTAR.Location = new System.Drawing.Point(2, 211);
            this.CMDINSERTAR.Name = "CMDINSERTAR";
            this.CMDINSERTAR.Size = new System.Drawing.Size(111, 33);
            this.CMDINSERTAR.TabIndex = 4;
            this.CMDINSERTAR.Text = "INSERTAR";
            this.CMDINSERTAR.UseVisualStyleBackColor = true;
            this.CMDINSERTAR.Click += new System.EventHandler(this.CMDINSERTAR_Click);
            // 
            // CMDMODIFICAR
            // 
            this.CMDMODIFICAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMDMODIFICAR.Location = new System.Drawing.Point(119, 211);
            this.CMDMODIFICAR.Name = "CMDMODIFICAR";
            this.CMDMODIFICAR.Size = new System.Drawing.Size(111, 33);
            this.CMDMODIFICAR.TabIndex = 5;
            this.CMDMODIFICAR.Text = "ACTUALIZAR";
            this.CMDMODIFICAR.UseVisualStyleBackColor = true;
            this.CMDMODIFICAR.Click += new System.EventHandler(this.CMDMODIFICAR_Click);
            // 
            // CMDBUSCAR
            // 
            this.CMDBUSCAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMDBUSCAR.Location = new System.Drawing.Point(241, 211);
            this.CMDBUSCAR.Name = "CMDBUSCAR";
            this.CMDBUSCAR.Size = new System.Drawing.Size(111, 33);
            this.CMDBUSCAR.TabIndex = 6;
            this.CMDBUSCAR.Text = "BUSCAR";
            this.CMDBUSCAR.UseVisualStyleBackColor = true;
            this.CMDBUSCAR.Click += new System.EventHandler(this.CMDBUSCAR_Click);
            // 
            // CMDELIMINAR
            // 
            this.CMDELIMINAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMDELIMINAR.Location = new System.Drawing.Point(359, 211);
            this.CMDELIMINAR.Name = "CMDELIMINAR";
            this.CMDELIMINAR.Size = new System.Drawing.Size(111, 33);
            this.CMDELIMINAR.TabIndex = 7;
            this.CMDELIMINAR.Text = "ELIMINAR";
            this.CMDELIMINAR.UseVisualStyleBackColor = true;
            this.CMDELIMINAR.Click += new System.EventHandler(this.CMDELIMINAR_Click);
            // 
            // CMDSALIR
            // 
            this.CMDSALIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMDSALIR.Location = new System.Drawing.Point(485, 194);
            this.CMDSALIR.Name = "CMDSALIR";
            this.CMDSALIR.Size = new System.Drawing.Size(85, 50);
            this.CMDSALIR.TabIndex = 8;
            this.CMDSALIR.Text = "SALIR";
            this.CMDSALIR.UseVisualStyleBackColor = true;
            this.CMDSALIR.Click += new System.EventHandler(this.CMDSALIR_Click);
            // 
            // TXTCLAVEFAM
            // 
            this.TXTCLAVEFAM.Location = new System.Drawing.Point(189, 35);
            this.TXTCLAVEFAM.Name = "TXTCLAVEFAM";
            this.TXTCLAVEFAM.Size = new System.Drawing.Size(252, 20);
            this.TXTCLAVEFAM.TabIndex = 9;
            // 
            // TXTNOMBRE
            // 
            this.TXTNOMBRE.Location = new System.Drawing.Point(189, 66);
            this.TXTNOMBRE.Name = "TXTNOMBRE";
            this.TXTNOMBRE.Size = new System.Drawing.Size(252, 20);
            this.TXTNOMBRE.TabIndex = 10;
            // 
            // RBACTIVO
            // 
            this.RBACTIVO.AutoSize = true;
            this.RBACTIVO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBACTIVO.Location = new System.Drawing.Point(45, 155);
            this.RBACTIVO.Name = "RBACTIVO";
            this.RBACTIVO.Size = new System.Drawing.Size(70, 17);
            this.RBACTIVO.TabIndex = 11;
            this.RBACTIVO.TabStop = true;
            this.RBACTIVO.Text = "ACTIVO";
            this.RBACTIVO.UseVisualStyleBackColor = true;
            this.RBACTIVO.CheckedChanged += new System.EventHandler(this.RBACTIVO_CheckedChanged);
            // 
            // RBBAJA
            // 
            this.RBBAJA.AutoSize = true;
            this.RBBAJA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBBAJA.Location = new System.Drawing.Point(151, 155);
            this.RBBAJA.Name = "RBBAJA";
            this.RBBAJA.Size = new System.Drawing.Size(55, 17);
            this.RBBAJA.TabIndex = 12;
            this.RBBAJA.TabStop = true;
            this.RBBAJA.Text = "BAJA";
            this.RBBAJA.UseVisualStyleBackColor = true;
            this.RBBAJA.CheckedChanged += new System.EventHandler(this.RBBAJA_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(300, 152);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(233, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.RBBAJA);
            this.groupBox1.Controls.Add(this.RBACTIVO);
            this.groupBox1.Controls.Add(this.TXTNOMBRE);
            this.groupBox1.Controls.Add(this.TXTCLAVEFAM);
            this.groupBox1.Controls.Add(this.CMDSALIR);
            this.groupBox1.Controls.Add(this.CMDELIMINAR);
            this.groupBox1.Controls.Add(this.CMDBUSCAR);
            this.groupBox1.Controls.Add(this.CMDMODIFICAR);
            this.groupBox1.Controls.Add(this.CMDINSERTAR);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 253);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FAMILIA";
            // 
            // Productos_Familia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(599, 260);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Productos_Familia";
            this.Text = "Productos_Familia";
            this.Load += new System.EventHandler(this.Productos_Familia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CMDINSERTAR;
        private System.Windows.Forms.Button CMDMODIFICAR;
        private System.Windows.Forms.Button CMDBUSCAR;
        private System.Windows.Forms.Button CMDELIMINAR;
        private System.Windows.Forms.Button CMDSALIR;
        private System.Windows.Forms.TextBox TXTCLAVEFAM;
        private System.Windows.Forms.TextBox TXTNOMBRE;
        private System.Windows.Forms.RadioButton RBACTIVO;
        private System.Windows.Forms.RadioButton RBBAJA;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}