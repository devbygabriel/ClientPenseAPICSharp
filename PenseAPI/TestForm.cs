using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace PenseAPI
{
    public partial class TestForm
    {
        public TestForm()
        {
            InitializeComponent();
            _BtnGetToken.Name = "BtnGetToken";
            _TabControl1.Name = "TabControl1";
            _BtnCreateStore.Name = "BtnCreateStore";
            _BtnRegisterPos.Name = "BtnRegisterPos";
            _BtmRemoveItem.Name = "BtmRemoveItem";
            _BtnAddItem.Name = "BtnAddItem";
            _BtnGenerateSale.Name = "BtnGenerateSale";
            _BtnCancelSale.Name = "BtnCancelSale";
            _BtnConsultByReference.Name = "BtnConsultByReference";
            _BtnConsultStatus.Name = "BtnConsultStatus";
        }

        private string consultStatus;

        private void BtnGetToken_Click(object sender, EventArgs e)
        {
            Functions.baseUrl = TxtBaseUrl.Text;
            Functions.accessKey = TxtAccessKey.Text;
            Functions.clientId = TxtClientId.Text;
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(Functions.Authentication(Functions.accessKey, Functions.clientId), true, false)))
            {
                TxtAccessToken.Text = Functions.accessToken;
            }
            else
            {
                Interaction.MsgBox("Falha ao obter token!" + Constants.vbCrLf + Constants.vbCrLf + Functions.returnWithError, Constants.vbCritical, "PenseAPI");
                return;
            }

            Interaction.MsgBox("Token obtido com sucesso", Constants.vbInformation, "PenseAPI");
        }

        private void BtnCreateStore_Click(object sender, EventArgs e)
        {
            string open = TxtOpen.Text;
            string close = TxtClose.Text;
            string companyName = TxtCompanyName.Text;
            string document = TxtDocument.Text;
            string externalReference = TxtExternalReference.Text;
            string streetNumber = TxtStreetNumber.Text;
            string streetName = TxtStreetName.Text;
            string cityName = TxtCityName.Text;
            string stateName = TxtStateName.Text;
            string latitude = TxtLatitude.Text;
            string longitude = TxtLongitude.Text;
            string reference = txtReferene.Text;
            string tradeName = TxtTradeName.Text;
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(Functions.CreateStore(open, close, companyName, document, externalReference, streetNumber, streetName, cityName, stateName, latitude, longitude, reference, tradeName), true, false)))
            {
                Interaction.MsgBox("Loja cadastrada com sucesso", Constants.vbInformation, "PenseAPI");
            }
            else
            {
                Interaction.MsgBox("Falha ao cadastrar loja!" + Constants.vbCrLf + Constants.vbCrLf + Functions.returnWithError, Constants.vbCritical, "PenseAPI");
                return;
            }
        }

        private void BtnRegisterPos_Click(object sender, EventArgs e)
        {
            string externalReference = TxtExternalReferencePos.Text;
            string externalReferenceStore = TxtExternalReferenceStorePos.Text;
            string name = TxtNamePos.Text;
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(Functions.RegisterPOS(externalReference, externalReferenceStore, name), true, false)))
            {
                Interaction.MsgBox("PDV cadastrado com sucesso", Constants.vbInformation, "PenseAPI");
            }
            else
            {
                Interaction.MsgBox("Falha ao cadastrar PDV!" + Constants.vbCrLf + Constants.vbCrLf + Functions.returnWithError, Constants.vbCritical, "PenseAPI");
                return;
            }
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControl1.SelectedIndex == 3)
            {
                Width = 862;
            }
            else
            {
                Width = 506;
            }
        }

        private string ItemList()
        {

            // Construção da lista de itens que estará contida no body da requisição de pagamento
            string quotationMarks = "\"";
            string parameters = "";
            string itemDescription = "";
            string itemQuantity = "";
            string itemValue = "";
            int lines = 0;
            parameters = quotationMarks + "items" + quotationMarks + ": " + "[";
            if (DgvItems.Rows.Count - 1 == 1)
            {
                for (int i = 0, loopTo = DgvItems.Rows.Count - 2; i <= loopTo; i++)
                {
                    itemDescription = DgvItems.Rows[i].Cells[0].Value.ToString();
                    itemQuantity = DgvItems.Rows[i].Cells[1].Value.ToString();
                    itemValue = DgvItems.Rows[i].Cells[2].Value.ToString();
                    itemValue = itemValue.Replace(",", ".");
                }

                parameters = parameters + @"
{" + @"
" + quotationMarks + "description" + quotationMarks + ": " + quotationMarks + itemDescription + quotationMarks + @",
" + quotationMarks + "quantity" + quotationMarks + ": " + quotationMarks + itemQuantity + quotationMarks + @",
" + quotationMarks + "value" + quotationMarks + ": " + quotationMarks + itemValue + quotationMarks + @"
}";
            }
            else
            {
                lines = DgvItems.Rows.Count - 2;
                for (int i = 0, loopTo1 = DgvItems.Rows.Count - 2; i <= loopTo1; i++)
                {
                    itemDescription = DgvItems.Rows[i].Cells[0].Value.ToString();
                    itemQuantity = DgvItems.Rows[i].Cells[1].Value.ToString();
                    itemValue = DgvItems.Rows[i].Cells[2].Value.ToString();
                    itemValue = itemValue.Replace(",", ".");
                    if (i == lines)
                    {
                        parameters = parameters + @"
{" + @"
" + quotationMarks + "description" + quotationMarks + ": " + quotationMarks + itemDescription + quotationMarks + @",
" + quotationMarks + "quantity" + quotationMarks + ": " + quotationMarks + itemQuantity + quotationMarks + @",
" + quotationMarks + "value" + quotationMarks + ": " + quotationMarks + itemValue + quotationMarks + @"
}";
                    }
                    else
                    {
                        parameters = parameters + @"
{" + @"
" + quotationMarks + "description" + quotationMarks + ": " + quotationMarks + itemDescription + quotationMarks + @",
" + quotationMarks + "quantity" + quotationMarks + ": " + quotationMarks + itemQuantity + quotationMarks + @",
" + quotationMarks + "value" + quotationMarks + ": " + quotationMarks + itemValue + quotationMarks + @"
},
";
                    }
                }
            }

            parameters = parameters + "],";
            parameters = parameters.Replace(Constants.vbCrLf, "");
            return parameters;
        }

        private void BtnGenerateSale_Click(object sender, EventArgs e)
        {
            string description = TxtDescriptionPayment.Text;
            string externalReference = TxtExternalReferencePayment.Text;
            string value = TxtValuePayment.Text;
            value = value.Replace(",", ".");
            string wallet = TxtWalletPayment.Text;
            string store = TxtStorePayment.Text;
            string pdv = TxtPdvPayment.Text;
            string items = ItemList();
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(Functions.Payment(description, externalReference, value, wallet, store, pdv, items), true, false)))
            {
                Interaction.MsgBox("Venda de número: " + Functions.paymentId + " foi registrada com sucesso", Constants.vbInformation, "PenseAPI");
                TxtPaymentId.Text = Functions.paymentId.ToString();
                ImgQrCodeUrl.Load(Functions.qrCodeUrl);
                LblPaymentStatus.Text = "";
                LblUpdateAt.Text = "";
                consultStatus = "";
                TimerPaymentStatus.Start();
            }
            else
            {
                Interaction.MsgBox("Falha ao registrar venda!" + Constants.vbCrLf + Constants.vbCrLf + Functions.returnWithError, Constants.vbCritical, "PenseAPI");
                return;
            }
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            if (TabControl1.SelectedIndex == 3)
            {
                Width = 862;
            }
            else
            {
                Width = 506;
            }
        }

        private void TimerPaymentStatus_Tick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(LblPaymentStatus.Text) | LblPaymentStatus.Text == "Waiting")
            {
                try
                {
                    BwPaymentStatus.RunWorkerAsync();
                    System.Threading.Thread.Sleep(100);
                    Application.DoEvents();
                    if (consultStatus == "OK")
                    {
                        LblPaymentStatus.Text = Functions.paymentStatus;
                        LblUpdateAt.Text = Conversions.ToString(Functions.updateAt.AddHours(-3));
                    }

                    if (LblPaymentStatus.Text == "Waiting")
                    {
                        LblPaymentStatus.ForeColor = Color.Gold;
                    }
                    else if (LblPaymentStatus.Text == "Paid")
                    {
                        LblPaymentStatus.ForeColor = Color.Green;
                    }
                    else
                    {
                        LblPaymentStatus.ForeColor = Color.Red;
                    }
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox(ex.Message.ToString());
                }
            }
            else
            {
                TimerPaymentStatus.Stop();
            }

            TimerPaymentStatus.Interval = 5000;
        }

        private void BwPaymentStatus_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(Functions.GetPaymentStatus(Functions.paymentId), true, false)))
            {
                consultStatus = "OK";
            }
            else
            {
                consultStatus = "ERROR";
            }
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            DgvItems.Rows.Add(TxtItemDescriptionPayment.Text, TxtItemQuantityPayment.Text, TxtItemValuePayment.Text, Convert.ToDecimal(TxtItemQuantityPayment.Text) * Convert.ToDecimal(TxtItemValuePayment.Text) / 100m);
            CalculateTotal();
        }

        private void CalculateTotal()
        {
            double total = 0d;
            for (int i = 0, loopTo = DgvItems.Rows.Count - 1; i <= loopTo; i++)
                total += (double)Convert.ToDecimal(DgvItems.Rows[i].Cells[3].Value);
            TxtValuePayment.Text = total.ToString();
        }

        private void BtmRemoveItem_Click(object sender, EventArgs e)
        {
            DgvItems.Rows.RemoveAt(DgvItems.CurrentCell.RowIndex);
            CalculateTotal();
        }

        private void BtnConsultStatus_Click(object sender, EventArgs e)
        {
            ConsultTransactionStatus(Conversions.ToInteger(TxtPaymentIdConsult.Text), "paymentId");
        }

        private void ConsultTransactionStatus(int information, string type)
        {
            LblPaymentStatusConsult.Text = "";
            LblUpdateAtConsult.Text = "";
            if (type == "paymentId")
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(Functions.GetPaymentStatus(information), true, false)))
                {
                    ImgQrCodeUrlConsult.Load(Functions.qrCodeUrl);
                    LblPaymentStatusConsult.Text = Functions.paymentStatus;
                    LblUpdateAtConsult.Text = Conversions.ToString(Functions.updateAt.AddHours(-3));
                    if (LblPaymentStatusConsult.Text == "Waiting")
                    {
                        LblPaymentStatusConsult.ForeColor = Color.Gold;
                    }
                    else if (LblPaymentStatusConsult.Text == "Paid")
                    {
                        LblPaymentStatusConsult.ForeColor = Color.Green;
                    }
                    else
                    {
                        LblPaymentStatusConsult.ForeColor = Color.Red;
                    }
                }
            }
            else if (type == "externalReference")
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(Functions.GetPaymentStatusByExternalReference(information), true, false)))
                {
                    ImgQrCodeUrlConsult.Load(Functions.qrCodeUrl);
                    LblPaymentStatusConsult.Text = Functions.paymentStatus;
                    LblUpdateAtConsult.Text = Conversions.ToString(Functions.updateAt.AddHours(-3));
                    if (LblPaymentStatusConsult.Text == "Waiting")
                    {
                        LblPaymentStatusConsult.ForeColor = Color.Gold;
                    }
                    else if (LblPaymentStatusConsult.Text == "Paid")
                    {
                        LblPaymentStatusConsult.ForeColor = Color.Green;
                    }
                    else
                    {
                        LblPaymentStatusConsult.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void BtnCancelSale_Click(object sender, EventArgs e)
        {
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(Functions.CancelPayment(Conversions.ToInteger(TxtPaymentIdConsult.Text)), true, false)))
            {
                Interaction.MsgBox("Venda de número: " + TxtPaymentIdConsult.Text + " cancelada com sucesso", Constants.vbInformation, "PenseAPI");
                ConsultTransactionStatus(Conversions.ToInteger(TxtPaymentIdConsult.Text), "paymentId");
            }
            else
            {
                Interaction.MsgBox("Falha ao cancelar venda!" + Constants.vbCrLf + Constants.vbCrLf + Functions.returnWithError, Constants.vbCritical, "PenseAPI");
                return;
            }
        }

        private void BtnConsultByReference_Click(object sender, EventArgs e)
        {
            ConsultTransactionStatus(Conversions.ToInteger(TxtExternalReferencePaymentConsult.Text), "externalReference");
        }
    }
}