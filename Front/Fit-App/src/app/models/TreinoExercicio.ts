import { Exercicio } from "./Exercicio";
import { Treino } from "./Treino";
import { Unidade } from "./Unidade";

export interface TreinoExercicio {
  TreinoId: number;
  Treino: Treino;
  ExercicioId: number;
  Exercicio: Exercicio;
  UnidadeId: number;
  Unidade: Unidade;
  DiaDaSemana: number;
  Valor: number;
  Series: number;
  Repeticoes: number;
}
