using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace PenseAPI
{
    [DesignerGenerated()]
    public partial class TestForm : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this._BtnGetToken = new System.Windows.Forms.Button();
            this.TxtAccessKey = new System.Windows.Forms.TextBox();
            this.TxtClientId = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.TxtAccessToken = new System.Windows.Forms.RichTextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.TxtBaseUrl = new System.Windows.Forms.TextBox();
            this._TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.txtReferene = new System.Windows.Forms.TextBox();
            this.Label17 = new System.Windows.Forms.Label();
            this.TxtLongitude = new System.Windows.Forms.TextBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.TxtLatitude = new System.Windows.Forms.TextBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.TxtStreetNumber = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.TxtStateName = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.TxtStreetName = new System.Windows.Forms.TextBox();
            this.Label13 = new System.Windows.Forms.Label();
            this.TxtCityName = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtTradeName = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.TxtExternalReference = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.TxtCompanyName = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.TxtDocument = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtClose = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.TxtOpen = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this._BtnCreateStore = new System.Windows.Forms.Button();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.TxtNamePos = new System.Windows.Forms.TextBox();
            this._BtnRegisterPos = new System.Windows.Forms.Button();
            this.Label18 = new System.Windows.Forms.Label();
            this.TxtExternalReferencePos = new System.Windows.Forms.TextBox();
            this.TxtExternalReferenceStorePos = new System.Windows.Forms.TextBox();
            this.Label19 = new System.Windows.Forms.Label();
            this.Label20 = new System.Windows.Forms.Label();
            this.TabPage4 = new System.Windows.Forms.TabPage();
            this.LblUpdateAt = new System.Windows.Forms.Label();
            this._BtmRemoveItem = new System.Windows.Forms.Button();
            this._BtnAddItem = new System.Windows.Forms.Button();
            this.DgvItems = new System.Windows.Forms.DataGridView();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblPaymentStatus = new System.Windows.Forms.Label();
            this.TxtPaymentId = new System.Windows.Forms.TextBox();
            this.Label30 = new System.Windows.Forms.Label();
            this.TxtItemValuePayment = new System.Windows.Forms.TextBox();
            this.Label27 = new System.Windows.Forms.Label();
            this.TxtItemQuantityPayment = new System.Windows.Forms.TextBox();
            this.Label28 = new System.Windows.Forms.Label();
            this.TxtItemDescriptionPayment = new System.Windows.Forms.TextBox();
            this.Label29 = new System.Windows.Forms.Label();
            this.TxtPdvPayment = new System.Windows.Forms.TextBox();
            this.Label26 = new System.Windows.Forms.Label();
            this.TxtStorePayment = new System.Windows.Forms.TextBox();
            this.Label25 = new System.Windows.Forms.Label();
            this.TxtWalletPayment = new System.Windows.Forms.TextBox();
            this.Label24 = new System.Windows.Forms.Label();
            this.TxtValuePayment = new System.Windows.Forms.TextBox();
            this.Label23 = new System.Windows.Forms.Label();
            this.TxtExternalReferencePayment = new System.Windows.Forms.TextBox();
            this.Label22 = new System.Windows.Forms.Label();
            this.TxtDescriptionPayment = new System.Windows.Forms.TextBox();
            this._BtnGenerateSale = new System.Windows.Forms.Button();
            this.Label21 = new System.Windows.Forms.Label();
            this.ImgQrCodeUrl = new System.Windows.Forms.PictureBox();
            this.TabPage5 = new System.Windows.Forms.TabPage();
            this.LblUpdateAtConsult = new System.Windows.Forms.Label();
            this._BtnCancelSale = new System.Windows.Forms.Button();
            this._BtnConsultByReference = new System.Windows.Forms.Button();
            this.LblPaymentStatusConsult = new System.Windows.Forms.Label();
            this.TxtPaymentIdConsult = new System.Windows.Forms.TextBox();
            this.Label32 = new System.Windows.Forms.Label();
            this.TxtExternalReferencePaymentConsult = new System.Windows.Forms.TextBox();
            this.Label33 = new System.Windows.Forms.Label();
            this._BtnConsultStatus = new System.Windows.Forms.Button();
            this.ImgQrCodeUrlConsult = new System.Windows.Forms.PictureBox();
            this._TimerPaymentStatus = new System.Windows.Forms.Timer(this.components);
            this._BwPaymentStatus = new System.ComponentModel.BackgroundWorker();
            this._TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.TabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgQrCodeUrl)).BeginInit();
            this.TabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgQrCodeUrlConsult)).BeginInit();
            this.SuspendLayout();
            // 
            // _BtnGetToken
            // 
            this._BtnGetToken.Location = new System.Drawing.Point(95, 475);
            this._BtnGetToken.Name = "_BtnGetToken";
            this._BtnGetToken.Size = new System.Drawing.Size(332, 42);
            this._BtnGetToken.TabIndex = 0;
            this._BtnGetToken.Text = "Obter Token";
            this._BtnGetToken.UseVisualStyleBackColor = true;
            this._BtnGetToken.Click += new System.EventHandler(this.BtnGetToken_Click);
            // 
            // TxtAccessKey
            // 
            this.TxtAccessKey.Location = new System.Drawing.Point(95, 37);
            this.TxtAccessKey.Name = "TxtAccessKey";
            this.TxtAccessKey.Size = new System.Drawing.Size(332, 23);
            this.TxtAccessKey.TabIndex = 1;
            // 
            // TxtClientId
            // 
            this.TxtClientId.Location = new System.Drawing.Point(95, 66);
            this.TxtClientId.Name = "TxtClientId";
            this.TxtClientId.Size = new System.Drawing.Size(332, 23);
            this.TxtClientId.TabIndex = 2;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(5, 41);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(68, 15);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Access Key:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(5, 70);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(54, 15);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "Client Id:";
            // 
            // TxtAccessToken
            // 
            this.TxtAccessToken.Location = new System.Drawing.Point(95, 95);
            this.TxtAccessToken.Name = "TxtAccessToken";
            this.TxtAccessToken.Size = new System.Drawing.Size(332, 374);
            this.TxtAccessToken.TabIndex = 5;
            this.TxtAccessToken.Text = "";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(5, 275);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(80, 15);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "Access Token:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(5, 12);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(52, 15);
            this.Label4.TabIndex = 7;
            this.Label4.Text = "Base Url:";
            // 
            // TxtBaseUrl
            // 
            this.TxtBaseUrl.Location = new System.Drawing.Point(95, 8);
            this.TxtBaseUrl.Name = "TxtBaseUrl";
            this.TxtBaseUrl.Size = new System.Drawing.Size(332, 23);
            this.TxtBaseUrl.TabIndex = 0;
            this.TxtBaseUrl.Text = "https://sandboxpayment.mentesquepensam.com.br";
            // 
            // _TabControl1
            // 
            this._TabControl1.Controls.Add(this.TabPage1);
            this._TabControl1.Controls.Add(this.TabPage2);
            this._TabControl1.Controls.Add(this.TabPage3);
            this._TabControl1.Controls.Add(this.TabPage4);
            this._TabControl1.Controls.Add(this.TabPage5);
            this._TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._TabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this._TabControl1.Location = new System.Drawing.Point(0, 0);
            this._TabControl1.Name = "_TabControl1";
            this._TabControl1.SelectedIndex = 0;
            this._TabControl1.Size = new System.Drawing.Size(489, 566);
            this._TabControl1.TabIndex = 9;
            this._TabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.TxtBaseUrl);
            this.TabPage1.Controls.Add(this._BtnGetToken);
            this.TabPage1.Controls.Add(this.Label4);
            this.TabPage1.Controls.Add(this.TxtAccessKey);
            this.TabPage1.Controls.Add(this.Label3);
            this.TabPage1.Controls.Add(this.TxtClientId);
            this.TabPage1.Controls.Add(this.TxtAccessToken);
            this.TabPage1.Controls.Add(this.Label1);
            this.TabPage1.Controls.Add(this.Label2);
            this.TabPage1.Location = new System.Drawing.Point(4, 24);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(481, 538);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Configurações";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.GroupBox3);
            this.TabPage2.Controls.Add(this.GroupBox2);
            this.TabPage2.Controls.Add(this.GroupBox1);
            this.TabPage2.Controls.Add(this._BtnCreateStore);
            this.TabPage2.Location = new System.Drawing.Point(4, 24);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(481, 538);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Cadastrar Loja";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.txtReferene);
            this.GroupBox3.Controls.Add(this.Label17);
            this.GroupBox3.Controls.Add(this.TxtLongitude);
            this.GroupBox3.Controls.Add(this.Label16);
            this.GroupBox3.Controls.Add(this.TxtLatitude);
            this.GroupBox3.Controls.Add(this.Label15);
            this.GroupBox3.Controls.Add(this.TxtStreetNumber);
            this.GroupBox3.Controls.Add(this.Label11);
            this.GroupBox3.Controls.Add(this.TxtStateName);
            this.GroupBox3.Controls.Add(this.Label12);
            this.GroupBox3.Controls.Add(this.TxtStreetName);
            this.GroupBox3.Controls.Add(this.Label13);
            this.GroupBox3.Controls.Add(this.TxtCityName);
            this.GroupBox3.Controls.Add(this.Label14);
            this.GroupBox3.Location = new System.Drawing.Point(52, 227);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(367, 231);
            this.GroupBox3.TabIndex = 18;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Informações da Empresa";
            // 
            // txtReferene
            // 
            this.txtReferene.Location = new System.Drawing.Point(116, 196);
            this.txtReferene.Name = "txtReferene";
            this.txtReferene.Size = new System.Drawing.Size(245, 23);
            this.txtReferene.TabIndex = 12;
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Location = new System.Drawing.Point(9, 200);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(65, 15);
            this.Label17.TabIndex = 25;
            this.Label17.Text = "Referência:";
            // 
            // TxtLongitude
            // 
            this.TxtLongitude.Location = new System.Drawing.Point(116, 167);
            this.TxtLongitude.Name = "TxtLongitude";
            this.TxtLongitude.Size = new System.Drawing.Size(245, 23);
            this.TxtLongitude.TabIndex = 11;
            this.TxtLongitude.Text = "-43.9528173";
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Location = new System.Drawing.Point(9, 171);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(64, 15);
            this.Label16.TabIndex = 23;
            this.Label16.Text = "Longitude:";
            // 
            // TxtLatitude
            // 
            this.TxtLatitude.Location = new System.Drawing.Point(116, 138);
            this.TxtLatitude.Name = "TxtLatitude";
            this.TxtLatitude.Size = new System.Drawing.Size(245, 23);
            this.TxtLatitude.TabIndex = 10;
            this.TxtLatitude.Text = "-19.928907";
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(9, 142);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(53, 15);
            this.Label15.TabIndex = 21;
            this.Label15.Text = "Latitude:";
            // 
            // TxtStreetNumber
            // 
            this.TxtStreetNumber.Location = new System.Drawing.Point(116, 51);
            this.TxtStreetNumber.Name = "TxtStreetNumber";
            this.TxtStreetNumber.Size = new System.Drawing.Size(245, 23);
            this.TxtStreetNumber.TabIndex = 7;
            this.TxtStreetNumber.Text = "1200";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(9, 55);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(54, 15);
            this.Label11.TabIndex = 19;
            this.Label11.Text = "Número:";
            // 
            // TxtStateName
            // 
            this.TxtStateName.Location = new System.Drawing.Point(116, 109);
            this.TxtStateName.Name = "TxtStateName";
            this.TxtStateName.Size = new System.Drawing.Size(245, 23);
            this.TxtStateName.TabIndex = 9;
            this.TxtStateName.Text = "Minas Gerais";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(9, 113);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(45, 15);
            this.Label12.TabIndex = 17;
            this.Label12.Text = "Estado:";
            // 
            // TxtStreetName
            // 
            this.TxtStreetName.Location = new System.Drawing.Point(116, 22);
            this.TxtStreetName.Name = "TxtStreetName";
            this.TxtStreetName.Size = new System.Drawing.Size(245, 23);
            this.TxtStreetName.TabIndex = 6;
            this.TxtStreetName.Text = "Av. Barbacena";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(9, 26);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(82, 15);
            this.Label13.TabIndex = 13;
            this.Label13.Text = "Nome da Rua:";
            // 
            // TxtCityName
            // 
            this.TxtCityName.Location = new System.Drawing.Point(116, 80);
            this.TxtCityName.Name = "TxtCityName";
            this.TxtCityName.Size = new System.Drawing.Size(245, 23);
            this.TxtCityName.TabIndex = 8;
            this.TxtCityName.Text = "Belo Horizonte";
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(9, 84);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(47, 15);
            this.Label14.TabIndex = 15;
            this.Label14.Text = "Cidade:";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.TxtTradeName);
            this.GroupBox2.Controls.Add(this.Label10);
            this.GroupBox2.Controls.Add(this.TxtExternalReference);
            this.GroupBox2.Controls.Add(this.Label9);
            this.GroupBox2.Controls.Add(this.TxtCompanyName);
            this.GroupBox2.Controls.Add(this.Label7);
            this.GroupBox2.Controls.Add(this.TxtDocument);
            this.GroupBox2.Controls.Add(this.Label8);
            this.GroupBox2.Location = new System.Drawing.Point(52, 75);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(367, 146);
            this.GroupBox2.TabIndex = 17;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Informações da Empresa";
            // 
            // TxtTradeName
            // 
            this.TxtTradeName.Location = new System.Drawing.Point(116, 51);
            this.TxtTradeName.Name = "TxtTradeName";
            this.TxtTradeName.Size = new System.Drawing.Size(245, 23);
            this.TxtTradeName.TabIndex = 3;
            this.TxtTradeName.Text = "CEMIG";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(9, 55);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(89, 15);
            this.Label10.TabIndex = 19;
            this.Label10.Text = "Nome Fantasia:";
            // 
            // TxtExternalReference
            // 
            this.TxtExternalReference.Location = new System.Drawing.Point(116, 109);
            this.TxtExternalReference.Name = "TxtExternalReference";
            this.TxtExternalReference.Size = new System.Drawing.Size(245, 23);
            this.TxtExternalReference.TabIndex = 5;
            this.TxtExternalReference.Text = "17155730000164";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(9, 113);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(107, 15);
            this.Label9.TabIndex = 17;
            this.Label9.Text = "Referência Externa:";
            // 
            // TxtCompanyName
            // 
            this.TxtCompanyName.Location = new System.Drawing.Point(116, 22);
            this.TxtCompanyName.Name = "TxtCompanyName";
            this.TxtCompanyName.Size = new System.Drawing.Size(245, 23);
            this.TxtCompanyName.TabIndex = 2;
            this.TxtCompanyName.Text = "CEMIG";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(9, 26);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(43, 15);
            this.Label7.TabIndex = 13;
            this.Label7.Text = "Nome:";
            // 
            // TxtDocument
            // 
            this.TxtDocument.Location = new System.Drawing.Point(116, 80);
            this.TxtDocument.Name = "TxtDocument";
            this.TxtDocument.Size = new System.Drawing.Size(245, 23);
            this.TxtDocument.TabIndex = 4;
            this.TxtDocument.Text = "17155730000164";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(9, 84);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(73, 15);
            this.Label8.TabIndex = 15;
            this.Label8.Text = "Documento:";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.TxtClose);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.TxtOpen);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Location = new System.Drawing.Point(52, 11);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(367, 58);
            this.GroupBox1.TabIndex = 16;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Horário de Funcionamento";
            // 
            // TxtClose
            // 
            this.TxtClose.Location = new System.Drawing.Point(265, 22);
            this.TxtClose.Name = "TxtClose";
            this.TxtClose.Size = new System.Drawing.Size(96, 23);
            this.TxtClose.TabIndex = 1;
            this.TxtClose.Text = "23:59";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(8, 26);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(56, 15);
            this.Label5.TabIndex = 7;
            this.Label5.Text = "Abertura:";
            // 
            // TxtOpen
            // 
            this.TxtOpen.Location = new System.Drawing.Point(70, 22);
            this.TxtOpen.Name = "TxtOpen";
            this.TxtOpen.Size = new System.Drawing.Size(96, 23);
            this.TxtOpen.TabIndex = 0;
            this.TxtOpen.Text = "00:00";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(183, 26);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(76, 15);
            this.Label6.TabIndex = 11;
            this.Label6.Text = "Fechamento:";
            // 
            // _BtnCreateStore
            // 
            this._BtnCreateStore.Location = new System.Drawing.Point(52, 477);
            this._BtnCreateStore.Name = "_BtnCreateStore";
            this._BtnCreateStore.Size = new System.Drawing.Size(367, 42);
            this._BtnCreateStore.TabIndex = 13;
            this._BtnCreateStore.Text = "Cadastrar Loja";
            this._BtnCreateStore.UseVisualStyleBackColor = true;
            this._BtnCreateStore.Click += new System.EventHandler(this.BtnCreateStore_Click);
            // 
            // TabPage3
            // 
            this.TabPage3.Controls.Add(this.TxtNamePos);
            this.TabPage3.Controls.Add(this._BtnRegisterPos);
            this.TabPage3.Controls.Add(this.Label18);
            this.TabPage3.Controls.Add(this.TxtExternalReferencePos);
            this.TabPage3.Controls.Add(this.TxtExternalReferenceStorePos);
            this.TabPage3.Controls.Add(this.Label19);
            this.TabPage3.Controls.Add(this.Label20);
            this.TabPage3.Location = new System.Drawing.Point(4, 24);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage3.Size = new System.Drawing.Size(481, 538);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "Cadastrar PDV";
            this.TabPage3.UseVisualStyleBackColor = true;
            // 
            // TxtNamePos
            // 
            this.TxtNamePos.Location = new System.Drawing.Point(195, 87);
            this.TxtNamePos.Name = "TxtNamePos";
            this.TxtNamePos.Size = new System.Drawing.Size(236, 23);
            this.TxtNamePos.TabIndex = 2;
            this.TxtNamePos.Text = "PDV12345";
            // 
            // _BtnRegisterPos
            // 
            this._BtnRegisterPos.Location = new System.Drawing.Point(86, 149);
            this._BtnRegisterPos.Name = "_BtnRegisterPos";
            this._BtnRegisterPos.Size = new System.Drawing.Size(298, 42);
            this._BtnRegisterPos.TabIndex = 3;
            this._BtnRegisterPos.Text = "Cadastrar PDV";
            this._BtnRegisterPos.UseVisualStyleBackColor = true;
            this._BtnRegisterPos.Click += new System.EventHandler(this.BtnRegisterPos_Click);
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.Location = new System.Drawing.Point(43, 91);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(43, 15);
            this.Label18.TabIndex = 14;
            this.Label18.Text = "Nome:";
            // 
            // TxtExternalReferencePos
            // 
            this.TxtExternalReferencePos.Location = new System.Drawing.Point(195, 29);
            this.TxtExternalReferencePos.Name = "TxtExternalReferencePos";
            this.TxtExternalReferencePos.Size = new System.Drawing.Size(236, 23);
            this.TxtExternalReferencePos.TabIndex = 0;
            this.TxtExternalReferencePos.Text = "12345";
            // 
            // TxtExternalReferenceStorePos
            // 
            this.TxtExternalReferenceStorePos.Location = new System.Drawing.Point(195, 58);
            this.TxtExternalReferenceStorePos.Name = "TxtExternalReferenceStorePos";
            this.TxtExternalReferenceStorePos.Size = new System.Drawing.Size(236, 23);
            this.TxtExternalReferenceStorePos.TabIndex = 1;
            this.TxtExternalReferenceStorePos.Text = "17155730000164";
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Location = new System.Drawing.Point(43, 33);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(107, 15);
            this.Label19.TabIndex = 12;
            this.Label19.Text = "Referência Externa:";
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Location = new System.Drawing.Point(43, 62);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(148, 15);
            this.Label20.TabIndex = 13;
            this.Label20.Text = "Loja de Referência Externa:";
            // 
            // TabPage4
            // 
            this.TabPage4.Controls.Add(this.LblUpdateAt);
            this.TabPage4.Controls.Add(this._BtmRemoveItem);
            this.TabPage4.Controls.Add(this._BtnAddItem);
            this.TabPage4.Controls.Add(this.DgvItems);
            this.TabPage4.Controls.Add(this.LblPaymentStatus);
            this.TabPage4.Controls.Add(this.TxtPaymentId);
            this.TabPage4.Controls.Add(this.Label30);
            this.TabPage4.Controls.Add(this.TxtItemValuePayment);
            this.TabPage4.Controls.Add(this.Label27);
            this.TabPage4.Controls.Add(this.TxtItemQuantityPayment);
            this.TabPage4.Controls.Add(this.Label28);
            this.TabPage4.Controls.Add(this.TxtItemDescriptionPayment);
            this.TabPage4.Controls.Add(this.Label29);
            this.TabPage4.Controls.Add(this.TxtPdvPayment);
            this.TabPage4.Controls.Add(this.Label26);
            this.TabPage4.Controls.Add(this.TxtStorePayment);
            this.TabPage4.Controls.Add(this.Label25);
            this.TabPage4.Controls.Add(this.TxtWalletPayment);
            this.TabPage4.Controls.Add(this.Label24);
            this.TabPage4.Controls.Add(this.TxtValuePayment);
            this.TabPage4.Controls.Add(this.Label23);
            this.TabPage4.Controls.Add(this.TxtExternalReferencePayment);
            this.TabPage4.Controls.Add(this.Label22);
            this.TabPage4.Controls.Add(this.TxtDescriptionPayment);
            this.TabPage4.Controls.Add(this._BtnGenerateSale);
            this.TabPage4.Controls.Add(this.Label21);
            this.TabPage4.Controls.Add(this.ImgQrCodeUrl);
            this.TabPage4.Location = new System.Drawing.Point(4, 24);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage4.Size = new System.Drawing.Size(481, 538);
            this.TabPage4.TabIndex = 3;
            this.TabPage4.Text = "Gerar Venda";
            this.TabPage4.UseVisualStyleBackColor = true;
            // 
            // LblUpdateAt
            // 
            this.LblUpdateAt.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblUpdateAt.Location = new System.Drawing.Point(460, 478);
            this.LblUpdateAt.Name = "LblUpdateAt";
            this.LblUpdateAt.Size = new System.Drawing.Size(350, 42);
            this.LblUpdateAt.TabIndex = 45;
            this.LblUpdateAt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // _BtmRemoveItem
            // 
            this._BtmRemoveItem.Location = new System.Drawing.Point(264, 293);
            this._BtmRemoveItem.Name = "_BtmRemoveItem";
            this._BtmRemoveItem.Size = new System.Drawing.Size(170, 25);
            this._BtmRemoveItem.TabIndex = 11;
            this._BtmRemoveItem.Text = "Remover Item Selecionado";
            this._BtmRemoveItem.UseVisualStyleBackColor = true;
            this._BtmRemoveItem.Click += new System.EventHandler(this.BtmRemoveItem_Click);
            // 
            // _BtnAddItem
            // 
            this._BtnAddItem.Location = new System.Drawing.Point(15, 293);
            this._BtnAddItem.Name = "_BtnAddItem";
            this._BtnAddItem.Size = new System.Drawing.Size(170, 25);
            this._BtnAddItem.TabIndex = 10;
            this._BtnAddItem.Text = "Adicionar Item";
            this._BtnAddItem.UseVisualStyleBackColor = true;
            this._BtnAddItem.Click += new System.EventHandler(this.BtnAddItem_Click);
            // 
            // DgvItems
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Description,
            this.Quantity,
            this.Value,
            this.Total});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvItems.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvItems.Location = new System.Drawing.Point(15, 324);
            this.DgvItems.Name = "DgvItems";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvItems.RowTemplate.Height = 25;
            this.DgvItems.Size = new System.Drawing.Size(419, 131);
            this.DgvItems.TabIndex = 35;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.HeaderText = "Descrição";
            this.Description.Name = "Description";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantidade";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 80;
            // 
            // Value
            // 
            this.Value.HeaderText = "Valor";
            this.Value.Name = "Value";
            this.Value.Width = 60;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.Width = 60;
            // 
            // LblPaymentStatus
            // 
            this.LblPaymentStatus.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblPaymentStatus.Location = new System.Drawing.Point(460, 413);
            this.LblPaymentStatus.Name = "LblPaymentStatus";
            this.LblPaymentStatus.Size = new System.Drawing.Size(350, 42);
            this.LblPaymentStatus.TabIndex = 34;
            this.LblPaymentStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TxtPaymentId
            // 
            this.TxtPaymentId.Enabled = false;
            this.TxtPaymentId.Location = new System.Drawing.Point(167, 50);
            this.TxtPaymentId.Name = "TxtPaymentId";
            this.TxtPaymentId.Size = new System.Drawing.Size(267, 23);
            this.TxtPaymentId.TabIndex = 0;
            // 
            // Label30
            // 
            this.Label30.AutoSize = true;
            this.Label30.Location = new System.Drawing.Point(15, 54);
            this.Label30.Name = "Label30";
            this.Label30.Size = new System.Drawing.Size(49, 15);
            this.Label30.TabIndex = 32;
            this.Label30.Text = "Código:";
            // 
            // TxtItemValuePayment
            // 
            this.TxtItemValuePayment.Location = new System.Drawing.Point(395, 253);
            this.TxtItemValuePayment.Name = "TxtItemValuePayment";
            this.TxtItemValuePayment.Size = new System.Drawing.Size(39, 23);
            this.TxtItemValuePayment.TabIndex = 9;
            this.TxtItemValuePayment.Text = "0.01";
            // 
            // Label27
            // 
            this.Label27.AutoSize = true;
            this.Label27.Location = new System.Drawing.Point(353, 257);
            this.Label27.Name = "Label27";
            this.Label27.Size = new System.Drawing.Size(36, 15);
            this.Label27.TabIndex = 31;
            this.Label27.Text = "Valor:";
            // 
            // TxtItemQuantityPayment
            // 
            this.TxtItemQuantityPayment.Location = new System.Drawing.Point(315, 253);
            this.TxtItemQuantityPayment.Name = "TxtItemQuantityPayment";
            this.TxtItemQuantityPayment.Size = new System.Drawing.Size(32, 23);
            this.TxtItemQuantityPayment.TabIndex = 8;
            this.TxtItemQuantityPayment.Text = "1";
            // 
            // Label28
            // 
            this.Label28.AutoSize = true;
            this.Label28.Location = new System.Drawing.Point(237, 257);
            this.Label28.Name = "Label28";
            this.Label28.Size = new System.Drawing.Size(72, 15);
            this.Label28.TabIndex = 29;
            this.Label28.Text = "Quantidade:";
            // 
            // TxtItemDescriptionPayment
            // 
            this.TxtItemDescriptionPayment.Location = new System.Drawing.Point(167, 253);
            this.TxtItemDescriptionPayment.Name = "TxtItemDescriptionPayment";
            this.TxtItemDescriptionPayment.Size = new System.Drawing.Size(64, 23);
            this.TxtItemDescriptionPayment.TabIndex = 7;
            this.TxtItemDescriptionPayment.Text = "Item 1";
            // 
            // Label29
            // 
            this.Label29.AutoSize = true;
            this.Label29.Location = new System.Drawing.Point(15, 257);
            this.Label29.Name = "Label29";
            this.Label29.Size = new System.Drawing.Size(105, 15);
            this.Label29.TabIndex = 27;
            this.Label29.Text = "Descrição do Item:";
            // 
            // TxtPdvPayment
            // 
            this.TxtPdvPayment.Location = new System.Drawing.Point(167, 224);
            this.TxtPdvPayment.Name = "TxtPdvPayment";
            this.TxtPdvPayment.Size = new System.Drawing.Size(267, 23);
            this.TxtPdvPayment.TabIndex = 6;
            this.TxtPdvPayment.Text = "12345";
            // 
            // Label26
            // 
            this.Label26.AutoSize = true;
            this.Label26.Location = new System.Drawing.Point(15, 228);
            this.Label26.Name = "Label26";
            this.Label26.Size = new System.Drawing.Size(32, 15);
            this.Label26.TabIndex = 25;
            this.Label26.Text = "PDV:";
            // 
            // TxtStorePayment
            // 
            this.TxtStorePayment.Location = new System.Drawing.Point(167, 195);
            this.TxtStorePayment.Name = "TxtStorePayment";
            this.TxtStorePayment.Size = new System.Drawing.Size(267, 23);
            this.TxtStorePayment.TabIndex = 5;
            this.TxtStorePayment.Text = "17155730000164";
            // 
            // Label25
            // 
            this.Label25.AutoSize = true;
            this.Label25.Location = new System.Drawing.Point(15, 199);
            this.Label25.Name = "Label25";
            this.Label25.Size = new System.Drawing.Size(32, 15);
            this.Label25.TabIndex = 23;
            this.Label25.Text = "Loja:";
            // 
            // TxtWalletPayment
            // 
            this.TxtWalletPayment.Location = new System.Drawing.Point(167, 166);
            this.TxtWalletPayment.Name = "TxtWalletPayment";
            this.TxtWalletPayment.Size = new System.Drawing.Size(267, 23);
            this.TxtWalletPayment.TabIndex = 4;
            this.TxtWalletPayment.Text = "MercadoPago";
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.Location = new System.Drawing.Point(15, 170);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(51, 15);
            this.Label24.TabIndex = 21;
            this.Label24.Text = "Carteira:";
            // 
            // TxtValuePayment
            // 
            this.TxtValuePayment.Enabled = false;
            this.TxtValuePayment.Location = new System.Drawing.Point(167, 137);
            this.TxtValuePayment.Name = "TxtValuePayment";
            this.TxtValuePayment.Size = new System.Drawing.Size(267, 23);
            this.TxtValuePayment.TabIndex = 3;
            this.TxtValuePayment.Text = "0.00";
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.Location = new System.Drawing.Point(15, 141);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(64, 15);
            this.Label23.TabIndex = 19;
            this.Label23.Text = "Valor Total:";
            // 
            // TxtExternalReferencePayment
            // 
            this.TxtExternalReferencePayment.Location = new System.Drawing.Point(167, 108);
            this.TxtExternalReferencePayment.Name = "TxtExternalReferencePayment";
            this.TxtExternalReferencePayment.Size = new System.Drawing.Size(267, 23);
            this.TxtExternalReferencePayment.TabIndex = 2;
            this.TxtExternalReferencePayment.Text = "1";
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.Location = new System.Drawing.Point(15, 112);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(107, 15);
            this.Label22.TabIndex = 17;
            this.Label22.Text = "Referência Externa:";
            // 
            // TxtDescriptionPayment
            // 
            this.TxtDescriptionPayment.Location = new System.Drawing.Point(167, 79);
            this.TxtDescriptionPayment.Name = "TxtDescriptionPayment";
            this.TxtDescriptionPayment.Size = new System.Drawing.Size(267, 23);
            this.TxtDescriptionPayment.TabIndex = 1;
            this.TxtDescriptionPayment.Text = "VENDA";
            // 
            // _BtnGenerateSale
            // 
            this._BtnGenerateSale.Location = new System.Drawing.Point(91, 478);
            this._BtnGenerateSale.Name = "_BtnGenerateSale";
            this._BtnGenerateSale.Size = new System.Drawing.Size(298, 42);
            this._BtnGenerateSale.TabIndex = 12;
            this._BtnGenerateSale.Text = "Gerar Venda";
            this._BtnGenerateSale.UseVisualStyleBackColor = true;
            this._BtnGenerateSale.Click += new System.EventHandler(this.BtnGenerateSale_Click);
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.Location = new System.Drawing.Point(15, 83);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(61, 15);
            this.Label21.TabIndex = 14;
            this.Label21.Text = "Descrição:";
            // 
            // ImgQrCodeUrl
            // 
            this.ImgQrCodeUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImgQrCodeUrl.Location = new System.Drawing.Point(460, 50);
            this.ImgQrCodeUrl.Name = "ImgQrCodeUrl";
            this.ImgQrCodeUrl.Size = new System.Drawing.Size(350, 350);
            this.ImgQrCodeUrl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgQrCodeUrl.TabIndex = 0;
            this.ImgQrCodeUrl.TabStop = false;
            // 
            // TabPage5
            // 
            this.TabPage5.Controls.Add(this.LblUpdateAtConsult);
            this.TabPage5.Controls.Add(this._BtnCancelSale);
            this.TabPage5.Controls.Add(this._BtnConsultByReference);
            this.TabPage5.Controls.Add(this.LblPaymentStatusConsult);
            this.TabPage5.Controls.Add(this.TxtPaymentIdConsult);
            this.TabPage5.Controls.Add(this.Label32);
            this.TabPage5.Controls.Add(this.TxtExternalReferencePaymentConsult);
            this.TabPage5.Controls.Add(this.Label33);
            this.TabPage5.Controls.Add(this._BtnConsultStatus);
            this.TabPage5.Controls.Add(this.ImgQrCodeUrlConsult);
            this.TabPage5.Location = new System.Drawing.Point(4, 24);
            this.TabPage5.Name = "TabPage5";
            this.TabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage5.Size = new System.Drawing.Size(481, 538);
            this.TabPage5.TabIndex = 4;
            this.TabPage5.Text = "Consulta e Cancelamento";
            this.TabPage5.UseVisualStyleBackColor = true;
            // 
            // LblUpdateAtConsult
            // 
            this.LblUpdateAtConsult.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblUpdateAtConsult.Location = new System.Drawing.Point(72, 420);
            this.LblUpdateAtConsult.Name = "LblUpdateAtConsult";
            this.LblUpdateAtConsult.Size = new System.Drawing.Size(350, 42);
            this.LblUpdateAtConsult.TabIndex = 44;
            this.LblUpdateAtConsult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // _BtnCancelSale
            // 
            this._BtnCancelSale.Location = new System.Drawing.Point(364, 465);
            this._BtnCancelSale.Name = "_BtnCancelSale";
            this._BtnCancelSale.Size = new System.Drawing.Size(75, 23);
            this._BtnCancelSale.TabIndex = 4;
            this._BtnCancelSale.Text = "Cancelar";
            this._BtnCancelSale.UseVisualStyleBackColor = true;
            this._BtnCancelSale.Click += new System.EventHandler(this.BtnCancelSale_Click);
            // 
            // _BtnConsultByReference
            // 
            this._BtnConsultByReference.Location = new System.Drawing.Point(283, 494);
            this._BtnConsultByReference.Name = "_BtnConsultByReference";
            this._BtnConsultByReference.Size = new System.Drawing.Size(156, 23);
            this._BtnConsultByReference.TabIndex = 3;
            this._BtnConsultByReference.Text = "Consulta por Referência";
            this._BtnConsultByReference.UseVisualStyleBackColor = true;
            this._BtnConsultByReference.Click += new System.EventHandler(this.BtnConsultByReference_Click);
            // 
            // LblPaymentStatusConsult
            // 
            this.LblPaymentStatusConsult.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblPaymentStatusConsult.Location = new System.Drawing.Point(72, 376);
            this.LblPaymentStatusConsult.Name = "LblPaymentStatusConsult";
            this.LblPaymentStatusConsult.Size = new System.Drawing.Size(350, 42);
            this.LblPaymentStatusConsult.TabIndex = 41;
            this.LblPaymentStatusConsult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TxtPaymentIdConsult
            // 
            this.TxtPaymentIdConsult.Location = new System.Drawing.Point(157, 465);
            this.TxtPaymentIdConsult.Name = "TxtPaymentIdConsult";
            this.TxtPaymentIdConsult.Size = new System.Drawing.Size(120, 23);
            this.TxtPaymentIdConsult.TabIndex = 0;
            // 
            // Label32
            // 
            this.Label32.AutoSize = true;
            this.Label32.Location = new System.Drawing.Point(41, 469);
            this.Label32.Name = "Label32";
            this.Label32.Size = new System.Drawing.Size(49, 15);
            this.Label32.TabIndex = 39;
            this.Label32.Text = "Código:";
            // 
            // TxtExternalReferencePaymentConsult
            // 
            this.TxtExternalReferencePaymentConsult.Location = new System.Drawing.Point(157, 494);
            this.TxtExternalReferencePaymentConsult.Name = "TxtExternalReferencePaymentConsult";
            this.TxtExternalReferencePaymentConsult.Size = new System.Drawing.Size(120, 23);
            this.TxtExternalReferencePaymentConsult.TabIndex = 2;
            // 
            // Label33
            // 
            this.Label33.AutoSize = true;
            this.Label33.Location = new System.Drawing.Point(41, 498);
            this.Label33.Name = "Label33";
            this.Label33.Size = new System.Drawing.Size(107, 15);
            this.Label33.TabIndex = 38;
            this.Label33.Text = "Referência Externa:";
            // 
            // _BtnConsultStatus
            // 
            this._BtnConsultStatus.Location = new System.Drawing.Point(283, 465);
            this._BtnConsultStatus.Name = "_BtnConsultStatus";
            this._BtnConsultStatus.Size = new System.Drawing.Size(75, 23);
            this._BtnConsultStatus.TabIndex = 1;
            this._BtnConsultStatus.Text = "Consultar";
            this._BtnConsultStatus.UseVisualStyleBackColor = true;
            this._BtnConsultStatus.Click += new System.EventHandler(this.BtnConsultStatus_Click);
            // 
            // ImgQrCodeUrlConsult
            // 
            this.ImgQrCodeUrlConsult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImgQrCodeUrlConsult.Location = new System.Drawing.Point(72, 12);
            this.ImgQrCodeUrlConsult.Name = "ImgQrCodeUrlConsult";
            this.ImgQrCodeUrlConsult.Size = new System.Drawing.Size(350, 350);
            this.ImgQrCodeUrlConsult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgQrCodeUrlConsult.TabIndex = 35;
            this.ImgQrCodeUrlConsult.TabStop = false;
            // 
            // _TimerPaymentStatus
            // 
            this._TimerPaymentStatus.Interval = 5000;
            this._TimerPaymentStatus.Tick += new System.EventHandler(this.TimerPaymentStatus_Tick);
            // 
            // _BwPaymentStatus
            // 
            this._BwPaymentStatus.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BwPaymentStatus_DoWork);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 566);
            this.Controls.Add(this._TabControl1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(862, 605);
            this.Name = "TestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PenseAPI - By Gabriel Phillipe - Tecno X Sistemas";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this._TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.TabPage3.ResumeLayout(false);
            this.TabPage3.PerformLayout();
            this.TabPage4.ResumeLayout(false);
            this.TabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgQrCodeUrl)).EndInit();
            this.TabPage5.ResumeLayout(false);
            this.TabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgQrCodeUrlConsult)).EndInit();
            this.ResumeLayout(false);

        }

        private Button _BtnGetToken;

        internal Button BtnGetToken
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BtnGetToken;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BtnGetToken != null)
                {
                    _BtnGetToken.Click -= BtnGetToken_Click;
                }

                _BtnGetToken = value;
                if (_BtnGetToken != null)
                {
                    _BtnGetToken.Click += BtnGetToken_Click;
                }
            }
        }

        internal TextBox TxtAccessKey;
        internal TextBox TxtClientId;
        internal Label Label1;
        internal Label Label2;
        internal RichTextBox TxtAccessToken;
        internal Label Label3;
        internal Label Label4;
        internal TextBox TxtBaseUrl;
        private TabControl _TabControl1;

        internal TabControl TabControl1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TabControl1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TabControl1 != null)
                {
                    _TabControl1.SelectedIndexChanged -= TabControl1_SelectedIndexChanged;
                }

                _TabControl1 = value;
                if (_TabControl1 != null)
                {
                    _TabControl1.SelectedIndexChanged += TabControl1_SelectedIndexChanged;
                }
            }
        }

        internal TabPage TabPage1;
        internal TabPage TabPage2;
        private Button _BtnCreateStore;

        internal Button BtnCreateStore
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BtnCreateStore;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BtnCreateStore != null)
                {
                    _BtnCreateStore.Click -= BtnCreateStore_Click;
                }

                _BtnCreateStore = value;
                if (_BtnCreateStore != null)
                {
                    _BtnCreateStore.Click += BtnCreateStore_Click;
                }
            }
        }

        internal TextBox TxtOpen;
        internal Label Label5;
        internal TabPage TabPage3;
        internal GroupBox GroupBox2;
        internal TextBox TxtTradeName;
        internal Label Label10;
        internal TextBox TxtExternalReference;
        internal Label Label9;
        internal TextBox TxtCompanyName;
        internal Label Label7;
        internal TextBox TxtDocument;
        internal Label Label8;
        internal GroupBox GroupBox1;
        internal TextBox TxtClose;
        internal Label Label6;
        internal GroupBox GroupBox3;
        internal TextBox txtReferene;
        internal Label Label17;
        internal TextBox TxtLongitude;
        internal Label Label16;
        internal TextBox TxtLatitude;
        internal Label Label15;
        internal TextBox TxtStreetNumber;
        internal Label Label11;
        internal TextBox TxtStateName;
        internal Label Label12;
        internal TextBox TxtStreetName;
        internal Label Label13;
        internal TextBox TxtCityName;
        internal Label Label14;
        internal TextBox TxtNamePos;
        private Button _BtnRegisterPos;

        internal Button BtnRegisterPos
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BtnRegisterPos;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BtnRegisterPos != null)
                {
                    _BtnRegisterPos.Click -= BtnRegisterPos_Click;
                }

                _BtnRegisterPos = value;
                if (_BtnRegisterPos != null)
                {
                    _BtnRegisterPos.Click += BtnRegisterPos_Click;
                }
            }
        }

        internal Label Label18;
        internal TextBox TxtExternalReferencePos;
        internal TextBox TxtExternalReferenceStorePos;
        internal Label Label19;
        internal Label Label20;
        internal TabPage TabPage4;
        internal TextBox TxtDescriptionPayment;
        private Button _BtnGenerateSale;

        internal Button BtnGenerateSale
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BtnGenerateSale;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BtnGenerateSale != null)
                {
                    _BtnGenerateSale.Click -= BtnGenerateSale_Click;
                }

                _BtnGenerateSale = value;
                if (_BtnGenerateSale != null)
                {
                    _BtnGenerateSale.Click += BtnGenerateSale_Click;
                }
            }
        }

        internal Label Label21;
        internal PictureBox ImgQrCodeUrl;
        internal TextBox TxtExternalReferencePayment;
        internal Label Label22;
        internal TextBox TxtValuePayment;
        internal Label Label23;
        internal TextBox TxtWalletPayment;
        internal Label Label24;
        internal TextBox TxtStorePayment;
        internal Label Label25;
        internal TextBox TxtPdvPayment;
        internal Label Label26;
        internal TextBox TxtItemValuePayment;
        internal Label Label27;
        internal TextBox TxtItemQuantityPayment;
        internal Label Label28;
        internal TextBox TxtItemDescriptionPayment;
        internal Label Label29;
        internal TextBox Txt;
        internal Label LblPaymentStatus;
        internal TextBox TxtPaymentId;
        internal Label Label30;
        private Timer _TimerPaymentStatus;

        internal Timer TimerPaymentStatus
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TimerPaymentStatus;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TimerPaymentStatus != null)
                {
                    _TimerPaymentStatus.Tick -= TimerPaymentStatus_Tick;
                }

                _TimerPaymentStatus = value;
                if (_TimerPaymentStatus != null)
                {
                    _TimerPaymentStatus.Tick += TimerPaymentStatus_Tick;
                }
            }
        }

        private System.ComponentModel.BackgroundWorker _BwPaymentStatus;

        internal System.ComponentModel.BackgroundWorker BwPaymentStatus
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BwPaymentStatus;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BwPaymentStatus != null)
                {
                    _BwPaymentStatus.DoWork -= BwPaymentStatus_DoWork;
                }

                _BwPaymentStatus = value;
                if (_BwPaymentStatus != null)
                {
                    _BwPaymentStatus.DoWork += BwPaymentStatus_DoWork;
                }
            }
        }

        internal DataGridView DgvItems;
        private Button _BtnAddItem;

        internal Button BtnAddItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BtnAddItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BtnAddItem != null)
                {
                    _BtnAddItem.Click -= BtnAddItem_Click;
                }

                _BtnAddItem = value;
                if (_BtnAddItem != null)
                {
                    _BtnAddItem.Click += BtnAddItem_Click;
                }
            }
        }

        private Button _BtmRemoveItem;

        internal Button BtmRemoveItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BtmRemoveItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BtmRemoveItem != null)
                {
                    _BtmRemoveItem.Click -= BtmRemoveItem_Click;
                }

                _BtmRemoveItem = value;
                if (_BtmRemoveItem != null)
                {
                    _BtmRemoveItem.Click += BtmRemoveItem_Click;
                }
            }
        }

        internal DataGridViewTextBoxColumn Description;
        internal DataGridViewTextBoxColumn Quantity;
        internal DataGridViewTextBoxColumn Value;
        internal DataGridViewTextBoxColumn Total;
        internal TabPage TabPage5;
        internal Label LblPaymentStatusConsult;
        internal TextBox TxtPaymentIdConsult;
        internal Label Label32;
        internal TextBox TxtExternalReferencePaymentConsult;
        internal Label Label33;
        private Button _BtnConsultStatus;

        internal Button BtnConsultStatus
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BtnConsultStatus;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BtnConsultStatus != null)
                {
                    _BtnConsultStatus.Click -= BtnConsultStatus_Click;
                }

                _BtnConsultStatus = value;
                if (_BtnConsultStatus != null)
                {
                    _BtnConsultStatus.Click += BtnConsultStatus_Click;
                }
            }
        }

        internal PictureBox ImgQrCodeUrlConsult;
        private Button _BtnCancelSale;

        internal Button BtnCancelSale
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BtnCancelSale;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BtnCancelSale != null)
                {
                    _BtnCancelSale.Click -= BtnCancelSale_Click;
                }

                _BtnCancelSale = value;
                if (_BtnCancelSale != null)
                {
                    _BtnCancelSale.Click += BtnCancelSale_Click;
                }
            }
        }

        private Button _BtnConsultByReference;

        internal Button BtnConsultByReference
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BtnConsultByReference;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BtnConsultByReference != null)
                {
                    _BtnConsultByReference.Click -= BtnConsultByReference_Click;
                }

                _BtnConsultByReference = value;
                if (_BtnConsultByReference != null)
                {
                    _BtnConsultByReference.Click += BtnConsultByReference_Click;
                }
            }
        }

        internal Label LblUpdateAtConsult;
        internal Label LblUpdateAt;
    }
}