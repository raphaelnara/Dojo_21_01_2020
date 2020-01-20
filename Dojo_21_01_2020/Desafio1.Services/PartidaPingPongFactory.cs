﻿using System;
using Desafio1.Model;
using Desafio1.Services.Interfaces;

namespace Desafio1.Services
{
    public class PartidaPingPongFactory : IPartidaFactory
    {
        public Partida CriarPartida()
        {
            string jogador1, jogador2, jogador3, jogador4;
            do
            {
                Console.WriteLine("Entre com o jogador 1 para a dupla 1:");
                jogador1 = Console.ReadLine();

                if (string.IsNullOrEmpty(jogador1))
                    Console.WriteLine("Valor inválido!");
            }
            while (string.IsNullOrEmpty(jogador1));

            do
            {
                Console.WriteLine("Entre com o jogador 2 para a dupla 1:");
                jogador2 = Console.ReadLine();

                if (string.IsNullOrEmpty(jogador2))
                    Console.WriteLine("Valor inválido!");
            }
            while (string.IsNullOrEmpty(jogador2));

            do
            {
                Console.WriteLine("Entre com o jogador 1 para a dupla 2:");
                jogador3 = Console.ReadLine();

                if (string.IsNullOrEmpty(jogador3))
                    Console.WriteLine("Valor inválido!");
            }
            while (string.IsNullOrEmpty(jogador3));

            do
            {
                Console.WriteLine("Entre com o jogador 2 para a dupla 2:");
                jogador4 = Console.ReadLine();

                if (string.IsNullOrEmpty(jogador4))
                    Console.WriteLine("Valor inválido!");
            }
            while (string.IsNullOrEmpty(jogador4));

            return new Partida
            {
                Dupla1 = new Dupla
                {
                    Jogador1 = jogador1,
                    Jogador2 = jogador2
                },
                Dupla2 = new Dupla
                {
                    Jogador1 = jogador3,
                    Jogador2 = jogador4
                },
            };
        }
    }
}