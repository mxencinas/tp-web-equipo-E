﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        public int IdArticulos { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public Marca Marca {  get; set; }
        public Categoria Categoria { get; set; }
        public List<Imagen> Imagenes { get; set; }
        public string ImagenPrincipal
        {
            get
            {
                return (Imagenes is null || Imagenes.Count <= 0) ? "./img/img-premio.jpg" : Imagenes[0].Url;
            }
        }

    }
}
