﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp.Restaurante.Domain.Entities
{
    public class Mercaderia
    {
        public int MercaderiaId { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Nombre { get; set; }

        public int Precio { get; set; }

        [Required]
        [Column(TypeName = "varchar(255)")]
        public string Ingredientes { get; set; }

        [Required]
        [Column(TypeName = "varchar(255)")]
        public string Preparacion { get; set; }

        [Required]
        [Column(TypeName = "varchar(255)")]
        public string Imagen { get; set; }

        public int TipoMercaderiaId { get; set; }

        public TipoMercaderia TipoMercaderiaNavigator { get; set; }

        public IList<ComandaMercaderia> ComandaMercaderiasNavigator { get; set; }







    }
}
