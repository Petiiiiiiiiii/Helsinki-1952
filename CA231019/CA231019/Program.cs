using CA231019;
using System.Text;


var sr = new StreamReader(
    path:@"..\..\..\src\helsinki.txt",
    encoding: Encoding.UTF8);

var adatok = new List<Adat>();

while (!sr.EndOfStream)
    adatok.Add(new Adat(sr.ReadLine()));

var f3 = adatok
    .Count();

Console.WriteLine("3. feladat: ");
Console.WriteLine($"Pontszerző helyezések száma: {f3}");

var f4dic = new Dictionary<string, int>();
var f4 = adatok
    .Where(a => a.Helyezes <= 3)
    .GroupBy(g => g.Helyezes);

foreach (var item in f4)
{
    if (item.Key == 1)
        f4dic.Add("Arany", item.Count());
    else if (item.Key == 2)
        f4dic.Add("Ezüst", item.Count());
    else
        f4dic.Add("Bronz", item.Count());

}

Console.WriteLine("4. feladat:");
foreach (var item in f4dic) 
{
    Console.WriteLine($"{item.Key}: {item.Value}");
}

var f4ossz = adatok
    .Where(a => a.Helyezes <= 3);

Console.WriteLine($"Összesen: {f4ossz.Count()}");


var f5dic = new Dictionary<int, int>() { {1,7},{2,5},{3,4},{4,3},{5,2},{6,1} };
var ossz = 0;

foreach (var item in adatok)
{
    foreach (var pont in f5dic)
    {
        if (item.Helyezes == pont.Key)
        {
            ossz += pont.Value;
        }
    }
}
Console.WriteLine("5. feladat:");
Console.WriteLine($"Olimpiai pontok száma: {ossz}");

var f6Torna = adatok
    .Where(a => a.Sportag == "torna")
    .ToList();

var f6Uszas = adatok
    .Where(a => a.Sportag == "uszas")
    .ToList();

Console.WriteLine("6. feladat:");

if (f6Torna.Count() > f6Uszas.Count())
    Console.WriteLine("Torna sportágban szereztek többet.");
else if (f6Uszas.Count() > f6Torna.Count())
    Console.WriteLine("Úszás sportágban szereztek többet.");
else
    Console.WriteLine("Egyenlő volt az érmek száma");

foreach (var item in adatok)
{
    foreach (var pont in f5dic)
    {
        if (item.Helyezes == pont.Key)
        {
            item.OsszPontszam = pont.Value;
        }
    }
}

foreach (var item in adatok) 
{
    if (item.Sportag == "kajakkenu")
    {
        item.Sportag = "kajak-kenu";
    }
}

var sw = new StreamWriter(
    path:@"..\..\..\src\helsinki2.txt",
    append:false);

foreach (var item in adatok)
{
    sw.WriteLine(item);
}

sw.Close();

var f8 = adatok
    .Where(a => a.DarabSportolo == adatok.Max(m => m.DarabSportolo));

Console.WriteLine("8. feladat:");

foreach (var item in f8) 
{
    Console.WriteLine($"Helyezés: {item.Helyezes}");
    Console.WriteLine($"Sportág: {item.Sportag}");
    Console.WriteLine($"Versenyszám: {item.Versenyszam}");
    Console.WriteLine($"Sporotlók száma: {item.DarabSportolo}");
}














Console.ReadKey();
