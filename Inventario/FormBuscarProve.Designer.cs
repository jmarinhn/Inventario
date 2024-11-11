namespace Inventario
{
    partial class FormBuscarProve
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.apellidobuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cargarBD = new System.Windows.Forms.Button();
            this.agregar = new System.Windows.Forms.Button();
            this.buscar = new System.Windows.Forms.Button();
            this.nombrebuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridBuscar = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.apellidobuscar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cargarBD);
            this.groupBox1.Controls.Add(this.agregar);
            this.groupBox1.Controls.Add(this.buscar);
            this.groupBox1.Controls.Add(this.nombrebuscar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(49, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 119);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro Personalizado (Nombre de Proveedor)";
            // 
            // apellidobuscar
            // 
            this.apellidobuscar.Location = new System.Drawing.Point(122, 80);
            this.apellidobuscar.Name = "apellidobuscar";
            this.apellidobuscar.Size = new System.Drawing.Size(300, 20);
            this.apellidobuscar.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingrese Apellido:";
            // 
            // cargarBD
            // 
            this.cargarBD.Location = new System.Drawing.Point(623, 58);
            this.cargarBD.Name = "cargarBD";
            this.cargarBD.Size = new System.Drawing.Size(75, 23);
            this.cargarBD.TabIndex = 4;
            this.cargarBD.Text = "CargarBD";
            this.cargarBD.UseVisualStyleBackColor = true;
            this.cargarBD.Click += new System.EventHandler(this.cargarBD_Click_1);
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(533, 58);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(75, 23);
            this.agregar.TabIndex = 3;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click_1);
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(442, 58);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 2;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click_1);
            // 
            // nombrebuscar
            // 
            this.nombrebuscar.Location = new System.Drawing.Point(122, 42);
            this.nombrebuscar.Name = "nombrebuscar";
            this.nombrebuscar.Size = new System.Drawing.Size(300, 20);
            this.nombrebuscar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese Nombre:";
            // 
            // dataGridBuscar
            // 
            this.dataGridBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBuscar.Location = new System.Drawing.Point(49, 180);
            this.dataGridBuscar.Name = "dataGridBuscar";
            this.dataGridBuscar.Size = new System.Drawing.Size(714, 150);
            this.dataGridBuscar.TabIndex = 2;
            // 
            // FormBuscarProve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridBuscar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormBuscarProve";
            this.Text = "FormBuscarProve";
            this.Load += new System.EventHandler(this.FormBuscarProve_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBuscar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cargarBD;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.TextBox nombrebuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private System.Windows.Forms.DataGridView dataGridBuscar;
        private System.Windows.Forms.TextBox apellidobuscar;
        private System.Windows.Forms.Label label2;
    }
}