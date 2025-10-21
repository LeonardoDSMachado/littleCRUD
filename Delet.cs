using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD;

public class Delet
{


    public static void getDelet(int id)
    {
        int item = Itens.listaItens.FindIndex(i => i.Id == id);
        if (item >= 0)
        {
            Itens.listaItens.RemoveAt(item);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Item com ID {id} removido com sucesso!\n\n");
            Console.ResetColor();
        }
        else
        {
            Console.WriteLine($"Nenhum item encontrado com o ID {id}.\n\n");
        }
    }
}
