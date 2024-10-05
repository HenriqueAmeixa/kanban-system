Criar uma migration:
  Add-Migration NomeDaMigration -StartupProject BoardService.API -Project BoardService.Infrastructure
  Update-Database -StartupProject BoardService.API -Project BoardService.Infrastructure
