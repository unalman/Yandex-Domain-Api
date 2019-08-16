namespace YandexDomainApi.Models
{

    public class RemoveDomainResponseModel : IBaseResponse
    {
        public string domain { get; set; }
        public string success { get; set; }
    }

}
