using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ismsapi.ViewModel
{
    public class StudentDetail
    {
        public int Id { get; set; }
        public int FacultyId { get; set; }
        public string FacultyName { get; set; }
        public int MajorStudentId { get; set; }
        public string MajorStudentName { get; set; }
        public int BankAccountId { get; set; }
        public int TutionStatusId { get; set; }
        public string TutionStatusName { get; set; }
        public string AccountNumber { get; set; }
        public string BankName { get; set; }
        public int TutionDebt { get; set; }
        public int EducateTypeId { get; set; }
        public string EducateType { get; set; }
        public int StudyTypeId { get; set; }
        public int StudyType { get; set; }
        public int StudyStatusId { get; set; }
        public string StudyStatus { get; set; }
        public int RoleGroupId { get; set; }
        public int RoleGroupName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string StudentCode { get; set; }
        public string Avatar { get; set; }
        public string NameFirst { get; set; }
        public string NameMiddle { get; set; }
        public string NameLast { get; set; }
        public string AddressApartment { get; set; }
        public string AddressStreet { get; set; }
        public string AddressDistrict { get; set; }
        public string AddressCity { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public DateTime? DateGraduate { get; set; }
    }
}
