using System.ComponentModel;

int[] lista = [67, 92, 153, 15];


var resultado  = from listaResult in lista 
                 where listaResult > 30 && listaResult<100
                 select listaResult;




foreach (var i in resultado) { Console.WriteLine(i); }