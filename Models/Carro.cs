namespace Inyeccion_de_dependencias_Prueba.Models;

public class Carro : IScoped,ISingleton,ITransient{
    

    private List<string> Carritos;

    public string  vehiculo ;

    public Carro(){
        Carritos = new List<string>();
        Carritos.Add("Gti");
        Carritos.Add("Rx8");
        Carritos.Add("Cayman");
        Carritos.Add("Carrera GT");
        Carritos.Add("Ford GT");
        Carritos.Add("Gallardo");
        Carritos.Add("Murcielago");
        Carritos.Add("Aventador");
        Carritos.Add("Reventon");
        Carritos.Add("Bugati");
        int posicion = new Random().Next(9);
        string carro = Carritos[posicion];
        vehiculo= carro;


    }

    public string getCarro(){
        return vehiculo;
    }
}