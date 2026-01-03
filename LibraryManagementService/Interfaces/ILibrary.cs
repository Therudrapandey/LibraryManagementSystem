namespace LibraryManagementService.Interface;
using LibraryManagementService.Models.Books;

public interface ILibrary{

    bool Issuebook(int BookId, int UserId);
    bool ReturnBook(int BookId,int UserID);
     
    IEnumerable<Books> GetAvailableBooks();
    
}