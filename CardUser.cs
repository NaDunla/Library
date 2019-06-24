using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CardUser
    {
        private static int startAccountNumber = 0;
        private static List<string> booksChecked = new List<string>();


        #region Properties
        public int AccountNumber { get; private set; }
        public List<string> BooksCheckedOut { get; private set; }
        public string EmailAddress { get; set; }
        public DateTime DateCreated { get; private set; }
        public string Name { get; set; }
        #endregion

        public CardUser()
        {
            AccountNumber = ++startAccountNumber;
            BooksCheckedOut = booksChecked;
            DateCreated = DateTime.Now;
        }

        #region Methods
        /// <summary>
        /// assign book of user's choice to their account
        /// </summary>
        public void checkOutBook(string title, string author)
        {

        }
        /// <summary>
        /// assign the book of user's choice back in 
        /// </summary>
        public void checkInBook(string title, string author)
        {

        }
        #endregion








    }
}
