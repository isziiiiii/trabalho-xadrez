
using System;
using System.IO;
using System.Windows.Forms;

public class ArquivoJogo
{
    private string caminhoArquivo = "jogadas.txt";  // Nome correto do arquivo
    
    public void SalvarJogadas(Peça[,] grid)
    {
        string caminho = "jogadas.txt";
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                Peça entrada = grid[i, j];

                if (i == 0 && j == 0)
                {
                    File.AppendAllText(caminho, entrada.ToString());
                }
                else
                {
                    File.AppendAllText(caminho, "," + entrada.ToString());
                }
            }
        }

        File.AppendAllText(caminho, Environment.NewLine);
        MessageBox.Show($"{DateTime.Now} : Jogada salva com sucesso!");
    }

    public void CarregarJogadas()
    {
        if (File.Exists(caminhoArquivo))
        {
            string[] linhas = File.ReadAllLines(caminhoArquivo);
            string[] jogadas = linhas[0].Split(',');

            int index = 0;
            

            MessageBox.Show("Jogada carregada com sucesso!");
        }
        else
        {
            MessageBox.Show("Jogo reiniciado");
        }
    }   
    
}