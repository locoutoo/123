using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EsteCarII.Data;
using EsteCarII.Migrations;
using EsteCarII.Models;
using Microsoft.EntityFrameworkCore;

namespace EsteCarII.Services
{
    public class AlugueresHoje : IAlugueresHoje
    {
        private readonly ApplicationDbContext _context;

        public AlugueresHoje(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Aluguer> AlgueresHoje
        {
            get
            {
                return _context.Aluguer
                    .Include(a => a.Carro)
                    .Include(a => a.Cliente)
                    .Where(a => a.DataInicio.Day == DateTime.Today.Day);
            }
        }
    }
}
