using Geometrie.BLL;
using Geometrie.BLL.Exceptions;
using System.Net.NetworkInformation;

try
{
    var p = new Point(1, 2);

    //p.Distance(null);

    var c = new Cercle(2, p);

    //test du polygone
    var p1 = new Point(0, 0);
    var p2 = new Point(1, 0);
    var p3 = new Point(0, 1);
    var p4 = new Point(0, 1);
    var tri = new Triangle(p1, p2, p3);
    var quadri = new Quadrilatere(p1, p2, p3, p4);

    var listeDeFormes = new List<IForme>();
    listeDeFormes.Add(c);
    listeDeFormes.Add(tri);
    listeDeFormes.Add(quadri);

    foreach (var item in listeDeFormes)
    {
        Console.WriteLine($"{item} ### Périmètre :{item.CalculerPerimetre()} ### Aire :{item.CalculerAire()}");
    }
}
catch (DivideByZeroException)
{
    Console.WriteLine("Division par zéro");
}
catch (ArgumentNullException ex)
{
    Console.WriteLine($"Un argument est null : {ex.ParamName}");
    Console.WriteLine(ex.Message);
}
catch (PolygoneException ex)
{
    Console.WriteLine("Erreur dans le polygone");
    Console.WriteLine(ex.Message);
    Console.WriteLine($"Points : {string.Join(", ", ex.Points)}");
}
catch (Exception ex)
{
    Console.WriteLine("Une erreur inconnue s'est produite");
    Console.WriteLine(ex.Message);
}