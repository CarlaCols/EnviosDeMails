using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
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


        private void btnImportar_Click(object sender, EventArgs e)
        {
            DataSet ds;
            using (OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Excel | *.xls;*.xlsx;*.xlsm;*.csv;",
                ValidateNames = true,
                Title = "Seleccionar Archivo"
            })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileStream fileStream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read);
                    IExcelDataReader reader;



                    string getExtension = openFileDialog.SafeFileName.Substring(openFileDialog.SafeFileName.LastIndexOf('.') + 1);

                    if (getExtension == "csv")
                    {
                        reader = ExcelReaderFactory.CreateCsvReader(fileStream);
                    }
                    else
                    {
                        reader = ExcelReaderFactory.CreateReader(fileStream);
                    }



                    //// reader.IsFirstRowAsColumnNames
                    var conf = new ExcelDataSetConfiguration
                    {
                        ConfigureDataTable = _ => new ExcelDataTableConfiguration
                        {
                            UseHeaderRow = true
                        }
                    };

                    var dataSet = reader.AsDataSet(conf);

                    // Now you can get data from each sheet by its index or its "name"
                    var dataTable = dataSet.Tables[0];
                    dataDetalles.DataSource = dataSet.Tables[0];
                }
            };
        }
    }
}
