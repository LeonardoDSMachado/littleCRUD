using CRUD;
using System.Data;

Console.WriteLine("Bem-vindo a sua lista de itens!\n");

int resposta = -1;

try
{
    while (resposta != 0)
    {
        getLista();

        Console.WriteLine("\nDeseja fazer alguma ação com a lista?");
        Console.WriteLine("\n1 - Criar novo item\n2 - Atualizar item \n3 - Consultar item\n4 - Deletar item\n0 - Fechar programa");
        resposta = Convert.ToInt32(Console.ReadLine());

        if (resposta > 0)
        {
            Console.Clear();
        }

        switch (resposta)
        {
            case 1:
                Console.Clear();
                getLista();
                Create.getCreate();
                break;

            case 2:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Digite o Id do item que deseja atualizar:\n");
                Console.ResetColor();
                getLista();
                int updatedParamer = Convert.ToInt32(Console.ReadLine());               
                Update.setUpdated(updatedParamer);
                break;
            case 3:
                Console.Clear();
                getLista();
                Console.WriteLine("Digite o Id do item a ser consultado");
                int idConsult = Convert.ToInt32(Console.ReadLine());
                Consult.getConsult(idConsult);
                break;
            case 4:
                Console.Clear();
                getLista();

                Console.WriteLine("Digite o Id do item a ser deletado");
                int idDelet = Convert.ToInt32(Console.ReadLine());

                var idDeleted = Itens.listaItens.Where(i => i.Id == idDelet).ToList();
                foreach (var i in idDeleted)
                {
                    Console.WriteLine("Deletando o item abaixo...");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"ID:{i.Id} \tPreço:{i.preco} \tNome:{i.nome} ");
                    Console.ResetColor();
                }

                Delet.getDelet(idDelet);
                break;
            case 0:
                Console.WriteLine("Voce escolheu sair do programa\n");
                break;
            default:
                Console.WriteLine("Opção Inválida! Escolha um dos números abaixo:\n");
                break;


        }
    }
    Console.WriteLine("Programa fechando...");

}
catch (FormatException ex)
{
    Console.WriteLine("Letras não são aceitas como resposta!\nDigite um número da lista de opções." + ex.Message);
    throw;
}

catch (Exception ex)
{
    Console.WriteLine("Erro generico:" + ex.Message);
    throw;
}

static void getLista()
{
    foreach (var i in Itens.listaItens)
    {
        Console.WriteLine($"ID:{i.Id} \tPreço:{i.preco} \tNome:{i.nome} ");
    }
}