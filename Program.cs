﻿using System;

Console.WriteLine(Comparador.Comparar("a", "a"));
Console.WriteLine(Comparador.Comparar("a", "b"));
Console.WriteLine(Comparador.Comparar(1, 1));
Console.WriteLine(Comparador.Comparar(1, 2));
Console.WriteLine(Comparador.Comparar(1.1, 1.1));
Console.WriteLine(Comparador.Comparar(1.2, 2.3));
Console.WriteLine(Comparador.Comparar("1", 1));
Console.WriteLine(Comparador.Comparar("1", 2));
Console.WriteLine(Comparador.Comparar("1", 2.3));
Console.WriteLine(Comparador.Comparar(2, 2.3));
Console.WriteLine(Comparador.Comparar(2, 2.0));
Console.WriteLine(Comparador.Comparar(new List<int>(), new List<string>()));
Console.WriteLine(Comparador.Comparar(new List<int>(), new List<int>()));

var teste1 = new Teste()
{
  Prop1 = 1,
  Prop2 = 2,
};

var teste2 = new Teste()
{
  Prop1 = 1,
  Prop2 = 2,
};

Console.WriteLine(Comparador.Comparar(teste1, teste2));
Console.WriteLine(Comparador.Comparar(teste1, teste1));

static class Comparador
{
  public static bool Comparar(string param1, string param2) => param1.Equals(param2);
  public static bool Comparar(int param1, int param2) => param1.Equals(param2);
  public static bool Comparar(double param1, double param2) => param1.Equals(param2);
  public static bool Comparar(string param1, int param2) => param1.Equals(param2.ToString());
  public static bool Comparar(int param1, string param2) => param1.ToString().Equals(param2);
  public static bool Comparar(string param1, double param2) => param1.Equals(param2.ToString());
  public static bool Comparar(double param1, string param2) => param1.ToString().Equals(param2);
  public static bool Comparar(double param1, int param2) => param1.ToString().Equals(param2.ToString());
  public static bool Comparar(int param1, double param2) => param1.ToString().Equals(param2.ToString());
  public static bool Comparar<T, U>(T param1, U param2) where T : notnull
                                                        where U : notnull
  {
    return param1.Equals(param2);
  }
}

class Teste
{
  public int Prop1 { get; set; }
  public int Prop2 { get; set; }
}