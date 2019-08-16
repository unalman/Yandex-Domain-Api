using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using YandexDomainApi.Models;

namespace YandexDomainApi
{
    public class YandexMailApi
    {
        #region Domain
        public AddDomainResponseModel AddDomain(AddDomainRequestModel model)
        {
            AddDomainResponseModel CResponse = new AddDomainResponseModel();

            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://pddimp.yandex.ru/api2/admin/domain/register?domain=" + model.Domain + "");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Accept = "*/*";
            httpWebRequest.Method = "POST";
            httpWebRequest.Headers.Add("PddToken", model.PddToken);
            httpWebRequest.ContentType = "application/x-www-form-urlencoded";

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            try
            {
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    string jsonResponse = streamReader.ReadToEnd();
                    CResponse = JsonConvert.DeserializeObject<AddDomainResponseModel>(jsonResponse);
                    if (CResponse.success == "ok")
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(DateTime.Now + " -> Error (" + ex.Message + ")");
            }
            return CResponse;
        }
        public RemoveDomainResponseModel RemoveDomain(RemoveDomainRequestModel model)
        {
            RemoveDomainResponseModel CResponse = new RemoveDomainResponseModel();

            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://pddimp.yandex.ru/api2/admin/domain/delete?domain=" + model.Domain + "");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Accept = "*/*";
            httpWebRequest.Method = "POST";
            httpWebRequest.Headers.Add("PddToken", model.PddToken);
            httpWebRequest.ContentType = "application/x-www-form-urlencoded";

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            try
            {
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    string jsonResponse = streamReader.ReadToEnd();
                    CResponse = JsonConvert.DeserializeObject<RemoveDomainResponseModel>(jsonResponse);
                    if (CResponse.success == "ok")
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(DateTime.Now + " -> Error (" + ex.Message + ")");
            }
            return CResponse;
        }
        #endregion

        #region Mail
        public AddMailResponseModel AddMail(AddMailRequestModel model)
        {
            AddMailResponseModel CResponse = new AddMailResponseModel();

            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://pddimp.yandex.ru/api2/admin/email/add?domain=" + model.Domain + "&login=" + model.Login + "&password=" + model.Password + "");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Accept = "*/*";
            httpWebRequest.Method = "POST";
            httpWebRequest.Headers.Add("PddToken", model.PddToken);
            httpWebRequest.ContentType = "application/x-www-form-urlencoded";

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            try
            {
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    string jsonResponse = streamReader.ReadToEnd();
                    CResponse = JsonConvert.DeserializeObject<AddMailResponseModel>(jsonResponse);
                    if (CResponse.success == "ok")
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(DateTime.Now + " -> Error (" + ex.Message + ")");
            }
            return CResponse;
        }
        public RemoveMailResponseModel RemoveMail(RemoveMailRequestModel model)
        {
            RemoveMailResponseModel CResponse = new RemoveMailResponseModel();

            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://pddimp.yandex.ru/api2/admin/email/del?domain=" + model.Domain + "&login=" + model.Login + "");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Accept = "*/*";
            httpWebRequest.Method = "POST";
            httpWebRequest.Headers.Add("PddToken", model.PddToken);
            httpWebRequest.ContentType = "application/x-www-form-urlencoded";

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            try
            {
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    string jsonResponse = streamReader.ReadToEnd();
                    CResponse = JsonConvert.DeserializeObject<RemoveMailResponseModel>(jsonResponse);
                    if (CResponse.success == "ok")
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(DateTime.Now + " -> Error (" + ex.Message + ")");
            }
            return CResponse;
        }
        #endregion
    }
}
