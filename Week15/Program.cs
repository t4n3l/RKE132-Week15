

List<Film> minuFilmid = new List<Film>();
string[] data = AndmedFailist();
//loeAndmed(data);

foreach (string line in data)
{
    string[] tempMassiiv = line.Split(new char[] {';'}, StringSplitOptions.RemoveEmptyEntries);
    Film uusFilm = new Film(tempMassiiv[0], tempMassiiv[2]);
    minuFilmid.Add(uusFilm);
}

foreach (Film film in minuFilmid)
{
    Console.WriteLine($"Minu lemmikfilm {film.Pealkiri} tuli välja aastal {film.Aasta}.");
}

static string[] AndmedFailist()
{
    string asukoht = @"C:\Users\rists\Desktop\TKTK KMT2023\1-K Programmeerimise algkursus - kevad 2024 - J. Voronetskaja\Week15\movies.txt";
    string[] andmed = File.ReadAllLines(asukoht);

    return andmed;
}

static void loeAndmed(string[] massiiv)
{
    foreach(string line in massiiv)
    {
        Console.WriteLine(line);
    }
}


class Film
{
    string pealkiri;
    string aasta;

    public string Pealkiri
    {
        get { return pealkiri; }
    }
    public string Aasta
    {
        get { return aasta; }
    }

    public Film(string _pealkiri, string _aasta)
    {
        pealkiri = _pealkiri;
        aasta = _aasta;
    }
}