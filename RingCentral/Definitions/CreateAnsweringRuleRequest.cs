namespace RingCentral
{
    public partial class CreateAnsweringRuleRequest
    {
        // Type of an answering rule. The 'Custom' value should be specified
        public string @type { get; set; }
        // Name of an answering rule specified by user
        public string @name { get; set; }
        // Answering rule will be applied when calls are received from the specified caller(s)
        public CallersInfoRequest[] @callers { get; set; }
        // Forwarding parameters. Should be specified if the 'callHandlingAction' parameter value is set to 'ForwardCalls'. These settings determine the forwarding numbers to which the call should be forwarded
        public ForwardingInfoCreateRuleRequest @forwarding { get; set; }
    }
}
