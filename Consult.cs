using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD;

public class Consult
{
    public static void getConsult(int id)
    {
        int item = Itens.listaItens.FindIndex(i => i.Id == id);
        var itemConsult = Itens.listaItens.Where(i => i.Id == id);
        if (item >= 0)
        {
            foreach (var i in itemConsult)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\nID:{i.Id} \tPreço:{i.preco} \tNome:{i.nome} \tDescrição:{i.descricao}\n\n");
                Console.ResetColor();
            }
        }
        else
        {
            Console.WriteLine($"Nenhum item encontrado com o ID {id}.\n\n");
        }


    }
}
