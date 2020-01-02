import { EventStatusModel } from '../event-status/event-status.model';

export class EventModel {
    id: number;
    eventStatusId: number;
    eventStatusName: string;
    name: string;
    thumbnail: string;
    content: string;
    dateStart: Date;
    dateEnd: Date;

    constructor(obj: any){
        Object.assign(this,obj);
    }  
}