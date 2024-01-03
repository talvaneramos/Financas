using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financas.Domain.Dtos
{
    public class CriarCategoriaDto
    {
        [LengthAttribute(8, 100, ErrorMessage = "Informe o nome de {1} a {2} caracteres.")]
        [Required(ErrorMessage = "Informe o nome da categoria.")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Informe a descrição.")]
        public string? Descricao { get; set; }
    }
}
