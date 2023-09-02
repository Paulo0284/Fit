import { HttpClient } from '@angular/common/http';
import { Component, TemplateRef } from '@angular/core';
import { DatePipe } from '@angular/common';
import { AlunoService } from '../services/aluno.service';
import { Aluno } from '../models/Aluno';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { ToastrService } from 'ngx-toastr';
import { NgxSpinnerService } from 'ngx-spinner';



@Component({
  selector: 'app-alunos',
  templateUrl: './alunos.component.html',
  styleUrls: ['./alunos.component.scss']
})

export class AlunosComponent {
  public alunos: Aluno[] = [] ;
  public alunosFiltrados: Aluno[] = [];
  public exibirImagem: boolean = false;
  private _filtroLista:string = "";
  modalRef?: BsModalRef;


  constructor(
    private alunoService: AlunoService,
    private datePipe: DatePipe,
    private modalService: BsModalService,
    private toastr: ToastrService,
    private spinner: NgxSpinnerService
  ){

  }


  public get filtroLista(){
    return this._filtroLista;
  }

  public set filtroLista(value: string){
    this._filtroLista = value;
    this.alunosFiltrados = this.filtroLista ? this.filtrarAlunos(this.filtroLista) : this.alunos;
  }

  public filtrarAlunos(filtrarPor: string): Aluno[]{
      filtrarPor = filtrarPor.toLocaleLowerCase();
      return this.alunos.filter((aluno: Aluno) => aluno.nomeAluno.toLocaleLowerCase().indexOf(filtrarPor) !== -1 );
  }
public ngOnInit(): void {
  this.getAlunos();

 // console.log('Alunos: ', this.alunos);
 this.spinner.show();

 setTimeout(() => {
   /** spinner ends after 5 seconds */
   this.spinner.hide();
 }, 5000);
}

public exibirOcultarImagem(): void {
  this.exibirImagem = !this.exibirImagem;
}

  public getAlunos(): void {
    const observer = {
      next: (_alunos: Aluno[]) => {this.alunos = _alunos; this.alunosFiltrados = _alunos;},
      error: (error: any) => console.log(error)

    };
    this.alunoService.getAlunos().subscribe(observer);
  }

  public formatarData(dData:any){
    return this.datePipe.transform(dData,"dd/MM/yyyy");
  }

  public openModal(template: TemplateRef<any>) {
    this.modalRef = this.modalService.show(template, {class: 'modal-sm'});
  }

  public confirm(): void {
    this.modalRef?.hide();
    this.toastr.success('O aluno foi excluído!', 'Deletado!');
  }

  public decline(): void {
    this.modalRef?.hide();
  }

}
