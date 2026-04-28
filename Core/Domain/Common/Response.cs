namespace Domain.Common
{
    public class Response<T> : BaseResponse
    {
        public T? Data { get; set; }
    }
}
