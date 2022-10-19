using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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

       
        public void btnSend_Click(object sender, EventArgs e)
        {
            //ClearErrorProvider();

            //Se validan que no esten null los txt
            if (txtUser.Text == string.Empty || txtUser.Text != @"^[^@\s]+@[^@\s]+\.[^@\s]+$")
            {
                errorProvider.SetError(txtUser, "Ingrese un Mail valido");
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
 
                    //var Prueba2 = dataDetails.Columns[0].HeaderText.ToString();
                    //{
                    //}

                    //List<DataGridViewRow> rows = (from item in dataDetails.Rows.Cast<DataGridViewRow>()
                    //                              select item).ToList<DataGridViewRow>();

                    //var rows = (from item in dataDetails.Rows.Cast<DataGridViewRow>()
                    //           select new
                    //           {
                    //            email = (
                    //               new Func<string>(
                    //               () =>
                    //               {
                    //               if (new[] { "O3503", "O3504", "O3505", "O8195" }.Any(c => item.Cells[0].Value.ToString().Contains(c)))

                    //                  return item.Cells[4].Value.ToString();
                    //               else
                    //               return item.Cells[0].Value.ToString() + "@gmail.com";
                    //               }
                    //               )()
                    //               ),
                    //               abiertoPor = item.Cells[1].Value.ToString(),
                    //               idInteraccion = item.Cells[2].Value.ToString(),
                    //               titulo = item.Cells[3].Value.ToString(),
                    //               emailPersonal = item.Cells[4].Value.ToString(),
                    //               }).GroupBy(g => g.email).ToList();


                    var rows = (from item in dataDetails.Rows.Cast<DataGridViewRow>()
                                select new
                                {
                                    email = (
                                    new Func<string>(
                                    () =>
                                    {
                                        if (new[] { "O3503", "O3504", "O3505", "O8195" }.Any(c => item.Cells[0].Value.ToString().Contains(c)))

                                            return item.Cells[4].Value.ToString();
                                        else
                                            return item.Cells[0].Value.ToString() + "@gmail.com";
                                    }
                                    )()
                                    ),
                                    abiertoPor = item.Cells[1].Value.ToString(),
                                    idInteraccion = item.Cells[2].Value.ToString(),
                                    titulo = item.Cells[3].Value.ToString(),
                                    emailPersonal = dataDetails.Columns.Count > 4 ? item.Cells[4].Value.ToString() : item.Cells[3].Value.ToString(),
                                }).GroupBy(g => g.email).ToList();


                    for (int i = 0; i < rows.Count; i++)
                    {
                        foreach (var item in rows[i])
                        {
                            emailBody.groupDescriptions.Add(new groupDescriptions
                            {
                                IdInteraction = item.idInteraccion,
                                Title = item.titulo,
                                OpenBy= item.abiertoPor,
                            });
                        }

                        emailBody.To = rows[i].Select(s => s.email).FirstOrDefault();
                        emailBody.OpenBy = rows[i].Select(s => s.abiertoPor).FirstOrDefault();
                        send.sendMail(btnSend, emailBody);
                        emailBody.groupDescriptions.Clear();
                    }

                    MessageBox.Show("Mensajes Enviados");

                }

                //Blanquea los datos
                txtUser.Text = string.Empty;
                txtPassword.Text = string.Empty;
                dataDetails.DataSource = null;

            }   
               
        }
        // Blanquea los errorProvider
        private void ClearErrorProvider()
        {
            errorProvider.SetError(txtUser, "");
            errorProvider.SetError(txtPassword, "");
            errorProvider.SetError(dataDetails, null);            
        }
    }
}
