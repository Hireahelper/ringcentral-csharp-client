namespace RingCentral
{
    public partial class UserCallLogRecord
    {
        // Internal identifier of a cal log record
        public string @id { get; set; }
        // Canonical URI of a call log record
        public string @uri { get; set; }
        // Internal identifier of a call session
        public string @sessionId { get; set; }
        // Caller information
        public string @from { get; set; }
        // Callee information
        public string @to { get; set; }
        // Call type = ['Voice', 'Fax']
        public string @type { get; set; }
        // Call direction = ['Inbound', 'Outbound']
        public string @direction { get; set; }
        // The call start datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        public string @startTime { get; set; }
        // Call duration in seconds
        public long? @duration { get; set; }
        // Call recording data. Returned if the call is recorded. Each call recording is stored in the system for 90 days. But if the number of recordings exceeds the admissible limit (100,000 recordings per account) then the older recordings are replaced with the new ones. Thus a link to an older recording in a certain call log record becomes unavailable
        public string @recording { get; set; }
    }
}
