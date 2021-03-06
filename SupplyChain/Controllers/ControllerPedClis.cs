﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace SupplyChain
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedClisController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PedClisController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<PedCli> Get(string CAMPO)
        {
            try
            {
                string xSQL = string.Format("select CG_ESTADO, CG_ART from Pedcli WHERE PEDIDO = 51767 ");
                return _context.PedCli.FromSqlRaw(xSQL).ToList<PedCli>();
            }
            catch
            {
                return new List<PedCli>();
            }
        }
    }
}