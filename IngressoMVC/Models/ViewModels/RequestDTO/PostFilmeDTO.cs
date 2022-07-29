using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Models.ViewModels.RequestDTO
{
    public class PostFilmeDTO
    {
        [Required(ErrorMessage = "Nome do Filme é Obrigatório!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Filme deve ter no máximo 50 caracters, e no mínimo 3")]
        public string Titulo { get; set; }

        public string Descricao { get; set; }

        [Required(ErrorMessage = "O valor do filme é obrigatório")]
        public decimal Preco { get; set; }
        //Não consegui pensar muito sobre como definir se o valor não poderia ser aceito caso fosse menor que 0.0 

        [Required(ErrorMessage = "Imagem obrigatória")]
        public string ImageURL { get; set; }

        #region relacionamentos
        public string NomeCinema { get; set; }

        public int ProdutorId { get; set; }

        public List<int> AtoresId { get; set; }
        public List<int> CategoriasId { get; set; } //Por Id
        #endregion
    }
}
