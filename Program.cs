// See https://aka.ms/new-console-template for more information

Mazo maz = new Mazo();
maz.listarCartas();
Console.WriteLine($"la cantidad de cartas en el mazo es de {maz.Cartas.Count}");

maz.mostrarBaraja();


Jugador jug = new Jugador();

for(int i = 0;  i < 3; i++ ){
Cartas carta = jug.robarCarta(maz);

Console.WriteLine($"el jugador a robado la carta {carta.Nom} con pinta {carta.Pint} y valor {carta.Valor}");
}




maz.mostrarBaraja();


jug.descarte(1);

foreach( Cartas carta in jug.Mano){
    Console.WriteLine($"la mano del jugador tiene {carta.Nom}-{carta.Pint}-{carta.Valor}");
}