import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './components/app/app.component';
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';
import { FetchEmployeeComponent } from './components/fetchemployee/FetchEmployee.component';
import { CreateEmployee } from './components/addemployee/AddEmployee.component';
import { EmployeeService } from './Services/EmpService.service';

@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
        AppComponent,
        NavMenuComponent,
        FetchEmployeeComponent,
        HomeComponent,
        CreateEmployee
       
    ],
    imports: [
        CommonModule,
        HttpModule,
        FormsModule,
        ReactiveFormsModule,  
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: 'fetch-employee', component: FetchEmployeeComponent },
            { path: 'new-employee', component: CreateEmployee },
            { path: 'employee/edit/:id', component: CreateEmployee },
            { path: '**', redirectTo: 'home' }
        ])
    ],
    providers: [EmployeeService]  
})
export class AppModuleShared {
}
