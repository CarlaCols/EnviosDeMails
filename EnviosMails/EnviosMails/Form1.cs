using System;
using System.Windows.Forms;
using System.Diagnostics;
namespace EnviosMails
{
    public partial class FormSendMail : Form
    {
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
            searchFile.btnSearchFile_Click(dataDetails);
        }

        private void linkIniciarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Si el link es presionado "true"
            linkIniciarSesion.LinkVisited = true;

            //Habilita la pestaña Iniciar Sesion (tabPage1) del Tabcontrol  
            if (tabPage1.Parent == null)
            {                                             
                tabControl1.TabPages.Add(tabPage1);            
                //selecciona como principal la pestaña Iniciar Sesion(tabPage1)
                tabControl1.SelectTab(tabPage1);
            }
        }

        private void linkCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Cancela-Cierra tabPage1 inicio de Sesion
            tabControl1.TabPages.Remove(tabPage1);
        }
    }
}
