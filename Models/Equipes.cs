using System.Runtime.InteropServices;
using EJOGOS.Models;
using System.Collections.Generic;
using EJOGOS.Controllers;
using EJOGOS.Interface;
using System.IO;

namespace EJOGOS.Models
{
    public class Equipes : EquipeBase, IEquipes
    {
        public int IDEquipe { get; set; }
        public string Nome { get; set; }
        public string Imagem { get; set; }


        private const string caminhobd = "DataBase/equipe.csv";

        public Equipes()
        {
            Nome = "Nome não identificado";
            CriarPastaOuArquivo(caminhobd);
        }


        string Preparar(Equipes e)
        {
            return $"{e.IDEquipe};{e.Nome};{e.Imagem}";
        }


        public void Criar(Equipes novaEquipe)
        {
            string[] equipe_texto = { Preparar(novaEquipe) };
            File.AppendAllLines(caminhobd, equipe_texto);
        }

        public List<Equipes> LerEquipes()
        {
            List<Equipes> listaEquipes = new List<Equipes>();
            string[] linhas = File.ReadAllLines(caminhobd);

            foreach (string item in linhas)
            {
                // 1; nome da equipe;  caminho da imagem
                string[] linhaEquipe = item.Split(';');

                Equipes equipeAtual = new Equipes();
                equipeAtual.IDEquipe = int.Parse(linhaEquipe[0]);
                equipeAtual.Nome = linhaEquipe[1];
                equipeAtual.Imagem = linhaEquipe[2];

                listaEquipes.Add(equipeAtual);
            }

            return listaEquipes;
        }
    }
}