﻿using DashTelecom.Domain.Intefaces;
using DashTelecom.Domain.Models;
using DashTelecom.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DashTelecom.Infrastructure.Repository
{
    public class TabTelecomConsolidadoRepository : Repository<TabTelecomConsolidado>, ITabTelecomConsolidadoRepository
    {
        public TabTelecomConsolidadoRepository(MeuDbContext context) : base(context) { }

        public async Task<IEnumerable<TabTelecomConsolidado>> ObterTelecomConsolidado()
        {
            var TelecomConsolidado = await Db.TabTelecomConsolidado.AsNoTracking().ToListAsync(); //processo somente com id para carregar
            return TelecomConsolidado;
        }
    }
}
