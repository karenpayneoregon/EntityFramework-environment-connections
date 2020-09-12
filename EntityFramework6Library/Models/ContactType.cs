using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace EntityFramework6Library.Models
{
    [Table("ContactType")]
    public partial class ContactType
    {
        [SuppressMessage(
            "Microsoft.Usage", 
            "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ContactType()
        {
            Contacts = new HashSet<Contact>();
        }

        [Key]
        public int ContactTypeIdentifier { get; set; }

        public string ContactTitle { get; set; }

        [SuppressMessage(
            "Microsoft.Usage", 
            "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contact> Contacts { get; set; }
    }
}
