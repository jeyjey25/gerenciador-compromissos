using System;
using ConsoleApp.Modelos;

class Program
{
    static void Main()
    {
        Compromisso compromisso = new Compromisso();

        Console.WriteLine("Cadastro de Compromisso");

        Console.Write("Digite a data (dd/MM/aaaa): ");
        string dataDigitada = Console.ReadLine();
        bool dataValida = false;

        while (!dataValida)
        {
            try
            {
                compromisso.Data = dataDigitada;
                dataValida = true;
            }
            catch (Exception erro)
            {
                Console.WriteLine("Erro: " + erro.Message);
                Console.Write("Digite a data novamente: ");
                dataDigitada = Console.ReadLine();
            }
        }

        Console.Write("Digite a hora (HH:mm): ");
        string horaDigitada = Console.ReadLine();
        bool horaValida = false;

        while (!horaValida)
        {
            try
            {
                compromisso.Hora = horaDigitada;
                horaValida = true;
            }
            catch (Exception erro)
            {
                Console.WriteLine("Erro: " + erro.Message);
                Console.Write("Digite a hora novamente: ");
                horaDigitada = Console.ReadLine();
            }
        }

        Console.Write("Digite a descrição do compromisso: ");
        compromisso.Descricao = Console.ReadLine();

        Console.Write("Digite o local do compromisso: ");
        compromisso.Local = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Compromisso registrado com sucesso!");
        Console.WriteLine("Data: " + compromisso.Data);
        Console.WriteLine("Hora: " + compromisso.Hora);
        Console.WriteLine("Descrição: " + compromisso.Descricao);
        Console.WriteLine("Local: " + compromisso.Local);
    }
}



// Compromisso compromisso = new();

// Console.WriteLine("Vamos registrar um compromisso");

// Console.Write("Digite a data do compromisso (dd/MM/aaaa): ");
// // var dataDigitada = Console.ReadLine();

// while (true) {
//     try {
//         compromisso.Data = Console.ReadLine();
//         break;
//     } catch (Exception e) {
//         Console.Write($"Erro: {e.Message}\nDigite uma nova data: ");
//     }
// }
// Console.Write("Digite a hora do compromisso (HH:mm): ");
// var horaDigitada = Console.ReadLine();

// TimeSpan horaCompromisso;

// while(!TimeSpan.TryParse(horaDigitada, out horaCompromisso)) {
//     Console.WriteLine("HORA INVÁLIDA. \nDigite a hora do compromisso (HH:mm): ");
//     horaDigitada = Console.ReadLine();
// }

// Console.Write("Digite a DESCRIÇÃO para o compromisso: ");
// var descricao = Console.ReadLine();

// Console.Write("Digite o LOCAL para o compromisso: ");
// var local = Console.ReadLine();

// DateTime dataEHoraParaCompromisso = dataCompromisso.Add(horaCompromisso); 

// Console.WriteLine("Data: " + dataCompromisso.Date.ToShortDateString());
// Console.WriteLine($"Hora: {horaCompromisso}");
// Console.WriteLine($"Descrição: {descricao}");
// Console.WriteLine($"Local: {local}");

// Console.WriteLine($"Data e Hora: {dataEHoraParaCompromisso}");


// // Compromisso compromisso = new Compromisso();
// // var compromisso = new Compromisso();



// // Compromisso compromisso = new();
// // compromisso.Data = DateTime.Now.Date;
// // Console.WriteLine(compromisso.Data);
// // Console.WriteLine(compromisso.DataBR());

// // compromisso.RegistrarData(DateTime.Now.Date);

// // Console.Write(compromisso.ObterData());

