using System;
using PeerReviewSample.Processes;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeerReviewSample
{
    public partial class ReviewTasks : Form
    {
        private int reviewerId;
        ReviewTaskExtractor reviewTaskExtractor; 
        public ReviewTasks(int reviewerId)
        {
            InitializeComponent();
            this.reviewerId = reviewerId;
            reviewTaskExtractor = new ReviewTaskExtractor(reviewerId);
        }

        private void ReviewTasks_Load(object sender, EventArgs e)
        {

            DataTable dtAllStatus = reviewTaskExtractor.GetReviewsAllStatus();
            dGridAllStatus.DataSource = dtAllStatus;

            DataTable dtAwaiting = reviewTaskExtractor.GetReviewsAwaiting();
            dGridAwaiting.DataSource = dtAwaiting;
        }

        private void btnAwaiting_Click(object sender, EventArgs e)
        {  
            DataTable dtAwaiting = reviewTaskExtractor.GetReviewsAwaiting();
            dGridAwaiting.DataSource = dtAwaiting;
            SetInvisibleAllPanels();
            panelAwaiting.Visible = true;
        }
        private void btnAll_Click(object sender, EventArgs e)
        {
            DataTable dtAllStatus = reviewTaskExtractor.GetReviewsAllStatus();
            dGridAllStatus.DataSource = dtAllStatus;
            SetInvisibleAllPanels();
            panelAllStatus.Visible = true;
        }


        private void SetInvisibleAllPanels()
        {
            panelAllStatus.Visible = false;
            panelAwaiting.Visible = false;
        }

        private void dGridAwaiting_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            new Comments().Show();
        }
    }
}
