using System;
using System.Collections.Generic;
using System.Linq;
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


        public class groupByData {
            public string nis { get; set; }
            public string abiertoPor { get; set; }
            public string idInteraccion { get; set; }
            public string titulo { get; set; }
        }

        //public class dateToSendEmails
        //{
        //    public string nis { get; set; }
        //    public string abiertoPor { get; set; }
        //    public List<groupDescriptions> groupDescriptions { get; set; } = new List<groupDescriptions>();
        //}
        //public class groupDescriptions
        //{
        //    public string idInteraccion { get; set; }
        //    public string titulo { get; set; }
        //}

        private void btnSend_Click(object sender, EventArgs e)
        {
            emailBody.mailUser = txtUser.Text;
            emailBody.mailPass = txtPassword.Text;
            emailBody.mailCc = txtCC.Text;
            emailBody.mailCco = txtCCO.Text;

            //if (emailBody.mailUser != null && emailBody.mailPass != null)
            //{
                //Se instancia Clase SendMail
                SendMail send = new SendMail();

            var groupByDataGrid = new List<groupByData>();

            for (int i = 0; i < dataDetails.RowCount; i++)
            {
                groupByDataGrid.Add(new groupByData { 
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
                var dataSendToEmail = new dateToSendEmails();
                foreach (var informationToSend in itemGroupNis)
                {
                    emailBody.To = informationToSend.nis + "@gmail.com";
                    emailBody.abiertoPor = informationToSend.abiertoPor;
                    emailBody.groupDescriptions.Add(new groupDescriptions
                    {
                        IdInteraction = informationToSend.idInteraccion,
                        Title = informationToSend.titulo
                    });
                }
                send.sendMail(btnSend, emailBody, null);
            }


            for (int i = 0; i < dataDetails.RowCount; i++)
            {
                //emailBody.To = dataDetails.Rows[i].Cells[0].Value.ToString() + "@gmail.com";
                //emailBody.IdInteraction = dataDetails.Rows[i].Cells[1].Value.ToString();
                //emailBody.Message = dataDetails.Rows[i].Cells[2].Value.ToString();
                //emailBody.Title = dataDetails.Rows[i].Cells[3].Value.ToString();

                //send.sendMail(btnSend, emailBody);
            }

            //StringBuilder sb = new StringBuilder();

            //foreach (DataGridViewCell item in dataDetails.CurrentRow.Cells)
            //{
            //    sb.Append("   " + item.Value.ToString());
            //}
            //emailBody.mailBody = sb.ToString();
            ////txtCC.Text = sb.ToString();
            //send.sendMail(btnSend, emailBody);
            //}
            //else
            //{   
            //    //Habilita la pestaña Iniciar Sesion (tabPage1) del Tabcontrol  
            //    if (tabPage1.Parent == null)
            //    {
            //        tabControl1.TabPages.Add(tabPage1);

            //        //selecciona como principal la pestaña Iniciar Sesion(tabPage1)
            //        tabControl1.SelectTab(tabPage1);
            //    }
            //}
        }

      
    }
}
