import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { DatePipe } from '@angular/common';


@Component({
  selector: 'app-alunos',
  templateUrl: './alunos.component.html',
  styleUrls: ['./alunos.component.scss']
})

export class AlunosComponent {
  public alunos: any = [] ;
  public alunosFiltrados: any = [];
  exibirImagem: boolean = false;
  private _filtroLista:string = "";


  constructor(private http: HttpClient,private datePipe: DatePipe){

  }


  public get filtroLista(){
    return this._filtroLista;
  }

  public set filtroLista(value: string){
    this._filtroLista = value;
    this.alunosFiltrados = this.filtroLista ? this.filtrarAlunos(this.filtroLista) : this.alunos;
  }

  filtrarAlunos(filtrarPor: string): any{
      filtrarPor = filtrarPor.toLocaleLowerCase();
      return this.alunos.filter((aluno: any) => aluno.nomeAluno.toLocaleLowerCase().indexOf(filtrarPor) !== -1 );
  }
ngOnInit(): void {
  this.getAlunos();

 // console.log('Alunos: ', this.alunos);
}

exibirOcultarImagem(){
  this.exibirImagem = !this.exibirImagem;
}

  public getAlunos(): void {
    this.http.get('https://localhost:7183/api/Fit').subscribe(
      response => {this.alunos = response; this.alunosFiltrados = response;},
      error => console.log(error)
    );
  }

  public formatarData(dData:any){
    return this.datePipe.transform(dData,"dd/MM/yyyy");
  }

}
