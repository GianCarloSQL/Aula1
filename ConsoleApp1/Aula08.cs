using System;

public class Aula08
{
    public Aula08()
    {

    }

    public void faca()
    {
        Console.WriteLine("Ola");
        var conteudo = Console.ReadLine();
        for (int i = 0; i < conteudo.length; i++)
        {
            Console.WriteLine(conteudo[i]);
        }





        Console.ReadKey();
    }

}
