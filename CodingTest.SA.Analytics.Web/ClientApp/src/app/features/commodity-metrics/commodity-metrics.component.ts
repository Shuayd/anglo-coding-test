import { Component, OnInit } from '@angular/core';
import { CommodityService } from 'src/app/core/services/commodity/commodity.service';

@Component({
  selector: 'app-commodity-metrics',
  templateUrl: './commodity-metrics.component.html',
  styleUrls: ['./commodity-metrics.component.scss']
})
export class CommodityMetricsComponent implements OnInit {

  constructor(private commodityService: CommodityService) { }

  ngOnInit() {
    this.commodityService.getPnlYTDMetrics().subscribe(res => console.log(res));
  }

}
