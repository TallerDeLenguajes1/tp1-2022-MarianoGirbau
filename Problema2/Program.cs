Console.WriteLine("Ingrese un numero DIVIDENDO:");
string A = Console.ReadLine();
Console.WriteLine("Ingrese un numero DIVISOR:");
string B = Console.ReadLine();
try
{
    var a=Convert.ToDecimal(A);
    var b=Convert.ToDecimal(B);
    division(a,b);
}
catch (System.FormatException e)
{
    Console.WriteLine("Error de entrada: Ingreso un formato de numero no deseado \n"+ e.Message);
}
catch (System.OverflowException e)
{
    Console.WriteLine("Error de entrada: Ingreso un numero muy grande \n"+ e.Message);
}
catch (System.DivideByZeroException e)
{
    Console.WriteLine($"Error de entrada: Estas dividiendo en 0!! \n"+ e.Message);
}


void division (decimal A,decimal B){
    Console.WriteLine("La division es: " + Convert.ToString(A/B));
}