using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YandexDomainApi.Models;

namespace YandexDomainApi
{
   public class AddMailRequestModel : IBaseRequest
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Domain { get; set; }
        public string PddToken { get; set; }
    }
} 
