# Calc.API
API desenvolvida em APS.NET Core 2.2 com duas funcionalidade:

- Endpoint /showmethecode: Retornar a URL do repositório da aplicação no GitHub.
- Endpoint /calculajuros: Retornar o resultado de juros compostos aplicados ao valor inicial e a quantidade de meses informado, considerando a taxa fixa de 1% ao mês.

# Calc.API.Teste.Unidade
Projeto de Teste de Unidade criado em ASP.NET Core 2.2.

Camada de Serviços:
* Teste da funcionalidade para retornar URL do repositório do endereço da aplicação no GitHub.
* Teste da funcionalidade para realizar o cálculo de juros compostos esperando resultado de sucesso.
* Teste da funcionalidade para realizar o cálculo de juros compostos esperando resultado de sucesso e garantindo que o valor do resultado não está sendo arredondado após aplicar a função Trunc.

Camada de Modelos:
* Teste para garantir a funcionalidade de validação do valor inicial informado não pode ser menor ou igual a zero.
* Teste para garantir a funcionalidade de validação da quantidade de meses informada não pode ser menor ou igual a zero.
* Teste para garantir a funcionalidade de validação do valor inicial informado e a quantidade de meses informada não pode ser menor ou igual a zero.

# Calc.API.Teste.Integracao
Projeto de Teste de Integração criado em ASP.NET Core 2.2.

Camada de Controles:
* Teste da funcionalidade para realizar o cálculo de juros compostos esperando resultado de sucesso.
* Teste da funcionalidade para realizar o cálculo de juros compostos esperando resultado de sucesso e garantindo que o valor do resultado não está sendo arredondado após aplicar a função Trunc.
* Teste para garantir a funcionalidade de validação do valor inicial informado não pode ser menor ou igual a zero.
* Teste para garantir a funcionalidade de validação da quantidade de meses informada não pode ser menor ou igual a zero.
* Teste para garantir a funcionalidade de validação do valor inicial informado e a quantidade de meses informada não pode ser menor ou igual a zero.
* Teste para garantir a funcionalidade de validação do valor inicial informado não pode ser diferente de um número do tipo decimal.
* Teste para garantir a funcionalidade de validação da quantidade de meses informada não pode ser diferente de um número do tipo inteiro.
* Teste para garantir a funcionalidade de validação do valor inicial informado não deve estar em branco.
* Teste para garantir a funcionalidade de validação da quantidade de meses informada não deve estar em branco.
* Teste para garantir a funcionalidade de validação do valor inicial e da quantidade de meses informada não deve estar em branco.

# API V1.0:
- http://calcjuroscompostos.azurewebsites.net/swagger/index.html

# Imagem Docker:
- https://hub.docker.com/r/ajala/calcapi

Comandos docker para baixar e executar a imagem:
   - docker pull ajala/calcap
   - docker run -d -P ajala/calcapi
   - Imagem em execução: http://localhost:12345/swagger/index.html

# Ajala Oliveira
- https://www.linkedin.com/in/ajala-oliveira-85917442/
