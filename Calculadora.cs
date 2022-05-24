public class Calculadora
{
    public double resultado;
    public void suma(double termino)
    {
        resultado += termino;
    }

    public void resta(double termino)
    {
        resultado -= termino;
    }
    public void multiplicar(double termino)
    {
        resultado *= termino;
    }
    public void division(double termino)
    {
        resultado /= termino;
    }

    public void clear()
    {
        resultado=0;
    }

    public Calculadora(double valor)
    {
        resultado = valor;
    }

}