using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexDomainApi.Models
{
    public class AddMailResponseModel : IBaseResponse
    {
        public string login { get; set; }
        public string success { get; set; }
        public string uid { get; set; }
        public string domain { get; set; }
    }
}
