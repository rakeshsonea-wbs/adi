using System;
using System.Data;
using System.Windows.Forms;
using PeerReviewSample.Entities;
using PeerReviewSample.Processes;
namespace PeerReviewSample
{
    public partial class MakeReviewRequest : Form
    {
        Database db = new Database();
        DataTable dt = new DataTable("SelectedSpecialismWithMinGrade");
        ReviewRequest reviewRequest;
        ReviewerSelection reviewerSelection;
        public MakeReviewRequest()
        {
            InitializeComponent();
        }

        private void MakeReviewRequest_Load(object sender, EventArgs e)
        {
            string sqlQuery = "select specialism from specialisms;";
            DataTable dt = db.Read(sqlQuery);
            foreach (DataRow dr in dt.Rows)
            {
                chkListSpecialisms.Items.Add(dr.ItemArray[0].ToString());
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
          
            DataColumn col;
            DataRow row;
            col = new DataColumn();
            panelMinGrade.Visible = true;
            col.DataType = Type.GetType("System.String");
            col.ColumnName = "Specialism";
            dt.Columns.Add(col);
            col = new DataColumn();
            col.DataType = Type.GetType("System.Int32");
            col.ColumnName = "MinGrade";
            dt.Columns.Add(col);

            int noOfSpecialisms = chkListSpecialisms.CheckedItems.Count;
           
            int i = 0;
            foreach (var item in chkListSpecialisms.CheckedItems)
            {
                if (i < noOfSpecialisms)
                {
                    row = dt.NewRow();
                    row["Specialism"] = item.ToString();
                    row["MinGrade"] = 5;
                    dt.Rows.Add(row);
                }
                i++;
            }
            dGridViewMinGrade.DataSource = dt;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            RDoc rDoc = new RDoc();
            int rdocId;
            rDoc.Title = txtTitle.Text.Trim().ToLower();
            rDoc.Link = txtLink.Text.Trim().ToLower();
            rDoc.AuthorId = 17; //TODO Hardcode
            rDoc.SpecialismWithMinGrade = dt;
            reviewRequest = new ReviewRequest(rDoc);
            reviewRequest.MakeReviewRequest();
            rdocId = reviewRequest.GetLastRDocId();
            btnSubmit.Enabled = false;
            reviewerSelection = new ReviewerSelection(rdocId, rDoc.AuthorId);
            reviewerSelection.CreateReview();

        }
    }
}
