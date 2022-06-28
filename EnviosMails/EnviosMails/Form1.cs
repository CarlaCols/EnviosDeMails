using System;
using System.Drawing;
using System.Windows.Forms;

namespace EnviosMails
{
    public partial class FormSendMail : Form
    {
        public string mailUser { get; set; }
        public string mailPass { get; set; }
        public string mailCc { get; set; }

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
            // se hace pase de parametro de clase SearchFile a dataDetails
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
                mailUser = txtUser.Text ;
                errorProvider.Clear();                
            }

            if (txtPassword.Text == string.Empty)
            {
                errorProvider.SetError(txtPassword, "Ingrese Contraseña");                                             
            }
            else
            {          
                mailPass = txtPassword.Text;
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
        private void btnEnviar_Click(object sender, EventArgs e)
        {           
            mailCc = txtCC.Text;

            if (mailUser != null && mailPass != null)
            {
                SendMail send = new SendMail();
                send.sendMail(btnEnviar, mailUser, mailPass, mailCc);
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
