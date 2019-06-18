using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Books
    {

        #region Properties
        public string Author { get; private set; }
        public string Title { get; private set; }
        public string Status { get; private set; }
        public int checkedOutTo { get; private set; }
        public int daysUntilLate { get; private set; }
        #endregion


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
