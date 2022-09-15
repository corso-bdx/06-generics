
// === GENERICS ===
// Esempio generics in C#.
// ================


TuplaInt tupla1 = new TuplaInt(1, 2);
TuplaInt tupla2 = new TuplaInt(3, 4);

TuplaString tupla3 = new TuplaString("hello", "world");
TuplaString tupla4 = new TuplaString("ciao", "mondo");

Tupla<int> tupla5 = new Tupla<int>(5, 6);
Tupla<string> tupla6 = new Tupla<string>("hola", "mundo");


class TuplaInt {
    public int Valore1 { get; }
    public int Valore2 { get; }

    public TuplaInt(int valore1, int valore2)
    {
        Valore1 = valore1;
        Valore2 = valore2;
    }
}

class TuplaString
{
    public string Valore1 { get; }
    public string Valore2 { get; }

    public TuplaString(string valore1, string valore2)
    {
        Valore1 = valore1;
        Valore2 = valore2;
    }
}

class Tupla<T>
{
    public T Valore1 { get; }
    public T Valore2 { get; }

    public Tupla(T valore1, T valore2)
    {
        Valore1 = valore1;
        Valore2 = valore2;
    }
}
