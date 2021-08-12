using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;

namespace PenseAPI
{
    static class Functions
    {
        public static string baseUrl = "";
        public static string accessToken = "";
        public static double tokenValidity;
        public static string accessKey = "";
        public static string clientId = "";
        public static string returnWithError = "";
        public static string qrCodeUrl;
        public static int paymentId;
        public static string paymentStatus;
        public static DateTime updateAt;

        public static object Authentication(string accessKey, string clientId)
        {
            var dictData = new Dictionary<string, string>();

            // Construção do body que será enviado na requisição
            dictData.Add("accessKey", accessKey);
            dictData.Add("clientId", clientId);
            var webClient = new WebClient();
            byte[] requestByte;
            string request;
            byte[] requestString;
            try
            {

                // Definição do tipo de requisição que será feita
                webClient.Headers["content-type"] = "application/json";

                // Serialização dos dados
                requestString = Encoding.Default.GetBytes(JsonConvert.SerializeObject(dictData, Formatting.Indented));
                // Fazendo a requisição
                requestByte = webClient.UploadData(baseUrl + "/api/Auth", "post", requestString);
                // Pegando o retorno em string
                request = Encoding.Default.GetString(requestByte);

                // Desserializar retorno Json
                var getReturn = JsonConvert.DeserializeObject<PenseAPI.ReturnAuthentication>(request);
                webClient.Dispose();

                // Obtendo o token retornado no Json
                accessToken = getReturn.accessToken;
            }
            catch (WebException ex)
            {

                // Tratamento de erro
                using (var stream = ex.Response.GetResponseStream())
                {
                    using (var sr = new StreamReader(stream))
                    {
                        returnWithError = sr.ReadToEnd();
                    }
                }

                return false;
            }

            // Salva em milisegundos a data e hora da última atualização do token 
            tokenValidity = (long)Math.Round(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds);
            return true;
        }

        private static object RefreshAuthentication()
        {
            if (tokenValidity >= tokenValidity + 12 * 60000)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(Authentication(accessKey, clientId), false, false)))
                {
                    return false;
                }
            }

            return true;
        }

        public static object CreateStore(string open, string close, string companyName, string document, string externalReference, string streetNumber, string streetName, string cityName, string stateName, string latitude, string longitude, string reference, string tradeName)
        {

            // Verifica se já se passaram 12 minutos ou mais desde a última requisição do token
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(RefreshAuthentication(), false, false)))
            {
                return false;
            }

            // Construção do body que será enviado na requisição
            string quotationMarks = "\"";
            string parameters = "";
            parameters = @"{
" + quotationMarks + "businessHours" + quotationMarks + ": " + @"{
" + quotationMarks + "monday" + quotationMarks + ": " + @"[
{
" + quotationMarks + "open" + quotationMarks + ": " + quotationMarks + open + quotationMarks + @",
" + quotationMarks + "close" + quotationMarks + ": " + quotationMarks + close + quotationMarks + @"
}
],
" + quotationMarks + "tuesday" + quotationMarks + ": " + @"[
{
" + quotationMarks + "open" + quotationMarks + ": " + quotationMarks + open + quotationMarks + @",
" + quotationMarks + "close" + quotationMarks + ": " + quotationMarks + close + quotationMarks + @"
}
],
" + quotationMarks + "wednesday" + quotationMarks + ": " + @"[
{
" + quotationMarks + "open" + quotationMarks + ": " + quotationMarks + open + quotationMarks + @",
" + quotationMarks + "close" + quotationMarks + ": " + quotationMarks + close + quotationMarks + @"
}
],
" + quotationMarks + "sunday" + quotationMarks + ": " + @"[
{
" + quotationMarks + "open" + quotationMarks + ": " + quotationMarks + open + quotationMarks + @",
" + quotationMarks + "close" + quotationMarks + ": " + quotationMarks + close + quotationMarks + @"
}
],
" + quotationMarks + "saturday" + quotationMarks + ": " + @"[
{
" + quotationMarks + "open" + quotationMarks + ": " + quotationMarks + open + quotationMarks + @",
" + quotationMarks + "close" + quotationMarks + ": " + quotationMarks + close + quotationMarks + @"
}
],
" + quotationMarks + "friday" + quotationMarks + ": " + @"[
{
" + quotationMarks + "open" + quotationMarks + ": " + quotationMarks + open + quotationMarks + @",
" + quotationMarks + "close" + quotationMarks + ": " + quotationMarks + close + quotationMarks + @"
}
],
" + quotationMarks + "thursday" + quotationMarks + ": " + @"[
{
" + quotationMarks + "open" + quotationMarks + ": " + quotationMarks + open + quotationMarks + @",
" + quotationMarks + "close" + quotationMarks + ": " + quotationMarks + close + quotationMarks + @"
}
]
},
" + quotationMarks + "companyName" + quotationMarks + ": " + quotationMarks + companyName + quotationMarks + @",
" + quotationMarks + "document" + quotationMarks + ": " + quotationMarks + document + quotationMarks + @",
" + quotationMarks + "externalReference" + quotationMarks + ": " + quotationMarks + externalReference + quotationMarks + @",
" + quotationMarks + "location" + quotationMarks + ": " + @"{
" + quotationMarks + "streetNumber" + quotationMarks + ": " + quotationMarks + streetNumber + quotationMarks + @",
" + quotationMarks + "streetName" + quotationMarks + ": " + quotationMarks + streetName + quotationMarks + @",
" + quotationMarks + "cityName" + quotationMarks + ": " + quotationMarks + cityName + quotationMarks + @",
" + quotationMarks + "stateName" + quotationMarks + ": " + quotationMarks + stateName + quotationMarks + @",
" + quotationMarks + "latitude" + quotationMarks + ": " + quotationMarks + latitude + quotationMarks + @",
" + quotationMarks + "longitude" + quotationMarks + ": " + quotationMarks + longitude + quotationMarks + @",
" + quotationMarks + "reference" + quotationMarks + ": " + quotationMarks + reference + quotationMarks + @"
},
" + quotationMarks + "tradeName" + quotationMarks + ": " + quotationMarks + tradeName + quotationMarks + @"
}";
            parameters = parameters.Replace(Constants.vbCrLf, "");
            var webClient = new WebClient();
            byte[] requestByte;
            string request;
            byte[] requestString;
            try
            {

                // Definição do tipo de requisição que será feita
                webClient.Headers["content-type"] = "application/json";
                // Passagem do token obtido na autenticação
                webClient.Headers["authorization"] = "Bearer " + accessToken;

                // Convertendo o body para bytes
                requestString = Encoding.Default.GetBytes(parameters);
                // Fazendo a requisição
                requestByte = webClient.UploadData(baseUrl + "/api/Config/Store", "post", requestString);
                // Pegando o retorno em string
                request = Encoding.Default.GetString(requestByte);
                webClient.Dispose();
            }
            catch (WebException ex)
            {

                // Tratamento de erro
                using (var stream = ex.Response.GetResponseStream())
                {
                    using (var sr = new StreamReader(stream))
                    {
                        returnWithError = sr.ReadToEnd();
                    }
                }

                return false;
            }

            return true;
        }

        public static object RegisterPOS(string externalReference, string externalReferenceStore, string name)
        {

            // Verifica se já se passaram 12 minutos ou mais desde a última requisição do token
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(RefreshAuthentication(), false, false)))
            {
                return false;
            }

            var dictData = new Dictionary<string, string>();

            // Construção do body que será enviado na requisição
            dictData.Add("externalReference", externalReference);
            dictData.Add("externalReferenceStore", externalReferenceStore);
            dictData.Add("name", name);
            var webClient = new WebClient();
            byte[] requestByte;
            string request;
            byte[] requestString;
            try
            {

                // Definição do tipo de requisição que será feita
                webClient.Headers["content-type"] = "application/json";
                // Passagem do token obtido na autenticação
                webClient.Headers["authorization"] = "Bearer " + accessToken;

                // Serialização dos dados
                requestString = Encoding.Default.GetBytes(JsonConvert.SerializeObject(dictData, Formatting.Indented));
                // Fazendo a requisição
                requestByte = webClient.UploadData(baseUrl + "/api/Config/Pdv", "post", requestString);
                // Pegando o retorno em string
                request = Encoding.Default.GetString(requestByte);
                webClient.Dispose();
            }
            catch (WebException ex)
            {

                // Tratamento de erro
                using (var stream = ex.Response.GetResponseStream())
                {
                    using (var sr = new StreamReader(stream))
                    {
                        returnWithError = sr.ReadToEnd();
                    }
                }

                return false;
            }

            return true;
        }

        public static object Payment(string description, string externalReference, string value, string wallet, string store, string pdv, string items)
        {

            // Verifica se já se passaram 12 minutos ou mais desde a última requisição do token
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(RefreshAuthentication(), false, false)))
            {
                return false;
            }

            // Construção do body que será enviado na requisição
            string quotationMarks = "\"";
            string parameters = "";
            parameters = @"{
" + quotationMarks + "description" + quotationMarks + ": " + quotationMarks + description + quotationMarks + @",
" + quotationMarks + "externalReference" + quotationMarks + ": " + quotationMarks + externalReference + quotationMarks + @",
" + quotationMarks + "value" + quotationMarks + ": " + quotationMarks + value + quotationMarks + @",
" + quotationMarks + "wallet" + quotationMarks + ": " + quotationMarks + wallet + quotationMarks + @",
" + items + @"
" + quotationMarks + "store" + quotationMarks + ": " + quotationMarks + store + quotationMarks + @",
" + quotationMarks + "pdv" + quotationMarks + ": " + quotationMarks + pdv + quotationMarks + @"
}";
            parameters = parameters.Replace(Constants.vbCrLf, "");
            var webClient = new WebClient();
            byte[] requestByte;
            string request;
            byte[] requestString;
            try
            {

                // Definição do tipo de requisição que será feita
                webClient.Headers["content-type"] = "application/json";
                // Passagem do token obtido na autenticação
                webClient.Headers["authorization"] = "Bearer " + accessToken;

                // Convertendo o body em bytes
                requestString = Encoding.Default.GetBytes(parameters);
                // Fazendo a requisição
                requestByte = webClient.UploadData(baseUrl + "/api/Payment", "post", requestString);
                // Pegando o retorno em string
                request = Encoding.Default.GetString(requestByte);

                // Desserializar retorno Json
                var getReturn = JsonConvert.DeserializeObject<PenseAPI.ReturnPayment>(request);
                webClient.Dispose();

                // Obtendo o qrcode e o id da venda
                qrCodeUrl = getReturn.qrCodeUrl;
                paymentId = getReturn.id;
            }
            catch (WebException ex)
            {

                // Tratamento de erro
                using (var stream = ex.Response.GetResponseStream())
                {
                    using (var sr = new StreamReader(stream))
                    {
                        returnWithError = sr.ReadToEnd();
                    }
                }

                return false;
            }

            return true;
        }

        public static object GetPaymentStatus(int paymentId)
        {

            // Verifica se já se passaram 12 minutos ou mais desde a última requisição do token
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(RefreshAuthentication(), false, false)))
            {
                return false;
            }

            var webClient = new WebClient();
            byte[] requestByte;
            string request;
            try
            {

                // Definição do tipo de requisição que será feita
                webClient.Headers["content-type"] = "application/json";
                // Passagem do token obtido na autenticação
                webClient.Headers["authorization"] = "Bearer " + accessToken;

                // Fazendo a requisição
                requestByte = webClient.DownloadData(baseUrl + "/api/Payment/" + paymentId);
                // Pegando o retorno em string
                request = Encoding.Default.GetString(requestByte);

                // Desserializar retorno Json
                var getReturn = JsonConvert.DeserializeObject<PenseAPI.ReturnPaymentStatus>(request);

                // Obtendo status, qrcode e data de atualização da venda
                paymentStatus = getReturn.status;
                qrCodeUrl = getReturn.qrCodeUrl;
                updateAt = getReturn.updateAt;
                webClient.Dispose();
            }
            catch (WebException ex)
            {

                // Tratamento de erro
                using (var stream = ex.Response.GetResponseStream())
                {
                    using (var sr = new StreamReader(stream))
                    {
                        returnWithError = sr.ReadToEnd();
                    }
                }

                return false;
            }

            return true;
        }

        public static object GetPaymentStatusByExternalReference(int externalReference)
        {

            // Verifica se já se passaram 12 minutos ou mais desde a última requisição do token
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(RefreshAuthentication(), false, false)))
            {
                return false;
            }

            var webClient = new WebClient();
            byte[] requestByte;
            string request;
            try
            {

                // Definição do tipo de requisição que será feita
                webClient.Headers["content-type"] = "application/json";
                // Passagem do token obtido na autenticação
                webClient.Headers["authorization"] = "Bearer " + accessToken;

                // Fazendo a requisição
                requestByte = webClient.DownloadData(baseUrl + "/api/Payment/ByExternalReference/" + externalReference);
                // Pegando o retorno em string
                request = Encoding.Default.GetString(requestByte);

                // Desserializar retorno Json
                var getReturn = JsonConvert.DeserializeObject<PenseAPI.ReturnPaymentStatus>(request);

                // Obtendo status, qrcode e data de atualização da venda
                paymentStatus = getReturn.status;
                qrCodeUrl = getReturn.qrCodeUrl;
                updateAt = getReturn.updateAt;
                webClient.Dispose();
            }
            catch (WebException ex)
            {

                // Tratamento de erro
                using (var stream = ex.Response.GetResponseStream())
                {
                    using (var sr = new StreamReader(stream))
                    {
                        returnWithError = sr.ReadToEnd();
                    }
                }

                return false;
            }

            return true;
        }

        public static object CancelPayment(int paymentId)
        {

            // Verifica se já se passaram 12 minutos ou mais desde a última requisição do token
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(RefreshAuthentication(), false, false)))
            {
                return false;
            }

            var webClient = new WebClient();
            string request;
            try
            {

                // Definição do tipo de requisição que será feita
                webClient.Headers["content-type"] = "application/json";
                // Passagem do token obtido na autenticação
                webClient.Headers["authorization"] = "Bearer " + accessToken;

                // Fazendo a requisição
                request = webClient.UploadString(baseUrl + "/api/Payment/" + paymentId, "DELETE", "Cancelamento");
                webClient.Dispose();
            }
            catch (WebException ex)
            {

                // Tratamento de erro
                using (var stream = ex.Response.GetResponseStream())
                {
                    using (var sr = new StreamReader(stream))
                    {
                        returnWithError = sr.ReadToEnd();
                    }
                }

                return false;
            }

            return true;
        }
    }
}