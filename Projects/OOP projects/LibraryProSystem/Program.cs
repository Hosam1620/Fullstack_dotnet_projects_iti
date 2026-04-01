using LibraryProSystem.Libraries;

namespace LibraryProSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            LibraryEngine lib = new LibraryEngine();
            lib.SaveData();
        }
    }
}