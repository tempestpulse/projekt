public class Lotnisko
{
    private string _kraj;
    private string _miasto;
    private string _id;

    public Lotnisko(string kraj, string miasto, string id)
    {
        _kraj = kraj;
        _miasto = miasto;
        _id = id;
    }

    public string GetKraj()
    {
        return _kraj;
    }

    public string GetMiasto()
    {
        return _miasto;
    }

    public string GetId()
    {
        return _id;
    }
}