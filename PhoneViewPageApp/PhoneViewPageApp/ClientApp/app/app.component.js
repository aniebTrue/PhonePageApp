var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
import { Component } from '@angular/core';
import { DataService } from './data.service';
var AppComponent = /** @class */ (function () {
    function AppComponent(dataService) {
        this.dataService = dataService;
        this.phones = [];
        this.tableMode = true;
    }
    AppComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.dataService.getPhones()
            .subscribe(function (data) {
            _this.phones = data;
            console.log("Data");
            console.log(data);
            console.log("Phones");
            console.log(_this.phones);
        });
    };
    AppComponent = __decorate([
        Component({
            selector: 'app',
            //    template: `
            //<h1>Телефоны</h1>
            //<div *ngFor="let p of phones" class="PhoneCard" style="margin:5px; border:solid black 2px; height:350px; width:600px">
            //<img src="{{p?.PhoneIMGName}}" style="float:right; height:350px; width:250px"/>
            //<p class="PhoneCard PhoneModelName">{{p?.ModelName}}</p>
            //</div>`,
            templateUrl: './app.component.html',
            providers: [DataService]
        }),
        __metadata("design:paramtypes", [DataService])
    ], AppComponent);
    return AppComponent;
}());
export { AppComponent };
//# sourceMappingURL=app.component.js.map