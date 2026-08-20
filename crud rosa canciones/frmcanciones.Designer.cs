namespace crud_rosa_canciones
{
    partial class frmcanciones
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
            btn_agregar = new Button();
            dgv_canciones = new DataGridView();
            btn_eliminar = new Button();
            btn_actualizar = new Button();
            txb_titulo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txb_artista = new TextBox();
            label3 = new Label();
            txb_año = new TextBox();
            btn_limpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_canciones).BeginInit();
            SuspendLayout();
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(218, 327);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(99, 60);
            btn_agregar.TabIndex = 0;
            btn_agregar.Text = "AGREGAR";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // dgv_canciones
            // 
            dgv_canciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_canciones.Location = new Point(55, 39);
            dgv_canciones.Name = "dgv_canciones";
            dgv_canciones.Size = new Size(425, 167);
            dgv_canciones.TabIndex = 1;
            dgv_canciones.CellContentClick += dgv_canciones_CellContentClick;
            dgv_canciones.SelectionChanged += dgv_canciones_SelectionChanged;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Location = new Point(101, 327);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(99, 60);
            btn_eliminar.TabIndex = 2;
            btn_eliminar.Text = "ELIMINAR";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // btn_actualizar
            // 
            btn_actualizar.Location = new Point(332, 327);
            btn_actualizar.Name = "btn_actualizar";
            btn_actualizar.Size = new Size(99, 60);
            btn_actualizar.TabIndex = 3;
            btn_actualizar.Text = "ACTUALIZAR";
            btn_actualizar.UseVisualStyleBackColor = true;
            btn_actualizar.Click += btn_actualizar_Click;
            // 
            // txb_titulo
            // 
            txb_titulo.Location = new Point(99, 273);
            txb_titulo.Name = "txb_titulo";
            txb_titulo.Size = new Size(100, 23);
            txb_titulo.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(99, 255);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 5;
            label1.Text = "Titulo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(216, 255);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 7;
            label2.Text = "Artista";
            // 
            // txb_artista
            // 
            txb_artista.Location = new Point(216, 273);
            txb_artista.Name = "txb_artista";
            txb_artista.Size = new Size(100, 23);
            txb_artista.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(331, 255);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 9;
            label3.Text = "Año";
            // 
            // txb_año
            // 
            txb_año.Location = new Point(331, 273);
            txb_año.Name = "txb_año";
            txb_año.Size = new Size(100, 23);
            txb_año.TabIndex = 8;
            // 
            // btn_limpiar
            // 
            btn_limpiar.Location = new Point(233, 411);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(70, 37);
            btn_limpiar.TabIndex = 10;
            btn_limpiar.Text = "LIMPIAR";
            btn_limpiar.UseVisualStyleBackColor = true;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // frmcanciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.HotPink;
            ClientSize = new Size(551, 486);
            Controls.Add(btn_limpiar);
            Controls.Add(label3);
            Controls.Add(txb_año);
            Controls.Add(label2);
            Controls.Add(txb_artista);
            Controls.Add(label1);
            Controls.Add(txb_titulo);
            Controls.Add(btn_actualizar);
            Controls.Add(btn_eliminar);
            Controls.Add(dgv_canciones);
            Controls.Add(btn_agregar);
            Name = "frmcanciones";
            Text = "canciones";
            Load += frmcanciones_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_canciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_agregar;
        private DataGridView dgv_canciones;
        private Button btn_eliminar;
        private Button btn_actualizar;
        private TextBox txb_titulo;
        private Label label1;
        private Label label2;
        private TextBox txb_artista;
        private Label label3;
        private TextBox txb_año;
        private Button btn_limpiar;
    }
}