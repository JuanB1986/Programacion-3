static IList<string> DevolverPalabrasCapitales(string cadena)
{
    IList<string> listaSeparada = new List<string>();

    listaSeparada = cadena.Split(" ").ToList();
    
    IList<String> listaNueva = new List<String>();

    var listaFiltrada = from lis in listaSeparada
              where lis.All(char.IsUpper)
              select lis;

    return listaFiltrada.ToList();
}


String cadena = "ESTO es un EJEMPLO del EJERcicio";

IList<string> listaDevuelta = new List<string>();

listaDevuelta = DevolverPalabrasCapitales(cadena);

foreach (String item in listaDevuelta)
{
    Console.Write(item+"\n");
}