String []listaPalabras = ["ventilador", "reloj", "buscador"];

var listaResultado = from lista in listaPalabras
                     where lista.StartsWith('b') && lista.EndsWith('r')
                     select lista;

foreach(String item in listaResultado)
{
    Console.WriteLine(item);
}