using System.Windows.Forms;

namespace Practico_5__C__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk_1(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DataGridView1.Columns["Eliminar"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DataGridView1.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Configura la fuente para la columna "Nombre"
            DataGridView1.Columns["Nombre"].DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);

            // Configura la fuente para la columna "Apellido"
            DataGridView1.Columns["Apellido"].DefaultCellStyle.Font = new Font("Verdana", 10, FontStyle.Italic);
        }


        private void TNombre_TextChanged(object sender, EventArgs e)
        {
            if (TNombre.Text.Length > 0)
            {
                TNombre.Text = char.ToUpper(TNombre.Text[0]) + TNombre.Text.Substring(1).ToLower();
                TNombre.SelectionStart = TNombre.Text.Length; // Mueve el cursor al final del texto
            }
        }

        private void TApellido_TextChanged(object sender, EventArgs e)
        {
            if (TApellido.Text.Length > 0)
            {
                TApellido.Text = char.ToUpper(TApellido.Text[0]) + TApellido.Text.Substring(1).ToLower();
                TApellido.SelectionStart = TApellido.Text.Length; // Mueve el cursor al final del texto
            }
        }



        private void BAgregar_Click(object sender, EventArgs e)
        {


            // Validación de campos vacíos
            if (string.IsNullOrWhiteSpace(TNombre.Text) ||
                string.IsNullOrWhiteSpace(TApellido.Text) ||
                string.IsNullOrWhiteSpace(TSaldo.Text) ||
                string.IsNullOrWhiteSpace(TxtFoto.Text))
            {
                MessageBox.Show("Todos los campos deben ser completados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validación de que el Nombre y Apellido solo contengan letras
            if (!EsTextoValido(TNombre.Text) || !EsTextoValido(TApellido.Text))
            {
                MessageBox.Show("El Nombre y Apellido solo deben contener letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validación de que el Saldo solo contenga números y sea un valor válido
            if (!decimal.TryParse(TSaldo.Text, out decimal saldo) || saldo < 0)
            {
                MessageBox.Show("El Saldo debe ser un número positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Crear la fila y agregar los valores de los campos
            int index = DataGridView1.Rows.Add();
            DataGridViewRow row = DataGridView1.Rows[index];


            row.Cells["Apellido"].Value = TApellido.Text;
            row.Cells["Nombre"].Value = TNombre.Text;
            row.Cells["Fecha_nacimiento"].Value = FechaNacimiento.Value.ToShortDateString();
            row.Cells["Sexo"].Value = RBMujer.Checked ? "Mujer" : "Hombre";
            row.Cells["Saldo"].Value = TSaldo.Text;

            // Verificar si hay una imagen seleccionada, si no cargar la imagen por defecto
            if (pictureUser.Image != null)
            {
                row.Cells["Foto"].Value = pictureUser.Image;
                row.Cells["Ruta"].Value = TxtFoto.Text;
            }
            else
            {
                // Ruta de la imagen por defecto
                string defaultImagePath = Path.Combine(Application.StartupPath, "Fotos", "user_7718888.png");
                Image defaultImage = Image.FromFile(defaultImagePath);
                row.Cells["Foto"].Value = Image.FromFile(defaultImagePath);
                row.Cells["Ruta"].Value = defaultImagePath;
            }

            // Cargar la imagen en el PictureBox
            try
            {
                pictureUser.Image = Image.FromFile(TxtFoto.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            // Agregar un botón "Eliminar"
            DataGridViewButtonCell btnEliminar = new DataGridViewButtonCell();
            btnEliminar.Value = "Eliminar";
            row.Cells["Eliminar"] = btnEliminar;

            // 8. Cambiar el fondo de la fila si el saldo es menor a $50
            if (int.TryParse(TSaldo.Text, out int Saldo) && Saldo < 50)
            {
                row.DefaultCellStyle.BackColor = Color.Red;
            }
        }


        private bool EsTextoValido(string texto)
        {
            foreach (char c in texto)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    return false;
                }
            }
            return true;
        }


        private void BFoto_Click(object sender, EventArgs e)
        {
            // Crear un nuevo OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Imagenes (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png|Todos los archivos (*.*)|*.*";
            openFileDialog.Title = "Seleccionar una imagen";


            // Mostrar el diálogo y verificar si el usuario seleccionó un archivo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta del archivo seleccionado
                string rutaArchivo = openFileDialog.FileName;

                // Mostrar la imagen en el PictureBox
                pictureUser.Image = Image.FromFile(rutaArchivo);

                // Mostrar la ruta del archivo en el TextBox TxtFoto
                TxtFoto.Text = rutaArchivo;
            }
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DataGridView1.SelectedRows[0];
                string sexo = selectedRow.Cells["Sexo"].Value.ToString();

                if (sexo == "Mujer")
                {
                    RBMujer.Checked = true;
                }
                else if (sexo == "Hombre")
                {
                    RBHombre.Checked = true;
                }


                if (selectedRow.Cells["Foto"].Value != null)
                {
                    pictureUser.Image = (Image)selectedRow.Cells["Foto"].Value;
                }
            }
        }









    }
}
