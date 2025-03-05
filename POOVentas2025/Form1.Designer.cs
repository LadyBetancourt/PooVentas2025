namespace POOVentas2025
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            LblCantidad = new Label();
            label2 = new Label();
            LblPrecioUnitario = new Label();
            DgvVenta = new DataGridView();
            Cantidad = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            PrecioUnitario = new DataGridViewTextBoxColumn();
            Importe = new DataGridViewTextBoxColumn();
            TxtCantidad = new TextBox();
            TxtDescripción = new TextBox();
            BtnAgregar = new Button();
            RbContado = new RadioButton();
            RbCrédito = new RadioButton();
            LblTotal = new Label();
            TxtTotal = new TextBox();
            TxtPrecioUnitario = new TextBox();
            gbxTipoVenta = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)DgvVenta).BeginInit();
            gbxTipoVenta.SuspendLayout();
            SuspendLayout();
            // 
            // LblCantidad
            // 
            LblCantidad.AutoSize = true;
            LblCantidad.BackColor = Color.DeepPink;
            LblCantidad.ForeColor = SystemColors.ControlLightLight;
            LblCantidad.Location = new Point(14, 108);
            LblCantidad.Name = "LblCantidad";
            LblCantidad.Size = new Size(69, 20);
            LblCantidad.TabIndex = 0;
            LblCantidad.Text = "Cantidad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DeepPink;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(14, 139);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 1;
            label2.Text = "Descripción";
            // 
            // LblPrecioUnitario
            // 
            LblPrecioUnitario.AutoSize = true;
            LblPrecioUnitario.BackColor = Color.DeepPink;
            LblPrecioUnitario.ForeColor = SystemColors.ControlLightLight;
            LblPrecioUnitario.Location = new Point(14, 166);
            LblPrecioUnitario.Name = "LblPrecioUnitario";
            LblPrecioUnitario.Size = new Size(105, 20);
            LblPrecioUnitario.TabIndex = 2;
            LblPrecioUnitario.Text = "Precio unitario";
            // 
            // DgvVenta
            // 
            DgvVenta.AllowUserToAddRows = false;
            DgvVenta.AllowUserToDeleteRows = false;
            DgvVenta.BackgroundColor = Color.DeepPink;
            DgvVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvVenta.Columns.AddRange(new DataGridViewColumn[] { Cantidad, Descripcion, PrecioUnitario, Importe });
            DgvVenta.Location = new Point(12, 199);
            DgvVenta.Name = "DgvVenta";
            DgvVenta.ReadOnly = true;
            DgvVenta.RowHeadersVisible = false;
            DgvVenta.RowHeadersWidth = 51;
            DgvVenta.Size = new Size(511, 109);
            DgvVenta.TabIndex = 3;
            // 
            // Cantidad
            // 
            Cantidad.DataPropertyName = "Cantidad";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0.00";
            Cantidad.DefaultCellStyle = dataGridViewCellStyle5;
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Width = 125;
            // 
            // Descripcion
            // 
            Descripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Descripcion.DataPropertyName = "Descripcion";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            Descripcion.DefaultCellStyle = dataGridViewCellStyle6;
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // PrecioUnitario
            // 
            PrecioUnitario.DataPropertyName = "PrecioUnitario";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = "0.00";
            PrecioUnitario.DefaultCellStyle = dataGridViewCellStyle7;
            PrecioUnitario.HeaderText = "PrecioUnitario";
            PrecioUnitario.MinimumWidth = 6;
            PrecioUnitario.Name = "PrecioUnitario";
            PrecioUnitario.ReadOnly = true;
            PrecioUnitario.Width = 125;
            // 
            // Importe
            // 
            Importe.DataPropertyName = "Importe";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = "0.00";
            Importe.DefaultCellStyle = dataGridViewCellStyle8;
            Importe.HeaderText = "Importe";
            Importe.MinimumWidth = 6;
            Importe.Name = "Importe";
            Importe.ReadOnly = true;
            Importe.Width = 125;
            // 
            // TxtCantidad
            // 
            TxtCantidad.Location = new Point(89, 105);
            TxtCantidad.Name = "TxtCantidad";
            TxtCantidad.Size = new Size(247, 27);
            TxtCantidad.TabIndex = 4;
            // 
            // TxtDescripción
            // 
            TxtDescripción.Location = new Point(107, 136);
            TxtDescripción.Name = "TxtDescripción";
            TxtDescripción.Size = new Size(229, 27);
            TxtDescripción.TabIndex = 5;
            // 
            // BtnAgregar
            // 
            BtnAgregar.BackColor = Color.DeepPink;
            BtnAgregar.ForeColor = SystemColors.ControlLightLight;
            BtnAgregar.Location = new Point(454, 122);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(68, 52);
            BtnAgregar.TabIndex = 6;
            BtnAgregar.Text = "+";
            BtnAgregar.UseVisualStyleBackColor = false;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // RbContado
            // 
            RbContado.AutoSize = true;
            RbContado.ForeColor = SystemColors.ControlLightLight;
            RbContado.Location = new Point(6, 32);
            RbContado.Name = "RbContado";
            RbContado.Size = new Size(87, 24);
            RbContado.TabIndex = 7;
            RbContado.TabStop = true;
            RbContado.Text = "Contado";
            RbContado.UseVisualStyleBackColor = true;
            // 
            // RbCrédito
            // 
            RbCrédito.AutoSize = true;
            RbCrédito.ForeColor = SystemColors.ControlLightLight;
            RbCrédito.Location = new Point(6, 59);
            RbCrédito.Name = "RbCrédito";
            RbCrédito.Size = new Size(79, 24);
            RbCrédito.TabIndex = 8;
            RbCrédito.TabStop = true;
            RbCrédito.Text = "Crédito";
            RbCrédito.UseVisualStyleBackColor = true;
            // 
            // LblTotal
            // 
            LblTotal.AutoSize = true;
            LblTotal.BackColor = Color.DeepPink;
            LblTotal.ForeColor = SystemColors.ControlLightLight;
            LblTotal.Location = new Point(350, 317);
            LblTotal.Name = "LblTotal";
            LblTotal.Size = new Size(42, 20);
            LblTotal.TabIndex = 9;
            LblTotal.Text = "Total";
            // 
            // TxtTotal
            // 
            TxtTotal.Location = new Point(398, 314);
            TxtTotal.Name = "TxtTotal";
            TxtTotal.Size = new Size(125, 27);
            TxtTotal.TabIndex = 10;
            // 
            // TxtPrecioUnitario
            // 
            TxtPrecioUnitario.Location = new Point(125, 166);
            TxtPrecioUnitario.Name = "TxtPrecioUnitario";
            TxtPrecioUnitario.Size = new Size(211, 27);
            TxtPrecioUnitario.TabIndex = 11;
            // 
            // gbxTipoVenta
            // 
            gbxTipoVenta.BackColor = Color.DeepPink;
            gbxTipoVenta.Controls.Add(RbContado);
            gbxTipoVenta.Controls.Add(RbCrédito);
            gbxTipoVenta.ForeColor = SystemColors.ControlLightLight;
            gbxTipoVenta.Location = new Point(342, 105);
            gbxTipoVenta.Name = "gbxTipoVenta";
            gbxTipoVenta.Size = new Size(106, 88);
            gbxTipoVenta.TabIndex = 12;
            gbxTipoVenta.TabStop = false;
            gbxTipoVenta.Text = "Tipo venta";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Imagen_de_WhatsApp_2025_03_04_a_las_10_331;
            ClientSize = new Size(535, 350);
            Controls.Add(gbxTipoVenta);
            Controls.Add(TxtPrecioUnitario);
            Controls.Add(TxtTotal);
            Controls.Add(LblTotal);
            Controls.Add(BtnAgregar);
            Controls.Add(TxtDescripción);
            Controls.Add(TxtCantidad);
            Controls.Add(DgvVenta);
            Controls.Add(LblPrecioUnitario);
            Controls.Add(label2);
            Controls.Add(LblCantidad);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DgvVenta).EndInit();
            gbxTipoVenta.ResumeLayout(false);
            gbxTipoVenta.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblCantidad;
        private Label label2;
        private Label LblPrecioUnitario;
        private DataGridView DgvVenta;
        private TextBox TxtCantidad;
        private TextBox TxtDescripción;
        private Button BtnAgregar;
        private RadioButton RbContado;
        private RadioButton RbCrédito;
        private Label LblTotal;
        private TextBox TxtTotal;
        private TextBox TxtPrecioUnitario;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn PrecioUnitario;
        private DataGridViewTextBoxColumn Importe;
        private GroupBox gbxTipoVenta;
    }
}
