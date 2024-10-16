﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebConta.Shared.Entities
{
    public class Cuenta
    {
        public int Id { get; set; }

        public int EmpresaId { get; set; }

        public Empresa? Empresa { get; set; }

        [Display(Name = "Codigo contable")]
        [MaxLength(11, ErrorMessage = "El campo {0} no puede tener mas de {1} carácteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Codigo { get; set; } = null!;

        [Display(Name = "Nombre de la cuenta")]
        [MaxLength(65, ErrorMessage = "El campo {0} no puede tener mas de {1} carácteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Nombre { get; set; } = null!;

        [Display(Name = "Tipo de saldo")]
        [MaxLength(1, ErrorMessage = "El campo {0} no puede tener mas de {1} carácteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string DebeHaber { get; set; } = null!;

        public int? Saldo { get; set; }
        public int? Cargos { get; set; }
        public int? Abonos { get; set; }
        public int? SaldoMes { get; set; }
        public int? CargosMes { get; set; }
        public int? AbonosMes { get; set; }
        public int? SaldoCierre { get; set; }

        [Display(Name = "Codigo Cuenta Mayor")]
        [MaxLength(11, ErrorMessage = "El campo {0} no puede tener mas de {1} carácteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string CodigoMayor { get; set; } = null!;

        [Display(Name = "Codigo Presupuesto")]
        [MaxLength(11, ErrorMessage = "El campo {0} no puede tener mas de {1} carácteres")]
        public string? CodigoPres { get; set; }

        public string? IngresoCash { get; set; }
        public string? EgresoCash { get; set; }
    }
}