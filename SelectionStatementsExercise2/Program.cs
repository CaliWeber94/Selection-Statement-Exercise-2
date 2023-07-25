namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            string FavSubject = Console.ReadLine();
           
            switch(FavSubject.ToUpper())
            {
                case "Science":
                    Console.WriteLine("Ok, your favorite subject is: Science");
                    break;
                case "Math":
                    Console.WriteLine("Ok, your favorite subject is: Math");
                    break;
                case "English":
                    Console.WriteLine("Ok, your favorite subject is: English");
                    break;
                case "Home Economics":
                    Console.WriteLine("Ok, your favorite subject is: Home Economics");
                    break;
                case "P.E":
                    Console.WriteLine("Ok, your favorite subject is: P.E");
                    break;
                case "History":
                    Console.WriteLine("Ok, your favorite subject is: History");
                    break;
                default: Console.WriteLine("Ok, this subject was not included");
                    break;
            }
        }
    }
}