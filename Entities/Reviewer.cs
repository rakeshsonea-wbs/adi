

namespace PeerReviewSample.Entities
{
    class Reviewer:User
    {
        private string[] specialisms;
        private double[] averages;
        public string [] Specialisms { get; set; }
        public double [] Averages { get; set; }
        
    }
}

