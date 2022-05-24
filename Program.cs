double valor1, valor2;
int operacion,endCheck;
bool end=true;

Console.WriteLine("Ingrese 2 numeros\n");
Console.WriteLine("Valor 1: ");
valor1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("\nValor 2: ");
valor2=Convert.ToDouble(Console.ReadLine());
Calculadora calc = new Calculadora(valor1);

do
{
    Console.WriteLine("Que operacion quiere hacer Limpiar[0],Suma[1],Resta[2],Multiplicacion[3],Division[4]");
    operacion = Convert.ToInt32(Console.ReadLine());
    switch (operacion)
    {
        case 1:
            calc.suma(valor2);
        break;
        case 2:
            calc.resta(valor2);
        break;
        case 3:
            calc.multiplicar(valor2);
        break;
        case 4:
            calc.division(valor2);
        break;
        default:
            calc.clear();
        break;
    }
    Console.WriteLine($"El resultado actual es: {calc.resultado}");
    Console.WriteLine("Quiere seguir operando sobre ese resultado? Si[1], No[0]");
    endCheck = Convert.ToInt32(Console.ReadLine());

    if (endCheck == 0)
    {
        end = false;
    }else
    {
        Console.WriteLine("\nIngrese el valor para operar: ");
        valor2=Convert.ToDouble(Console.ReadLine());
    }
}
while(end);