using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class static LibraryOps
    {
        
        public static readonly List<CardUser> cardHoldersList = new List<CardUser>();
        public static readonly List<string> booksList = new List<string>();


        public static CardUser createAccount(string fullName, string emailAddress)
        {
            var cardUser = new CardUser
            {
                Name = fullName,
                EmailAddress = emailAddress,

            };
            cardHoldersList.Add(cardUser);
            return cardUser;
        }

        public static Books createBook(string title, string author)
        {
            var book = new Books {
                Title = title,
                Author = author,
            };
            string bookPresentation = title + " by " + author;
            booksList.Add(bookPresentation);
            return book;
        }

        //#region Methods
        //public List<String> inStock()
        //{
            
        //}
        //public List<String> outStock()
        //{

        //}
        //public List<String> allBooks()
        //{

        //}
        //public List<String> cardHolders()
        //{

        //}
       
        //#endregion
        
    }

}
