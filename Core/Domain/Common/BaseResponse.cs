using Domain.Enums;

namespace Domain.Common
{
    public abstract class BaseResponse
    {
        public ResponseCodes ResponseCode { get; set; }
        public string? ResponseMessage { get; set; }
    }
}
