using System;
using System.Threading.Tasks;
using LibraryManagementService.Interface;

public class AppRunner
{
    private readonly ILibrary _library;

    public AppRunner(ILibrary library)
    {
        _library = library;
    }

    public Task RunAsync()
    {

        PrintAvailable();
        // All business flow / demos here — keeps Program.cs tiny
        Console.WriteLine("Issuing book to user 1...");
        var issued = _library.Issuebook(1, 1);    // ensure this matches your ILibrary method name
        Console.WriteLine($"Issued: {issued}");

        PrintAvailable();

        Console.WriteLine("Returning book...");
        var returned = _library.ReturnBook(1, 1);
        Console.WriteLine($"Returned: {returned}");

        PrintAvailable();

        return Task.CompletedTask;
    }

    private void PrintAvailable()
    {
        foreach (var b in _library.GetAvailableBooks())
        {
            Console.WriteLine($"BookID: {b.BookID}, Title: {b.Title}, Available: {b.AvailableCopies}");
        }
    }
}
