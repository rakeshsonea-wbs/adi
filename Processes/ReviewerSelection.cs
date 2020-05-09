using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace PeerReviewSample.Processes
{
    class ReviewerSelection:Database
    {
        private int authorId;
        private int rdocId;
        public ReviewerSelection(int rdocId, int authorId)
        {
            this.rdocId = rdocId;
            this.authorId = authorId;
        }
        public void CreateReview()
        {
            GetAllReviewersWithSpecialismWithoutOverload();
        }
        private void GetAllReviewersWithSpecialismWithoutOverload()
        {
            string specialism;
            int minGrade;
            DataTable dtAllSpecialismWithMinGradeForAnRDoc;
            DataTable dt = new DataTable();
            dtAllSpecialismWithMinGradeForAnRDoc = GetAllReviewRequestsForAnRDoc();

            foreach (DataRow dr in dtAllSpecialismWithMinGradeForAnRDoc.Rows)
            {
                specialism = dr.ItemArray[0].ToString();   
                minGrade = Convert.ToInt32(dr.ItemArray[1].ToString()); 
                dt = GetListOfReviewersWithSpecialism(specialism, minGrade);
                CreateReviewsForAnRDoc(dt);
            }
        
        }
        private void CreateReviewsForAnRDoc(DataTable dt)
        {
            Boolean isReviewerNotOverload;
            int reviewerId;
            string specialism;
            string sqlQuery;
           
            foreach (DataRow dr in dt.Rows)
            {
                reviewerId = Convert.ToInt32(dr.ItemArray[0].ToString());
                specialism = dr.ItemArray[1].ToString();
                Console.WriteLine("The specialism is " + specialism);
                isReviewerNotOverload = CheckReviewerNotOverload(reviewerId);

                if (isReviewerNotOverload)
                {
                    sqlQuery = "INSERT INTO Reviews (rdocId,specialism,reviewerId) VALUES" +
                        "("+rdocId+",'"+specialism+"',"+reviewerId+"); ";

                    Create(sqlQuery);
                }
            }
        }
        private DataTable GetAllReviewRequestsForAnRDoc()
        {
            DataTable dt;
            string sqlQuery = "select specialism, minGrade from specialismwithmingrade where rdocid = " + rdocId + ";";
            dt = Read(sqlQuery);
            Console.WriteLine("GetAllReviewRequestsForAnRDoc");
            
            return dt;
        }
        private Boolean CheckReviewerNotOverload(int reviewerId)
        {
            Boolean isReviewerNotOverload;
            int count;
            string sqlQuery = "select count(reviewId) from Reviews where reviewerId="+reviewerId+" AND status = 'awaiting';";
            count = GetInteger(sqlQuery);
            Console.WriteLine("Count of  Reviewer " + reviewerId + "is "+count);
            isReviewerNotOverload = (count < 4) ? true : false;
            return isReviewerNotOverload;
        }
        
        private DataTable GetListOfReviewersWithSpecialism(string sp, int minGrade)
        {
            string sqlQuery = "select reviewerId, specialism from reviewerspecialisms " +
                "where specialism ='"+sp+"' and average>= "+minGrade+ " and NOT reviewerId  = " +authorId+"; ";
            DataTable dt = Read(sqlQuery);
            Console.WriteLine("GetListOfReviewersWithSpecialism");
           
            return dt;
        }
    }
}
