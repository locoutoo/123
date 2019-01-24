using System.Collections;
using System.Collections.Generic;
using EsteCarII.Models;

namespace EsteCarII.Services
{
    public interface IAlugueresHoje
    {
        IEnumerable<Aluguer> AlgueresHoje { get; }
    }
}