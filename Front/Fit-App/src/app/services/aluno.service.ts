import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Aluno } from '../models/Aluno';

@Injectable(
//  {  providedIn: 'root'}
)
export class AlunoService {
  baseURL = 'https://localhost:7183/api/Aluno';

  constructor(private http: HttpClient) { }

  public getAlunos(): Observable<Aluno[]>{
    return this.http.get<Aluno[]>(this.baseURL);
  }

  public getAluno(id: number): Observable<Aluno>{
    return this.http.get<Aluno>(`${this.baseURL}/${id}`);
  }

  public getAlunoByNome(nome: string): Observable<Aluno[]>{
    return this.http.get<Aluno[]>(`${this.baseURL}/${nome}/busca`);
  }

}
