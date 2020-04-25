# Secretaria
 
## Temas visuales Bulma css

- https://cssninja.io/themes/fresh
- https://bulmathemes.com/
- https://huaji8.top/post/azusa/
- http://www.niemingzhao.top/

## Restaurar la base de datos

Desde el menu *Herramientas -> Gestor de Paquetes Nuget -> Consola de Paquetes Nuget* ejecutar el siguiente comando:
```code
dotnet ef database update --project Secretaria.FrontEnd
```

## Crear la migración de la base de datos
```code
dotnet ef migrations add InitialMigration --project Secretaria.FrontEnd
```
