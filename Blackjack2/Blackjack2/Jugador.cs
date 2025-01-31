public class Jugador{

    public string Nombre {get; set; }
    public bool Banca { get; set; }

public Jugador(string nombre, bool banca = false){
    Nombre = nombre;
    Banca = banca;
}

}