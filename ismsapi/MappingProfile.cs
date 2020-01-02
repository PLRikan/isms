using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ismsapi
{
    public class MappingProfile: AutoMapper.Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<Models.Event, ViewModel.EventDetail>()
                .ForMember(dest => dest.EventStatusName, opt => opt.MapFrom(e => e.EventStatus.Status));
   
            CreateMap<Models.Student, ViewModel.StudentRowIndex>()
                .ForMember(dest => dest.FacultyName, opt => opt.MapFrom(s => s.Faculty.Name))
                .ForMember(dest => dest.MajorName, opt => opt.MapFrom(s => s.MajorStudent.Major))
                .ForMember(dest => dest.StudyStatus, opt => opt.MapFrom(s => s.StudyStatus.Status))
                .ForMember(dest => dest.TuitionStatus, opt => opt.MapFrom(s => s.BankAccount.TutionStatusNavigation.Id));
            
            CreateMap<Models.Student, ViewModel.StudentDetail>()
                .ForMember(dest => dest.FacultyName, opt => opt.MapFrom(s => s.Faculty.Name))
                .ForMember(dest => dest.MajorStudentName, opt => opt.MapFrom(s => s.MajorStudent.Major))
                .ForMember(dest => dest.StudyStatus, opt => opt.MapFrom(s => s.StudyStatus.Status))
                .ForMember(dest => dest.TutionStatusId, opt => opt.MapFrom(s => s.BankAccount.TutionStatus))
                .ForMember(dest => dest.TutionStatusName, opt => opt.MapFrom(s => s.BankAccount.TutionStatusNavigation.Status))
                .ForMember(dest => dest.AccountNumber, opt => opt.MapFrom(s => s.BankAccount.AccountNumber))
                .ForMember(dest => dest.BankName, opt => opt.MapFrom(s => s.BankAccount.BankName))
                .ForMember(dest => dest.TutionDebt, opt => opt.MapFrom(s => s.BankAccount.TutionDebt))
                .ForMember(dest => dest.EducateType, opt => opt.MapFrom(s => s.EducateType.Type))
                .ForMember(dest => dest.StudyType, opt => opt.MapFrom(s => s.StudyType.Type))
                .ForMember(dest => dest.StudyStatus, opt => opt.MapFrom(s => s.StudyStatus.Status))
                .ForMember(dest => dest.RoleGroupName, opt => opt.MapFrom(s => s.RoleGroup.Name));
        }
    }
}
