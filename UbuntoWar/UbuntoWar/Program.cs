using System;
using System.Collections.Generic;
using System.Linq;
using UbuntoWar.Controller;
using UbuntoWar.Entities;

namespace UbuntoWar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dictionary
            Dictionary<int, string> jogador = new Dictionary<int, string>();

            //List
            List<Jogador> jogadores = new List<Jogador>();

            // Declaração das entidades
            Comandos comandos = new Comandos();
            Jogador player = new Jogador();
            Porta porta = new Porta();

            // Variáveis utilizadas
            var jogadorAtual = 1;
            var count = 0; // Contador de portas
            var avanco = 0; // Contador de portas corretas
            var portaEscolhida = ""; // Porta escolhida pelo jogador
            var proximaporta = comandos.sortPorta(); // Gerador de números aleatorios

            Console.WriteLine("Deseja participar do jogo?\n(1-Sim/2-Não)");
            comandos.setInicio(Console.ReadLine());

            // Looping para iniciar o jogo
            do
            {
                Console.Clear();
                // Switch case Menu
                switch (comandos.getInicio())
                {
                    case "1":
                        Console.WriteLine("Bem-vindo!\n\nDigite seu nome!");
                        player.setNome(Console.ReadLine());
                        Console.Clear();

                        Console.WriteLine("Digite sua idade!");
                        player.setIdade(Console.ReadLine());
                        Console.Clear();

                        Console.WriteLine("Digite seu sexo!\n(M-Masculino/F-Feminino)");
                        player.setSexo(Console.ReadLine());

                        switch (player.getSexo())
                        {
                            case "M":
                                player.setSexo("Masculino");
                                break;
                            case "F":
                                player.setSexo("Feminino");
                                break;
                            default:
                                player.setSexo("Desconhecido");
                                break;
                        }
                        Console.Clear();

                        Console.WriteLine($"Perfeito {player.getNome()}, iremos iniciar o jogo!");
                        count = 0;
                        jogadorAtual++;

                        // For para contagem de portas
                        for (int i = 0; i < 5; i++)
                        {
                            Console.Clear();
                            Console.WriteLine($"({count+1}/5)\n");
                            Console.WriteLine($"Escolha uma porta!\n");
                            Console.WriteLine("_________ _________ _________");
                            Console.WriteLine("|-------| |-------| |-------|");
                            Console.WriteLine("|-------| |-------| |-------|");
                            Console.WriteLine("|---A---| |---B---| |---C---|");
                            Console.WriteLine("|-------| |-------| |-------|");
                            Console.WriteLine("|-------| |-------| |-------|\n");

                            // Do While para repetição da pergunta referente a porta
                            do
                            {
                                proximaporta = comandos.sortPorta();
                                // Descomente para visualizar as respostas
                                for (int n = 0; n < 3; n++)
                                {
                                    Console.WriteLine(proximaporta[n]);
                                }
                                portaEscolhida = Console.ReadLine();
                                Console.Clear();

                                //Switch case, escolha da porta correta
                                switch (portaEscolhida)
                                {
                                    case "A":
                                        Console.WriteLine($"Você escolher a porta {porta.getPortaA()}");
                                        Console.ReadLine();
                                        avanco = proximaporta[0];
                                        Console.Clear();
                                        break;
                                    case "B":
                                        Console.WriteLine($"Você escolher a porta {porta.getPortaB()}");
                                        Console.ReadLine();
                                        avanco = proximaporta[1];
                                        Console.Clear();
                                        break;
                                    case "C":
                                        Console.WriteLine($"Você escolher a porta {porta.getPortaC()}");
                                        Console.ReadLine();
                                        avanco = proximaporta[2];
                                        Console.Clear();
                                        break;
                                    default:
                                        Console.WriteLine($"({count + 1}/5)\n");
                                        Console.WriteLine("Opção inválida!\nEscolha uma porta!");
                                        Console.WriteLine("_________ _________ _________");
                                        Console.WriteLine("|-------| |-------| |-------|");
                                        Console.WriteLine("|-------| |-------| |-------|");
                                        Console.WriteLine("|---A---| |---B---| |---C---|");
                                        Console.WriteLine("|-------| |-------| |-------|");
                                        Console.WriteLine("|-------| |-------| |-------|\n");
                                        break;
                                }
                            } while ((portaEscolhida != "A") && (portaEscolhida != "B") && (portaEscolhida != "C"));
                            // Switch case para definir o avanço do jogador
                            // A porta correta sempre será defenida como 1
                            switch (avanco)
                            {
                                case 1:
                                    ++count;
                                    Console.WriteLine("Parabéns! Você avançou para próxima etapa!");
                                    Console.ReadLine();
                                    break;
                                default:
                                    i = 5;
                                    player.setVencedor("Perdeu!");
                                    Console.WriteLine("Você morreu!\n\n");
                                    jogadores.Add(player);
                                    Console.WriteLine("Deseja reiniciar o jogo? (1-Sim/2-Não)");
                                    comandos.setReiniciar(Console.ReadLine());
                                    switch (comandos.getInicio())
                                    {
                                        case "1":
                                            break;
                                        case "2":
                                            Console.Clear();
                                            Console.WriteLine("Perdedor!\n\n\n\n\n\n\n");
                                            Console.ReadLine();
                                            comandos.setInicio("Não");
                                            break;

                                        default:
                                            Console.WriteLine("Resposta inválida!");
                                            Console.ReadLine();
                                            break;
                                    }
                                    break;
                            }
                            Console.Clear();
                            if (i == 1)
                            {
                                player.setPorta1("Passou");
                            }
                            if (i == 2)
                            {
                                player.setPorta2("Passou");
                            }
                            if (i == 3)
                            {
                                player.setPorta3("Passou");
                            }
                            if (i == 4)
                            {
                                player.setPorta4("Passou");
                            }
                        }
                        // If para contagem de portas passadas pelo jogador, definindo se ele será vitorioso ou perdedor
                        if (count == 5)
                        {
                            Console.Clear();
                            Console.WriteLine($"Parabéns {player.getNome()} você ganhou!");
                            player.setPorta5("Passou");
                            player.setVencedor("Ganhou!");
                            jogadores.Add(player);
                            Console.ReadLine();

                            Console.Clear();
                            Console.WriteLine("Obrigado por jogar!");
                            Console.ReadLine();
                            comandos.setInicio("Não");
                        }
                        
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("Perdedor!\n\n\n\n\n\n\n");
                        comandos.setInicio("Não");
                        break;

                    default:
                        Console.WriteLine("Resposta inválida!");
                        break;
                }
            } while (comandos.getInicio() != "Não");

            // Dependencia Microsoft Excel utilizada
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            app.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook wb = app.Workbooks.Add(1);
            Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.Worksheets[1];
            int linha = 2, coluna = 1;


            ws.Cells[1, 1] = "Nome";
            ws.Cells[1, 2] = "Idade";
            ws.Cells[1, 3] = "Sexo";
            ws.Cells[1, 4] = "Porta 1";
            ws.Cells[1, 5] = "Porta 2";
            ws.Cells[1, 6] = "Porta 3";
            ws.Cells[1, 7] = "Porta 4";
            ws.Cells[1, 8] = "Porta 5";
            ws.Cells[1, 9] = "Ganhador";


            jogadores.ForEach(jogador =>
            {

                for (int i = 0; i < 1; i++)
                {
                    ws.Cells[linha, coluna] = jogador.getNome();
                    coluna++;
                }
                for (int i = 0; i < 1; i++)
                {
                    ws.Cells[linha, coluna] = jogador.getIdade();
                    coluna++;
                }
                for (int i = 0; i < 1; i++)
                {
                    ws.Cells[linha, coluna] = jogador.getSexo();
                    coluna++;
                }
                for (int i = 0; i < 1; i++)
                {
                    ws.Cells[linha, coluna] = jogador.getPorta1();
                    coluna++;
                }
                for (int i = 0; i < 1; i++)
                {
                    ws.Cells[linha, coluna] = jogador.getPorta2();
                    coluna++;
                }
                for (int i = 0; i < 1; i++)
                {
                    ws.Cells[linha, coluna] = jogador.getPorta3();
                    coluna++;
                }
                for (int i = 0; i < 1; i++)
                {
                    ws.Cells[linha, coluna] = jogador.getPorta4();
                    coluna++;
                }
                for (int i = 0; i < 1; i++)
                {
                    ws.Cells[linha, coluna] = jogador.getPorta5();
                    coluna++;
                }
                for (int i = 0; i < 1; i++)
                {
                    ws.Cells[linha, coluna] = jogador.getVencedor();
                    coluna++;
                }
                linha++;
                coluna = 1;
            });

        }
    }
}
