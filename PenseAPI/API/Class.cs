using System;

namespace PenseAPI.PenseAPI
{
    public class ReturnAuthentication
    {
        public bool authenticated { get; set; }
        public string message { get; set; }
        public DateTime create { get; set; }
        public DateTime expiration { get; set; }
        public string accessToken { get; set; }
        public string accessKey { get; set; }
        public string clientId { get; set; }
    }

    public class ReturnPayment
    {
        public int id { get; set; }
        public string description { get; set; }
        public string externalReference { get; set; }
        public string urlCallback { get; set; }
        public string qrCodeUrl { get; set; }
        public string qrCodeData { get; set; }
        public string status { get; set; }
        public double value { get; set; }
        public string wallet { get; set; }
        public DateTime updateAt { get; set; }
    }

    public class ReturnPaymentStatus
    {
        public int id { get; set; }
        public string description { get; set; }
        public string externalReference { get; set; }
        public string urlCallback { get; set; }
        public string qrCodeUrl { get; set; }
        public string qrCodeData { get; set; }
        public string status { get; set; }
        public double value { get; set; }
        public string wallet { get; set; }
        public DateTime updateAt { get; set; }
    }
}