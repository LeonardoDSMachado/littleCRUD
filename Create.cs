using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CRUD;

public class Create
{
    public static void getCreate()
    {
        int id;
        string name;
        double price;
        string desc;


        

        if (Itens.listaItens.Count == 0)
        {
            id = 1;
        }
        else
        {
            id = Itens.listaItens.Max(item => item.Id) + 1;
        }

        Console.WriteLine("\nDigite o nome do novo item");
        name = Console.ReadLine();

        Console.WriteLine("\nDigite o preço do novo item");
        price = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nDigite a descrição do novo item");
        desc = Console.ReadLine();

        var novoItem = new Item
        {
            Id = id,
            nome = name,
            preco = price,
            descricao = desc
        };

        Itens.listaItens.Add(novoItem);

        Console.WriteLine("\nItem abaixo adicionado na lista");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"ID:{novoItem.Id} \tPreço:{novoItem.preco} \tNome:{novoItem.nome}\n");
        Console.ResetColor();
    }
}
