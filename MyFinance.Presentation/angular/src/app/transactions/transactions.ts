import { Component, OnInit } from '@angular/core';
import { ApiService } from '../services/api.service';
import TransactionModel from '../models/transaction.model';
import { CommonModule } from '@angular/common';
import { UpsertTransaction } from './upsert-transaction/upsert-transaction';

@Component({
  selector: 'app-transactions',
  imports: [CommonModule, UpsertTransaction],
  templateUrl: './transactions.html',
  styleUrl: './transactions.css'
})
export class Transactions implements OnInit{
  constructor(private client: ApiService<TransactionModel>) {
    
  }

  transactions!: TransactionModel[]
  dataToUpdate!: TransactionModel
  ngOnInit(): void {
    this.client.getAll('transactions').subscribe(transactions => this.transactions = transactions)
  }

  remove = (id: number) => {
    this.client.delete('transactions', id).subscribe(() => {
      alert('Registro removido com sucesso')
      window.location.reload()
    })
  }
  edit = (data: TransactionModel) => {
    this.dataToUpdate = data
  }
}
