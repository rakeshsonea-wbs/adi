using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeerReviewSample.Entities
{
    class Author:User
    {
        private RDoc rdoc;
        public RDoc Rdoc { get; set; }
    }
}
