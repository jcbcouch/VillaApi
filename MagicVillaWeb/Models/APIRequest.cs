using System.Security.AccessControl;
using static MagicVillaUtility.SD;

namespace MagicVillaWeb.Models
{
    public class APIRequest
    {
        public ApiType ApiType { get; set; } = ApiType.GET;
        public string Url { get; set; }
        public object Data { get; set; }
    }
}
