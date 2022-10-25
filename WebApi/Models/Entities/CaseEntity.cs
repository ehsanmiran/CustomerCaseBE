using System.ComponentModel.DataAnnotations;

namespace WebApi.Models.Entities
{
    public class CaseEntity
    {
        [Key]
        public string Email { get; set; }
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime Updated { get; set; } = DateTime.Now;
        public string CustomerName { get; set; }
        public string Subject { get; set; } = "";
        public string Message { get; set; } = "";
        public string Status { get; set; } = "Not Opened";
    }
}
