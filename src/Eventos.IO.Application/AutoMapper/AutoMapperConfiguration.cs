using System;
using AutoMapper;
using Eventos.IO.Application.ViewModels;
using Eventos.IO.Domain.EventoRoot;
using Eventos.IO.Domain.EventoRoot.Commands;

namespace Eventos.IO.Application.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(ps =>
            {
                ps.AddProfile(new DomainToViewModelMappingProfile());
                ps.AddProfile(new ViewModelToDomainMappingProfile());
            });
        }
    }

    
    internal class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<EventoViewModel, RegistrarEventoCommand>()
                .ConstructUsing(c => new RegistrarEventoCommand(c.Titulo, c.CategoriaId, c.DataInicio, c.HoraInicio));

            CreateMap<EventoViewModel, ExcluirEventoCommand>()
                .ConstructUsing(c => new ExcluirEventoCommand(c.Id));
            //
        }
    
    }
    
    internal class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Evento, EventoViewModel>();
            CreateMap<Categoria, CategoriaViewModel>();

        }
    }
}