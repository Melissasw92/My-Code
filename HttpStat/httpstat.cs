ConsoleApplication.Run();

public class ConsoleApplication
{
    public static void Run()
    {
    

        static void Main (string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a Response code: ");
                string codeS = Console.ReadLine();

                if (!int.TryParse(codeS, out int code))
                {
                    Console.WriteLine($"{codeS} is not a valid Response.");
                    continue;
                }
                string responses = GetResponse(code);


                if (responses != null)
                {
                    Console.WriteLine($"{code} is a {responses} Response.");
                }
                else
                {
                    Console.WriteLine($"{code} is not a valid Response.");
                }
            }

        }
        static string GetResponse(int code)
        {
            if (code >= 100 && code <= 199)
            {
                return "Informational";

            }
            else if (code >= 200 && code <= 299)
            {
                return "Successful";

            }
            else if (code >= 300 && code <= 399)
            {
                return "Redirection";

            }
            else if (code >= 400 && code <= 499)
            {
                return "Client Error Message";

            }
            else if (code >= 500 && code <= 599)
            {
                return "Server Error Message";

            } else
            {
                return null;
            }
        }
        Main (null);
    }
}
