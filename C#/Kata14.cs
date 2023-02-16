using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    struct Book
    {
        //Array of strings to fill
        public string[][] Page;
        //Standard for the number of items per line
        public int WordCount;
        //Total number of pages
        public int NumberOfPages;
    }

    class Program
    {
        static void Main(string[] args)
        {
            IList<int> collection = new List<int> {};
            PagnationHelper<int> helper;

            helper = new PagnationHelper<int>(collection, 10);

            Console.WriteLine(helper.PageIndex(0));
            Console.ReadKey();

        }
    }

    public class PagnationHelper<T>
    {
        // TODO: Complete this class

        private Book MyBook;
        

        /// <summary>
        /// Constructor, takes in a list of items and the number of items that fit within a single page
        /// </summary>
        /// <param name="collection">A list of items</param>
        /// <param name="itemsPerPage">The number of items that fit within a single page</param>
        public PagnationHelper(IList<T> collection, int itemsPerPage)
        {
            if (itemsPerPage < collection.Count)
                MyBook.NumberOfPages = (int)Math.Floor((double)(collection.Count / itemsPerPage)) + 1;
            else
            {
                MyBook.NumberOfPages = 0;
                MyBook.Page = new string[0][];
                return;
            }

            MyBook.Page = new string[MyBook.NumberOfPages][];
            MyBook.WordCount = itemsPerPage;

            for (int i = 0; i < MyBook.Page.Length; i++)
            {
                int check = Math.Min(itemsPerPage, collection.Count - itemsPerPage * i);

                MyBook.Page[i] = new string[check];

                for (int j = i * itemsPerPage, counter = 0; j < i * itemsPerPage + check; j++, counter++)
                    MyBook.Page[i][counter] = Convert.ToString(collection[j]);
            }
        }

        /// <summary>
        /// The number of items within the collection
        /// </summary>
        public int ItemCount
        {
            get
            {
                int output = 0;
                for (int i = 0; i < MyBook.NumberOfPages; i++)
                    output += MyBook.Page[i].Length;
                return output;
            }
        }

        /// <summary>
        /// The number of pages
        /// </summary>
        public int PageCount
        {
            get
            {
                return MyBook.NumberOfPages;
            }
        }

        /// <summary>
        /// Returns the number of items in the page at the given page index 
        /// </summary>
        /// <param name="pageIndex">The zero-based page index to get the number of items for</param>
        /// <returns>The number of items on the specified page or -1 for pageIndex values that are out of range</returns>
        public int PageItemCount(int pageIndex)
        {
            if ((pageIndex >= 0) && (pageIndex < MyBook.NumberOfPages))
                return MyBook.Page[pageIndex].Length;

            if (MyBook.Page == null)
                return 0;

            return -1;
        }

        /// <summary>
        /// Returns the page index of the page containing the item at the given item index.
        /// </summary>
        /// <param name="itemIndex">The zero-based index of the item to get the pageIndex for</param>
        /// <returns>The zero-based page index of the page containing the item at the given item index or -1 if the item index is out of range</returns>
        public int PageIndex(int itemIndex)
        {
            if (MyBook.NumberOfPages == 0)
                return 0;

            for (int i = 0; i < MyBook.Page.Length; i++)
                for (int j = 0; j < MyBook.Page[i].Length; j++)
                    if (i * MyBook.WordCount + j == itemIndex) return i;

            return -1;
        }
    }
}