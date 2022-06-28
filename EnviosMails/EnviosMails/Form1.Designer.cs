
namespace EnviosMails
{
    partial class FormSendMail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSearchFile = new System.Windows.Forms.Button();
            this.dataDetails = new System.Windows.Forms.DataGridView();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtCCO = new System.Windows.Forms.TextBox();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.linkCancel = new System.Windows.Forms.LinkLabel();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDetails)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSearchFile);
            this.tabPage2.Controls.Add(this.dataDetails);
            this.tabPage2.Controls.Add(this.btnEnviar);
            this.tabPage2.Controls.Add(this.txtCCO);
            this.tabPage2.Controls.Add(this.txtCC);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lista de Devoluciones";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSearchFile
            // 
            this.btnSearchFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchFile.Image = global::EnviosMails.Properties.Resources.Search;
            this.btnSearchFile.Location = new System.Drawing.Point(751, 116);
            this.btnSearchFile.Name = "btnSearchFile";
            this.btnSearchFile.Size = new System.Drawing.Size(33, 33);
            this.btnSearchFile.TabIndex = 7;
            this.btnSearchFile.UseVisualStyleBackColor = true;
            this.btnSearchFile.Click += new System.EventHandler(this.btnSearchFile_Click);
            // 
            // dataDetails
            // 
            this.dataDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataDetails.ColumnHeadersHeight = 29;
            this.dataDetails.Location = new System.Drawing.Point(58, 116);
            this.dataDetails.Name = "dataDetails";
            this.dataDetails.RowHeadersVisible = false;
            this.dataDetails.RowHeadersWidth = 51;
            this.dataDetails.RowTemplate.Height = 24;
            this.dataDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataDetails.Size = new System.Drawing.Size(683, 234);
            this.dataDetails.TabIndex = 6;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnEnviar.Location = new System.Drawing.Point(350, 356);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 43);
            this.btnEnviar.TabIndex = 5;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtCCO
            // 
            this.txtCCO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCCO.Location = new System.Drawing.Point(154, 68);
            this.txtCCO.Multiline = true;
            this.txtCCO.Name = "txtCCO";
            this.txtCCO.Size = new System.Drawing.Size(486, 22);
            this.txtCCO.TabIndex = 4;
            // 
            // txtCC
            // 
            this.txtCC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCC.Location = new System.Drawing.Point(154, 36);
            this.txtCC.Multiline = true;
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(486, 22);
            this.txtCC.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "CCO";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "CC";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.linkCancel);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.txtPassword);
            this.tabPage1.Controls.Add(this.txtUser);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Iniciar Sesion";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // linkCancel
            // 
            this.linkCancel.AutoSize = true;
            this.linkCancel.Location = new System.Drawing.Point(387, 261);
            this.linkCancel.Name = "linkCancel";
            this.linkCancel.Size = new System.Drawing.Size(64, 17);
            this.linkCancel.TabIndex = 5;
            this.linkCancel.TabStop = true;
            this.linkCancel.Text = "Cancelar";
            this.linkCancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Cancel);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(358, 219);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Aceptar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(317, 165);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(212, 22);
            this.txtPassword.TabIndex = 3;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(317, 137);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(212, 22);
            this.txtUser.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormSendMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormSendMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDetails)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCCO;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnSearchFile;
        private System.Windows.Forms.DataGridView dataDetails;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.LinkLabel linkCancel;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

