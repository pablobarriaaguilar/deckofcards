using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

class Mazo{
    List <Cartas> cartas = new List<Cartas>();
    string [] nombre = {"As", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Reina", "Rey"};
    string [] pinta = {"Tréboles", "Picas", "Corazones", "Diamantes"};

    internal List<Cartas> Cartas { get => cartas; set => cartas = value; }

    public void listarCartas(){
       foreach(string pint in pinta){
        for(int i = 0; i < nombre.Length; i++ ){
            Cartas carta = new Cartas();
            carta.Pint = pint;
            carta.Nom = nombre[i];
            
            if(carta.Nom == "As"){
                carta.Valor = 1;
            }
            else if(carta.Nom == "J"){
                carta.Valor = 11;
            }
            else if (carta.Nom == "Reina"){
                carta.Valor = 12;
            }
            else if (carta.Nom =="Rey"){
                carta.Valor = 13;
            }else{
                carta.Valor = int.Parse(carta.Nom);
            }
            cartas.Add(carta);
        }
       }

    }

    public void mostrarBaraja(){
        foreach( Cartas carta in cartas){
            Console.WriteLine($"{carta.Nom}-{carta.Pint}");
        }
    }


    public void reiniciarBaraja(){
        cartas.Clear();
        listarCartas();
    }
    
    public Cartas eliminarcarta(){
        int posicion = cartas.Count-1;
        Cartas cartaeliminada = cartas[cartas.Count-1];
        cartas.RemoveAt(posicion);
        return cartaeliminada;
    }
}