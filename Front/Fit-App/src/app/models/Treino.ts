import { Aluno } from "./Aluno";
import { Exercicio } from "./Exercicio";

export interface Treino
{
  Id: number;
  Observacoes: string;
  Inicio: Date ;
  AlunoId: number;
  Aluno: Aluno;
  Exercicios: Exercicio[];
}
