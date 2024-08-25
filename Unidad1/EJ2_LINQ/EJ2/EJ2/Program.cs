String[] listaPalabras = ["Rosario","Central","Juan","Manuel"];

var listaResultado = from lista in listaPalabras
                     where lista.Length > 5
                     select lista.ToUpper();

foreach(var item in listaResultado){
    Console.WriteLine(item);
}

