# Segundo Parcial – Programación Básica

## 1. Nombre y matrícula

- **Nombre:** Albert Alexander Carty
- **Matrícula:** 2025-2788
- **Carrera:** Ingeniería en Ciberseguridad
- **Asignatura:** Programación Básica (ISW-122-1)
- **Profesor:** Gamalier Reyes
- **Universidad:** Universidad Central del Este (UCE)

## 2. Descripción del programa

Aplicación de escritorio en C# (Windows Forms) para registrar pedidos de una cafetería. Permite agregar productos a un pedido, aplicar recargos por tamaño, porción extra y empaque para llevar, y calcular el descuento por cliente frecuente, el ITBIS y el total a pagar.

## 3. Datos de entrada

| Dato | Control | Detalle |
|---|---|---|
| Cliente | Cuadro de texto | Nombre del cliente |
| Cliente frecuente | Casilla de verificación | Aplica 10 % de descuento |
| Fecha | Selector de fecha | Por defecto, la fecha actual |
| Producto | Cuadro de texto | Obligatorio |
| Precio | Cuadro de texto | Número mayor o igual que 0 |
| Cantidad | Control numérico | De 1 a 20 |
| Tamaño | Botones de opción | Normal o Grande (+RD$25) |
| Porción extra | Casilla de verificación | +RD$30 por unidad |
| Modalidad | Botones de opción | Consumir en local o Para llevar (+RD$20) |

## 4. Proceso

1. Al presionar **Agregar al pedido**, se valida que el producto no esté vacío y que el precio sea un número válido.
2. Se calcula el precio unitario: precio base + RD$25 si el tamaño es grande + RD$30 si lleva porción extra.
3. Se calcula el total de la línea (precio unitario × cantidad), se agrega al listado del pedido y se acumula en el subtotal.
4. Al presionar **Calcular Total**:
   - **Descuento** = 10 % del subtotal si es cliente frecuente.
   - **Empaque** = RD$20 si el pedido es para llevar.
   - **Base** = subtotal − descuento + empaque.
   - **ITBIS** = 18 % de la base.
   - **Total a pagar** = base + ITBIS.
5. **Nuevo Pedido** reinicia el formulario y **Salir** cierra la aplicación.

## 5. Salida

- Listado del pedido con cantidad, producto (y tamaño), precio unitario y total por línea.
- Subtotal, descuento, empaque, ITBIS (18 %) y total a pagar, en pesos dominicanos (RD$).

**Ejemplo:** 2 sándwich grandes con porción extra (RD$205 c/u) + 1 jugo normal (RD$150), cliente frecuente, para llevar:

| Concepto | Monto |
|---|---|
| Subtotal | RD$ 560,00 |
| Descuento | RD$ 56,00 |
| Empaque | RD$ 20,00 |
| ITBIS (18 %) | RD$ 94,32 |
| **Total a pagar** | **RD$ 618,32** |

## 6. Captura de pantalla del programa en ejecución

**Agregando productos al pedido**

![Agregando productos](img/agregandoPro.jfif)

**Cálculo del total**

![Cálculo del total](img/Total.jfif)
