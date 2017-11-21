namespace RingCentral
{
    public partial class UserUpdateRequest
    {
        // Specification links
        public string[] @schemas { get; set; }
        // User name
        public NameInfoRequest @name { get; set; }
        // User mailbox
        public string @userName { get; set; }
        // User email addresses
        public EmailInfoRequest[] @emails { get; set; }
        // Status of a user
        public bool? @active { get; set; }
        // User phone numbers
        public PhoneNumberInfoRequest[] @phoneNumbers { get; set; }
        // External identifier of a user
        public string @externalId { get; set; }
        // User addresses
        public AddressInfoRequest @addresses { get; set; }
        // Internal identifier of a user
        public string @id { get; set; }
    }
}
