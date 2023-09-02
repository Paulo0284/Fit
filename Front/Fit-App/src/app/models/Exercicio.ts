import { GrupoMuscular } from "./GrupoMuscular";

export interface Exercicio {
  Id: number;
  NomeExercicio: string;
  GrupoMuscularId: number;
  GrupoMuscular: GrupoMuscular;
  URL: string;
}
