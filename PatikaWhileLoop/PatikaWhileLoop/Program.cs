// 1.Uygulama

using System.ComponentModel.Design;

int i = 0; 
while( i<10) // değişken değeri sıfır alındığı ve ekranda 10 kez cümle istendiği için koşul i<10 olarak verildi.
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini halledeceğim!");
    i++;
}

Console.WriteLine("\n");
//2.Uygulama

i = 1;
while( i<=20) // 1 ve 20 sayıları da dahil edilidi
{

    Console.WriteLine($"1 ve 20 arasındaki sayılar : {i}");
    i++;
}

Console.WriteLine("\n");
//3.Uygulama

i = 1;
while(i <= 20)
{
    if( i % 2 == 0)
    {
        Console.WriteLine(i);   
    }
    i++; 
}

Console.WriteLine("\n");
//4.Uygulama
i=50;
int toplam = 0;
while( i < 150)
{
    toplam +=i;
    i++; 
}

Console.WriteLine($"50 ve 150 arasındaki sayıların toplamı:{toplam}");

Console.WriteLine("\n");

//5.Uygulama
i = 1;
int ciftToplam=0;
int tekToplam=0;

while( i < 120)
{
    if ( i % 2 == 0)
    {
        i++;
        ciftToplam += i;

    }

    
    else if  (i %2 != 0)
    {
        i++;
        tekToplam += i;

    }

    
}
Console.WriteLine($"Çift sayıların toplamı: {ciftToplam}");
Console.WriteLine($"Çift sayıların toplam: {tekToplam}");
