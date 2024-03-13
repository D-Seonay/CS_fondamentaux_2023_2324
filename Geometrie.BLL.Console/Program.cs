using Geometrie.BLL; // Assuming this namespace contains your geometric classes
using System;
using System.Collections.Generic;
using Geometrie.BLL.Exceptions;


try
{
    var p = new Point(3, 4);
    var c = new Cercle(p, 2);

    // Testing the Polygone class
    var p1 = new Point(0, 0);
    var p2 = new Point(1, 0);
    var p3 = new Point(1, 1);
    var p4 = new Point(0, 1);
    var tri = new Triangle(p1, p2, p3);
    var quadri = new Quadrilatère(p1, p2, p3, p4);


    var listeDeFormes = new List<IForme>(); // Assuming IForme is an interface implemented by your geometric classes
    listeDeFormes.Add(c);
    listeDeFormes.Add(tri);
    listeDeFormes.Add(quadri);

    // Iterating through the list and printing information about each shape
    foreach (var item in listeDeFormes)
    {
        Console.WriteLine($"{item}  ### Périmètre = {item.CalculerPerimetre()}  ### Aire = {item.CalculerAire()}");
    }
}
catch (DivideByZeroException e)
{
    Console.WriteLine("Division par zéro : " + e.Message);
}
catch (ArgumentNullException ex)
{
    Console.WriteLine("Argument null : " + ex.ParamName);
}
catch (PolygoneException ex)
{
    Console.WriteLine("Erreur dans le polygone : " + ex.Message);
    Console.WriteLine($"Points : {string.Join(", ", ex.Points)}");
}
catch (Exception ex)
{
    Console.WriteLine("Erreur : " + ex.Message);
}

