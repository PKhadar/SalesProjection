import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { map } from 'rxjs/operators';

@Injectable()
export class SaleServices {

    constructor (
        private httpClient: HttpClient
    ){}


    getAllSaleData(){
        return this.httpClient.get('https://localhost:44361/api/Sales/')
        .pipe(
            map(
                (response) => {
                    return response;
                }
            )
        );
    }    



    getSalesDataByDate(date){
        return this.httpClient.get('https://localhost:44361/api/Sales/' + date)
        .pipe(
            map(
                (response) => {
                    return response;
                }
            )

        );
    }
}