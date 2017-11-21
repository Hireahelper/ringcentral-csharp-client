using System.Threading.Tasks;
namespace RingCentral
{
    public partial class LookupPath : PathSegment
    {
        internal LookupPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "lookup";
            }
        }
    }
}
