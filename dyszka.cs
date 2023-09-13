int nwd(int a,int b)
{
    while(a != b)
    {
        if (a > b) a -= b;
        else b -= a;
    }
    return b;
}
int nww(int a, int b)
{
    int x = a;
    int y = b;
    while(x != y) 
    {
        if (x > y) y += b;
        else x += a;
    }
    return y;
}
int[] dodajulamki(int l1, int m1, int l2, int m2)
{
    int mian = nww(m1, m2);
    int licz = (l1 * (mian / m1)) + (l2 * (mian / m2));
    int[] T = new int[2] { licz, mian };
    return T;
}

// zad 1

// zad 2
//int[] niewlasciwe = dodajulamki(int.Parse(Console.ReadLine()),
//    int.Parse(Console.ReadLine()),
//    int.Parse(Console.ReadLine()),
//    int.Parse(Console.ReadLine()));
//if (niewlasciwe[0] > niewlasciwe[1])
//{
//    //niewlasciwe
//}
//else
//{
//    //wlasciwe
//}

// zad 3

//int l1 = int.Parse(Console.ReadLine());
//int l2 = int.Parse(Console.ReadLine());
//int m1 = int.Parse(Console.ReadLine());
//int m2 = int.Parse(Console.ReadLine());
//// normalne
//int mian = nww(m1, m2);
//int licz = (l1 * (mian / m1)) + (l2 * (mian / m2));

//// odwrotne
//int mina = nww(l1, l2);
//int z = m1 * (mina / l1);
//int c = m2 * (mina / l2);
//int licz2 = z + c;
//// sprawdzam

//int mianownik = nww(mian, mina);
//int k1 = licz * (mianownik / licz);
//int k2 = licz2 * (mianownik / licz2);
//if (k1 > k2) Console.WriteLine("normalne wieksze");
//else if (k1 < k2) Console.WriteLine("odwrotne wieksze");
//else Console.WriteLine("takie same");

// n = 13/6
// o = 13/5

//8.Brajanek z Dżesiką grają w siedem. Gra polega na tym, że jeden z graczy podaje granice przedziału <a, b> 
//a drugi z nich musi szybko odpowiedzieć, ile w tym przedziale jest liczb,
//które są podzielne przez siedem, albo suma ich cyfr jest podzielna przez siedem (lub jedno i drugie). 
//Napisz program, który pomaga w takich obliczeniach.

int p = int.Parse(Console.ReadLine());
int k = int.Parse(Console.ReadLine());
int ile = 0;
int suma = 0;
for(int i = p; i <= k; i++)
{
    suma += i;
    if (i % 7 == 0)
    {
        ile++;
    }
}
Console.WriteLine("liczb które dzielą się przez 7 jest " + Convert.ToString(ile));
if (suma % 7 == 0)
{
    Console.WriteLine("suma liczb dzieli sie przez 7");
}
