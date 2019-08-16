using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexDomainApi.Models
{
    public class RemoveMailResponseModel: IBaseResponse
    {
        public string domain { get; set; }
        public string login { get; set; }
        public string success { get; set; }
    }
}
