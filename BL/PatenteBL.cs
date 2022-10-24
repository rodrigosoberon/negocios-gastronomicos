﻿using System.Collections.Generic;
using BE;
using DAL;

namespace BL
{
    public class PatenteBL
    {
        public List<Patente> Listar()
        {
            return PatenteDAL.Listar();
        }
        public int GuardarNuevo(Patente pPatente)
        {
            return PatenteDAL.GuardarNuevo(pPatente);
        }

        public int Modificar(Patente pPatente)
        {
            return PatenteDAL.Modificar(pPatente);
        }

        public int Borrar(Patente pPatente)
        {
            return PatenteDAL.Borrar(pPatente);
        }
    }
}
