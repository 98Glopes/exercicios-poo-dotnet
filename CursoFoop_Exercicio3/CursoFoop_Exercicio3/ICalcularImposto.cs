using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CursoFoop_Exercicio3
{
    public interface ICalcularImposto
    {
        decimal Calcular(decimal valor, decimal deducao);
    }
}
