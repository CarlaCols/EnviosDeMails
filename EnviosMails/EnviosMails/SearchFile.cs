using ExcelDataReader;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace EnviosMails
{
    public class SearchFile 
    {
        public void SearchFiles (DataGridView dataGrid)
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

                    // Se crea variable getExtension para obtener la extension del tipo de archivo que se subio (*.xls;*.xlsx;*.xlsm;*.csv)
                    string getExtension = openFileDialog.SafeFileName.Substring(openFileDialog.SafeFileName.LastIndexOf('.') + 1);

                    if (getExtension == "csv")
                    //Si es .Csv utilizara CreateCsvReader
                    {
                        reader = ExcelReaderFactory.CreateCsvReader(fileStream);
                    }
                    //Si es xls .xlsx .xlsm; utilizara CreateReader
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

                    // obtener datos de cada hoja por su índice o su "nombre"
                    var dataTable = dataSet.Tables[0];
                    dataGrid.DataSource = dataSet.Tables[0];
                    //Ordena alfabeicamente
                    dataGrid.Sort(dataGrid.Columns[0], System.ComponentModel.ListSortDirection.Ascending);

                }
            };
        }

    }

}
