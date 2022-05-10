using EJOGOS.Models;
using System.Collections.Generic;
using System.Runtime.InteropServices;
namespace EJOGOS.Interface
{
    public interface IEquipes
    {
        void Criar(Equipes novaEquipe);

        List<Equipes> LerEquipes();
    }
}