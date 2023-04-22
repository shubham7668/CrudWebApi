namespace ContactsApi.Models
{
    public class AddContactRequest
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
    }
}
