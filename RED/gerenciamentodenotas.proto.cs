syntax = "proto3";

// requisicao insercao notas
message requisicaoNotas {
	int32 ra = 1;
	string cod_disciplina = 2;
	int32 ano = 3;
	int32 semestre = 4;
	float nota = 5;
}

// response insercao notas
message requisicaoResponseNotas {
	string message = 1;
}

// requisicao consulta alunos
message requisicaoConsultaAlunos {
	string cod_disciplina = 1;
	int32 ano = 2;
	int32 semestre = 3;
}

// aluno
message Aluno {
	int32 ra = 1;
	string nome = 2;
	int32 periodo = 3;
}

// response consulta alunos
message requisicaoResponseConsultaAlunos {
	string message = 1;
	repeated Aluno aluno = 2;
}