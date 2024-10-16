﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebConta.Shared.Entities
{
    public class Empresa
    {
        public int Id { get; set; }

        [Display(Name = "Nit Empresa")]
        [MaxLength(15, ErrorMessage = "El campo {0} no puede tener mas de {1} carácteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Nit { get; set; } = null!;

        [Display(Name = "Nombre Empresa")]
        [MaxLength(15, ErrorMessage = "El campo {0} no puede tener mas de {1} carácteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Nombre { get; set; } = null!;

        [Display(Name = "Dirección Empresa")]
        [MaxLength(65, ErrorMessage = "El campo {0} no puede tener mas de {1} carácteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Direccion { get; set; } = null!;

        [Display(Name = "Patrono")]
        [MaxLength(65, ErrorMessage = "El campo {0} no puede tener mas de {1} carácteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Patrono { get; set; } = null!;

        [Display(Name = "Dirección Patrono")]
        [MaxLength(65, ErrorMessage = "El campo {0} no puede tener mas de {1} carácteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string DirecionPatrono { get; set; } = null!;

        [Display(Name = "Número Patronal")]
        [MaxLength(15, ErrorMessage = "El campo {0} no puede tener mas de {1} carácteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string NuimeroPatronal { get; set; } = null!;

        [Display(Name = "Produccion")]
        [MaxLength(01, ErrorMessage = "El campo {0} no puede tener mas de {1} carácteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Produce { get; set; } = null!;

        [Display(Name = "Tipo de saldo")]
        [MaxLength(1, ErrorMessage = "El campo {0} no puede tener mas de {1} carácteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string DebeHaber { get; set; } = null!;

        [Display(Name = "Largo Nivel 1")]
        [MaxLength(01, ErrorMessage = "El campo {0} no puede tener mas de {1} carácteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Nivel1 { get; set; } = null!;

        [Display(Name = "Largo Nivel 2")]
        [MaxLength(01, ErrorMessage = "El campo {0} no puede tener mas de {1} carácteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Nivel2 { get; set; } = null!;

        [Display(Name = "Largo Nivel 3")]
        [MaxLength(01, ErrorMessage = "El campo {0} no puede tener mas de {1} carácteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Nivel3 { get; set; } = null!;

        [Display(Name = "Largo Nivel 4")]
        [MaxLength(1, ErrorMessage = "El campo {0} no puede tener mas de {1} carácteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Nivel4 { get; set; } = null!;

        [Display(Name = "Largo Nivel 5")]
        [MaxLength(01, ErrorMessage = "El campo {0} no puede tener mas de {1} carácteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Nivel5 { get; set; } = null!;

        [Display(Name = "Largo Nivel 6")]
        [MaxLength(01, ErrorMessage = "El campo {0} no puede tener mas de {1} carácteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Nivel6 { get; set; } = null!;

        [Display(Name = "Activo")]
        [MaxLength(11, ErrorMessage = "El campo {0} no puede tener mas de {1} carácteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Activo { get; set; } = null!;

        [Display(Name = "Pasivo")]
        [MaxLength(11, ErrorMessage = "El campo {0} no puede tener mas de {1} carácteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Pasivo { get; set; } = null!;

        [Display(Name = "Capital")]
        [MaxLength(11, ErrorMessage = "El campo {0} no puede tener mas de {1} carácteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Capital { get; set; } = null!;

        [Display(Name = "Ventas")]
        [MaxLength(11, ErrorMessage = "El campo {0} no puede tener mas de {1} carácteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Ventas { get; set; } = null!;

        [Display(Name = "Costos")]
        [MaxLength(11, ErrorMessage = "El campo {0} no puede tener mas de {1} carácteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Costos { get; set; } = null!;

        [Display(Name = "Gastos")]
        [MaxLength(11, ErrorMessage = "El campo {0} no puede tener mas de {1} carácteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Gastos { get; set; } = null!;

        [Display(Name = "Otros Ingresos")]
        [MaxLength(11, ErrorMessage = "El campo {0} no puede tener mas de {1} carácteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string OtrosIngresos { get; set; } = null!;

        [Display(Name = "OtrosGastos")]
        [MaxLength(11, ErrorMessage = "El campo {0} no puede tener mas de {1} carácteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string OtrosGastos { get; set; } = null!;

        [Display(Name = "Produccion")]
        [MaxLength(11, ErrorMessage = "El campo {0} no puede tener mas de {1} carácteres")]
        public string Produccion { get; set; }

        [Display(Name = "Porcentaje IVA")]
        [Range(0.01, 100.00, ErrorMessage = "El campo {0} no puede tener mas de {1} carácteres")]
        public double PorcentajeIva { get; set; }

        [MaxLength(05)]
        public string? ActMesAct { get; set; }

        [MaxLength(05)]
        public string? BanMesAct { get; set; }

        [MaxLength(05)]
        public string? ComMesAct { get; set; }

        [MaxLength(05)]
        public string? ConMesAct { get; set; }

        [MaxLength(05)]
        public string? CxcMesAct { get; set; }

        [MaxLength(05)]
        public string? CxpMesAct { get; set; }

        [MaxLength(05)]
        public string? IvaMesAct { get; set; }

        [MaxLength(05)]
        public string? PlaMesAct { get; set; }
    }
}