import { Treino } from "./Treino";

export interface Aluno
{
   id: number;
   nomeAluno: string;
   dataNascimento: Date;
   cpf: number;
   tipoSanguineo: string;
   altura: Number;
   dataCadastro: Date;
   fotoAluno: string;
   telefone: string;
   email: string;
   treinos: Treino [];
}
