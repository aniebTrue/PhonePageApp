import { Component, OnInit } from '@angular/core';
import { DataService } from './data.service';
import { phone } from './phone';

@Component({
    selector: 'app',
//    template: `
//<h1>Телефоны</h1>
//<div *ngFor="let p of phones" class="PhoneCard" style="margin:5px; border:solid black 2px; height:350px; width:600px">
//<img src="{{p?.PhoneIMGName}}" style="float:right; height:350px; width:250px"/>
//<p class="PhoneCard PhoneModelName">{{p?.ModelName}}</p>
//</div>`,
    templateUrl: './app.component.html',
    providers: [DataService]
})
export class AppComponent implements OnInit {

    phones: phone[] = [];
    tableMode: boolean = true;

    constructor(private dataService: DataService) {
    }

    ngOnInit() {
        this.dataService.getPhones()
            .subscribe((data: phone[]) => {
                this.phones = data; console.log("Data"); console.log(data); console.log("Phones"); console.log(this.phones)
            });
    }
        
}