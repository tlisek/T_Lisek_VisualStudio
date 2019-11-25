using System;
using System.Collections.Generic;

namespace Lab6 {
  public class Zadanie1_4 {
    public void Run() {

      ChristmasTree Choinka = new ChristmasTree("Moja Choinka", 10);
      ChristmasTreeA ChoinkaA = new ChristmasTreeA("Moja Choinka", 10);
      ChristmasTreeB ChoinkaB = new ChristmasTreeB("Moja Choinka", 10);


      Choinka.Add("Czerwony", "Kula");
      Choinka.Add("Niebieski", "Gwiazda");
      Choinka.Add("Niebieski", "Anioł");
      Choinka.Add("Srebrny", "Gwiazda");


      ChoinkaA.Add("Czerwony", "Kula");
      ChoinkaA.Add("Niebieski", "Gwiazda");
      ChoinkaA.Add("Niebieski", "Anioł");
      ChoinkaA.Add("Srebrny", "Gwiazda");


      ChoinkaB.Add("Czerwony", "Kula");
      ChoinkaB.Add("Niebieski", "Gwiazda");
      ChoinkaB.Add("Niebieski", "Anioł");
      ChoinkaB.Add("Srebrny", "Gwiazda");


      Console.WriteLine( Choinka[0] );
      Console.WriteLine( ((ChristmasTree)(ChoinkaA))[0] ); // Tu ma być metoda z ChoinkaA zamiast z Choinka
      Console.WriteLine( ((ChristmasTreeA)(ChoinkaB))[0] );
      Console.WriteLine( ChoinkaB[0] );


    }
  }


  public class Tree {
    string _name;
    int _age;

    public Tree(string name, int age) {
      _name = name;
      _age = age;
    }

    public string Name {
      get => _name;
      set => _name = value;
    }

    public int Age {
      get => _age;
      set => _age = value;
    }


  }

  public class Fir : Tree {

    public Fir(string name, int age) : base(name, age) {
      _baubbles = new List<Baubble>();
    }

    protected List<Baubble> _baubbles;

    public void Add(string color, string type) {
      Baubble b = new Baubble(color, type);
      _baubbles.Add(b);
    }

    public void Remove(int idx) {
      _baubbles.RemoveAt(idx);
    }

    protected class Baubble {
      string _color;
      string _type;

      public Baubble(string color, string type) {
        _color = color;
        _type = type;
      }

      public string Color {
        get => _color;
        set => _color = value;
      }

      public string Type {
        get => _type;
        set => _type = value;
      }
    }

  }

  public class ChristmasTree : Fir {
    public ChristmasTree(string name, int age) : base(name, age) { }

    public string this[int idx] {
      get {
        Baubble b = _baubbles[idx];
        return b.Color;
      }
      set {
        _baubbles[idx].Color = value;
      }
    }

    public int this[string color] {
      get {
        List<Baubble> foundBaubbles = _baubbles.FindAll(b => b.Color == color);
        return foundBaubbles.Count;
      }
    }

  }

  public class ChristmasTreeA : ChristmasTree {
    public ChristmasTreeA(string name, int age) : base(name, age) { }

    public string this[int idx] { // ToDo rzutowanie nie działa tak jak ma
      get {
        Baubble b = _baubbles[idx];
        return b.Type;
      }
      set {
        _baubbles[idx].Type = value;
      }
    }

    public string BaubleColor(int idx) {
      return base[idx];
    }

  }


  public class ChristmasTreeB : ChristmasTreeA {
    public ChristmasTreeB(string name, int age) : base(name, age) { }

    public string this[int idx] {
      get {
        Baubble b = _baubbles[idx];
        return b.Color + " - " + b.Type;
      }
    }

  }

  //public sealed class ChristmasTreeC : ChristmasTreeB {
  //  public ChristmasTreeC(string name, int age) : base(name, age) { }
  //}
}
