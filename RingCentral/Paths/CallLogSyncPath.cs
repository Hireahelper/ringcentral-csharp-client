using System.Threading.Tasks;
namespace RingCentral
{
    public partial class CallLogSyncPath : PathSegment
    {
        internal CallLogSyncPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "call-log-sync";
            }
        }
        // <p style='font-style:italic;'></p><p></p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>ReadCallLog</td><td>Viewing user call logs</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Heavy</p>
        public async Task<bool> Get()
        {
            await RC.Get(Endpoint(true), null);
            return true;
        }
        // <p style='font-style:italic;'></p><p></p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>ReadCallLog</td><td>Viewing user call logs</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Heavy</p>
        public async Task<bool> Get(object parameters)
        {
            await RC.Get(Endpoint(true), parameters);
            return true;
        }
        // <p style='font-style:italic;'></p><p></p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>ReadCallLog</td><td>Viewing user call logs</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Heavy</p>
        public Task<bool> Get(GetParameters parameters)
        {
            return Get(parameters as object);
        }
        public partial class GetParameters
        {
            // Type of synchronization. 'FSync' is a default value
            public string[] @syncType { get; set; }
            // Value of syncToken property of last sync request response
            public string @syncToken { get; set; }
            // The start datetime for resulting records in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is the current moment
            public string @dateFrom { get; set; }
            // ForT?FSync the parameter is mandatory, it limits the number of records to be returned in response. For ISync it specifies with how many records to extend sync Frame to the past, the maximum number of records is 250
            public long? @recordCount { get; set; }
            // Type of calls to be returned. The default value is 'All'
            public string[] @statusGroup { get; set; }
        }
    }
}
