class Jugador{

    string nombre="";

    List<Cartas> mano = new List<Cartas>();
    public string Nombre { get => nombre; set => nombre = value; }
    internal List<Cartas> Mano { get => mano; set => mano = value; }

    public Cartas robarCarta( Mazo maz){
        Mano.Add(maz.eliminarcarta());
        int posicion = mano.Count-1;
        return mano[posicion];
    }

    public void descarte (int i){

        if(i> mano.Count-1 || i >mano.Count-1){
            Console.WriteLine("elige otro indice!");
        }else{
            mano.RemoveAt(i);
        }
        
        
    }
}