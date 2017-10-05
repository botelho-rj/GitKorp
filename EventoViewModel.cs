using System;

namespace Eventos.IO.Aplication.ViewModels
{ 

    public class EventoViewModel
    {
        public EventoViewModel()
        {
            Id = Guid.NewGuid();
            Categoria = new CategoriaViewModel();
        }

        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O Título é requerido")]
        [MinLength(2, ErrorMessage = "O tamanho minimo do Título é {1}")]
        [MaxLength(150, ErrorMessage = "O tamanho máximo do Título é {1}")]
        [Display(Name = "Título do Evento")]
        public string Nome { get; set; }

        public CategoriaViewModel Categoria { get; set; }

        public Guid CategoriaId { get; set; }

        [Display(Name = "Início do Evento")]
        [Required(ErrorMessage = "A data é requerida")]
        public DateTime DataInicio { get; set; }

        [Display(Name = "Horário do Evento")]
        [Required(ErrorMessage = "O Horário é requerido")]
        public TimeSpan HoraInicio { get; set; }

        [Display(Name = "Descricao do Evento")]
        public string Descricao { get; set; }

    }
}
