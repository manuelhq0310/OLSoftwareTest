namespace TestAPIRest.Models
{
    public class SendEmail
    {
        public string? NameEmail { get; set; }

        public string? FromEmail { get; set; }

        public string? ToEmail { get; set; }

        public string? Subject { get; set; }

        public string? Body { get; set; }

        public string? AttachmentName { get; set; }

        public byte[]? Attachment { get; set; }
    }
}
