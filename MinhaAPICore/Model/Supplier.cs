using System;
using System.ComponentModel.DataAnnotations;

namespace MinhaAPICore.Model
{
    public class Supplier
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage =  "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(14,ErrorMessage = "Ocampo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 11)]
        public string Document { get; set; }
        public int SupplierType { get; set; }
        public bool Active { get; set; }


    }
}
