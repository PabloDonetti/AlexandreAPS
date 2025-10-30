# Minha Aplicação

Este projeto é uma aplicação web desenvolvida seguindo os princípios de Clean Architecture e os conceitos de Domain-Driven Design (DDD). A estrutura do sistema é modular e organizada em quatro camadas principais: Domínio, Aplicação, Infraestrutura e Apresentação.

## Estrutura do Projeto

- **Domínio**: Contém as entidades de domínio, objetos de valor e interfaces de repositórios.
- **Aplicação**: Contém a lógica de negócios, serviços de aplicação e DTOs para transferência de dados.
- **Infraestrutura**: Contém a implementação do contexto de banco de dados, repositórios e configurações de persistência.
- **Apresentação**: Contém a API que expõe os endpoints para interação com a aplicação.

## Tecnologias Utilizadas

- **.NET 6**: Framework para desenvolvimento da aplicação.
- **Entity Framework Core**: ORM para acesso a dados.
- **Microsoft SQL Server**: Banco de dados utilizado para persistência de dados.
- **Docker**: Para containerização da aplicação.

## Funcionalidades

A aplicação implementa funcionalidades CRUD (Criar, Ler, Atualizar e Deletar) para gerenciar entidades. Os endpoints da API estão disponíveis na camada de apresentação e são gerenciados pelo `EntitiesController`.

## Instruções de Instalação

1. Clone o repositório:
   ```
   git clone <url-do-repositorio>
   cd MinhaAplicacao
   ```

2. Restaure as dependências:
   ```
   dotnet restore
   ```

3. Execute as migrações para configurar o banco de dados:
   ```
   dotnet ef database update --project src/MinhaAplicacao.Infrastructure/MinhaAplicacao.Infrastructure.csproj
   ```

4. Inicie a aplicação:
   ```
   dotnet run --project src/MinhaAplicacao.Api/MinhaAplicacao.Api.csproj
   ```

## Uso

Após iniciar a aplicação, você pode acessar a API através do endpoint base `http://localhost:5000`. Utilize ferramentas como Postman ou cURL para interagir com os endpoints disponíveis.

## Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou pull requests.

## Licença

Este projeto está licenciado sob a MIT License. Veja o arquivo LICENSE para mais detalhes.