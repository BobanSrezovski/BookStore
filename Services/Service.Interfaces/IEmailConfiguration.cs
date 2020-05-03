namespace BookStore.Services.Service.Interfaces
{
    public interface IEmailConfiguration
    {
        string SmtpServer { get; }
        int SmtpPort { get; }
        string SmtpUsername { get; set; }
        string SmtpPassword { get; set; }
        string AppEmailFrom { get; }
        string EmailName { get; }
    }
}
