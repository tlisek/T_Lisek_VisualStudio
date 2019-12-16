using System;

namespace Lab9 {
  class MainClass {
    public static void Main(string[] args) {

      Random random = new Random();

      char[] characters = { '*', '*', '*', '.', '-', 'o' };

      int width = 19;
      int height = width;

      for (int i = 0; i < height; i++) {

        for (int j = 0; j < width; j++) {

          int char_ind = random.Next(0, characters.Length);

          if (j >= width / 2 - i / 2 && j <= i / 2 + width / 2) {
            Console.Write(characters[char_ind]);
          }
          else {
            Console.Write(' ');
          }

        }

        Console.Write('\n');

      }

      for (int i = 0; i < width/8; i++) {
        for (int j = 0; j < width; j++) {

          if( j>= width*3/8 && j <= width * 5 / 8) {
            Console.Write('#');
          }
          else {
            Console.Write(' ');
          }

        }
        Console.Write('\n');
      }


    }
  }
}
