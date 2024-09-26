using static EatMicroservices.Web.Utils.StaticDetails;

namespace EatMicroservices.Web.Models.Dto
{
    public class RequestDto
    {
        public RequestType RequestType { get; set; } = RequestType.GET;
        public string Url { get; set; }
        public object Data { get; set; }
        public string AccessToken { get; set; }
    }
}
