/*

    Vous devez utiliser l’instruction do-while ou while comme boucle de jeu externe.
    Le héros et le monstre commencent avec 10 points de vie.
    Toutes les attaques ont une valeur comprise entre 1 et 10.
    Le héros attaque en premier.
    Afficher le nombre de points que le monstre a perdus et ses points restants.
    Si les points de vie du monstre sont supérieurs à 0, celui-ci peut attaquer le héros.
    Afficher le nombre de points que le héros a perdus et ses points restants.
    Continuer cette séquence d’attaques jusqu’à ce que les points de vie du monstre ou du héros soient inférieurs ou égaux à zéro.
    Afficher le gagnant.

    sortie attendu 
    Monster was damaged and lost 1 health and now has 9 health.
    Hero was damaged and lost 1 health and now has 9 health.
    Monster was damaged and lost 7 health and now has 2 health.
    Hero was damaged and lost 6 health and now has 3 health.
    Monster was damaged and lost 9 health and now has -7 health.
    Hero wins!
*/
Random random = new Random();
int heros = 10;
int monsters = 10;
int strike = 0;
do
    {
    strike = random.Next(1,10);
    monsters = monsters - strike;
    Console.WriteLine($"Monstre a perdu {strike}pv et il lui reste {monsters}pv"); 
  if(monsters > 0)
  {
    strike = random.Next(1,10);
    heros = heros - strike;
    Console.WriteLine($"Heros a perdu {strike}pv et il lui reste {heros}pv");
  }else {
    Console.WriteLine("Heros Wins");
  }
}while(heros>0 && monsters>0);
if (heros <=0){
    Console.WriteLine("Monsters Wins");
}