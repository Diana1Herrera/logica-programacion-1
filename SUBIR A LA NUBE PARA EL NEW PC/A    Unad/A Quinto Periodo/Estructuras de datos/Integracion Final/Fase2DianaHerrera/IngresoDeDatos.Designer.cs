using System;

namespace Fase2DianaHerrera
{
    partial class IngresoDeDatos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngresoDeDatos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCostoClase = new System.Windows.Forms.TextBox();
            this.txtNumeroClase = new System.Windows.Forms.TextBox();
            this.cmbInstrumento = new System.Windows.Forms.ComboBox();
            this.radioButtonFemenino = new System.Windows.Forms.RadioButton();
            this.groupGenero = new System.Windows.Forms.GroupBox();
            this.radioButtonMasculi = new System.Windows.Forms.RadioButton();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupGenero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Instrumento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(88, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Costo por clase";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(88, 239);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Numero de clases";
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(285, 57);
            this.txtIdentificacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(160, 22);
            this.txtIdentificacion.TabIndex = 5;
            this.txtIdentificacion.TextChanged += new System.EventHandler(this.txtIdentificacion_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(285, 103);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(160, 22);
            this.txtName.TabIndex = 6;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtCostoClase
            // 
            this.txtCostoClase.Enabled = false;
            this.txtCostoClase.Location = new System.Drawing.Point(285, 193);
            this.txtCostoClase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCostoClase.Name = "txtCostoClase";
            this.txtCostoClase.Size = new System.Drawing.Size(160, 22);
            this.txtCostoClase.TabIndex = 7;
            // 
            // txtNumeroClase
            // 
            this.txtNumeroClase.Location = new System.Drawing.Point(285, 241);
            this.txtNumeroClase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumeroClase.Name = "txtNumeroClase";
            this.txtNumeroClase.Size = new System.Drawing.Size(160, 22);
            this.txtNumeroClase.TabIndex = 8;
            this.txtNumeroClase.TextChanged += new System.EventHandler(this.txtNumeroClase_TextChanged);
            // 
            // cmbInstrumento
            // 
            this.cmbInstrumento.FormattingEnabled = true;
            this.cmbInstrumento.Items.AddRange(new object[] {
            "Piano",
            "Guitarra",
            "Bateria",
            "Violin",
            "Canto"});
            this.cmbInstrumento.Location = new System.Drawing.Point(285, 143);
            this.cmbInstrumento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbInstrumento.Name = "cmbInstrumento";
            this.cmbInstrumento.Size = new System.Drawing.Size(160, 24);
            this.cmbInstrumento.TabIndex = 9;
            this.cmbInstrumento.SelectedIndexChanged += new System.EventHandler(this.cmbInstrumento_SelectedIndexChanged);
            // 
            // radioButtonFemenino
            // 
            this.radioButtonFemenino.AutoSize = true;
            this.radioButtonFemenino.Location = new System.Drawing.Point(39, 23);
            this.radioButtonFemenino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonFemenino.Name = "radioButtonFemenino";
            this.radioButtonFemenino.Size = new System.Drawing.Size(107, 26);
            this.radioButtonFemenino.TabIndex = 10;
            this.radioButtonFemenino.TabStop = true;
            this.radioButtonFemenino.Text = "Femenino";
            this.radioButtonFemenino.UseVisualStyleBackColor = true;
            // 
            // groupGenero
            // 
            this.groupGenero.Controls.Add(this.radioButtonMasculi);
            this.groupGenero.Controls.Add(this.radioButtonFemenino);
            this.groupGenero.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupGenero.Location = new System.Drawing.Point(488, 169);
            this.groupGenero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupGenero.Name = "groupGenero";
            this.groupGenero.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupGenero.Size = new System.Drawing.Size(267, 123);
            this.groupGenero.TabIndex = 11;
            this.groupGenero.TabStop = false;
            this.groupGenero.Text = "Genero";
            this.groupGenero.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButtonMasculi
            // 
            this.radioButtonMasculi.AutoSize = true;
            this.radioButtonMasculi.Location = new System.Drawing.Point(39, 52);
            this.radioButtonMasculi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonMasculi.Name = "radioButtonMasculi";
            this.radioButtonMasculi.Size = new System.Drawing.Size(112, 26);
            this.radioButtonMasculi.TabIndex = 11;
            this.radioButtonMasculi.TabStop = true;
            this.radioButtonMasculi.Text = "Masculino";
            this.radioButtonMasculi.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.Location = new System.Drawing.Point(100, 320);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(121, 52);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.Fuchsia;
            this.btnMostrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMostrar.BackgroundImage")));
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnMostrar.Location = new System.Drawing.Point(271, 320);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(180, 52);
            this.btnMostrar.TabIndex = 13;
            this.btnMostrar.Text = "Calcular/Mostrar Reporte";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnSalir.Location = new System.Drawing.Point(500, 320);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(144, 52);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(239, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(285, 30);
            this.label6.TabIndex = 15;
            this.label6.Text = "INGRESA TUS DATOS";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // IngresoDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(796, 425);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupGenero);
            this.Controls.Add(this.cmbInstrumento);
            this.Controls.Add(this.txtNumeroClase);
            this.Controls.Add(this.txtCostoClase);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "IngresoDeDatos";
            this.Text = "IngresoDeDatos";
            this.Load += new System.EventHandler(this.IngresoDeDatos_Load);
            this.groupGenero.ResumeLayout(false);
            this.groupGenero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void IngresoDeDatos_Load(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCostoClase;
        private System.Windows.Forms.TextBox txtNumeroClase;
        private System.Windows.Forms.ComboBox cmbInstrumento;
        private System.Windows.Forms.RadioButton radioButtonFemenino;
        private System.Windows.Forms.GroupBox groupGenero;
        private System.Windows.Forms.RadioButton radioButtonMasculi;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}