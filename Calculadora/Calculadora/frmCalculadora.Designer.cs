namespace Calculadora
{
    partial class frmCalculadora
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.rbtBasicas = new System.Windows.Forms.CheckBox();
            this.rbtAvanzadas = new System.Windows.Forms.CheckBox();
            this.lstBasicas = new System.Windows.Forms.ListBox();
            this.lstAvanzadas = new System.Windows.Forms.ListBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnfin = new System.Windows.Forms.Button();
            this.btnCuadratica = new System.Windows.Forms.Button();
            this.btnConversiones = new System.Windows.Forms.Button();
            this.btnFechas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Numero 2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Resultado:";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(100, 20);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 20);
            this.txtNum1.TabIndex = 1;
            this.txtNum1.TextChanged += new System.EventHandler(this.txtN1_TextChanged);
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(100, 46);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 20);
            this.txtNum2.TabIndex = 1;
            this.txtNum2.TextChanged += new System.EventHandler(this.txtN1_TextChanged);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(100, 68);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 1;
            this.txtResultado.TextChanged += new System.EventHandler(this.txtN1_TextChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(114, 104);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // rbtBasicas
            // 
            this.rbtBasicas.AutoSize = true;
            this.rbtBasicas.Location = new System.Drawing.Point(12, 145);
            this.rbtBasicas.Name = "rbtBasicas";
            this.rbtBasicas.Size = new System.Drawing.Size(63, 17);
            this.rbtBasicas.TabIndex = 3;
            this.rbtBasicas.Text = "Basicas";
            this.rbtBasicas.UseVisualStyleBackColor = true;
            this.rbtBasicas.CheckedChanged += new System.EventHandler(this.rbtBasicas_CheckedChanged);
            // 
            // rbtAvanzadas
            // 
            this.rbtAvanzadas.AutoSize = true;
            this.rbtAvanzadas.Location = new System.Drawing.Point(152, 145);
            this.rbtAvanzadas.Name = "rbtAvanzadas";
            this.rbtAvanzadas.Size = new System.Drawing.Size(79, 17);
            this.rbtAvanzadas.TabIndex = 3;
            this.rbtAvanzadas.Text = "Avanzadas";
            this.rbtAvanzadas.UseVisualStyleBackColor = true;
            this.rbtAvanzadas.CheckedChanged += new System.EventHandler(this.rbtAvanzadas_CheckedChanged);
            // 
            // lstBasicas
            // 
            this.lstBasicas.FormattingEnabled = true;
            this.lstBasicas.Items.AddRange(new object[] {
            "Suma",
            "Resta",
            "Multiplicacion",
            "Division"});
            this.lstBasicas.Location = new System.Drawing.Point(12, 169);
            this.lstBasicas.Name = "lstBasicas";
            this.lstBasicas.Size = new System.Drawing.Size(120, 95);
            this.lstBasicas.TabIndex = 4;
            // 
            // lstAvanzadas
            // 
            this.lstAvanzadas.FormattingEnabled = true;
            this.lstAvanzadas.Items.AddRange(new object[] {
            "Raiz n",
            "Potencia",
            "Exponente",
            "Mod"});
            this.lstAvanzadas.Location = new System.Drawing.Point(146, 169);
            this.lstAvanzadas.Name = "lstAvanzadas";
            this.lstAvanzadas.Size = new System.Drawing.Size(120, 95);
            this.lstAvanzadas.TabIndex = 4;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(12, 274);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnfin
            // 
            this.btnfin.Location = new System.Drawing.Point(256, 274);
            this.btnfin.Name = "btnfin";
            this.btnfin.Size = new System.Drawing.Size(75, 23);
            this.btnfin.TabIndex = 5;
            this.btnfin.Text = "Finalizar";
            this.btnfin.UseVisualStyleBackColor = true;
            this.btnfin.Click += new System.EventHandler(this.btnfin_Click);
            // 
            // btnCuadratica
            // 
            this.btnCuadratica.Location = new System.Drawing.Point(272, 169);
            this.btnCuadratica.Name = "btnCuadratica";
            this.btnCuadratica.Size = new System.Drawing.Size(75, 23);
            this.btnCuadratica.TabIndex = 6;
            this.btnCuadratica.Text = "Cuadratica";
            this.btnCuadratica.UseVisualStyleBackColor = true;
            this.btnCuadratica.Click += new System.EventHandler(this.btnCuadratica_Click);
            // 
            // btnConversiones
            // 
            this.btnConversiones.Location = new System.Drawing.Point(272, 198);
            this.btnConversiones.Name = "btnConversiones";
            this.btnConversiones.Size = new System.Drawing.Size(75, 23);
            this.btnConversiones.TabIndex = 7;
            this.btnConversiones.Text = "Conversiones";
            this.btnConversiones.UseVisualStyleBackColor = true;
            this.btnConversiones.Click += new System.EventHandler(this.btnConversiones_Click);
            // 
            // btnFechas
            // 
            this.btnFechas.Location = new System.Drawing.Point(272, 227);
            this.btnFechas.Name = "btnFechas";
            this.btnFechas.Size = new System.Drawing.Size(75, 23);
            this.btnFechas.TabIndex = 8;
            this.btnFechas.Text = "Fechas";
            this.btnFechas.UseVisualStyleBackColor = true;
            this.btnFechas.Click += new System.EventHandler(this.btnFechas_Click);
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 309);
            this.Controls.Add(this.btnFechas);
            this.Controls.Add(this.btnConversiones);
            this.Controls.Add(this.btnCuadratica);
            this.Controls.Add(this.btnfin);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lstAvanzadas);
            this.Controls.Add(this.lstBasicas);
            this.Controls.Add(this.rbtAvanzadas);
            this.Controls.Add(this.rbtBasicas);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCalculadora";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.CheckBox rbtBasicas;
        private System.Windows.Forms.CheckBox rbtAvanzadas;
        private System.Windows.Forms.ListBox lstBasicas;
        private System.Windows.Forms.ListBox lstAvanzadas;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnfin;
        private System.Windows.Forms.Button btnCuadratica;
        private System.Windows.Forms.Button btnConversiones;
        private System.Windows.Forms.Button btnFechas;
    }
}

