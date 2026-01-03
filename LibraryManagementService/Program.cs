// Program.cs (Console app)
using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using LibraryManagementService.Interface;    // ILibrary

using LibraryManagementService.Models;
using LibraryManagementService.Models.Users;
using LibraryManagementService.Models.Books;  
using LibraryManagementService.Models.IssueRecord;     // Book, User

var services = new ServiceCollection();

services.AddSingleton<ILibrary>(sp =>
    new LibraryService(
         new List<Books>
        {
            new Books { BookID = 1, Title = "Clean Code", TotalCopies = 2, AvailableCopies = 2 },
            new Books { BookID = 2, Title = "The Pragmatic Programmer", TotalCopies = 1, AvailableCopies = 1 }
        },
        new List<User>
        {
            new User { Id = 1, Name = "Alice" },
            new User { Id = 2, Name = "Bob" }
        }
    )
);

// register application runner
services.AddTransient<AppRunner>();

var provider = services.BuildServiceProvider();

await provider.GetRequiredService<AppRunner>().RunAsync();
