namespace Practico_5__C__
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BAgregar = new Button();
            pictureUser = new PictureBox();
            panel1 = new Panel();
            RBMujer = new RadioButton();
            RBHombre = new RadioButton();
            FechaNacimiento = new DateTimePicker();
            BFoto = new Button();
            TxtFoto = new TextBox();
            TSaldo = new TextBox();
            TApellido = new TextBox();
            TNombre = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            DataGridView1 = new DataGridView();
            Apellido = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Fecha_nacimiento = new DataGridViewTextBoxColumn();
            Sexo = new DataGridViewTextBoxColumn();
            Eliminar = new DataGridViewButtonColumn();
            Saldo = new DataGridViewTextBoxColumn();
            Foto = new DataGridViewImageColumn();
            Ruta = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureUser).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // BAgregar
            // 
            BAgregar.BackgroundImage = (Image)resources.GetObject("BAgregar.BackgroundImage");
            BAgregar.BackgroundImageLayout = ImageLayout.Stretch;
            BAgregar.Font = new Font("Book Antiqua", 13F, FontStyle.Bold);
            BAgregar.Location = new Point(240, 359);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(143, 69);
            BAgregar.TabIndex = 0;
            BAgregar.Text = "AGREGAR";
            BAgregar.UseVisualStyleBackColor = true;
            BAgregar.Click += BAgregar_Click;
            // 
            // pictureUser
            // 
            pictureUser.BackColor = Color.Transparent;
            pictureUser.BackgroundImageLayout = ImageLayout.Stretch;
            pictureUser.Location = new Point(611, 46);
            pictureUser.Name = "pictureUser";
            pictureUser.Size = new Size(262, 257);
            pictureUser.TabIndex = 1;
            pictureUser.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(RBMujer);
            panel1.Controls.Add(RBHombre);
            panel1.Controls.Add(FechaNacimiento);
            panel1.Controls.Add(BFoto);
            panel1.Controls.Add(TxtFoto);
            panel1.Controls.Add(TSaldo);
            panel1.Controls.Add(TApellido);
            panel1.Controls.Add(TNombre);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(70, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(447, 341);
            panel1.TabIndex = 2;
            // 
            // RBMujer
            // 
            RBMujer.AutoSize = true;
            RBMujer.BackColor = Color.Transparent;
            RBMujer.Location = new Point(272, 189);
            RBMujer.Name = "RBMujer";
            RBMujer.Size = new Size(70, 24);
            RBMujer.TabIndex = 14;
            RBMujer.TabStop = true;
            RBMujer.Text = "Mujer";
            RBMujer.UseVisualStyleBackColor = false;
            // 
            // RBHombre
            // 
            RBHombre.AutoSize = true;
            RBHombre.BackColor = Color.Transparent;
            RBHombre.Location = new Point(148, 189);
            RBHombre.Name = "RBHombre";
            RBHombre.Size = new Size(84, 24);
            RBHombre.TabIndex = 13;
            RBHombre.TabStop = true;
            RBHombre.Text = "Hombre";
            RBHombre.UseVisualStyleBackColor = false;
            // 
            // FechaNacimiento
            // 
            FechaNacimiento.Format = DateTimePickerFormat.Short;
            FechaNacimiento.Location = new Point(241, 146);
            FechaNacimiento.Name = "FechaNacimiento";
            FechaNacimiento.Size = new Size(131, 26);
            FechaNacimiento.TabIndex = 10;
            // 
            // BFoto
            // 
            BFoto.Location = new Point(64, 277);
            BFoto.Name = "BFoto";
            BFoto.Size = new Size(72, 29);
            BFoto.TabIndex = 9;
            BFoto.Text = "Foto";
            BFoto.UseVisualStyleBackColor = true;
            BFoto.Click += BFoto_Click;
            // 
            // TxtFoto
            // 
            TxtFoto.Location = new Point(170, 280);
            TxtFoto.Name = "TxtFoto";
            TxtFoto.Size = new Size(202, 26);
            TxtFoto.TabIndex = 8;
            TxtFoto.TextChanged += textBox4_TextChanged;
            // 
            // TSaldo
            // 
            TSaldo.Location = new Point(170, 231);
            TSaldo.Name = "TSaldo";
            TSaldo.Size = new Size(202, 26);
            TSaldo.TabIndex = 7;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(170, 91);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(202, 26);
            TApellido.TabIndex = 6;
            TApellido.TextChanged += TApellido_TextChanged;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(170, 34);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(202, 26);
            TNombre.TabIndex = 5;
            TNombre.TextChanged += TNombre_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Book Antiqua", 11F);
            label5.Location = new Point(64, 233);
            label5.Name = "label5";
            label5.Size = new Size(58, 23);
            label5.TabIndex = 4;
            label5.Text = "Saldo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Book Antiqua", 11F);
            label4.Location = new Point(64, 189);
            label4.Name = "label4";
            label4.Size = new Size(49, 23);
            label4.TabIndex = 3;
            label4.Text = "Sexo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Book Antiqua", 11F);
            label3.Location = new Point(47, 149);
            label3.Name = "label3";
            label3.Size = new Size(189, 23);
            label3.TabIndex = 2;
            label3.Text = "Fecha de Nacimiento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Book Antiqua", 11F);
            label2.Location = new Point(64, 93);
            label2.Name = "label2";
            label2.Size = new Size(85, 23);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Book Antiqua", 11F);
            label1.Location = new Point(64, 37);
            label1.Name = "label1";
            label1.Size = new Size(81, 23);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk_1;
            // 
            // DataGridView1
            // 
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Columns.AddRange(new DataGridViewColumn[] { Apellido, Nombre, Fecha_nacimiento, Sexo, Eliminar, Saldo, Foto, Ruta });
            DataGridView1.Location = new Point(2, 434);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.RowHeadersWidth = 51;
            DataGridView1.Size = new Size(1053, 164);
            DataGridView1.TabIndex = 3;
            DataGridView1.CellContentClick += DataGridView1_CellContentClick;
            DataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 6;
            Apellido.Name = "Apellido";
            Apellido.Width = 125;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // Fecha_nacimiento
            // 
            Fecha_nacimiento.HeaderText = "Fecha Nacimiento";
            Fecha_nacimiento.MinimumWidth = 6;
            Fecha_nacimiento.Name = "Fecha_nacimiento";
            Fecha_nacimiento.Width = 125;
            // 
            // Sexo
            // 
            Sexo.HeaderText = "Sexo";
            Sexo.MinimumWidth = 6;
            Sexo.Name = "Sexo";
            Sexo.Width = 125;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.MinimumWidth = 6;
            Eliminar.Name = "Eliminar";
            Eliminar.Resizable = DataGridViewTriState.True;
            Eliminar.SortMode = DataGridViewColumnSortMode.Automatic;
            Eliminar.Width = 125;
            // 
            // Saldo
            // 
            Saldo.HeaderText = "Saldo";
            Saldo.MinimumWidth = 6;
            Saldo.Name = "Saldo";
            Saldo.Width = 125;
            // 
            // Foto
            // 
            Foto.HeaderText = "Foto";
            Foto.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Foto.MinimumWidth = 6;
            Foto.Name = "Foto";
            Foto.Resizable = DataGridViewTriState.True;
            Foto.SortMode = DataGridViewColumnSortMode.Automatic;
            Foto.Width = 125;
            // 
            // Ruta
            // 
            Ruta.HeaderText = "Ruta";
            Ruta.MinimumWidth = 6;
            Ruta.Name = "Ruta";
            Ruta.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pngtree_texture_of_used_paper_sheet_isolated_on_a_white_background_image_13842948;
            ClientSize = new Size(1106, 596);
            Controls.Add(DataGridView1);
            Controls.Add(panel1);
            Controls.Add(pictureUser);
            Controls.Add(BAgregar);
            Font = new Font("Book Antiqua", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Formulario con Grid";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureUser).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BAgregar;
        private PictureBox pictureUser;
        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox TxtFoto;
        private TextBox TSaldo;
        private TextBox TApellido;
        private TextBox TNombre;
        private Button BFoto;
        //private CheckBox CBMujer;
        //private CheckBox CBHombre;
        private DateTimePicker FechaNacimiento;
        private OpenFileDialog openFileDialog1;
        private DataGridView DataGridView1;
        private RadioButton RBMujer;
        private RadioButton RBHombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Fecha_nacimiento;
        private DataGridViewTextBoxColumn Sexo;
        private DataGridViewButtonColumn Eliminar;
        private DataGridViewTextBoxColumn Saldo;
        private DataGridViewImageColumn Foto;
        private DataGridViewTextBoxColumn Ruta;
    }
}
