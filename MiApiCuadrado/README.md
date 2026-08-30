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