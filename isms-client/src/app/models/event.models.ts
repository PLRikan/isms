export class EventModel{
    public Id : number;
    public EventStatusId : number;
    public Name : string;
    public Thumbnail : string;
    public Content : string;
    public DateStart : Date;
    public DateEnd : Date;
    constructor(Id: number, EventStatusId: number, Name: string, Thumbnail: string, Content: string, DateStart: Date, DateEnd: Date) {
        this.Id = Id;
        this.EventStatusId = EventStatusId;
        this.Name = Name;
        this.Thumbnail = Thumbnail;
        this.Content = Content;
        this.DateStart = DateStart;
        this.DateEnd = DateEnd;
    }
}