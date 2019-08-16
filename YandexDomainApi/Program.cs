using System;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using YandexDomainApi.Models;
namespace YandexDomainApi
{

    class Program
    {
        static void Main(string[] ars)
        {
            string domain = "", login = "", password = "", PddToken = "";
            YandexMailApi Api = new YandexMailApi();
            AddDomainRequestModel addDomain = new AddDomainRequestModel {
                Domain= domain,
                PddToken= PddToken
            };
            AddDomainResponseModel addDomainResponse= Api.AddDomain(addDomain);
            
        }
    }
}
