namespace PracticaVisor
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.abrir = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.anterior = new System.Windows.Forms.ToolStripButton();
            this.siguiente = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aumentar = new System.Windows.Forms.ToolStripButton();
            this.disminuir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.rotarHorario = new System.Windows.Forms.ToolStripButton();
            this.rotarsentidoantihorario = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.eliminarImagen = new System.Windows.Forms.ToolStripButton();
            this.limpiar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.abrirImagenes = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.expandir = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirImágenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagenActualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todasLasImágenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarVisorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ediciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagenAnteriorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagenSiguienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.irAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aumentarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disminuirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotarDerechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotarIzquierdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desplazarArribaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desplazarAbajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desplazarIzquierdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desplazarDerechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expandirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagenPrinci = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPrinci)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // abrir
            // 
            this.abrir.FileName = "abrir";
            this.abrir.Filter = "Imagenes|*.jpg;*.png;*.gif;";
            this.abrir.Multiselect = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(25, 479);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "0/0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(-1, 459);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 12;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox6, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox7, 6, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(603, 63);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox2.Location = new System.Drawing.Point(89, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(78, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox3.Location = new System.Drawing.Point(175, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(78, 57);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox4.Location = new System.Drawing.Point(261, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(78, 57);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Black;
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox6.Location = new System.Drawing.Point(433, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(78, 57);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 9;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Black;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox5.Location = new System.Drawing.Point(347, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(78, 57);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Black;
            this.pictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox7.Location = new System.Drawing.Point(519, 3);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(79, 57);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 10;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 511F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.toolStrip1, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(29, 473);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(603, 36);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anterior,
            this.siguiente,
            this.toolStripSeparator1,
            this.aumentar,
            this.disminuir,
            this.toolStripSeparator2,
            this.rotarHorario,
            this.rotarsentidoantihorario,
            this.toolStripSeparator3,
            this.eliminarImagen,
            this.limpiar,
            this.toolStripSeparator5,
            this.abrirImagenes,
            this.toolStripSeparator4,
            this.expandir});
            this.toolStrip1.Location = new System.Drawing.Point(46, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(511, 36);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.MouseHover += new System.EventHandler(this.toolStrip1_MouseHover);
            // 
            // anterior
            // 
            this.anterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.anterior.Image = ((System.Drawing.Image)(resources.GetObject("anterior.Image")));
            this.anterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.anterior.Name = "anterior";
            this.anterior.Padding = new System.Windows.Forms.Padding(20, 10, 0, 0);
            this.anterior.Size = new System.Drawing.Size(44, 33);
            this.anterior.Text = "Anterior";
            this.anterior.Click += new System.EventHandler(this.anterior_Click);
            // 
            // siguiente
            // 
            this.siguiente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.siguiente.Image = ((System.Drawing.Image)(resources.GetObject("siguiente.Image")));
            this.siguiente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.siguiente.Name = "siguiente";
            this.siguiente.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.siguiente.Size = new System.Drawing.Size(44, 33);
            this.siguiente.Text = "siguiente";
            this.siguiente.Click += new System.EventHandler(this.siguiente_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.White;
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 36);
            // 
            // aumentar
            // 
            this.aumentar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aumentar.Image = ((System.Drawing.Image)(resources.GetObject("aumentar.Image")));
            this.aumentar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aumentar.Name = "aumentar";
            this.aumentar.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.aumentar.Size = new System.Drawing.Size(44, 33);
            this.aumentar.Text = "aumentar";
            this.aumentar.Click += new System.EventHandler(this.aumentar_Click);
            // 
            // disminuir
            // 
            this.disminuir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.disminuir.Image = ((System.Drawing.Image)(resources.GetObject("disminuir.Image")));
            this.disminuir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.disminuir.Name = "disminuir";
            this.disminuir.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.disminuir.Size = new System.Drawing.Size(44, 33);
            this.disminuir.Text = "disminuir";
            this.disminuir.Click += new System.EventHandler(this.disminuir_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.Color.White;
            this.toolStripSeparator2.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 36);
            // 
            // rotarHorario
            // 
            this.rotarHorario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rotarHorario.Image = ((System.Drawing.Image)(resources.GetObject("rotarHorario.Image")));
            this.rotarHorario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rotarHorario.Name = "rotarHorario";
            this.rotarHorario.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.rotarHorario.Size = new System.Drawing.Size(44, 33);
            this.rotarHorario.Text = "Rotar derecha";
            this.rotarHorario.Click += new System.EventHandler(this.rotarHorario_Click);
            // 
            // rotarsentidoantihorario
            // 
            this.rotarsentidoantihorario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rotarsentidoantihorario.Image = ((System.Drawing.Image)(resources.GetObject("rotarsentidoantihorario.Image")));
            this.rotarsentidoantihorario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rotarsentidoantihorario.Name = "rotarsentidoantihorario";
            this.rotarsentidoantihorario.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.rotarsentidoantihorario.Size = new System.Drawing.Size(44, 33);
            this.rotarsentidoantihorario.Text = "Rotar izquierda";
            this.rotarsentidoantihorario.Click += new System.EventHandler(this.rotarsentidoantihorario_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.BackColor = System.Drawing.Color.White;
            this.toolStripSeparator3.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 36);
            // 
            // eliminarImagen
            // 
            this.eliminarImagen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eliminarImagen.Image = ((System.Drawing.Image)(resources.GetObject("eliminarImagen.Image")));
            this.eliminarImagen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.eliminarImagen.Name = "eliminarImagen";
            this.eliminarImagen.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.eliminarImagen.Size = new System.Drawing.Size(44, 33);
            this.eliminarImagen.Text = "toolStripButton8";
            this.eliminarImagen.ToolTipText = "Eliminar imagen";
            this.eliminarImagen.Click += new System.EventHandler(this.eliminarImagen_Click);
            // 
            // limpiar
            // 
            this.limpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.limpiar.Image = ((System.Drawing.Image)(resources.GetObject("limpiar.Image")));
            this.limpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.limpiar.Name = "limpiar";
            this.limpiar.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.limpiar.Size = new System.Drawing.Size(44, 33);
            this.limpiar.Text = "Limpiar imágenes";
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripSeparator5.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 36);
            // 
            // abrirImagenes
            // 
            this.abrirImagenes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.abrirImagenes.Image = ((System.Drawing.Image)(resources.GetObject("abrirImagenes.Image")));
            this.abrirImagenes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.abrirImagenes.Name = "abrirImagenes";
            this.abrirImagenes.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.abrirImagenes.Size = new System.Drawing.Size(44, 33);
            this.abrirImagenes.Text = "toolStripButton7";
            this.abrirImagenes.ToolTipText = "Abrir imagenes";
            this.abrirImagenes.Click += new System.EventHandler(this.abrirImagenes_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.BackColor = System.Drawing.Color.White;
            this.toolStripSeparator4.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 36);
            // 
            // expandir
            // 
            this.expandir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.expandir.Image = ((System.Drawing.Image)(resources.GetObject("expandir.Image")));
            this.expandir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.expandir.Name = "expandir";
            this.expandir.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.expandir.Size = new System.Drawing.Size(44, 33);
            this.expandir.Text = "expandir";
            this.expandir.Click += new System.EventHandler(this.expandir_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ediciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(2, 2);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(603, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseHover += new System.EventHandler(this.menuStrip1_MouseHover);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirImágenesToolStripMenuItem,
            this.limpiarToolStripMenuItem,
            this.cerrarVisorToolStripMenuItem});
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // abrirImágenesToolStripMenuItem
            // 
            this.abrirImágenesToolStripMenuItem.Name = "abrirImágenesToolStripMenuItem";
            this.abrirImágenesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.abrirImágenesToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.abrirImágenesToolStripMenuItem.Text = "&Abrir imágenes...";
            this.abrirImágenesToolStripMenuItem.Click += new System.EventHandler(this.abrirImágenesToolStripMenuItem_Click);
            // 
            // limpiarToolStripMenuItem
            // 
            this.limpiarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imagenActualToolStripMenuItem,
            this.todasLasImágenesToolStripMenuItem});
            this.limpiarToolStripMenuItem.Name = "limpiarToolStripMenuItem";
            this.limpiarToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.limpiarToolStripMenuItem.Text = "&Limpiar...";
            // 
            // imagenActualToolStripMenuItem
            // 
            this.imagenActualToolStripMenuItem.Name = "imagenActualToolStripMenuItem";
            this.imagenActualToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.imagenActualToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imagenActualToolStripMenuItem.Text = "&Imagen actual";
            this.imagenActualToolStripMenuItem.Click += new System.EventHandler(this.imagenActualToolStripMenuItem_Click);
            // 
            // todasLasImágenesToolStripMenuItem
            // 
            this.todasLasImágenesToolStripMenuItem.Name = "todasLasImágenesToolStripMenuItem";
            this.todasLasImágenesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.todasLasImágenesToolStripMenuItem.Text = "&Todas las imágenes";
            this.todasLasImágenesToolStripMenuItem.Click += new System.EventHandler(this.todasLasImágenesToolStripMenuItem_Click);
            // 
            // cerrarVisorToolStripMenuItem
            // 
            this.cerrarVisorToolStripMenuItem.Name = "cerrarVisorToolStripMenuItem";
            this.cerrarVisorToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.cerrarVisorToolStripMenuItem.Text = "&Cerrar Visor";
            this.cerrarVisorToolStripMenuItem.Click += new System.EventHandler(this.cerrarVisorToolStripMenuItem_Click);
            // 
            // ediciónToolStripMenuItem
            // 
            this.ediciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imagenAnteriorToolStripMenuItem,
            this.imagenSiguienteToolStripMenuItem,
            this.irAToolStripMenuItem,
            this.zoomToolStripMenuItem,
            this.rotarToolStripMenuItem,
            this.moverToolStripMenuItem,
            this.expandirToolStripMenuItem});
            this.ediciónToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ediciónToolStripMenuItem.Name = "ediciónToolStripMenuItem";
            this.ediciónToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ediciónToolStripMenuItem.Text = "&Edición";
            // 
            // imagenAnteriorToolStripMenuItem
            // 
            this.imagenAnteriorToolStripMenuItem.Name = "imagenAnteriorToolStripMenuItem";
            this.imagenAnteriorToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.imagenAnteriorToolStripMenuItem.Text = "Imagen &anterior";
            this.imagenAnteriorToolStripMenuItem.Click += new System.EventHandler(this.imagenAnteriorToolStripMenuItem_Click);
            // 
            // imagenSiguienteToolStripMenuItem
            // 
            this.imagenSiguienteToolStripMenuItem.Name = "imagenSiguienteToolStripMenuItem";
            this.imagenSiguienteToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.imagenSiguienteToolStripMenuItem.Text = "Imagen &siguiente";
            this.imagenSiguienteToolStripMenuItem.Click += new System.EventHandler(this.imagenSiguienteToolStripMenuItem_Click);
            // 
            // irAToolStripMenuItem
            // 
            this.irAToolStripMenuItem.Name = "irAToolStripMenuItem";
            this.irAToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.irAToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.irAToolStripMenuItem.Text = "&Ir a la Imagen...";
            this.irAToolStripMenuItem.Click += new System.EventHandler(this.irAToolStripMenuItem_Click);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aumentarToolStripMenuItem,
            this.disminuirToolStripMenuItem});
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.zoomToolStripMenuItem.Text = "&Zoom...";
            // 
            // aumentarToolStripMenuItem
            // 
            this.aumentarToolStripMenuItem.Name = "aumentarToolStripMenuItem";
            this.aumentarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.aumentarToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.aumentarToolStripMenuItem.Text = "&Aumentar";
            this.aumentarToolStripMenuItem.Click += new System.EventHandler(this.aumentarToolStripMenuItem_Click);
            // 
            // disminuirToolStripMenuItem
            // 
            this.disminuirToolStripMenuItem.Name = "disminuirToolStripMenuItem";
            this.disminuirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.disminuirToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.disminuirToolStripMenuItem.Text = "&Disminuir";
            this.disminuirToolStripMenuItem.Click += new System.EventHandler(this.disminuirToolStripMenuItem_Click);
            // 
            // rotarToolStripMenuItem
            // 
            this.rotarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotarDerechaToolStripMenuItem,
            this.rotarIzquierdaToolStripMenuItem});
            this.rotarToolStripMenuItem.Name = "rotarToolStripMenuItem";
            this.rotarToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.rotarToolStripMenuItem.Text = "&Rotar...";
            // 
            // rotarDerechaToolStripMenuItem
            // 
            this.rotarDerechaToolStripMenuItem.Name = "rotarDerechaToolStripMenuItem";
            this.rotarDerechaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.rotarDerechaToolStripMenuItem.Text = "&Derecha";
            this.rotarDerechaToolStripMenuItem.Click += new System.EventHandler(this.rotarDerechaToolStripMenuItem_Click);
            // 
            // rotarIzquierdaToolStripMenuItem
            // 
            this.rotarIzquierdaToolStripMenuItem.Name = "rotarIzquierdaToolStripMenuItem";
            this.rotarIzquierdaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.rotarIzquierdaToolStripMenuItem.Text = "&Izquierda";
            this.rotarIzquierdaToolStripMenuItem.Click += new System.EventHandler(this.rotarIzquierdaToolStripMenuItem_Click);
            // 
            // moverToolStripMenuItem
            // 
            this.moverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desplazarArribaToolStripMenuItem,
            this.desplazarAbajoToolStripMenuItem,
            this.desplazarIzquierdaToolStripMenuItem,
            this.desplazarDerechaToolStripMenuItem});
            this.moverToolStripMenuItem.Name = "moverToolStripMenuItem";
            this.moverToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.moverToolStripMenuItem.Text = "&Desplazar...";
            // 
            // desplazarArribaToolStripMenuItem
            // 
            this.desplazarArribaToolStripMenuItem.Name = "desplazarArribaToolStripMenuItem";
            this.desplazarArribaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
            this.desplazarArribaToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.desplazarArribaToolStripMenuItem.Text = "&Arriba";
            this.desplazarArribaToolStripMenuItem.Click += new System.EventHandler(this.desplazarArribaToolStripMenuItem_Click);
            // 
            // desplazarAbajoToolStripMenuItem
            // 
            this.desplazarAbajoToolStripMenuItem.Name = "desplazarAbajoToolStripMenuItem";
            this.desplazarAbajoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
            this.desplazarAbajoToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.desplazarAbajoToolStripMenuItem.Text = "A&bajo";
            this.desplazarAbajoToolStripMenuItem.Click += new System.EventHandler(this.desplazarAbajoToolStripMenuItem_Click);
            // 
            // desplazarIzquierdaToolStripMenuItem
            // 
            this.desplazarIzquierdaToolStripMenuItem.Name = "desplazarIzquierdaToolStripMenuItem";
            this.desplazarIzquierdaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Left)));
            this.desplazarIzquierdaToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.desplazarIzquierdaToolStripMenuItem.Text = "&Izquierda";
            this.desplazarIzquierdaToolStripMenuItem.Click += new System.EventHandler(this.desplazarIzquierdaToolStripMenuItem_Click);
            // 
            // desplazarDerechaToolStripMenuItem
            // 
            this.desplazarDerechaToolStripMenuItem.Name = "desplazarDerechaToolStripMenuItem";
            this.desplazarDerechaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Right)));
            this.desplazarDerechaToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.desplazarDerechaToolStripMenuItem.Text = "&Derecha";
            this.desplazarDerechaToolStripMenuItem.Click += new System.EventHandler(this.desplazarDerechaToolStripMenuItem_Click);
            // 
            // expandirToolStripMenuItem
            // 
            this.expandirToolStripMenuItem.Name = "expandirToolStripMenuItem";
            this.expandirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.expandirToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.expandirToolStripMenuItem.Text = "&Expandir";
            this.expandirToolStripMenuItem.Click += new System.EventHandler(this.expandirToolStripMenuItem_Click);
            // 
            // imagenPrinci
            // 
            this.imagenPrinci.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imagenPrinci.BackColor = System.Drawing.Color.Black;
            this.imagenPrinci.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagenPrinci.Cursor = System.Windows.Forms.Cursors.Cross;
            this.imagenPrinci.InitialImage = global::PracticaVisor.Properties.Resources.eye_outline_filled21;
            this.imagenPrinci.Location = new System.Drawing.Point(-4, 93);
            this.imagenPrinci.Name = "imagenPrinci";
            this.imagenPrinci.Size = new System.Drawing.Size(616, 379);
            this.imagenPrinci.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagenPrinci.TabIndex = 0;
            this.imagenPrinci.TabStop = false;
            this.imagenPrinci.WaitOnLoad = true;
            this.imagenPrinci.DragDrop += new System.Windows.Forms.DragEventHandler(this.imagenPrinci_DragDrop);
            this.imagenPrinci.DragEnter += new System.Windows.Forms.DragEventHandler(this.imagenPrinci_DragEnter);
            this.imagenPrinci.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imagenPrinci_MouseDown);
            this.imagenPrinci.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imagenPrinci_MouseMove);
            this.imagenPrinci.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imagenPrinci_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(607, 507);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imagenPrinci);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Opacity = 0.98D;
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "Visor de imágenes";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPrinci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imagenPrinci;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.OpenFileDialog abrir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton anterior;
        private System.Windows.Forms.ToolStripButton siguiente;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton aumentar;
        private System.Windows.Forms.ToolStripButton disminuir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton rotarHorario;
        private System.Windows.Forms.ToolStripButton rotarsentidoantihorario;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton eliminarImagen;
        private System.Windows.Forms.ToolStripButton limpiar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton abrirImagenes;
        private System.Windows.Forms.ToolStripButton expandir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirImágenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limpiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imagenActualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todasLasImágenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarVisorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ediciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aumentarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disminuirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotarDerechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotarIzquierdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem irAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imagenAnteriorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imagenSiguienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desplazarArribaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desplazarAbajoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desplazarIzquierdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desplazarDerechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expandirToolStripMenuItem;
    }
}

