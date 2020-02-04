import { Component, OnInit } from '@angular/core';
import { SaleServices } from '../services/sales.service';

@Component({
  selector: 'app-sale-data',
  templateUrl: './sale-data.component.html',
  styleUrls: ['./sale-data.component.css']
})
export class SaleDataComponent implements OnInit {
  public salesDates:any;
  public saleDateSelected: string = null;

  constructor(
    private saleServices: SaleServices
  ) {}

  ngOnInit() {
    this.saleServices.getAllSaleData()
    .subscribe(
      (response: any) => {
        this.salesDates = response.map(row => row.name);
       }
    );
  }


  saleDataByDate()
  {
    console.log(this.saleDateSelected);
    this.saleServices.getSalesDataByDate(this.saleDateSelected)
    .subscribe(
      (response: any) => {
        var data = [response];
        Object.assign(this, {data});
      }
    );
  }





  multi: any[];
  view: any[] = [1000, 700];

  // options
  legend: boolean = false;
  showLabels: boolean = true;
  animations: boolean = true;
  xAxis: boolean = true;
  yAxis: boolean = true;
  showYAxisLabel: boolean = true;
  showXAxisLabel: boolean = true;
  xAxisLabel: string = 'Hours (24 hour format)';
  yAxisLabel: string = '$';
  xScaleMin: any = 1;
  xScaleMax: any = 24;

  colorScheme = {
    domain: ['#5AA454', '#E44D25', '#CFC0BB', '#7aa3e5', '#a8385d', '#aae3f5']
  };

  onSelect(data): void {
    console.log('Item clicked', JSON.parse(JSON.stringify(data)));
  }

  onActivate(data): void {
    console.log('Activate', JSON.parse(JSON.stringify(data)));
  }

  onDeactivate(data): void {
    console.log('Deactivate', JSON.parse(JSON.stringify(data)));
  }




}
