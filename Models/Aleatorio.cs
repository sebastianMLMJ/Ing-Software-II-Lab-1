namespace Inyeccion_de_dependencias_Prueba.Models;

public interface ITransient {

}

public interface IScoped {

}

public interface ISingleton{
        
}

public class Aleatorio {   


    public readonly ITransient carrotransient;
    public readonly IScoped carroscoped;
    public readonly ISingleton carrosingleton;
    public readonly ITransient carrotransient2;
    public readonly IScoped carroscoped2;
    public readonly ISingleton carrosingleton2;

    public Aleatorio( ITransient _carrotransient, IScoped _carroscoped, ISingleton 
    _carrosingleton,ITransient _carrotransient2, IScoped _carroscoped2, ISingleton 
    _carrosingleton2){
        carrotransient = _carrotransient;
        carrosingleton = _carrosingleton;
        carroscoped = _carroscoped;
         carrotransient2 = _carrotransient2;
        carrosingleton2 = _carrosingleton2;
        carroscoped2 = _carroscoped2;

    }
}