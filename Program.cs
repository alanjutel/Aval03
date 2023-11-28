/*
- Substituir palíndromos, mostrar palíndromos encontrados
- Imprimir quantidade de palavras
*/

// Alan Jhosep Montanari Jutel
using System.Text;

internal class Program
{
    public Program()
    {
        string str = File.ReadAllText("provinhaBarbadinha.txt");
        StringBuilder auxTexto = new StringBuilder();

        for (int i = 0; i < str.Length; i++)
        {
            int chave = DeTeusPulos(i);
            int num = Convert.ToInt16(str[i]) - chave;
            auxTexto.Append((char)num);
        }

        auxTexto.Replace("@", "\n");

        Console.WriteLine("Número de caracteres: " + auxTexto.Length);

        Console.WriteLine(auxTexto.ToString().ToUpper());

    }

    public int DeTeusPulos(int indice)
    {
        if (indice % 5 == 0)
        {
            return 8;
        }
        else
        {
            return 16;
        }
    }

    public bool ChecarPalindromo(StringBuilder auxTexto)
    {
        for (int i = 0; i < auxTexto.Length - 4; i++)
        {
            for (int j = i + 4; j < auxTexto.Length; j++)
            {
                if (auxTexto[i] == auxTexto[j])
                {
                    if (auxTexto[i + 1] == auxTexto[j - 1])
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        return false;
    }

    private static void Main(string[] args)
    {
        var prog = new Program();
    }
}