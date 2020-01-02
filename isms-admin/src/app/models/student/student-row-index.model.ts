export class StudentRowIndexModel{
    id: Number;
    studentCode: string;
    nameFirst: string;
    nameMiddle: string;
    nameLast: string;
    facultyName: string;
    majorName: string;
    email: string;
    phoneNumber:string;
    studyStatus: string;
    tuitionStatus: string;
    
    constructor(obj: any){
        Object.assign(this,obj);
    }  
}
