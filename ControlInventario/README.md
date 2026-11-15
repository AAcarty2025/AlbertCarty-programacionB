# Control de Inventario de TecnoPunto

**Actividad:** Clases, objetos y propiedades – Programación Básica  
**Profesor:** Gamalier Reyes del Carmen

## Datos de los autores

| Nombre | Matrícula |
|---|---|
| Albert Alexander Carty | 2025-2788 |
| Orianna Dayanara Calcaño R. | 2025-2695 |
| Maria Pilar Vessania Silvence Yedi | 2025-3481 |

## Descripción del programa

Aplicación de consola desarrollada en **C#** para la tienda *TecnoPunto*, que llevaba su inventario en papel y cometía errores como precios negativos, cantidades inválidas y productos sin nombre.

El programa modela cada producto mediante la clase `Producto`, que encapsula sus datos utilizando **campos privados y propiedades con validación** (bloque `set`). Registra tres productos ingresados por teclado y muestra su información, incluido el **valor total en existencia**, que cada producto calcula por sí mismo.

Si el usuario ingresa un dato inválido, el programa muestra un mensaje claro y vuelve a solicitar los datos del mismo producto, evitando que la aplicación se cierre inesperadamente.

## Estructura del proyecto

| Archivo | Contenido |
|---|---|
| `Program.cs` | Contiene las clases `Producto` y `Program`, los campos privados, las propiedades con validación, el constructor, el método `MostrarInfo()`, el método `RegistrarProducto()` y el método `Main`. |
| `Inventario.csproj` | Archivo de configuración del proyecto de C#. |
| `Inventario.slnx` | Archivo de solución de Visual Studio. |
| `README.md` | Documentación del proyecto y evidencias de ejecución. |
| `Capturas/` | Carpeta que contiene las imágenes de las pruebas realizadas. |

## Datos de entrada

Para cada uno de los tres productos, el usuario ingresa por teclado:

| Dato | Tipo | Regla de validación |
|---|---|---|
| Código | `string` | Sin restricciones. |
| Nombre | `string` | No puede estar vacío ni contener solamente espacios. |
| Precio | `decimal` | Debe ser numérico y mayor que 0. |
| Cantidad | `int` | Debe ser un número entero y no puede ser negativa. El 0 es válido. |

## Datos que procesa

1. **Lectura y conversión:** el precio y la cantidad se convierten utilizando `decimal.TryParse` e `int.TryParse`. Si el texto ingresado no corresponde a un número válido, se muestra un mensaje de error.
2. **Validación en las propiedades (`set`):**
   - `Nombre`: lanza `ArgumentException` si está vacío o contiene solamente espacios.
   - `Precio`: lanza `ArgumentException` si es menor o igual a 0.
   - `Cantidad`: lanza `ArgumentException` si es negativa.
3. **Creación del objeto:** el constructor recibe los datos y los asigna mediante las propiedades, garantizando que se apliquen las validaciones.
4. **Cálculo:** la propiedad de solo lectura `ValorTotal` devuelve el resultado de multiplicar el precio por la cantidad.
5. **Manejo de errores:** un bloque `try-catch` dentro de un ciclo `while (true)` captura las excepciones, muestra el mensaje correspondiente y permite repetir el registro del producto hasta que los datos sean válidos.

## Datos de salida

- Mensaje de confirmación al registrar cada producto: `Producto registrado correctamente.`
- Mensajes de error ante datos inválidos:
  - `El nombre no puede estar vacío.`
  - `El precio debe ser mayor que cero.`
  - `La cantidad no puede ser negativa.`
  - `Debe ingresar un precio valido.`
  - `Debe ingresar una cantidad valida.`
- **Inventario final:** muestra los datos de cada producto, incluyendo código, nombre, precio, cantidad y valor total, con dos decimales.

## Capturas de la ejecución

### 1. Datos válidos

Se registra un producto con código `P001`, nombre `Laptop Hp`, precio `25000` y cantidad `3`. El programa acepta los datos y muestra el mensaje `Producto registrado correctamente.`

![Captura con datos válidos](Capturas/Productos.jfif)

### 2. Inventario final

Al terminar el registro de los tres productos, el programa muestra la información de cada uno: código, nombre, precio, cantidad y valor total (precio × cantidad).

![Captura del inventario final](Capturas/Segunda.jfif)

### 3. Precio negativo

Se ingresa el precio `-6000`. El programa muestra el mensaje `ERROR: El precio debe ser mayor que cero.` y vuelve a solicitar los datos del mismo producto.

![Captura con precio negativo](Capturas/tercera.jfif)

### 4. Nombre vacío

Se deja el nombre en blanco. El programa muestra el mensaje `ERROR: El nombre no puede estar vacío.` y vuelve a solicitar los datos.

![Captura con nombre vacío](Capturas/cuarta.jfif)

### 5. Cantidad cero

Se ingresa la cantidad `0`. El programa acepta el dato, porque solamente se rechazan las cantidades negativas, y registra el producto con un valor total de 0.

![Captura con cantidad cero](Capturas/Quinta.jfif)

### 6. Cantidad negativa

Se ingresa la cantidad `-8`. El programa muestra el mensaje `ERROR: La cantidad no puede ser negativa.` y vuelve a solicitar los datos.

![Captura con cantidad negativa](Capturas/Sexta.jfif)

## Cómo ejecutar el proyecto

Para ejecutar el programa se necesita Visual Studio con soporte para C# y el SDK de .NET compatible con la versión configurada en `Inventario.csproj`.

También se puede ejecutar desde una terminal, dentro de la carpeta del proyecto, utilizando:

```bash
dotnet run
```

En Visual Studio, se puede abrir la solución y presionar **F5** para iniciar la aplicación.

## Conceptos aplicados

- Clases y objetos: creación de tres objetos a partir de la clase `Producto`.
- Encapsulamiento: utilización de campos privados y acceso mediante propiedades.
- Propiedad de solo lectura: `ValorTotal`.
- Constructor: inicialización de los objetos.
- Validación de datos mediante propiedades.
- Manejo de excepciones: `try-catch` y `ArgumentException`.
- Entrada y salida de datos por consola.
