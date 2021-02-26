using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUD.Models
{
    [MetadataType(typeof(AULA_MDT))]
    public partial class AULA_MD{}

    public class AULA_MDT
    {
        [DisplayName("Código")]
        public int AulaId { get; set; }
        [DisplayName("Descrição")]
        [Required(ErrorMessage ="Campo Obrigatório.")]
        [StringLength(9, MinimumLength =4,ErrorMessage ="Minímo de 4 caracteres e no máximo de 9 caracteres.")]
        public string AulaDescricao { get; set; }
    }
}