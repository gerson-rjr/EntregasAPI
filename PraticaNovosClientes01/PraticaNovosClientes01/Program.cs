using PraticaNovosClientes01;
using System.Security.Cryptography.X509Certificates;

internal class Program

//Antes de executar o código contido em Program.cs, é necessário rodar o 'enable-migrations' > 'add-migration [nome do migration]' > 'update-database'
//Esses comandos devem ser realizados no Console do NuGet, para a criação da tabela juntamente com suas devidas colunas.
//É necessário também alterar a string contida na Class DataContext na prop base. A string que deve ser colocada é a do connection do banco local.
//Os códigos de ambas as aplicações construídas estão no meu repositório do GitHub. Não foram enviadas completamente, pq o form apenas permitiu o envio de um arquivo.
//Link do Repositório: https://github.com/gerson-rjr/EntregasAPI

{
    public static List<Pessoa> ListaPessoas = new List<Pessoa>();
    private static void Main(string[] args)
    {
        Pessoa pessoa0 = new Pessoa(1, "Gerson Rosa", DateTime.Now);
        Pessoa pessoa1 = new Pessoa(2, "Lauren Gomes", DateTime.Now);
        Pessoa pessoa2 = new Pessoa(3, "Adriano Corbucci", DateTime.Now);
        Pessoa pessoa3 = new Pessoa(4, "Nicolas Medeiros", DateTime.Now);
        Pessoa pessoa4 = new Pessoa(5, "Misael Pereira", DateTime.Now);
        Pessoa pessoa5 = new Pessoa(6, "João Pedro", DateTime.Now);
        Pessoa pessoa6 = new Pessoa(7, "Jhonatan Souza", DateTime.Now);
        Pessoa pessoa7 = new Pessoa(8, "André Franklin", DateTime.Now);
        Pessoa pessoa8 = new Pessoa(9, "Edna dos Santos", DateTime.Now);
        Pessoa pessoa9 = new Pessoa(10, "Hellen Karine", DateTime.Now);

        ListaPessoas.Add(pessoa0);
        ListaPessoas.Add(pessoa1);
        ListaPessoas.Add(pessoa2);
        ListaPessoas.Add(pessoa3);
        ListaPessoas.Add(pessoa4);
        ListaPessoas.Add(pessoa5);
        ListaPessoas.Add(pessoa6);
        ListaPessoas.Add(pessoa7);
        ListaPessoas.Add(pessoa8);
        ListaPessoas.Add(pessoa9);

        foreach (Pessoa pessoa in ListaPessoas)
        {
            Console.WriteLine("{0}", pessoa.ToString());
        }

        Console.WriteLine(InserirPessoasBanco());

    }
    public static bool InserirPessoasBanco()
    {
        using (var context = new DataContext())
        {
            foreach (Pessoa pessoa in ListaPessoas)
            context.Pessoa.Add(pessoa);
            context.SaveChanges();
            return true;
        }
    }
}