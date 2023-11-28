/*
- Corrigir algoritmo de descriptografar
- Substituir palíndromos, mostrar palíndromos encontrados
- Imprimir quantidade de palavras
*/

// Alan Jhosep Montanari Jutel
using System.Text;

internal class Program
{
    public Program()
    {
        string str = "Lu0s z q0tm0uƒ€q~x ƒ40t ‚uy~t (~ 0†w|q~„mPe}q(†ytq(q‚q‚i0…}0uy~…„w0y‚‚m|u†qv„uPeu0q„qy…u0tm0 † (u}0†é‚yqƒ(s ‚u{0u0„i}q~xwƒPTqvt 0ri|qƒ0m0sywi‚‚ ƒ(u0sqz ~qƒ(q0uƒ|‚q~xwƒPSqz‚ ƒ0wƒƒ 0lyŠu~l 0ƒyuP_0ƒq~q|0o‚y„qvt 0~ë PTu~u0ƒuz0yƒƒw0 …u(sxq}i}0tu(‚uƒƒ}‚uy÷ë PPSi€y„qt0Y~ykyq|PZuƒƒ…z‚uy÷ë ";
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