namespace OnionEmailApp.Domain.Entities
{
    public class Email
    {
        public int Id { get; set; }
        public string EmailAddress { get; set; }
        public object Recipient { get; set; }
    }
}