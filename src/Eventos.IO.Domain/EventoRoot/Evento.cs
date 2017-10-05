using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FluentValidation;
using Eventos.IO.Domain.Core.Models;

namespace Eventos.IO.Domain.EventoRoot
{
    public class Evento : Entity<Evento>
    {
        public string Titulo { get; private set; }
        public DateTime DataInicio { get; private set; }
        public TimeSpan HoraInicio { get; private set; }
        public bool Reservada { get; private set; }
        public string Descricao { get; private set; }
        public ICollection<Tags> Tags { get; private set; }
        public Guid CategoriaId { get; private set; }

        //propriedades de navegação

        public virtual Categoria Categoria { get; private set; }
    

        public Evento(string titulo, Guid categoriaId, DateTime dataInicio, TimeSpan horaInicio)
        {
            Id = Guid.NewGuid();
            this.Titulo = titulo;
            this.CategoriaId = categoriaId;
            this.DataInicio = dataInicio;
            this.HoraInicio = horaInicio;
            
        }

        private Evento(){}

        public void AtribuirCategoria(Categoria categoria)
        {
            if (!categoria.EhValido()) return;
            Categoria = categoria;

        }


        public override bool EhValido()
        {
            Validar();
            return ValidationResult.IsValid;
        }


        public void Validar()
        {
            RuleFor(c => c.Titulo)
                .NotEmpty().WithMessage("O título do evento deve ser fornecido.")
                .Length(2, 150).WithMessage("O título precisa conter de 2 a 150 caracteres.");

            RuleFor(c => c.DataInicio)
                .NotEmpty().WithMessage("A data do evento deve ser fornecida.");

            RuleFor(c => c.HoraInicio)
                .NotEmpty().WithMessage("A hora do evento deve ser fornecida."); 

            ValidationResult = Validate(this);
        }



        public static class EventoFactory
        {
             
            public static Evento NovoEventoCompleto(Guid id, string titulo, Guid? categoriaId, DateTime dataInicio, TimeSpan horaInicio, string descricao)
            {
                var evento = new Evento() {Id = id, Titulo = titulo, DataInicio = dataInicio, HoraInicio = horaInicio, Descricao = descricao};
                
                if(categoriaId!= null)
                    evento.Categoria = new Categoria(categoriaId.Value);

                return evento;
            }

   
        }



    }


}
