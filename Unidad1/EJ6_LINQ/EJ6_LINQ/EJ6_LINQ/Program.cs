String[] listaPalabras = ["estudiar", "caminar", "dia"];


var listaNueva = from lista in listaPalabras
                 select lista.Replace("ia", "*");


foreach (String item in listaNueva)
{
    Console.WriteLine(item);
}