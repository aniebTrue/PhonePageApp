import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { phone } from './phone';


@Injectable()
export class DataService {

    private url = "/api/phones";

    constructor(private http: HttpClient) {
    }

    getPhones() {
        ////let res: phone[];
        //let res = this.http.get(this.url);
        //console.log(res);
        return this.http.get(this.url);
    }
}