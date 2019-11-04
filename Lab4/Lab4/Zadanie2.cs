using System;
namespace Lab4 {

  class TestPointer {
    public unsafe void RunTestPointer() {
      int[] list = { 10, 100, 200 };
      fixed (int* ptr = list)
        for (int i = 0; i < 3; i++) {
          Console.WriteLine("Adres [{0}]={1}", i, (int)(ptr + i));
          Console.WriteLine("Wartość[{0}]={1}", i, *(ptr + i));
        }
      //Console.ReadKey();
    }
  }


  unsafe struct fixedIntBuffer {
    public fixed int _buffer[1024]; // This is a fixed buffer.
  }

  public class Zadanie2 {

    public unsafe void swap(int* p, int* q) {
      int temp = *p;
      *p = *q;
      *q = temp;
    }

    public void Run() {

      TestPointer t = new TestPointer();
      t.RunTestPointer();
      //Wskaźniki i bufory o ustalonym rozmiarze mogą zostać użyte tylko w kontekście słowa kluczowego „unsafe”



      int x = 10;
      int y = 100;

      Console.WriteLine("x={0}; y={0}", x, y);

      unsafe {
        swap(&x, &y);
      }

      Console.WriteLine("x={0}; y={0}", x, y);


      fixedIntBuffer b = new fixedIntBuffer();

      for (int i = 0; i < 1024; i++) {
        unsafe {
          *(b._buffer + i) = 1024 - i;
        }
      }


      for (int i = 0; i < 1024; i++) {
        unsafe {
          Console.WriteLine(*(b._buffer + i));
        }
      }

    }
  }
}
