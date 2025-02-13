using System.Security.AccessControl;
using Esercizio_U4_S1_L4.Models;

Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine("=======================================================");
Console.BackgroundColor = ConsoleColor.Blue;
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("BENVENUTO!");
Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine("=======================================================");
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("");
Console.BackgroundColor = ConsoleColor.Blue;
Console.ForegroundColor = ConsoleColor.White;
actions:
Console.WriteLine("Scegli l'operazione da effettuare:");
Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine("1. Login");
Console.WriteLine("2. Logout");
Console.WriteLine("3. Verifica ora e data di login");
Console.WriteLine("4. Lista degli accessi");
Console.WriteLine("5. Esci");
Console.WriteLine("");
Console.BackgroundColor = ConsoleColor.Blue;
Console.ForegroundColor = ConsoleColor.White;
Console.Write("Operazione: ");
var action = Console.ReadLine();

if (action == "1") {
username:
    Console.BackgroundColor = ConsoleColor.Blue;
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("Inserisci username: ");
    var username = Console.ReadLine();
    if (username != null && username != "" && username != " ") {
    password:
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Inserisci password: ");
        var password = Console.ReadLine();
        if (password != null && password != "" && password != " ") {
        confirmPassword:
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Conferma password: ");
            var confirmPassword = Console.ReadLine();
            if (confirmPassword != null && confirmPassword != "" && confirmPassword != " " && password == confirmPassword) {
                Utente.Login(username, password, confirmPassword);
                goto actions;
            } else {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Password non confermata!");
                goto confirmPassword;
            }
        } else {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Password non valida!");
            goto password;
        }
    } else {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Username non valido!");
        goto username;
    }
} else if (action == "2") {
    if (Utente.IsLogged) {
        Utente.IsLogged = false;
    } else {
        Console.WriteLine("Non sei loggato!");
        goto actions;
    }
    goto actions;
} else if (action == "3") {
    Console.WriteLine(Utente.Dates[Utente.Dates.Count - 1]);
} else if (action == "4") {
    foreach (var date in Utente.Dates) {
        Console.WriteLine(date);
    }
    goto actions;
} else if (action == "5") {
    Environment.Exit(0);
} else {
    Console.BackgroundColor = ConsoleColor.Red;
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Operazione non valida!");
    goto actions;
}