
export class StudentDetail{
    id: number;
    facultyId: number;
    facultyName: string;
    majorStudentId: number;
    majorStudentName: string;
    bankAccountId: number;
    tutionStatusId: number;
    tutionStatusName: string;
    accountNumber: string;
    bankName: string;
    tutionDebt: number;
    educateTypeId: number;
    educateType: string;
    studyTypeId: number;
    studyType: string;
    studyStatusId: number;
    studyStatus: string;
    roleGroupId: number;
    roleGroupName: string;
    email: string;
    phoneNumber: string;
    studentCode: string;
    avatar: string;
    nameFirst: string;
    nameMiddle: string;
    nameLast: string;
    addressApartment: string;
    addressStreet: string;
    addressDistrict: string;
    addressCity: string;
    dateStart: Date;
    dateEnd: Date;
    dateGraduate: Date;

    constructor(obj: any){
        Object.assign(this,obj);
    }  
}