    Console.WriteLine("Ingrese un numero ENTERO:");
    string N = Console.ReadLine();
try
{
    int Nint=Convert.ToInt32(N);
    Console.WriteLine("EL cuadrado del numero es: " + Convert.ToString(Nint*Nint));

}
catch (System.FormatException e)
{
    Console.WriteLine($"Error de entrada: Ingreso un formato de numero no deseado '{N}'\n"+ e.Message);
}
catch (System.OverflowException e)
{
    Console.WriteLine($"Error de entrada: Ingreso un numero muy grande '{N}'\n"+ e.Message);
}
catch (System.Exception e)
{
    Console.WriteLine($"Error: \n"+ e.Message);
}