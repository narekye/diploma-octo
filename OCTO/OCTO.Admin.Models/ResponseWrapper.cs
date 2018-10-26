namespace OCTO.Admin.Models
{
    public class ResponseWrapper<T>
    {
        public bool HasError { get; set; }

        public T Data { get; set; }

        public string Message { get; set; }

        public string State { get; set; }
    }
}
