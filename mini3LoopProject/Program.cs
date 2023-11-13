/*
Votre solution doit inclure une itération do-while ou while.
Avant le bloc d’itération : votre solution doit utiliser une instruction Console.WriteLine() pour demander à l’utilisateur d’entrer une valeur entière comprise entre 5 et 10.
À l’intérieur du bloc d’itération :

    Votre solution doit utiliser une instruction Console.ReadLine() pour obtenir l’entrée de l’utilisateur.
    Votre solution doit vérifier que l’entrée est une représentation valide d’un entier.
    Si la valeur entière n’est pas comprise entre 5 et 10, votre code doit utiliser une instruction Console.WriteLine() pour inviter l’utilisateur à entrer une valeur entière comprise entre 5 et 10.
    Votre solution doit vérifier que la valeur entière est comprise entre 5 et 10 avant de quitter l’itération.

Sous (après) le bloc de code d’itération : votre solution doit utiliser une instruction Console.WriteLine() pour informer l’utilisateur que sa valeur d’entrée a été acceptée
*/
Console.WriteLine("Saisir une valeur entre 5 et 10");
bool validNumber = false; 
bool validInput = false;
string? readResult;//chaîne de type Nullable
int numericValue=0;
do {
    readResult = Console.ReadLine();
    if(readResult != null)
    {
        validNumber = int.TryParse(readResult, out numericValue);
    }
    if(validNumber)
    {
        Console.WriteLine("c'est bon c'est un nombre12");
        if((numericValue >=5) && (numericValue <= 10))
        {
            Console.WriteLine("Merci pour votre saisie correct");
            validInput = true;        
        }
        else{
            Console.WriteLine("Veuillez tapez un nombre entre 5 et 10 SVP");
        }   
    }
    else
    {
        Console.WriteLine("Merci de saisir un nombre entre 5 et 10");
    }
}while(validInput == false);
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/*
    Votre solution doit inclure une itération do-while ou while.
    Avant le bloc d’itération : votre solution doit utiliser une instruction Console.WriteLine() pour demander à l’utilisateur d’entrer l’un des trois noms de rôle suivants : Administrator, Manager ou User.
    À l’intérieur du bloc d’itération :
        Votre solution doit utiliser une instruction Console.ReadLine() pour obtenir l’entrée de l’utilisateur.
        Votre solution doit vérifier que la valeur entrée correspond à l’une des trois options de rôle.
        Votre solution doit utiliser la méthode Trim() sur la valeur d’entrée pour ignorer les espaces de début et de fin.
        Votre solution doit utiliser la méthode ToLower() sur la valeur d’entrée pour ignorer la casse.
        Si la valeur entrée ne correspond pas à l’une des options de rôle, votre code doit utiliser une instruction Console.WriteLine() pour inviter l’utilisateur à fournir une entrée valide.
    Sous (après) le bloc de code d’itération : votre solution doit utiliser une instruction Console.WriteLine() pour informer l’utilisateur que sa valeur d’entrée a été acceptée.
*/
Console.WriteLine("Saisir votre rôle Admnistrateur | Manager | User");
bool inputUser = false;
string? readInput;
do 
{
    readInput = Console.ReadLine();
    readInput = readInput.Trim().ToLower();
    switch (readInput)
    {
        case  "administrateur" :
        Console.WriteLine($"Votre saisie {readInput} est valide");
        inputUser = true;
        break;
        case  "manager" :
        Console.WriteLine($"Votre saisie {readInput} est valide");
        inputUser = true;
        break;
        case  "user" :
        Console.WriteLine($"Votre saisie {readInput} est valide");
        inputUser = true;
        break;
        default:
        Console.WriteLine($"votre saisie {readInput} est invalide \n Saisir votre rôle Admnistrateur | Manager | User SVP");
        break;
    }       
}while(inputUser == false);
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/*
Votre solution doit déclarer une variable entière nommée periodLocation qui peut être utilisée pour contenir l’emplacement du caractère point dans une chaîne.
Votre solution doit inclure une boucle foreach ou for externe qui peut être utilisée pour traiter chaque élément de chaîne dans le tableau. La variable de chaîne que vous allez traiter dans les boucles doit être nommée myString.
Dans la boucle externe, votre solution doit utiliser la méthode IndexOf() de la classe String pour obtenir l’emplacement du premier caractère point dans la variable myString. L’appel de méthode doit ressembler à ceci : myString.IndexOf("."). S’il n’existe aucun point dans la chaîne, la valeur -1 est retournée.
Votre solution doit inclure une boucle do-while ou while interne qui peut être utilisée pour traiter la variable myString
Dans la boucle interne, votre solution doit extraire et afficher (écrire dans la console) chaque phrase contenue dans chacune des chaînes traitées.
Dans la boucle interne, votre solution ne doit pas afficher le caractère point.
Dans la boucle interne, votre solution doit utiliser les méthodes Remove(), Substring() et TrimStart() pour traiter les informations de chaîne.
sortie attendu
I like pizza
I like roast chicken
I like salad
I like all three of the menu choices
*/
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
