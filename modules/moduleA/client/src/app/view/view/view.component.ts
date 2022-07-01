import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-view',
  templateUrl: './view.component.html',
  styleUrls: ['./view.component.scss']
})

export class ViewComponent implements OnInit {

  data: DemoObject[] = []
  
  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.http.get<DemoObject[]>('http://localhost:8081/api/demo').subscribe(x => this.data = x)
  }
}

export type DemoObject = {
  name: string;
}
