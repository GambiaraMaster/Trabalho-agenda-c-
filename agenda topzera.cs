using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProAgenda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contato pessoa = new Contato();//dados de contato
            Console.WriteLine("Digite seu nome meu nobre: ");
            pessoa.nome = Console.ReadLine();
                    Console.WriteLine("Digite teu email: " + pessoa.email);
            pessoa.email = Console.ReadLine();
                     Console.WriteLine("Endereço:" + pessoa.endereço);
            pessoa.endereço = Console.ReadLine();
                       Console.WriteLine("Aniversario:" + pessoa.aniversario);
            pessoa.aniversario = Console.ReadLine();
                      Console.WriteLine("Passa o zap: " + pessoa.celular);
            pessoa.celular = Console.ReadLine();
                      Console.WriteLine("Passa o feice: " + pessoa.facebook);
            pessoa.facebook = Console.ReadLine();
                      Console.WriteLine("tuiter: " + pessoa.twitter);
            pessoa.twitter = Console.ReadLine();
                       Console.WriteLine("Qual e o teu insta: " + pessoa.instagram);
            pessoa.instagram = Console.ReadLine();
            Console.Clear();
            Agendamento busy = new Agendamento();//agendamento
            Console.WriteLine("Digite uma data:");
            busy.data = Console.ReadLine();
            Console.WriteLine("Informe os detalhes:");
            busy.detalhes=Console.ReadLine();
            Console.WriteLine("hora parar agendar:");
            busy.hora=Console.ReadLine();
            Console.WriteLine("Seus Dados sao: "+"Data"+busy.data +busy.hora+"hora:"+busy.detalhes+"detalhes");
            Console.ReadLine(); //mostrar os dado no final   
            Console.Clear();
            Tarefas tra = new Tarefas(); //tarefaas 
            Console.WriteLine("Informe o nome da tarefa: ");
            tra.nome=Console.ReadLine();
            Console.WriteLine("Informe o horario da tarefa");
            tra.horarioTRF=Console.ReadLine();
            Console.WriteLine("Informe as opçoes da tarefa: ");
            tra.opTRF=Console.ReadLine();
            Console.WriteLine("Seus Dados sao: " + "Data" + tra.nome + tra.horarioTRF + "hora:" + tra.opTRF + "opçoes");
            Console.ReadLine();
        }
    }
}
