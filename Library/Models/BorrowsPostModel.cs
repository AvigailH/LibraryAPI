using Library.Entities;

namespace Solid.Api.Models
{
    public class BorrowsPostModel
    {
            public int MemberId { get; set; }
            public int Id { get; set; }
            public bool Status { get; set; }
            public DateTime Date { get; set; }
            public List<Book> Books { get; set; }
    }
}
