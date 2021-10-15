using System;
using System.Linq;
using UbuntoWar.Controller;
using UbuntoWar.Entities;

namespace UbuntoWar
{
    class Program
    {
        static void Main(string[] args)
        {
            Comandos comandos = new Comandos();
            Jogador player = new Jogador();
            Porta porta = new Porta();

            var count = 0;
            var avanco = 0;
            var portaEscolhida = "";
            var proximaporta = comandos.sortPorta();

            Console.WriteLine("Deseja participar do jogo?\n(1-Sim/2-Não)");
            comandos.setInicio(Console.ReadLine());

            do
            {
                Console.Clear();
                switch (comandos.getInicio())
                {
                    case "1":
                        Console.WriteLine("Bem-vindo!\n\nDigite seu nome!");
                        player.setNome(Console.ReadLine());
                        Console.Clear();

                        Console.WriteLine("Digite sua idade!");
                        player.setIdade(Int32.Parse(Console.ReadLine()));
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
                            do
                            {
                                proximaporta = comandos.sortPorta();
                                //for (int n = 0; n < 3; n++)
                                //{
                                //    Console.WriteLine(proximaporta[n]);
                                //}
                                portaEscolhida = Console.ReadLine();
                                Console.Clear();

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
                            switch (avanco)
                            {
                                case 1:
                                    ++count;
                                    Console.WriteLine("Parabéns! Você avançou para próxima etapa!");
                                    Console.ReadLine();
                                    break;
                                default:
                                    i = 5;
                                    Console.WriteLine("Você morreu!\n\n");
                                    Console.WriteLine("Deseja reiniciar o jogo? (1-Sim/2-Não)");
                                    comandos.setReiniciar(Console.ReadLine());
                                    Console.Clear();
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
                        }
                        if (count == 5)
                        {
                            Console.Clear();
                            Console.WriteLine($"Parabéns {player.getNome()} você ganhou!");
                            Console.ReadLine();

                            Console.Clear();
                            Console.WriteLine("Deseja jogar novamente?\n(1-Sim/2-Não)");
                            comandos.setInicio(Console.ReadLine());
                            Console.Clear();
                            switch (comandos.getInicio())
                            {
                                case "1":
                                    comandos.setInicio("Sim");
                                    break;
                                case "2":
                                    Console.Clear();
                                    Console.WriteLine("Obrigado por jogar!");
                                    Console.ReadLine();
                                    comandos.setInicio("Não");

                                    Console.Clear();
                                    break;
                            }
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
        }
    }
}
