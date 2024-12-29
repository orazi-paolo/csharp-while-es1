// dichiaro la variabile num
int num;
// chiedo all'utente di inserire un numero
Console.WriteLine("Inserisci un numero N:");
// leggo il numero inserito dall'utente
int.TryParse(Console.ReadLine(), out num);
// dichiaro la variabile i e la variabile somma
int i = 0;
int somma = 0;
// finchè i è minore o uguale a num
while (i <= num)
{
    // sommo i alla variabile somma
    somma += i;
    // incremento i
    i++;
}
// stampo la somma
Console.WriteLine($"La somma dei primi {num} numeri naturali è: {somma}");