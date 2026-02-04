
# CNPJ Alfanumérico - Biblioteca (V1.0.0)

Esta biblioteca permite validar, limpar ou gerar CNPJs conforme o [novo projeto da Receita Federal](https://www.gov.br/receitafederal/pt-br/acesso-a-informacao/acoes-e-programas/programas-e-atividades/cnpj-alfanumerico) que será aplicado para as novas inscrições de CNPJs a partir de Julho de 2026.

## Estrutura do projeto `LibCNPJAlfanumerico`

```bash
LibCNPJAlfanumerico
|   LibCNPJAlfanumerico.sln      # Arquivo de projeto Visual Studio
|
\---CNPJ
        CNPJ.cs                  # Classe com as funções (Validar, Limpar e Gerar) da biblioteca 
``` 

## Guia de Utilização da biblioteca

1. Baixe o último release e importe para o seu projeto

	> v1.0.0 [`LibCNPJAlfanumerico.dll`](https://github.com/douglas-mathias-dev/LibCNPJAlfanumerico/releases/download/v1.0.0/LibCNPJAlfanumerico.dll)

2. Utilize os métodos Validar, Limpar ou Gerar

	Exemplo:

	```cs
	string cnpj = LibCNPJAlfanumerico.CNPJ.Gerar(); // Gerar um CNPJ randômico

	cnpj = LibCNPJAlfanumerico.CNPJ.Limpar($"CNPJ: {cnpj}"); // Para limpar o CNPJ, caso tenha algum resíduo

	if (LibCNPJAlfanumerico.CNPJ.Validar(cnpj)) // Verificando se o CNPJ é um CNPJ válido ou não
	{
		Console.WriteLine(cnpj); // CNPJ válido
	}
	```

## Contribua

1. Crie uma nova pull request com melhorias
3. De uma estrela para o projeto

## Licença

[`MIT`](LICENSE.txt)