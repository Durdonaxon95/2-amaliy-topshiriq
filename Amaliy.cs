Console.Write("Birinchi sonni kiriting: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Amalni kiriting: ");
string amal = Console.ReadLine() ?? string.Empty;

Console.Write("Ikkinchi sonni kiriting: ");
int b = Convert.ToInt32(Console.ReadLine());

 

double natija = 0;

switch (amal)
{
    case "+":
        natija = a + b;
        break;
    case "-":
        natija = a - b;
        break;
    case "*":
        natija = a * b;
        break;
    case "/":
        natija = a / b;
        break;
    default:
        Console.WriteLine("Noto‘g‘ri amal tanlandi!");
        break;
}

Console.WriteLine("Natija: " + natija);


// Foydalanuvchidan N musbat son so'ralganda, 1 dan N gacha bo'lgan sonlar yig'indisini hisoblovchi dastur tuzilsin.
 Console.WriteLine("N sonini kiriting: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = n * (n + 1) / 2;
Console.WriteLine("1 dan " + n + " gacha bo'lgan sonlar yig'indisi: " + sum);


//Foydalanuvchi kiritgan sonning juft yoki toq ekanligini aniqlovchi dastur tuzilsin.

Console.WriteLine("Sonni kiriting: ");
int son = Convert.ToInt32(Console.ReadLine());
if (son % 2 == 0)
{
    Console.WriteLine("Bu son juft son");
}
else
{
    Console.WriteLine("Bu son toq son");
}
