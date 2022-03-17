using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnviosMails
{
    public partial class FormEnvio : Form
    {
        public FormEnvio()
        {
            InitializeComponent();
        }

        DataView ImportarDatos (string nombreArchivo)
        {
            string conexion = string.Format("Provider = Microsoft.ACE.OLEDB.16.0; Data Source = {0}; Extended properties ='Excel 16.0;'", nombreArchivo);

            OleDbConnection conector = new OleDbConnection(conexion);

            conector.Open();

            OleDbCommand consulta = new OleDbCommand("Select * from [Datos$]", conector);

            OleDbDataAdapter adaptator = new OleDbDataAdapter
            {
                SelectCommand = consulta
            };

            DataSet ds = new DataSet();

            adaptator.Fill(ds);

            conector.Close();

            return ds.Tables[0].DefaultView;
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel | *.xls;*.xlsx;*.xlsm;",
                Title = "Seleccionar Archivo"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                dataDetalles.DataSource = ImportarDatos(openFileDialog.FileName);
            }
        }
    }
}
