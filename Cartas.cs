using System.Reflection.Metadata.Ecma335;

class Cartas{
    string [] nombre = {"As", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Reina", "Rey"};
    string [] pinta = {"Tréboles", "Picas", "Corazones", "Diamantes"};
    
    int valor;

    string nom = "";

    string pint = "";

    public string Nom { get => nom; set => nom = value; }
    public string Pint { get => pint; set => pint = value; }
    public int Valor { get => valor; set => valor = value; }

    public void Print (){
       Console.WriteLine($"La carta es un {Nom}, de pinta {Pint} y de valor {Valor} ");

    }

    
}