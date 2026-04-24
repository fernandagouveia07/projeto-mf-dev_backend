using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_mf.Models
{
	[Table("Veiculos")]
	public class Veiculo
	{ 
		[Key]
		public int Id { get; set; }

		[Required(ErrorMessage ="Informe seu nome")]
		public string Nome { get; set; }

        [Required(ErrorMessage = "Informe sua placa")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "Informe o ano de fabricação")]
        [Display(Name = "Ano de Fabricação")]
        public int AnoFabricacao { get; set; }

        [Required(ErrorMessage = "Informe o ano do modelo.")]
        [Display(Name = "Ano do Modelo")]
        public int AnoModelo { get; set; }
    }
}

