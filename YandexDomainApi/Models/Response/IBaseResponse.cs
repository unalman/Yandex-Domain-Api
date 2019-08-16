using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexDomainApi.Models
{
    public interface IBaseResponse
    {
        string domain { get; set; }
        string success { get; set; }
    }
}
