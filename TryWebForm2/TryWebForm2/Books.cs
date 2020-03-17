using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TryWebForm2
{
    public class Books
    {
        public int id { get; set; }
        public string Title { get; set; }
        public decimal price { get; set; }
        public DateTime DateOfRelease { get; set; }

        /*int startRowIndex, int maximum*/
        public static List<Books> GetPagedBooks(int startRowIndex, int maximum)
        {
            List<Books> List = new List<Books>();
            List.Add(new Books
            {
                id = 1,
            Title = "NEW AUTHOR",
            price = 100,
            DateOfRelease= Convert.ToDateTime("05/01/1996")
            });

            List.Add(new Books
            {
                id = 2,
                Title = "Try NEW",
                price = 200,
                DateOfRelease = Convert.ToDateTime("06/02/1996")
            });
            List.Add(new Books
            {
                id = 3,
                Title = "Shiva",
                price = 500,
                DateOfRelease = Convert.ToDateTime("07/08/2006")
            });
            List.Add(new Books
            {
                id = 4,
                Title = "akshay",
                price = 800,
                DateOfRelease = Convert.ToDateTime("01/08/2005")
            });

            //return List.ToList();

             return List.Skip(startRowIndex).Take(maximum).ToList();
        }
    }
}
