
# CNPJ Alfanumérico - Biblioteca

Esta biblioteca permite validar e limpar CNPJs conforme o [novo projeto da Receita Federal](https://www.gov.br/receitafederal/pt-br/acesso-a-informacao/acoes-e-programas/programas-e-atividades/cnpj-alfanumerico) que será aplicado para as novas inscrições de CNPJs a partir de Julho de 2026.

## Estrutura do projeto `LibCNPJAlfanumerico`

```bash
LibCNPJAlfanumerico
|   LibCNPJAlfanumerico.sln      # Arquivo de projeto Visual Studio
|
\---CNPJ
        CNPJ.cs                  # Classe com as funções da biblioteca
``` 

## Guia de Utilização da biblioteca

Baixe o último release e importe para o seu projeto

> v0.0.1 [`LibCNPJAlfanumerico.dll`](https://github.com/douglas-mathias-dev/LibCNPJAlfanumerico/releases/download/v0.0.1/LibCNPJAlfanumerico.dll)

Utilize os métodos Validar e Limpar da DLL

```cs
string cnpj = ""; // O CNPJ que será validado ou limpo

if(LibCNPJAlfanumerico.Validar(cnpj)) // Verificando se o CNPJ é um CNPJ válido ou não
{
	// Caso o CNPJ seja válido
}

string cnpjLimpo = LibCNPJAlfanumerico.Limpar(cnpj); // Para limpar o seu CNPJ
```

## Contribua

1. Crie uma nova pull request com melhorias
3. De uma estrela para o projeto 