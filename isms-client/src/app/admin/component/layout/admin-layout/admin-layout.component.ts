import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-admin-layout',
  templateUrl: './admin-layout.component.html',
  styleUrls: ['./admin-layout.component.css']
})
export class AdminLayoutComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }
  
  showSubMenu(id:number):void{
    var element = document.getElementsByClassName("SubMenu");
    if((<HTMLElement>element[id]).style.display == 'none'){
      (<HTMLElement>element[id]).style.display = 'block';
    }
    
    else if((<HTMLElement>element[id]).style.display == 'block'){
      (<HTMLElement>element[id]).style.display = 'none';
    }

    for(let i = 0; i < element.length; i++){
      if(id != i){
        if((<HTMLElement>element[i]).style.display != 'none'){
          (<HTMLElement>element[i]).style.display = 'none';
        }
      }
    }
  }
}
