import { CommonModule } from '@angular/common';
import { Component, ElementRef, Input, OnChanges, OnInit, SimpleChanges, ViewChild } from '@angular/core';
import TransactionModel from '../../models/transaction.model';
import { ApiService } from '../../services/api.service';
import { FormsModule } from '@angular/forms';
import ChartOfAccountModel from '../../models/chart-of-account.model';
@Component({
  selector: 'upsert-transaction',
  imports: [CommonModule, FormsModule],
  templateUrl: './upsert-transaction.html',
  styleUrl: './upsert-transaction.css'
})
export class UpsertTransaction implements OnInit{
  
  chartOfAccounts!: ChartOfAccountModel[]
  @ViewChild('btnModal') btnModal!: ElementRef;

  constructor(private _service: ApiService<TransactionModel>, private _chartService: ApiService<ChartOfAccountModel>) {
  }
  ngOnInit(): void {
    this._chartService.getAll('chartOfAccount').subscribe(x => this.chartOfAccounts = x);
  }

  ngAfterViewInit(){
     if(this.name == 'Atualizar')
      this.btnModal.nativeElement.click();
    }

  @Input() name!: 'Inserir' | 'Atualizar';
  @Input() data: TransactionModel = {
    amount: 0,
    chartOfAccountId: 0,
    date: new Date(),
    history: '',
    id: 0
  };

  save = () => {
    if(this.name == 'Inserir'){
    this._service.insert('transactions', this.data).subscribe(() => {
      alert('Registro inserido com sucesso');
      window.location.reload();
    })

    return;
  }

  if(this.name == 'Atualizar')
  {
    this._service.update('transactions', this.data.id, this.data).subscribe(() => {
      alert('Registro atualizado com sucesso');
      window.location.reload();
    })
  }
  }
  reload = () => {
      window.location.reload();
  }
}
