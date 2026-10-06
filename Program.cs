
// prima nyeremenyjatek
Console.WriteLine("Add meg a csoki gyartasi sorszamat:");
int csokiszam= int.Parse(Console.ReadLine());
bool ertek = false;
while (csokiszam <= 1)
{
    Console.WriteLine("Sajnos nem nyert!");
}
for (int i = 2; i<csokiszam; i++)
{
    if (csokiszam%i==0)
    {
        ertek=true;
        break;
    }
    
}
if (ertek == true)
{
    Console.WriteLine("Sajnos nem nyert!");
}
else
{
    
    Console.WriteLine("Gratulalok, nyertel!");
}