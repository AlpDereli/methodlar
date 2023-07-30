// See https://aka.ms/new-console-template for more information
int a = 2;
int b = 3;
Console.WriteLine(a+b);
int sonuc = topla(a,b);
Console.WriteLine(sonuc);
int sonuc2 = artirvetopla(ref a, ref b);
Console.WriteLine(sonuc2);




static int topla(int deger1, int deger2)
{
    return (deger1 + deger2);
}
static int artirvetopla(ref int deger1, ref int deger2)
{
    deger1++;
    deger2++;
    return(deger1 + deger2);
}
