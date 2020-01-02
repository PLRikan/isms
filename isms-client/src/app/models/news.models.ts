export class NewsModel {
    public id : number;
    public adminId: number;
    public postStatusId: number;
    public categoryId: number;
    public thumbnail: string;
    public title: string;
    public content: string;
    public dateCreate: Date;
    public dateModify: Date;
    public admin: any;
    public category: any;
    public postStatus: any;
    constructor(id: number, adminId: number, postStatusId : number, categoryId: number, thumbnail: string, title : string, content: string, dateCreate: Date, dateModify: Date, admin: any, category: any, postStatus: any) {
        this.id = id;
        this.adminId = adminId;
        this.postStatusId = postStatusId;
        this.categoryId = categoryId;
        this.thumbnail = thumbnail;
        this.title = title;
        this.content = content;
        this.dateCreate = dateCreate;
        this.dateModify = dateModify;
        this.admin = admin;
        this.category = category;
        this.postStatus = postStatus;
    }
}