using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeerReviewSample.Processes
{
    class ReviewTaskExtractor:Database
    {
        int reviewerId;
        public ReviewTaskExtractor(int reviewerId)
        {
            this.reviewerId = reviewerId;
        }
        public DataTable GetReviewsAllStatus()
        {
            string sqlQuery = "select rv.reviewId,rd.title,rd.link,rv.specialism,rv.status from reviews rv inner join rdocs rd " +
                "where rv.rdocId = rd.rdocId and rv.reviewerId = "+ reviewerId + "; ";
            return Read(sqlQuery);

        }
        public DataTable GetReviewsAwaiting()
        {
            string sqlQuery = "select rv.reviewId, rd.title,rd.link,rv.specialism,rv.status from reviews rv inner join rdocs rd " +
                "where rv.status ='Awaiting' and rv.rdocId = rd.rdocId and rv.reviewerId = " + reviewerId + "; ";
            return Read(sqlQuery);
        }
    }
}
