import { Component, ElementRef, Input, ViewChild } from '@angular/core';
import ChartOfAccountModel from '../../models/chart-of-account.model';
import { ApiService } from '../../services/api.service';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'upsert-chart-of-account',
  imports: [CommonModule, FormsModule],
  templateUrl: './upsert-chart-of-account.html',
  styleUrl: './upsert-chart-of-account.css'
})
export class UpsertChartOfAccount{
  
  @ViewChild('btnModal') btnModal!: ElementRef;

  constructor(private _service: ApiService<ChartOfAccountModel>) {
  }

  ngAfterViewInit(){
     if(this.name == 'Atualizar')
      this.btnModal.nativeElement.click();
    }

  @Input() name!: 'Inserir' | 'Atualizar';
  @Input() data: ChartOfAccountModel = {
    id: 0,
    name: '',
    type: 'D'
  };

  save = () => {
    if(this.name == 'Inserir'){
    this._service.insert('chartOfAccount', this.data).subscribe(() => {
      alert('Registro inserido com sucesso');
      window.location.reload();
    })

    return;
  }

  if(this.name == 'Atualizar')
  {
    this._service.update('chartOfAccount', this.data.id, this.data).subscribe(() => {
      alert('Registro atualizado com sucesso');
      window.location.reload();
    })
  }
  }
  reload = () => {
      window.location.reload();
  }
}