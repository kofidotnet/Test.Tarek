namespace Test.Tarek.Models
{
    public class BaseResponse<TType>
    {
        public bool Success { get; set; }
        public string? ErrorMessage { get; set; }
        public TType? Data { get; set; }

    }
}
