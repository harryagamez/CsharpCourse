using System.IO;

try
{
    string content = File.ReadAllText(@"C:\Users\harry\Documents\file.txt"); // El @ me permite usar \ en la ruta
    Console.WriteLine(content);

    //string content2 = File.ReadAllText(@"C:\Users\harry\Documents\file2.txt"); // El @ me permite usar \ en la ruta
    //Console.WriteLine(content2);

    throw new Exception("Ocurrió algo raro");
}
catch (FileNotFoundException ex)
{
    Console.WriteLine("El archivo no existe");
} catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Aquí me he ejecutado, pase lo que pase");
}

Console.WriteLine("Aquí se sigue ejecutando el programa");


