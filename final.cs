namespace TicTacToeClasses;

class TicTacToe
{
    static void Main(string[] args)
    {
        try
        {
        Session session = new Session();
        session.StartSession();
        }
        catch(Exception e)
        {
            Console.WriteLine("\n\nException caught!!");
            Console.WriteLine(e.ToString());
            return;
        }
    }
}
    