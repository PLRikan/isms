export class ContactsModel {
    public Id : number;
    public Email : string;
    public NameFirst: string;
    public NameMiddle: string;
    public NameLast: string;
    public Title: string;
    public Content: string;
    public DateSend: Date;
    constructor(Id: number, Email: string, NameFirst: string, NameMiddle: string, NameLast: string, Title: string, Content: string, DateSend: Date){
        this.Id = Id;
        this.Email = Email;
        this.NameFirst = NameFirst;
        this.NameMiddle = NameMiddle;
        this.NameLast = NameLast;
        this.Title = Title;
        this.Content = Content;
        this.DateSend = DateSend;
    }
}