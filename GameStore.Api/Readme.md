Anotações sobre projeto:
EntityFramework vai trabalhar para fazer o relacionamento da Api com o banco de dados
packages: 
    dotnet-ef  
    Microsoft.EntityFrameworkCore.Design
    Microsoft.EntityFrameworkCore.Sqlite

dotnet ef migrations add InitialCreate --output-dir Data\Migrations
    Comando engenharia reversa para criar a estrutura do banco a partir das entidades