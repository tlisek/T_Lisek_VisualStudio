using System;
using System.ComponentModel;

namespace Lab8 {
  public class Zadanie3 {
    public void Run() {

      Point p = new Point();

    }
  }

  public class Point : IDisposable {

    int _x;
    int _y;

    public int X {
      set {
        _x = value;
      }
      get {
        return _x;
      }
    }

    public int Y {
      set {
        _y = value;
      }
      get {
        return _y;
      }
    }

    public Point(int x = 0, int y = 0) {
      _x = x;
      _y = y;
    }




    protected bool disposed = false;
    private IntPtr handle;
    private Component components;

    public void Dispose() {
      Dispose(true);
      GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing) {
      if (!disposed) {
        if (disposing) {
          components.Dispose();
        }
        Console.WriteLine("Disposing");
        CloseHandle(handle);
        handle = IntPtr.Zero;
      }
      disposed = true;
    }

    ~Point() {
      Dispose(false);
    }


    [System.Runtime.InteropServices.DllImport("Kernel32")]
    private extern static Boolean CloseHandle(IntPtr handle);

  }

}
