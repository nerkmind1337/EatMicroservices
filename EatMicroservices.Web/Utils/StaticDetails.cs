namespace EatMicroservices.Web.Utils
{
    public class StaticDetails
    {
        public static string CouponApiBaseUrl { get; set; }
        public enum RequestType
        {
            GET,
            POST,
            PUT,
            DELETE
        }
    }
}
