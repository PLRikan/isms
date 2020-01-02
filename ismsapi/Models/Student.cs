using System;
using System.Collections.Generic;

namespace ismsapi.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public int FacultyId { get; set; }
        public int MajorStudentId { get; set; }
        public int BankAccountId { get; set; }
        public int EducateTypeId { get; set; }
        public int StudyTypeId { get; set; }
        public int StudyStatusId { get; set; }
        public int RoleGroupId { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string StudentCode { get; set; }
        public string Password { get; set; }
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

        public virtual BankAccount BankAccount { get; set; }
        public virtual EducateType EducateType { get; set; }
        public virtual Faculty Faculty { get; set; }
        public virtual MajorStudent MajorStudent { get; set; }
        public virtual RoleGroup RoleGroup { get; set; }
        public virtual StudyStatus StudyStatus { get; set; }
        public virtual StudyType StudyType { get; set; }
    }
}
