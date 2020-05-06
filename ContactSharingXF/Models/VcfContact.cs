using System.Collections.Generic;

namespace ContactSharingXF.Models
{
    public class VcfContact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FormattedName { get; set; }
        public string Organization { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public string Photo { get; set; }
        public List<VcfPhone> Phones { get; set; }
        public List<VcfAddress> Addresses { get; set; }
    }

    public class VcfPhone
    {
        public string Number { get; set; }
        public string Type { get; set; }
    }

    public class VcfAddress
    {
        public string Description { get; set; }
        public string Type { get; set; }
    }
}
