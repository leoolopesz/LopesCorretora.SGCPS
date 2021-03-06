﻿using System;
using System.Collections.Generic;
using System.Text;
using LopesCorretora.SGCPS.Repository.DataAccess;
using LopesCorretora.SGCPS.Models;
using System.Linq;

namespace LopesCorretora.SGCPS.Repository
{
    public class PlanoRPO
    {
        public static void Alterar(PlanoMOD planoMOD)
        {
            try
            {
                using (SGCPSContext context = new SGCPSContext())
                {
                    context.Planos.Update(planoMOD);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void Cadastrar(PlanoMOD planoMOD)
        {
            try
            {
                using (SGCPSContext context = new SGCPSContext())
                {
                    context.Planos.Add(planoMOD);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public static PlanoMOD Consultar(int Id)
        {
            try
            {
                using (SGCPSContext context = new SGCPSContext())
                {
                    return context.Planos.Where(x => x.Id == Id).First();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<PlanoMOD> Listar()
        {
            try
            {
                using (SGCPSContext context = new SGCPSContext())
                {
                    return context.Planos.ToList();
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
