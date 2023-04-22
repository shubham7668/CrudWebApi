namespace ContactsApi.Models
{
    public class UpdateContactRequest
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
    }
}
