using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CRUD;

public static class Update
{
    public static void setUpdated(int id)
    {       
        var itemUpdated = Itens.listaItens.Find(i => i.Id == id);

        Console.WriteLine($"O nome atual é {itemUpdated.nome}, deseja alterar ele?\nS/N");
        char resposta = Convert.ToChar(Console.ReadLine());
        if (resposta == 'S')
        {
            Console.WriteLine("Digite o novo nome abaixo:");
            string newName = Console.ReadLine();
            itemUpdated.nome = newName;
        }

        Console.WriteLine($"O preço atual é {itemUpdated.preco}, deseja alterar ele?\nS/N");
        resposta = Convert.ToChar(Console.ReadLine());
        if (resposta == 'S')
        {
            Console.WriteLine("Digite o novo preço abaixo:");
            int newPrice = Convert.ToInt32(Console.ReadLine());
            itemUpdated.preco = newPrice;
        }

        Console.WriteLine($"A descrição atual é {itemUpdated.descricao}, deseja alterar ela?\nS/N");
        resposta = Convert.ToChar(Console.ReadLine());
        if (resposta == 'S')
        {
            Console.WriteLine("Digite a nova descrição abaixo:");
            string newDesc = Console.ReadLine();
            itemUpdated.descricao = newDesc;
        }

        Console.WriteLine("Item atualizado com sucesso!");
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine($"\nID:{itemUpdated.Id} \tPreço:{itemUpdated.preco} \tNome:{itemUpdated.nome} \tDescrição:{itemUpdated.descricao}\n\n");
        Console.ResetColor();      
    }
}
