# MiApiCuadrado

API Web en .NET Core que recibe un número y devuelve su cuadrado.

## Endpoint
GET /api/Math/cuadrado/{numero}

## Ejemplos probados localmente
- /api/Math/cuadrado/5 → 25
- /api/Math/cuadrado/2 → 4
- /api/Math/cuadrado/10 → 100
- /api/Math/cuadrado/-3 → 400 Bad Request, "El número debe ser mayor o igual a 0."

## Conexión a base de datos (Somee)
Se creó una base de datos SQL Server en Somee.com con una tabla `Productos` con 10 registros insertados.

## Endpoint de productos
GET /api/Productos → devuelve todos los productos en formato JSON, obtenidos directamente desde la base de datos remota en Somee.


## Base de datos (Somee)
Se creó una base de datos SQL Server en Somee.com con una tabla `Productos` y 10 registros insertados.

## Endpoints

| Método | Ruta | Descripción |
|---|---|---|
| GET | /api/Math/cuadrado/{numero} | Devuelve el cuadrado de un número |
| GET | /api/Productos | Devuelve todos los productos desde la base de datos, en formato JSON |

## API publicada en línea
Además de probarse localmente, la API fue publicada en Somee y es accesible públicamente:

- http://micuadrado-api.somee.com/api/Math/cuadrado/5
- http://micuadrado-api.somee.com/api/Productos