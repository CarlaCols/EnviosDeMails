
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnSearchFile = new System.Windows.Forms.Button();
            this.dataDetails = new System.Windows.Forms.DataGridView();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtCCO = new System.Windows.Forms.TextBox();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.lblCco = new System.Windows.Forms.Label();
            this.lblCc = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.linkCancel = new System.Windows.Forms.LinkLabel();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.txtUser2 = new System.Windows.Forms.TextBox();
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
            this.tabControl1.Size = new System.Drawing.Size(800, 493);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtPassword);
            this.tabPage2.Controls.Add(this.txtUser);
            this.tabPage2.Controls.Add(this.lblPassword);
            this.tabPage2.Controls.Add(this.lblUser);
            this.tabPage2.Controls.Add(this.btnSearchFile);
            this.tabPage2.Controls.Add(this.dataDetails);
            this.tabPage2.Controls.Add(this.btnSend);
            this.tabPage2.Controls.Add(this.txtCCO);
            this.tabPage2.Controls.Add(this.txtCC);
            this.tabPage2.Controls.Add(this.lblCco);
            this.tabPage2.Controls.Add(this.lblCc);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 464);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Confirmacion de Tickets";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPassword.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPassword.Location = new System.Drawing.Point(479, 18);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(181, 22);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.Text = "Correo10515304";
            // 
            // txtUser
            // 
            this.txtUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUser.Location = new System.Drawing.Point(174, 18);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(174, 22);
            this.txtUser.TabIndex = 10;
            this.txtUser.Text = "c-cols@hotmail.com";
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(392, 21);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(81, 17);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Contraseña";
            // 
            // lblUser
            // 
            this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(111, 18);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(57, 17);
            this.lblUser.TabIndex = 8;
            this.lblUser.Text = "Usuario";
            // 
            // btnSearchFile
            // 
            this.btnSearchFile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSearchFile.Image = global::EnviosMails.Properties.Resources.Search;
            this.btnSearchFile.Location = new System.Drawing.Point(735, 185);
            this.btnSearchFile.Name = "btnSearchFile";
            this.btnSearchFile.Size = new System.Drawing.Size(33, 33);
            this.btnSearchFile.TabIndex = 7;
            this.btnSearchFile.UseVisualStyleBackColor = true;
            this.btnSearchFile.Click += new System.EventHandler(this.btnSearchFile_Click);
            // 
            // dataDetails
            // 
            this.dataDetails.AllowUserToAddRows = false;
            this.dataDetails.AllowUserToDeleteRows = false;
            this.dataDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataDetails.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataDetails.ColumnHeadersHeight = 29;
            this.dataDetails.EnableHeadersVisualStyles = false;
            this.dataDetails.Location = new System.Drawing.Point(46, 133);
            this.dataDetails.Name = "dataDetails";
            this.dataDetails.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataDetails.RowHeadersVisible = false;
            this.dataDetails.RowHeadersWidth = 51;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.dataDetails.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataDetails.RowTemplate.Height = 24;
            this.dataDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataDetails.Size = new System.Drawing.Size(683, 260);
            this.dataDetails.TabIndex = 6;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSend.Location = new System.Drawing.Point(351, 399);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 43);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Enviar";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtCCO
            // 
            this.txtCCO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCCO.Location = new System.Drawing.Point(174, 88);
            this.txtCCO.Multiline = true;
            this.txtCCO.Name = "txtCCO";
            this.txtCCO.Size = new System.Drawing.Size(486, 22);
            this.txtCCO.TabIndex = 4;
            // 
            // txtCC
            // 
            this.txtCC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCC.Location = new System.Drawing.Point(174, 56);
            this.txtCC.Multiline = true;
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(486, 22);
            this.txtCC.TabIndex = 3;
            // 
            // lblCco
            // 
            this.lblCco.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCco.AutoSize = true;
            this.lblCco.Location = new System.Drawing.Point(131, 88);
            this.lblCco.Name = "lblCco";
            this.lblCco.Size = new System.Drawing.Size(37, 17);
            this.lblCco.TabIndex = 2;
            this.lblCco.Text = "CCO";
            // 
            // lblCc
            // 
            this.lblCc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCc.AutoSize = true;
            this.lblCc.Location = new System.Drawing.Point(131, 59);
            this.lblCc.Name = "lblCc";
            this.lblCc.Size = new System.Drawing.Size(26, 17);
            this.lblCc.TabIndex = 1;
            this.lblCc.Text = "CC";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.linkCancel);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.txtPassword2);
            this.tabPage1.Controls.Add(this.txtUser2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 464);
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
            // txtPassword2
            // 
            this.txtPassword2.Location = new System.Drawing.Point(317, 165);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.Size = new System.Drawing.Size(212, 22);
            this.txtPassword2.TabIndex = 3;
            // 
            // txtUser2
            // 
            this.txtUser2.Location = new System.Drawing.Point(317, 137);
            this.txtUser2.Name = "txtUser2";
            this.txtUser2.Size = new System.Drawing.Size(212, 22);
            this.txtUser2.TabIndex = 2;
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
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormSendMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.TextBox txtUser2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.LinkLabel linkCancel;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnSearchFile;
        private System.Windows.Forms.DataGridView dataDetails;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtCCO;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.Label lblCco;
        private System.Windows.Forms.Label lblCc;
    }
}

