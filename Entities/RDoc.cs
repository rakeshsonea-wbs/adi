using System.Data;

namespace PeerReviewSample.Entities
{
    class RDoc
    {
       
        public string Title{ get; set; }
        public string Link { get; set; }

        public int AuthorId { get; set; }
        public DataTable SpecialismWithMinGrade { get; set; }

    }
}
