
# CNPJ Alfanumérico - Biblioteca

Esta biblioteca permite validar e limpar CNPJs conforme o [novo projeto da Receita Federal](https://www.gov.br/receitafederal/pt-br/acesso-a-informacao/acoes-e-programas/programas-e-atividades/cnpj-alfanumerico) que será aplicado para as novas inscrições de CNPJs a partir de Julho de 2026.

## Estrutura do projeto `LibCNPJAlfanumerico`

```bash
LibCNPJAlfanumerico
|   LibCNPJAlfanumerico.sln      # Arquivo de projeto Visual Studio
|
\---CNPJ
        CNPJ.cs                  # Classe com as funções (Validar, Limpar) da biblioteca 
``` 

## Guia de Utilização da biblioteca

1. Baixe o último release e importe para o seu projeto

	> v0.0.1 [`LibCNPJAlfanumerico.dll`](https://github.com/douglas-mathias-dev/LibCNPJAlfanumerico/releases/download/v0.0.1/LibCNPJAlfanumerico.dll)

2. Utilize os métodos Validar e Limpar

	Exemplo:
	
	```cs
	string cnpj = "CNPJ Fictício: A1.B23.4D5/678E-90"; // O CNPJ que será limpo e validado
	
	cnpj = LibCNPJAlfanumerico.CNPJ.Limpar(cnpj); // Para limpar o seu CNPJ
	
	if(LibCNPJAlfanumerico.CNPJ.Validar(cnpj)) // Verificando se o CNPJ é um CNPJ válido ou não
	{
		// Caso o CNPJ seja válido
	}
	```

## Contribua

1. Crie uma nova pull request com melhorias
3. De uma estrela para o projeto 