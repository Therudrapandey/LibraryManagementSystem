using LibraryManagementService.Interface;
using LibraryManagementService.Models.Books;

using LibraryManagementService.Models.Users;
using LibraryManagementService.Models.IssueRecord;


public class LibraryService: ILibrary{

    private readonly List<Books> _books;
    private readonly List<User> _users;
    private readonly List<IssueRecord> _records;

    public LibraryService(List<Books> books, List<User> users)
    {
        _books = books;
        _users = users;
        _records = new List<IssueRecord>();
    }

      public bool Issuebook(int bookId, int UserId){

         var user = _users.FirstOrDefault(u => u.Id == UserId);
         if (user==null) return false;

         Books book = _books.FirstOrDefault(b=>b.BookID == bookId);
         if(book==null || book.AvailableCopies<=0){
            return false;
         }

        IssueRecord Issue= _records.FirstOrDefault(b=>b.Id==bookId);
        if(Issue==null){
            _records.Add(new IssueRecord
            {
                Id = bookId,
                BookName = book.Title,
                UserId = UserId,
                IssueDate = DateTime.Now,
                ReturnDate = null
            });
        }else{
            Issue.UserId = UserId;
            Issue.IssueDate = DateTime.Now;
            Issue.ReturnDate=null;
        }
        book.AvailableCopies--;
        return true;

      }


    public bool ReturnBook(int BookID, int UserId)
    {
         var user = _users.FirstOrDefault(u => u.Id == UserId);
         if (user==null) return false;

         Books book = _books.FirstOrDefault(b=>b.BookID == BookID);
         if(book==null || book.AvailableCopies<=0){
            return false;
         }

        IssueRecord Issue= _records.FirstOrDefault(b=>b.Id==BookID);
        if(Issue==null){
            Issue.UserId = UserId;
            Issue.ReturnDate=DateTime.Now;
        }
        book.AvailableCopies++;
        return true;
    }

    public IEnumerable<Books> GetAvailableBooks(){

         return _books.Where(b => b.AvailableCopies > 0);
    }
}