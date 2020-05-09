using System;
using System.Data;


namespace PeerReviewSample.Utilities
{
    class DataTableDisplayer
    {
        public static void Display(DataTable dt)
        {
            foreach (DataRow dr in dt.Rows)
            {
                foreach (var item in dr.ItemArray)
                {
                    Console.Write(item);
                    Console.Write("-");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
