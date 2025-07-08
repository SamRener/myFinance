import { Routes } from '@angular/router';
import { Transactions } from './transactions/transactions';
import { ChartOfAccounts } from './chart-of-accounts/chart-of-accounts';
export const routes: Routes = [
    {
        path: 'transactions',
        component: Transactions
    },
    {
        path: 'chart-of-accounts',
        component: ChartOfAccounts
    },
    {
        path: '**',
        redirectTo: 'transactions'
    }
];
