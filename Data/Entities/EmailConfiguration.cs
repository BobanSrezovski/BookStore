using BookStore.Services.Service.Interfaces;

namespace BookStore.Data.Entities
{
    public class EmailConfiguration : IEmailConfiguration
    {
        public string SmtpServer { get; set; }
        public int SmtpPort { get; set; }
        public string SmtpUsername { get; set; }
        public string SmtpPassword { get; set; }
        public string AppEmailFrom { get; set; }
        public string EmailName { get; set; }
    }
}
