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

            //Oculta la pestaña Iniciar Sesion (tabPage1) del Tabcontrol
            tabPage1.Parent = null;
        }

        private void btnSearchFile_Click(object sender, EventArgs e)
        {
            //Se instancia la Clase SearchFile
            SearchFile searchFile = new SearchFile();
            // se hace pase de parametro de clase SearchFile(dataGrid) a dataDetails
            searchFile.SearchFiles(dataDetails);
        }
        private void link_Cancel(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtUser2.Text = "";
            txtPassword2.Text = "";
            errorProvider.Clear();
            //Cancela-Cierra tabPage1 inicio de Sesion
            tabControl1.TabPages.Remove(tabPage1);
        }
        public void btnSave_Click(object sender, EventArgs e)
        {
            //    //Se validan que no esten null los txt

            //    if (txtUser2.Text == string.Empty)
            //    {               
            //        errorProvider.SetError(txtUser2, "Ingrese Usuario");                                              
            //    }
            //    else
            //    {
            //        emailBody.mailUser = txtUser2.Text ;
            //        errorProvider.Clear();                
            //    }

            //    if (txtPassword2.Text == string.Empty)
            //    {
            //        errorProvider.SetError(txtPassword2, "Ingrese Contraseña");                                             
            //    }
            //    else
            //    {          
            //        emailBody.mailPass = txtPassword2.Text;
            //        errorProvider.Clear();
            //    }

            //    if (txtUser2.Text != string.Empty && txtPassword2.Text != string.Empty)
            //    {
            //        tabControl1.TabPages.Remove(tabPage1);
            //        errorProvider.Clear();
            //        txtUser2.Text = "";
            //        txtPassword2.Text = "";
            //    }  
        }

        public class groupByData
        {
            public string nis { get; set; }
            public string abiertoPor { get; set; }
            public string idInteraccion { get; set; }
            public string titulo { get; set; }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            //Se validan que no esten null los txt
            if (txtUser.Text == string.Empty)
            {
                errorProvider.SetError(txtUser, "Ingrese Usuario");
            }
            else
            {
                emailBody.mailUser = txtUser.Text;
                errorProvider.Clear();
            }
            //Se validan que no esten null los txt
            if (txtPassword.Text == string.Empty)
            {
                errorProvider.SetError(txtPassword, "Ingrese Contraseña");
            }
            else
            {
                emailBody.mailPass = txtPassword.Text;
                //errorProvider.Clear();
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

                    //********************************codigo de juan*******************
                    var groupByDataGrid = new List<groupByData>();

                    for (int i = 0; i < dataDetails.RowCount; i++)
                    {
                        groupByDataGrid.Add(new groupByData
                        {
                            nis = dataDetails.Rows[i].Cells[0].Value.ToString(),
                            abiertoPor = dataDetails.Rows[i].Cells[1].Value.ToString(),
                            idInteraccion = dataDetails.Rows[i].Cells[2].Value.ToString(),
                            titulo = dataDetails.Rows[i].Cells[3].Value.ToString(),
                        });
                    }

                    var groupByNis = from data in groupByDataGrid
                                     group data by data.nis into newGroup
                                     orderby newGroup.Key
                                     select newGroup;

                    foreach (var itemGroupNis in groupByNis)
                    {
                        var dataSendToEmail = new SendMail();
                        foreach (var informationToSend in itemGroupNis)
                        {
                            emailBody.To = informationToSend.nis + "@gmail.com";
                            emailBody.OpenBy = informationToSend.abiertoPor;
                            emailBody.groupDescriptions.Add(new groupDescriptions
                            {
                                IdInteraction = informationToSend.idInteraccion,
                                Title = informationToSend.titulo
                            });
                        }
                        //send.sendMail(btnSend, emailBody);

                        //********************************codigo de juan*******************
                    }
                    //emailBody = null;
                    txtUser.Text = string.Empty;
                    txtPassword.Text = string.Empty;
                    errorProvider.Clear();
                }
                

            }
        }
    }
}
