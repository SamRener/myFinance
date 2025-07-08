import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import ChartOfAccountModel from '../models/chart-of-account.model';
import { ApiService } from '../services/api.service';
import { UpsertChartOfAccount } from "./upsert-chart-of-account/upsert-chart-of-account";

@Component({
  selector: 'app-chart-of-accounts',
  imports: [CommonModule, UpsertChartOfAccount],
  templateUrl: './chart-of-accounts.html',
  styleUrl: './chart-of-accounts.css'
})
export class ChartOfAccounts implements OnInit{
  constructor(private client: ApiService<ChartOfAccountModel>) {
    
  }
  dataToUpdate!: ChartOfAccountModel
  chartOfAccounts!: ChartOfAccountModel[]
  ngOnInit(): void {
    this.client.getAll('chartOfAccount').subscribe(chartOfAccounts => this.chartOfAccounts = chartOfAccounts)
  }

  remove = (id: number) => {
    this.client.delete('chartOfAccount', id).subscribe(() => {
      alert('Registro removido com sucesso')
      window.location.reload()
    })
  }
edit = (data: ChartOfAccountModel) => {
    this.dataToUpdate = data
  }
}
