namespace WinFormsApp13;

public class Visitor
{
    public string name;
    private static int totalVisitors = 0;

    public Visitor(string name)
    {
        this.name = name;
        totalVisitors++;
    }

    public string PrintInfo()
    {
        return "Имя: " + name;
    }
    
    public static string ShowTotalVisitors()
    {
        return "Общее кол-во посетителей: " + totalVisitors;
    }
    
}