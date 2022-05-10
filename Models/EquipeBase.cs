using System.IO;
using System.Runtime.InteropServices;
using EJOGOS.Models;

namespace EJOGOS.Models
{
    public class EquipeBase
    {
        public void CriarPastaOuArquivo(string caminho)
        {
            string pasta = caminho.Split('/')[0];

           
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            if (!File.Exists(caminho))
            {
                File.Create(caminho);
            }
        }
    }
}