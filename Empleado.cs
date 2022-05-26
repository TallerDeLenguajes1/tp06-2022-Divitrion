public enum cargos
{
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador
}
public class Empleado 
{
    public readonly string Nombre;
    public readonly string Apellido;
    public readonly DateTime FechaNac;
    public char EstadoCivil;
    public char Genero;
    private DateTime fechaIngreso;
    private double sueldo;
    public cargos Cargo;

    public int antiguedad()
    {
        if (DateTime.Today.DayOfYear<fechaIngreso.DayOfYear)
        {
            return(DateTime.Today.Year - fechaIngreso.Year - 1);
        }else
        {
            return(DateTime.Today.Year - fechaIngreso.Year);
        }
    }
    public int edad()
    {
        if (DateTime.Today.DayOfYear<fechaIngreso.DayOfYear)
        {
            return(DateTime.Today.Year - FechaNac.Year - 1);
        }else
        {
            return(DateTime.Today.Year - FechaNac.Year);
        }
    }
    public int aptitudJubilacion(int antiguedad, int edad)
    {
        int aptitud=0;
        if (antiguedad>=20)
        {
            if ((Genero=='m' && edad>=65) || (Genero=='f' && edad>=60))
            {
                aptitud=0;
            }
        }else
        {
            aptitud=20-antiguedad;
        }
        return aptitud;
    }
}

