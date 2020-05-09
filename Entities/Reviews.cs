using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeerReviewSample.Entities
{
    class Reviews
    {
      

        public int RdocId { get; set; }
        public string Specialism { get; set; }
        public int ReviewerId { get; set; }
        public double ReviewAverage { get; set; }
        public string Status { get; set; }
    }
}
