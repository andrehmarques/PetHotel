string nomepet, especiepet, racapet, corpet;
int idadepet;

Console.WriteLine("Bem Vindo ao FortCão!");

Console.WriteLine("Preencha esse formulário a seguir");

Console.Write("Digite o nome do pet: ");
nomepet = Console.ReadLine()!.ToUpper();

Console.Write("Digite a idade do pet: ");
idadepet = int.Parse(Console.ReadLine()!);

Console.Write("Digite a especie do pet: ");
especiepet = Console.ReadLine()!.ToUpper();

Console.Write("Digite a raça do pet: ");
racapet = Console.ReadLine()!.ToUpper();

Console.Write("Digite a cor do pet: ");
corpet = Console.ReadLine()!.ToUpper();

Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine("+=========================================================+");

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("|                 Pet Hotel  \"FortCão\"                    |");

Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine("+=========================================================+");

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine($"| Espécie: {especiepet.PadLeft(18, '.')} | Raça: {racapet.PadLeft(19, '.')} |");

Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine("+=========================================================+");

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine($"| Atende pela alcunha de: {nomepet.PadLeft(31, '.')} |");

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine($"| Idade: {idadepet.ToString().PadLeft(2,'0')} ano(s) | Pelagem/cor: {corpet.PadLeft(23, '.')} |");

Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine("+=========================================================+");
Console.ResetColor();



// +=========================================================+
// |                 Pet Hotel "Nem um pio"                  |
// +=========================================================+
// | Espécie: ............CÃO | Raça: ............INDEFINIDA |
// +=========================================================+
// | Atende pela alcunha de: ...........................ZECA |
// | Idade: 03 ano(s) | Pelagem/cor: ...............CARAMELO |
// +=========================================================+
