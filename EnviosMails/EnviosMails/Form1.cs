using System;
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
            txtUser.Text = "";
            txtPassword.Text = "";
            errorProvider.Clear();
            //Cancela-Cierra tabPage1 inicio de Sesion
            tabControl1.TabPages.Remove(tabPage1);
        }              
        public void btnSave_Click(object sender, EventArgs e)
        {
            //Se validan que no esten null los txt

            if (txtUser.Text == string.Empty)
            {               
                errorProvider.SetError(txtUser, "Ingrese Usuario");                                              
            }
            else
            {
                emailBody.mailUser = txtUser.Text ;
                errorProvider.Clear();                
            }

            if (txtPassword.Text == string.Empty)
            {
                errorProvider.SetError(txtPassword, "Ingrese Contraseña");                                             
            }
            else
            {          
                emailBody.mailPass = txtPassword.Text;
                errorProvider.Clear();
            }

            if (txtUser.Text != string.Empty && txtPassword.Text != string.Empty)
            {
                tabControl1.TabPages.Remove(tabPage1);
                errorProvider.Clear();
                txtUser.Text = "";
                txtPassword.Text = "";
            }  
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            emailBody.mailCc = txtCC.Text;
            emailBody.mailCco = txtCCO.Text;

            if (emailBody.mailUser != null && emailBody.mailPass != null)
            {
                SendMail send = new SendMail();
                for (int i = 0; i < dataDetails.RowCount; i++)
                {
                    emailBody.To = dataDetails.Rows[i].Cells[0].Value.ToString() + "@gmail.com";                    
                    emailBody.IdInteraction = dataDetails.Rows[i].Cells[1].Value.ToString();
                    emailBody.Message = dataDetails.Rows[i].Cells[2].Value.ToString();
                    emailBody.Title = dataDetails.Rows[i].Cells[3].Value.ToString();
                    send.sendMail(btnSend, emailBody);
                }
               
            }
            else
            {   
                //Habilita la pestaña Iniciar Sesion (tabPage1) del Tabcontrol  
                if (tabPage1.Parent == null)
                {
                    tabControl1.TabPages.Add(tabPage1);

                    //selecciona como principal la pestaña Iniciar Sesion(tabPage1)
                    tabControl1.SelectTab(tabPage1);
                }
            }
        }
               
    }
}
