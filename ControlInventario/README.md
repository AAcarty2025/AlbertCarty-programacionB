 # Control de Inventario - TecnoPunto

## Información general

**Proyecto:** Control de Inventario de TecnoPunto  
**Asignatura:** Programación Básica  
**Actividad:** Clases, objetos y propiedades  
**Docente:** Gamalier Reyes del Carmen  

## Integrantes

- **Albert Alexander Carty** — 2025-2788
- **Orianna Dayanara Calcaño R.** — 2025-2695
- **Maria Pilar Vessania Silvence Yedi** — 2025-3481

## Descripción del proyecto

El proyecto consiste en desarrollar una aplicación de consola en C# para gestionar el inventario de una tienda de tecnología llamada TecnoPunto.

El programa permite registrar productos, validar sus datos y calcular el valor total de cada producto según su precio y cantidad disponible.

## Objetivos

- Aplicar los conceptos de clases y objetos en C#.
- Utilizar propiedades para acceder a los atributos de una clase.
- Implementar validaciones para evitar datos incorrectos.
- Registrar productos y calcular el valor total del inventario.

## Funcionamiento del programa

La aplicación permite:

1. Registrar tres productos.
2. Introducir el código, nombre, precio y cantidad de cada producto.
3. Validar los datos ingresados.
4. Mostrar mensajes de error cuando se introducen datos no permitidos.
5. Calcular el valor total de cada producto mediante su precio y cantidad.

## Estructura del proyecto

```text
ControlInventario/
│
├── Capturas/
│   ├── Productos.jfif
│   ├── Segunda.jfif
│   ├── tercera.jfif
│   ├── cuarta.jfif
│   ├── Quinta.jfif
│   └── Sexta.jfif
│
├── Inventario.csproj
├── Inventario.slnx
├── Program.cs
└── README.md
```

## Clases y conceptos utilizados

### Clase Producto

La clase `Producto` representa los artículos que forman parte del inventario. Contiene los atributos necesarios para almacenar la información de cada producto.

Se utilizan propiedades para controlar el acceso a los datos y aplicar las validaciones correspondientes.

### Propiedades y validaciones

- **Código:** identifica cada producto.
- **Nombre:** no puede estar vacío.
- **Precio:** debe ser mayor que cero.
- **Cantidad:** no puede ser negativa.
- **ValorTotal:** calcula el resultado de multiplicar el precio por la cantidad disponible.

### Conceptos aplicados

- Clases y objetos.
- Encapsulamiento.
- Campos privados.
- Propiedades.
- Validaciones.
- Métodos y constructores.

## Capturas de la ejecución

### 1. Cantidad cero

Se ingresa una cantidad igual a `0`. El programa acepta el dato, ya que solamente se rechazan las cantidades negativas.

![Captura con cantidad cero](Capturas/Productos.jfif)

### 2. Cantidad negativa

Se ingresa una cantidad negativa. El programa muestra el mensaje de error correspondiente y vuelve a solicitar los datos.

![Captura con cantidad negativa](Capturas/Segunda.jfif)

### 3. Nombre vacío

Se deja el nombre del producto en blanco. El programa muestra el mensaje `ERROR: El nombre no puede estar vacío.` y vuelve a solicitar los datos.

![Captura con nombre vacío](Capturas/tercera.jfif)

### 4. Precio negativo

Se ingresa un precio negativo. El programa muestra el mensaje `ERROR: El precio debe ser mayor que cero.` y vuelve a solicitar los datos.

![Captura con precio negativo](Capturas/cuarta.jfif)

### 5. Registro de productos

Se muestran los productos que fueron registrados correctamente durante la ejecución del programa.

![Captura de productos registrados](Capturas/Quinta.jfif)

### 6. Registro de otro producto

Se presenta otra evidencia del registro correcto de un producto en el inventario.

![Captura de otro producto registrado](Capturas/Sexta.jfif)

## ¿Cómo ejecutar el proyecto?

1. Abrir el archivo `Inventario.slnx` en Visual Studio.
2. Esperar a que el proyecto cargue correctamente.
3. Ejecutar la aplicación presionando `F5` o el botón de inicio.
4. Seguir las instrucciones que aparecen en la consola para registrar los productos.

También se puede ejecutar desde una terminal ubicada en la carpeta del proyecto utilizando:

```bash
dotnet run
```

## Conclusión

Este proyecto permitió poner en práctica los conocimientos adquiridos sobre programación orientada a objetos en C#, especialmente el uso de clases, objetos, propiedades y encapsulamiento.

Además, permitió comprender la importancia de implementar validaciones para garantizar que los datos ingresados sean correctos y mantener un control adecuado de la información del inventario.
