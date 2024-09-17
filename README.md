# API baseada em Microsservices.

A API foi desenvolvida com o objetivo de gerenciar sites encontrados na Surface Web que se parecem com o site original do cliente da nossa solução. Optamos por utilizar a arquitetura de microserviços pois dessa forma a manutenção do código tornou-se mais simples, caso seja necessário também podemos futuramente implementar mais Endpoints sem muitas dificuldades.

A arquitetura monolítica por exemplo não nos atenderia nesse caso, visto que o projeto já foi criado pensando na divisão dos serviços e a escalabilidade do projeto como um todo.

## Integrantes

Kelvin Gomes - rm98126
Leonardo Seiti - rm550207
Helena Medeiros - rm551873
Ezequiel Bispo - rm99573

## Requisitos

  - Pacotes NuGet:
  - `Oracle.EntityFrameworkCore`
  - `Oracle.ManagedDataAccess.Core`
  - `Swashbuckle.AspNetCore`

## Configurao do Projeto

### 1. Instalar Pacotes NuGet

No Console do Gerenciador de Pacotes NuGet, execute os seguintes comandos:

```sh
Install-Package Oracle.EntityFrameworkCore
Install-Package Oracle.ManagedDataAccess.Core
Install-Package Swashbuckle.AspNetCore
```

### 2. Configurar a String de Conexao:

No arquivo appsettings.json, adicione a string de conexo do Oracle:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "User Id=rmxxxxx;Password=xxxxxx;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=oracle.fiap.com.br)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=ORCL)))"
  }
}
```

### 3. Executar Migracoes:

No Console do Gerenciador de Pacotes NuGet, execute os seguintes comandos para adicionar e aplicar a migrao inicial:

```sh
Add-Migration InitialCreate
Update-Database
```

## EndPoints
![image](https://github.com/user-attachments/assets/10540b82-c50c-4a20-891c-fc0b26efb26c)

![image](https://github.com/user-attachments/assets/d5749d93-d187-4ade-a0d7-6e0d18b26baf)

![image](https://github.com/user-attachments/assets/2efafbea-a660-4f26-b452-8d77e6142c88)

![image](https://github.com/user-attachments/assets/26d963e0-4221-40f7-abc3-cc341499af5b)

![image](https://github.com/user-attachments/assets/bc230b6d-5733-46a1-bced-4a64b41ebfda)


