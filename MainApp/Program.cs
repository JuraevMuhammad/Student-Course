

using Service;

StudentService studentService = new();

try
{
    while (true)
    {
        Console.WriteLine("""
                          
                          """);
        Console.Write("Выберите пункт: ");
        int input = int.Parse(Console.ReadLine());

    }
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}