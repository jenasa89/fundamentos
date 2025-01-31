public class Jugador{

    public string Nombre {get; set; }
    public bool Banca { get; set; }
    public List<Carta> Mano {get; set; }

public Jugador(string nombre, bool banca = false){ 
    Nombre = nombre;
    Banca = banca;
    Mano = new List<Carta>();
}

public void RecibirCarta(Carta cartaRecibida){
    Mano.Add(cartaRecibida);
}

//Metodos necesarios de pedir carta si no supera 21 Y calculodepuntaje
public void CalcularPuntaje(){
//lOGICA DE PUNTAJE
}
//public bool SuperaTotal(){
//    return CalcularPuntaje() > 21;
//}


}