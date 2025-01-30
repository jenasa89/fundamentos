// Juego de blackjack 
// Su funcionamiento: ir pidiendo caras hasta que se llega lo mas cerca de 21 pero sin pasarse
   // pasos : 1º Generar una baraja de cartas, donde estan los numeros del 1-10 y figuras J,Q,K y los palos corazones, treboles, picas y diamantes
   // Una vez gerenada , el jugador empezara a pedir cartas teniendo en cuenta las siguientes consideraciones:
       // Cada una Bene un valor determinado: 1-10
       // Cada vez que se entrega una carta se hace un sumatorio y se le pide al usuario si quiere seguir jugando. En el caso de plantarse, pasa a jugar la banca de forma automatica. 
       // la banca debera plantarse cuando tenga una puntuacion de 17 o superior Ganara el jugador o banca que se acerque mas a 21

//Bienvenida a Blackjack
public class juego (){
    public static void Main(String [] args){
        Console.WriteLine(" 🎲 Bienvenido a Blackjack  🎲 ");
    }
}