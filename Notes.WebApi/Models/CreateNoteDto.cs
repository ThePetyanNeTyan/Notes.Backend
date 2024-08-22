﻿using AutoMapper;
using Notes.Application.Common.Mappings;
using Notes.Application.Notes.Commands.CreateNote;

namespace Notes.WebApi.Models
{
    public class CreateNoteDto : IMapWith<CreateNoteCommand>
    {
        public string Title { get; set; }
        public string Details { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateNoteDto, CreateNoteCommand>()
                .ForMember(noteCommand => noteCommand.Title,
                opt => opt.MapFrom(noteDto => noteDto.Title))
                .ForMember(noteCommand => noteCommand.Details,
                opt => opt.MapFrom(noteDto => noteDto.Details));
        }
    }
}
