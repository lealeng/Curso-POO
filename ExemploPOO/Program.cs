using System;
using System.Collections.Generic;
using System.IO;
using ExemploPOO.Helper;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;



namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var caminho = "C:\\workspace\\POO\\Arquivos";
            var CaminhoPathCombine = Path.Combine(caminho, "Teste1");
            var caminhoArquivo = Path.Combine(caminho, "arquivo-teste-string.txt");
            var caminhoArquivoTeste = Path.Combine(caminho, "arquivo-teste.txt");
            var caminhoArquivoTesteCopia = Path.Combine(caminho, "arquivo-teste-backup.txt");
            var novoCaminhoArquivo = Path.Combine(caminho, "Pasta teste 3", "arquivo-teste-stream.txt");
            
            var listaString = new List<string> {"Linha 1", "Linha 2", "Linha 3" };
            var listaStringContinuacao = new List<string> {"Linha 4", "Linha 5", "Linha 6" };

            FileHelper helper = new FileHelper();
           // helper.ListarDiretorios(caminho);
         //   helper.ListarArquivosDiretorios(caminho);
           // System.Console.WriteLine("Criando diretório: " + CaminhoPathCombine);
           // helper.CriarDiretorio(CaminhoPathCombine);
            //helper.ApagarDiretorio(CaminhoPathCombine, true);
          //  helper.CriarArquivoTexto(caminhoArquivo, "Olá! Teste de escrita de arquivo");
         //   helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
           // helper.AdicionarTextoStream(caminhoArquivo, listaStringContinuacao);
         //   helper.LerArquivoStream(caminhoArquivo);
        //  helper.MoverArquivo(caminhoArquivo, novoCaminhoArquivo, false);
         //   helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);
            helper.DeletarArquivo(caminhoArquivoTesteCopia);
            
            // ICalculadora calc = new Calculadora();
            // System.Console.WriteLine(calc.Somar(10, 20));


            // Computador pc = new Computador();
            // System.Console.WriteLine(pc.ToString());

            // Corrente cc = new Corrente();
            // cc.Creditar(100);

            // cc.ExibirSaldo();
    

            // Calculadora calc = new Calculadora();
            // System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar(10, 10));
            // System.Console.WriteLine("Resultado da segunda soma: " + calc.Somar(10, 10, 10));


            //  Aluno p1 = new Aluno();
            //  p1.Nome = "Daniel"; 
            //  p1.Idade = 25;
            //  p1.Nota = 9;
            
            //  p1.Apresentar();

            //  Professor p2 = new Professor();
            //  p2.Nome = "Leal"; 
            //  p2.Idade = 25;
            //  p2.Salario = 9;
            
            //  p2.Apresentar();


            // //VALORES VÁLIDOS
            // Retangulo r = new Retangulo();
            // r.DefinirMedidas(30, 30);
            // System.Console.WriteLine($"Área: {r.ObterArea()}");            


            // //VALORES INVÁLIDOS
            // Retangulo r2 = new Retangulo();
            // r2.DefinirMedidas(0, 0);
            // System.Console.WriteLine($"Área: {r2.ObterArea()}"); 
            
            // Pessoa p1 = new Pessoa();
            // p1.Nome = "Daniel"; 
            // p1.Idade = 25;
            
            // p1.Apresentar();

        }
    }
}