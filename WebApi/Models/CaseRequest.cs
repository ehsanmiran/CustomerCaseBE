namespace WebApi.Models
{
    public class CaseRequest
    {
        public string Email { get; set; }
        public string CustomerName { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string Status { get; set; }
    }
}
