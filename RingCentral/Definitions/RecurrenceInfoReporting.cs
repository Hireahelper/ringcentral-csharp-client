namespace RingCentral
{
    public partial class RecurrenceInfoReporting
    {
        // Pattern (frequency) of recurrence
        public string @pattern { get; set; }
        // Time and dates should be specified in UTC time zone
        public string @value { get; set; }
    }
}
