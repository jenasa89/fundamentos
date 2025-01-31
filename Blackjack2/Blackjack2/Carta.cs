public class Carta{

    public string Palo { get; set;}
    public string Valor { get; set;}
    public int Puntacion { get; set;}

public Carta(string palo, string valor, int puntuacion){

    Palo = palo;
    Valor = valor;
    Puntacion = puntuacion;
}

    public override string ToString()
    {
        return $"{Valor} de {Palo}";
    }

}