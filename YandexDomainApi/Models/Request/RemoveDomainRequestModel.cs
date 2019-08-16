using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexDomainApi.Models
{
    public class RemoveDomainRequestModel : IBaseRequest
    {
        public string PddToken { get; set; }
        public string Domain { get; set; }
    }
}
