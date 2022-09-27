using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnviosMails
{
    public partial class FormSendMail : Form
    {
        EmailBody emailBody = new EmailBody();
        public FormSendMail()
        {
            InitializeComponent();
        }

        private void btnSearchFile_Click(object sender, EventArgs e)
        {
            //Se instancia la Clase SearchFilel
            SearchFile searchFile = new SearchFile();
            // se hace pase de parametro de clase SearchFile(dataGrid) a dataDetails
            searchFile.SearchFiles(dataDetails);
        }          

        //public class groupByData
        //{
        //    public string nis { get; set; }
        //    public string abiertoPor { get; set; }
        //    public string idInteraccion { get; set; }
        //    public string titulo { get; set; }
        //    public string mailPersonal { get; set; }
        //    public string correo { get; set; }
        //}
        public void btnSend_Click(object sender, EventArgs e)
        {
            ClearErrorProvider();
            //Se validan que no esten null los txt
            if (txtUser.Text == string.Empty)
            {
                errorProvider.SetError(txtUser, "Ingrese Usuario");
            }
            else
            {
                emailBody.mailUser = txtUser.Text;
               
            }
            //Se validan que no esten null los txt
            if (txtPassword.Text == string.Empty)
            {
                errorProvider.SetError(txtPassword, "Ingrese Contraseña");
            }
            else
            {
                emailBody.mailPass = txtPassword.Text;
                
            }

            emailBody.mailCc = txtCC.Text;
            emailBody.mailCco = txtCCO.Text;

            if (txtUser.Text != String.Empty && txtPassword.Text != String.Empty)
            {
                //Se valida que no este null el dataDetails
                if (dataDetails.RowCount == 0)
                {
                    errorProvider.SetError(dataDetails, "Cargue Documento");
                }
                else
                {
                    //Se instancia Clase SendMail
                    SendMail send = new SendMail();

                    //var groupByDataGrid = new List<groupByData>();


                    List<DataGridViewRow> rows = (from item in dataDetails.Rows.Cast<DataGridViewRow>()
                                                  select item).ToList<DataGridViewRow>();


                    var rowsEmail= (from item in dataDetails.Rows.Cast<DataGridViewRow>()
                                    select new
                                    {
                                        email = item.Cells[0].Value.ToString(),
                                        abiertoPor = item.Cells[1].Value.ToString(),
                                        idInteraccion = item.Cells[2].Value.ToString(),
                                        titulo = item.Cells[3].Value.ToString(),
                                        emailPersonal = item.Cells[4].Value.ToString(),
                                    }).GroupBy(g => g.email).ToArray();



                    //foreach (var item in rowsEmail[0])
                    //{
                    //    emailBody.To = item.email + "@gmail.com";
                    //    emailBody.OpenBy = item.abiertoPor;
                    //    emailBody.groupDescriptions.Add(new groupDescriptions
                    //    {
                    //        IdInteraction = item.idInteraccion,
                    //        Title = item.titulo
                    //    });

                    //}
                    //int index = 0;

                    //foreach (var item in rowsEmail[index])
                    //{
                    //    emailBody.To = item.email + "@gmail.com";
                    //    emailBody.OpenBy = item.abiertoPor;
                    //    emailBody.groupDescriptions.Add(new groupDescriptions
                    //    {
                    //        IdInteraction = item.idInteraccion,
                    //        Title = item.titulo
                    //    });
                    //    index++;
                    //}


                    for (int i = 0; i < rowsEmail.Length; i++)
                    {
                        foreach (var item in rowsEmail[i])
                        {
                            emailBody.groupDescriptions.Add(new groupDescriptions
                            {
                                IdInteraction = item.idInteraccion,
                                Title = item.titulo,
                            });
                        }

                        emailBody.To = rowsEmail[i].Select(s=>s.email).FirstOrDefault() + "@gmail.com";
                        emailBody.OpenBy = rowsEmail[i].Select(s => s.abiertoPor).FirstOrDefault();
                        send.sendMail(btnSend, emailBody);
                        emailBody.groupDescriptions.Clear();
                    }

                    //}
                    //var pepito = rows[0].Cells[0].Value.ToString();

                    //var pupu = (from data in rows 
                    //           group data by data.Cells into newGroup 
                    //           select newGroup.Key).ToList();

                    //for (int i = 0; i < rowsPUPU.Count; i++)
                    //{
                    //    rowsPUPU[0].
                    //}


                    //}

                    //foreach (DataGridViewRow row in dataDetails.Rows)
                    //{
                    //    List<DataGridViewCell> data = (from item in row.Cells.Cast<DataGridViewCell>()                                                       
                    //                                   select item).ToList<DataGridViewCell>();
                    //}



                    //var groupByNis = from data in groupByDataGrid
                    //                 group data by data.correo into newGroup
                    //                 orderby newGroup.Key
                    //                 select newGroup;



                    //send.sendMail(btnSend, emailBody);
                }

                // Se blanquean los datos
                //txtUser.Text = string.Empty;
                //txtPassword.Text = string.Empty;
                //dataDetails.DataSource = null;
                //errorProvider2.Clear();

            }   


               
        }

        private void ClearErrorProvider()
        {
            errorProvider.SetError(txtUser, "");
            errorProvider.SetError(txtPassword, "");
            errorProvider.SetError(dataDetails, null);
            
        }


    }
}
