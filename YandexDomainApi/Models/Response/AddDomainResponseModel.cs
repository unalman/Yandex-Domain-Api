namespace YandexDomainApi.Models
{
    public class AddDomainResponseModel : IBaseResponse
    {
        public string stage { get; set; }
        public string status { get; set; }
        public Secrets secrets { get; set; }
        public string domain { get; set; }
        public string success { get; set; }
    }

    public class Secrets
    {
        public string name { get; set; }
        public string content { get; set; }
    }
}
