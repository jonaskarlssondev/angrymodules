import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DefaultComponent } from './default/default.component';

const routes: Routes = [
  { 
    path: '', 
    component: DefaultComponent 
  },
  {
    path: 'moduleA',
    loadChildren: () => import('moduleA/Module').then(m => m.ViewModule)
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
