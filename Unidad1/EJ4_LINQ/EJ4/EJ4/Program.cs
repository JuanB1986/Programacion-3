int []listaEnteros = [78, -9, 0, 23, 54, 21, 7, 86];

var listaOrdenada = listaEnteros.OrderDescending().SkipLast(listaEnteros.Length-5);

foreach (int i in listaOrdenada)
{
    Console.WriteLine(i);
}
