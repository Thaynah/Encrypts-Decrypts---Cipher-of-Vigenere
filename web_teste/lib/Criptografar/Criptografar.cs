using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using web_teste.Models;

namespace web_teste.lib
{
    public class Criptografar : ICriptografia
    {
        public string Cri_Vigenere(Conteudo conteudo)
        {
            var codigo = "";

            for (int i = 0, j = 0; i < conteudo.Texto.Length; i++, j++)
            {
                char c = char.ToUpper(conteudo.Texto[i]);

                if (c < 'A' || c > 'Z')
                {
                    continue;
                }

                codigo += (char)((c + char.ToUpper(conteudo.GetPalavraChave[j % conteudo.GetPalavraChave.Length]) - 2 * 'A') % 26 + 'A');
            }

            return codigo;
        }

    }
}