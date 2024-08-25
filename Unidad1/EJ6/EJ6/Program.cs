/*
 6) Pedir al usuario el precio de un producto (valor positivo) y la forma de pagar (efectivo o
tarjeta) si la forma de pago es mediante tarjeta, pedir el número de la misma(inventado),
verificar que sean 16 dígitos e informar el valor a pagar con un 10% de recargo.
*/

float price = 0.0f;
String cardNumber = "";

Console.WriteLine("ingresar precio: ");
price  = float.Parse(Console.ReadLine());
Console.WriteLine("forma de pago: 'tarjeta' / 'efectivo':");
String payment = Console.ReadLine();

if (payment == "tarjeta")
{
    Console.WriteLine("Ingresar numero de tarjeta: ");
    cardNumber = Console.ReadLine();
    if (cardNumber.Length != 16) { Console.WriteLine("Tarjeta Inválida"); return; }
    Console.Write(price+0.1*price);
}

if (payment == "efectivo")
{
    Console.WriteLine(price);
}
