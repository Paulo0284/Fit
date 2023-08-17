import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-alunos',
  templateUrl: './alunos.component.html',
  styleUrls: ['./alunos.component.scss']
})

export class AlunosComponent {
  public alunos: any ;

  constructor(private http: HttpClient){

  }

ngOnInit(): void {
  this.getAlunos();
}

  public getAlunos(): void {
    this.http.get('https://localhost:7183/api/Fit').subscribe(
      response => this.alunos = response,
      error => console.log(error)
    );

    this.alunos = [{Nome: "Paulo"}];
  }

}
