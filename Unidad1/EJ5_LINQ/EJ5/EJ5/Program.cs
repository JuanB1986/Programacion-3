int[] listaNumeros = [7, 2, 30];

var listaNueva = from lista in listaNumeros
                 where lista * lista > 20
                 select (lista,lista*lista);

foreach (var lista in listaNueva)
{
    Console.WriteLine(lista);
}

