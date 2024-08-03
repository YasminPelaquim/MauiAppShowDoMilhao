using MauiAppShowDoMilhao.Models;

namespace MauiAppShowDoMilhao
{
    public partial class App : Application
    {
       List<Pergunta> perguntas_faceis = new() 
       {
           new Pergunta
           {
               Id = 1,
               Enunciado = "Qual é o nome dado ao estado da água em forma de gelo",
               Alternativas = new()
               {
                   new Alternativa { Correta = false, Descricao = "LÍQUIDO" },
                   new Alternativa { Correta = true, Descricao = "SÓLIDO" },
                   new Alternativa { Correta = false, Descricao = "GASOSO" },
                   new Alternativa { Correta = false, Descricao = "VAPOROSO" },
               }
           },
           new Pergunta
           {
               Id = 2,
               Enunciado = "Quem fundou a fábrica de automóveis Ford?",
               Alternativas = new()
               {
                   new Alternativa{ Correta = false, Descricao = "HARRISON FORD" },
                   new Alternativa{ Correta = false, Descricao = "GERALD FORD" },
                   new Alternativa{ Correta = true, Descricao = "HENRY FORD" },
                   new Alternativa{ Correta = false, Descricao = "ANNA FORD" },
               }
           },
           new Pergunta
           {
               Id= 3,
               Enunciado = "Quando é comemorado o dia da independência do Brasil?",
               Alternativas = new()
               {
                   new Alternativa{ Correta = false, Descricao = "21 DE ABRIL" },
                   new Alternativa{ Correta = false, Descricao = "12 DE OUTUBRO" },
                   new Alternativa{ Correta = true, Descricao = "7 DE SETEMBRO" },
                   new Alternativa{ Correta = false, Descricao = "25 DE DEZEMBRO" },
               }

           },
           new Pergunta
           {
               Id = 4,
               Enunciado = "Quem foi o grande amor de Julieta?",
               Alternativas = new()
               {
                   new Alternativa{ Correta = true, Descricao = "ROMEU" },
                   new Alternativa{ Correta = false, Descricao = "ORFEU" },
                   new Alternativa{ Correta = false, Descricao = "HAMLET" },
                   new Alternativa{ Correta = false, Descricao = "IAGO" },
               }
           },
           new Pergunta
           {
               Id = 5,
               Enunciado = "Qual personagem da turma da Mônica tem apenas cinco fios de cabelo?",
               Alternativas = new()
               {
                   new Alternativa{ Correta = false, Descricao = "MÔNICA" },
                   new Alternativa{ Correta = true, Descricao = "CEBOLINHA" },
                   new Alternativa{ Correta = false, Descricao = "CASCÃO" },
                   new Alternativa{ Correta = false, Descricao = "MAGALI" },
               }
           },
           new Pergunta
           {
               Id = 6,
               Enunciado = "O churrasco é considerado uma comida típica de qual estado?",
               Alternativas = new()
               {
                   new Alternativa{ Correta = false, Descricao = "CEARÁ" },
                   new Alternativa{ Correta = true, Descricao = "RIO GRANDE DO SUL" },
                   new Alternativa{ Correta = false, Descricao = "PARÁ" },
                   new Alternativa{ Correta = false, Descricao = "MARANHÃO" },
               }
           },
           new Pergunta
           {
               Id = 7,
               Enunciado = "Quem foi o criador dos personagens Pedrinho, Narizinho e Emília?",
               Alternativas = new()
               {
                   new Alternativa{ Correta = false, Descricao = "MAURÍCIO DE SOUSA" },
                   new Alternativa{ Correta = false, Descricao = "ZIRALDO" },
                   new Alternativa{ Correta = true, Descricao = "MONTEIRO LOBATO" },
                   new Alternativa{ Correta = false, Descricao = "MACHADO DE ASSIS" },
               }
           },
           new Pergunta
           {
               Id = 8,
               Enunciado = "Quem fundou a Microsoft?",
               Alternativas = new()
               {
                   new Alternativa{ Correta = false, Descricao = "ULTÃO DE BRUNEI" },
                   new Alternativa{ Correta = false, Descricao = "AKIO MORITA" },
                   new Alternativa{ Correta = true, Descricao = "BILL GATES" },
                   new Alternativa{ Correta = false, Descricao = "PRÍNCIPE CHARLES" },

               }
           },
           new Pergunta
           {
               Id = 9,
               Enunciado = "Qual é o nome dado ao pneu reserva do carro?",
               Alternativas = new()
               {
                   new Alternativa{ Correta = false, Descricao = "CALOTA" },
                   new Alternativa{ Correta = true, Descricao = "ESTEPE" },
                   new Alternativa{ Correta = false, Descricao = "MACACO" },
                   new Alternativa{ Correta = false, Descricao = "CHAVE DE RODA" },
               }
           },
           new Pergunta
           {
               Id = 10,
               Enunciado = "Como se chama o lugar onde se guardam vinhos?",
               Alternativas = new()
               {
                   new Alternativa { Correta = true, Descricao = "ADEGA" },
                   new Alternativa { Correta = false, Descricao = "BIBLIOTECA" },
                   new Alternativa { Correta = false, Descricao = "SÓTÃO" },
                   new Alternativa { Correta = false, Descricao = "SALA" },
               }
           },
           new Pergunta
           {
               Id = 11,
               Enunciado = "Qual cantor ficou conhecidocomo “o rei do rock”?",
               Alternativas = new()
               {
                   new Alternativa{ Correta = false, Descricao = "FRANK SINATRA" },
                   new Alternativa{ Correta = false, Descricao = "LITTLE RICHARD" },
                   new Alternativa{ Correta = true, Descricao = "ELVIS PRESLEY" },
                   new Alternativa{ Correta = false, Descricao = "RICHIE VALENS" },
               }
           },
           new Pergunta
           {
               Id = 12,
               Enunciado = "Quem é o inimigo do Piu-Piu nos desenhos animados?",
               Alternativas = new()
               {
                   new Alternativa{ Correta = false, Descricao = "FÉLIX" },
                   new Alternativa{ Correta = false, Descricao = "TOM" },
                   new Alternativa{ Correta = true, Descricao = "FRAJOLA" },
                   new Alternativa{ Correta = false, Descricao = "MINGAU" },
               }
           },
           new Pergunta
           {
               Id = 13,
               Enunciado = "Onde fica o centro da indústria cinematográfica nos EUA?",
               Alternativas = new()
               {
                   new Alternativa{ Correta = false, Descricao = "NOVA YORK" },
                   new Alternativa{ Correta = false, Descricao = "LAS VEGAS" },
                   new Alternativa{ Correta = false, Descricao = "NEW ORLEANS" },
                   new Alternativa{ Correta = true, Descricao = "HOLLYWOOD" },
               }
           },
           new Pergunta
           {
               Id = 14,
               Enunciado = "Em que ano os portugueses descobriram o Brasil?",
               Alternativas = new()
               {
                   new Alternativa{ Correta = false, Descricao = "1450" },
                   new Alternativa{ Correta = true, Descricao = "1500" },
                   new Alternativa{ Correta = false, Descricao = "1550" },
                   new Alternativa{ Correta = false, Descricao = "1400" },
               }
           },
           new Pergunta
           {
               Id = 15,
               Enunciado = "Qual ator do cinema brasileiro é conhecido por ter unhas enormes?",
               Alternativas = new()
               {
                   new Alternativa { Correta = false, Descricao = "PENADINHO" },
                   new Alternativa { Correta = false, Descricao = "ZÉ DO CAIXÃO" },
                   new Alternativa { Correta = false, Descricao = "ZÉ DO CASARÃO" },
                   new Alternativa { Correta = false, Descricao = "TONINHO DO DIABO" },

               }
           },
           new Pergunta
           {
               Id = 16,
               Enunciado = "O violoncelo é um tipo de instrumento de?",
               Alternativas = new()
               {
                   new Alternativa{ Correta = false, Descricao = "SOPRO" },
                   new Alternativa{ Correta = true, Descricao = "CORDAS" },
                   new Alternativa{ Correta = false, Descricao = "PERCUSSÃO" },
                   new Alternativa{ Correta = false, Descricao = "REPERCUSSÃO" },
               }
           },
           new Pergunta
           {
               Id = 17,
               Enunciado = "Qual é a área da medicina que trata de crianças?",
               Alternativas = new()
               {
                   new Alternativa{ Correta = false, Descricao = "GERIATRIA" },
                   new Alternativa{ Correta = true, Descricao = "PEDIATRIA" },
                   new Alternativa{ Correta = false, Descricao = "INFANTOLOGIA" },
                   new Alternativa{ Correta = false, Descricao = "BIOLOGIA" },
               }
           },
           new Pergunta
           {
               Id = 18,
               Enunciado = "O dromedário tem quantas corcovas?",
               Alternativas = new()
               {
                   new Alternativa { Correta = true, Descricao = "UMA" },
                   new Alternativa { Correta = false, Descricao = "DUAS" },
                   new Alternativa { Correta = false, Descricao = "TRÊS" },
                   new Alternativa { Correta = false, Descricao = "QUATRO" },
               }
           },
           new Pergunta
           {
               Id = 19,
               Enunciado = "Qual foi o nome dado ao movimento liderado por Tiradentes?",
               Alternativas = new()
               {
                   new Alternativa{ Correta = false, Descricao = "REVOLUÇÃO FRANCESA" },
                   new Alternativa{ Correta = false, Descricao = "GUERRA DOS EMBOABAS" },
                   new Alternativa{ Correta = true, Descricao = "INCONFIDÊNCIA MINEIRA" },
                   new Alternativa{ Correta = false, Descricao = "SEGUNDA GUERRA MUNDIAL" },
               }
           },
           new Pergunta
           {
               Id = 20,
               Enunciado = "Quantos titulares possui umaequipe de vôlei?",
               Alternativas = new()
               {
                   new Alternativa{ Correta = false, Descricao = "CINCO" },
                   new Alternativa{ Correta = true, Descricao = "SEIS" },
                   new Alternativa{ Correta = false, Descricao = "SETE" },
                   new Alternativa{ Correta = false, Descricao = "OITO" },
               }
           },
       };

        List<Pergunta> perguntas_difceis = new()
        {

        };

    }
}
