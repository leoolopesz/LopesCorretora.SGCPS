﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LopesCorretora.SGCPS.Business;
using LopesCorretora.SGCPS.Models;
using LopesCorretora.SGCPS.ViewsModels;
using LopesCorretora.SGCPS.UI;

namespace LopesCorretora.SGCPS.UI.Controllers
{
    public class FinanceiroController : Controller
    {
        public IActionResult BalancoAnual()
        {
            return View();
        }

        public IActionResult BalancoMensal()
        {
            return View();
        }

        public IActionResult ControleDespesas()
        {
            return View();
        }

        public IActionResult DarBaixa()
        {
            return View();
        }

        public IActionResult Financeiro()
        {
            return View();
        }
    }
}