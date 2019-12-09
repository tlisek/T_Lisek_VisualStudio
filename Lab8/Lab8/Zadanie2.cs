using System;
namespace Lab8 {

  public class Zadanie2 {

    public delegate void OnDigitHandler();
    public event OnDigitHandler OnDigit;
    void HandleOnDigitHandler() {
      Console.WriteLine("Nacisnieto cyfre!");
    }


    public delegate void OnCharacterHandler();
    public event OnCharacterHandler OnCharacter;
    void HandleOnCharacterHandler() {
      Console.WriteLine("Nacisnieto litere!");
    }


    public void Run() {

      OnDigit += new OnDigitHandler(HandleOnDigitHandler);
      OnCharacter += new OnCharacterHandler(HandleOnCharacterHandler);

      char input;

      do {

        input = Console.ReadKey().KeyChar;

        Console.WriteLine();

        if (Char.IsLetter(input)) OnCharacter();
        if (Char.IsDigit(input)) OnDigit();

      }
      while (Char.IsLetter(input) || Char.IsDigit(input)  );


    }
  }
}
