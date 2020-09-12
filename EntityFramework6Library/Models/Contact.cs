namespace EntityFramework6Library.Models
{
    public partial class Contact
    {
        public int ContactId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int? ContactTypeIdentifier { get; set; }

        public virtual ContactType ContactType { get; set; }
    }
}
