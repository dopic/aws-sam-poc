# aws-sam-framework

Aplicação Serverless utilizando:

- [AWS Serverless Application Model (SAM)](https://aws.amazon.com/pt/serverless/sam/)
- [AWS API Gateway - REST API](https://docs.aws.amazon.com/apigateway/latest/developerguide/apigateway-rest-api.html)
- [ASP.NET Core](https://docs.microsoft.com/pt-br/aspnet/core/?view=aspnetcore-2.1)
- [Lambda AspNetCoreServer](https://docs.microsoft.com/pt-br/aspnet/core/?view=aspnetcore-2.1)

**Importante:** A implementação do AspnetCoreServer é automática, se utilizado o template de projeto para aplicações lambda, no Visual Studio. É necessário ter a extensão [AWS Toolkit for Visual Studio](https://aws.amazon.com/pt/visualstudio/) instalado.

## Deploy

Para publicar, basta utilizar o comando **Publish To AWS Lambda** no menu de contexto, no projeto da API. Se faz necessário obter as credenciais de um usuário na AWS, e configurar o [AWS CLI](https://aws.amazon.com/pt/cli/, ou fornecer as credenciais diretamente na publicação do VS. 

## Verificar implantação

Ao final do deploy, basta obter o endpoint da WebAPI criada na AWS. 

Existe apenas um controller (Customers), com dois endpoints:
- GET api/customers/{id}: Obtem um cliente
- POST /api/customers: Persiste um cliente

**Importante**: Os dados estão sendo salvos em memória. O tempo de vida da infraestrutura de uma lambda, é de aproximadamente 5 minutos (em estado ocioso). Se o intervalo entre os testes for muito maior do que isso, os dados salvos serão perdidos.