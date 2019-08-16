using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexDomainApi.Models
{
    public interface IBaseRequest
    {
         string PddToken{ get; set; }
        string Domain { get; set; }
    }
}
