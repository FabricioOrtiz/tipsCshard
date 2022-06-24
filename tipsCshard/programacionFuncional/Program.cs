Func<decimal, decimal> iva = (decimal amount) => amount + (amount * 0.16m);
var discount = (decimal amount) => amount - (amount * 0.1m);
var surcharge = (decimal amount) => amount + (amount * 0.2m);

Console.WriteLine(discount(iva(surcharge(100))));
//hay una manera de mejorar esta forma de usar multiples metodos , el cual se llama pipe y funciones encadenadas

//aqui se llama al metodo static que esta definido en methods
Console.WriteLine(iva(100).StructPipe());

string test = "";
test.StructPipe();

public static class Methods
{
    public static decimal NormalPipe(this decimal v)
    {
        return v;
    }

    public static Tin StructPipe<Tin>(this Tin v) where Tin : struct
    {
        return v;
    }
}

