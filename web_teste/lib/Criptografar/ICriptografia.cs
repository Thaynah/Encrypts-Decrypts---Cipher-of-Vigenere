using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web_teste.Models;

namespace web_teste.lib
{
    public interface ICriptografia
    {
        string Cri_Vigenere(Conteudo objeto);
    }
}