namespace LesBasesDuCS2;

public static class Extensions
{
    public static string MettreEnMajusculeUneLettreSurDeux(this string chaine)
    {
        var resultat = "";
        for (var i = 0; i < chaine.Length; i++)
        {
            if (i % 2 == 0)
            {
                resultat += chaine[i].ToString().ToUpper();
            }
            else
            {
                resultat += chaine[i];
            }
        }

        return resultat;
    }
}