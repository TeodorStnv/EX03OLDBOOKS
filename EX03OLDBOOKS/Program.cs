namespace EX03OLDBOOKS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string favoriteBook = Console.ReadLine();
            string nextBook = Console.ReadLine();
            double numberOfBooks = 0;

            while (nextBook != favoriteBook)
            {
               // numberOfBooks = numberOfBooks + 1;
                
                if (nextBook == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {numberOfBooks} books.");
                    break;
                }

                numberOfBooks = numberOfBooks + 1;
                nextBook = Console.ReadLine();
                   // numberOfBooks = numberOfBooks + 1;

            }
            if (nextBook==favoriteBook)
            Console.WriteLine($"You checked {numberOfBooks} books and found it.");

        }
    }
}