{
    int suma = 0, a, iloscLiczb = 0;
    do
    {
        Console.WriteLine("Podaj dodatni wykladnik:");
        a = int.Parse(Console.ReadLine());
        suma += a;
        iloscLiczb++;
        Console.Clear();
    } while (a != 0);
    Console.WriteLine("Podałeś {0} liczb, Suma wpisanych liczb = {1}",
        iloscLiczb,
        suma);
    Console.ReadLine();
}