# Secretaria
 
## Temas visuales Bulma css

- https://cssninja.io/themes/fresh
- https://bulmathemes.com/
- https://huaji8.top/post/azusa/
- http://www.niemingzhao.top/

## Crear las bases de datos 

Configurar el archivo *appsetting.json* con las credenciales del servidor de base de datos

Desde el menu *Herramientas -> Gestor de Paquetes Nuget -> Consola de Paquetes Nuget* ejecutar el siguiente comando:

```code
dotnet ef database update --project Secretaria.FrontEnd --context SecretariaDbContext
dotnet ef database update --project Secretaria.FrontEnd --context ApplicationDbContext
```
