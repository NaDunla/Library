using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Books
    {
        public string checkedOut = "Checked Out";
        public string inStock = "In Stock";
        public string noUser = "N/A";


        #region Properties
        public string Author { get; set; }
        public string Title { get; set; }
        public string Status { get; set; }
        public string checkedOutTo { get; set; }
        public int daysUntilLate { get; set; }
        public DateTime dayCheckedOut { get; set; }
        #endregion

        public Books()
        {
            Status = inStock;
            checkedOutTo = noUser;
            daysUntilLate = 0;
        }


        #region Methods
        public void beCheckOut()
        {

        }
        public void beCheckedIn()
        {

        }
        #endregion



    }
}
