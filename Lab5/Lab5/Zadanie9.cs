using System;
using System.Collections.Generic;

namespace Lab5 {

  class Book {
    private string _title;
    private string _author;
    private double _price;
    private string _isbn;
    private DateTime _date = DateTime.MinValue;

    public string Title {
      get => _title != null ? _title : "N/A";
      set => _title = value;
    }

    public string Author {
      get => _author != null ? _author : "N/A";
      set => _author = value;
    }

    public double Price {
      get => _price;
      set => _price = value;
    }

    public string ISBN {
      get => _isbn != null ? _isbn : "N/A";
    }

    public DateTime Date {
      get => _date;
      set => _date = value;
    }

    public Book(string isbn, string title = null, string author = null, double? price = null, DateTime? date = null) {
      _isbn = isbn;

      if (title != null)
        _title = title;


      if (author != null)
        _author = author;

      if (price.HasValue)
        _price = price.Value;

      if (date.HasValue)
        _date = date.Value;
    }

    public override string ToString() {
      return Title + " by " + Author + " from " + (Date == DateTime.MinValue ? "N/A" : Date.ToString("yyyy")) + " | Price: " + Price + " | ISBN:" + ISBN;
    }

  }

  class BookLibrary {
    private List<Book> _books;

    public BookLibrary() {
      _books = new List<Book>();
    }

    public bool BookInLibrary(Book b) {
      return _books.FindIndex(book => book.ISBN == b.ISBN) >= 0;
    }

    public void Add(Book b) {

      if (!this.BookInLibrary(b)) {
        _books.Add(b);
      }
      else {
        Console.WriteLine("Book with ISBN {0} already in the Library", b.ISBN);
      }

    }

    public void ListBooks() {
      foreach (Book b in _books) {
        Console.WriteLine(b);
      }
    }


    public Book FindByISBN(string isbn) {
      return _books.Find(book => book.ISBN == isbn);
    }

    public List<Book> findByTitle(string title) {
      return _books.FindAll(book => book.Title.Contains(title));
    }

    public List<Book> findByAuthor(string author) {
      return _books.FindAll(book => book.Author.Contains(author));
    }

    public List<Book> findByPrice(double minPrice = 0, double maxPrice = double.MaxValue) {
      return _books.FindAll(book => (book.Price >= minPrice && book.Price <= maxPrice) );
    }
  }

  public class Zadanie9 {
    public void Run() {

      BookLibrary Library = new BookLibrary();

      Book book1 = new Book("0000000000001", title: "Book 1", author: "Author 2", price: 10);
      Book book2 = new Book("0000000000002", title: "Book 2", author: "Author 1", date: Convert.ToDateTime("01-01-2015"), price: 20);
      Book book3 = new Book("0000000000003", title: "Novel 1", author: "Author 2", date: Convert.ToDateTime("01-01-2015"), price: 15);

      Library.Add(book1);
      Library.Add(book2);
      Library.Add(book3);

      Console.WriteLine("List all Books:");
      Library.ListBooks();

      Console.WriteLine();

      Console.WriteLine("Find by ISBN:");
      Console.WriteLine(Library.FindByISBN("0000000000001"));

      Console.WriteLine();

      Console.WriteLine("Find by Title:");
      List<Book> result1 = Library.findByTitle("Book");
      foreach (Book b in result1) Console.WriteLine(b);

      Console.WriteLine();

      Console.WriteLine("Find by Author:");
      List<Book> result2 = Library.findByAuthor("Author 2");
      foreach (Book b in result2) Console.WriteLine(b);

      Console.WriteLine();

      Console.WriteLine("Find by Price:");
      List<Book> result3 = Library.findByPrice(15, 30);
      foreach (Book b in result3) Console.WriteLine(b);

    }
  }
}
