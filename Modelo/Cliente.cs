﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Local { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Departamento { get; set; }
        public bool Activo { get; set; }
        public string Encargado { get; set; }
    }
}
