# Boletín de Calificaciones

# **Datos**
- **Nombre:** Albert Alexanader Carty
- **Matricula:** 2025-2788
- **Materia:** Programacion Basica

Este proyecto es una aplicación de Windows Forms hecha en C# para la actividad de **Programación Básica**. La idea es registrar las calificaciones de un estudiante por asignatura, calcular sus promedios y mostrar si aprobó, está en recuperación o reprobó.

Lo hice utilizando los controles básicos de Windows Forms y los temas trabajados en clase, como variables, constantes, condicionales, validaciones y eventos de botones.

## ¿Qué hace el programa?

- Permite escribir el nombre del estudiante y seleccionar su tanda (Matutina o Vespertina).
- Permite elegir una asignatura del ComboBox.
- Registra las notas de los cuatro períodos (P1, P2, P3 y P4).
- Permite indicar si el estudiante cumple con la asistencia mínima del 80 %.
- Calcula el promedio de cada asignatura y muestra su situación en el boletín.
- Lleva la cuenta de las asignaturas aprobadas, en recuperación y reprobadas.
- Calcula el promedio general de las asignaturas registradas.
- Muestra un resumen final y permite limpiar el formulario o salir del programa.

## Reglas para las calificaciones

Cada asignatura tiene cuatro calificaciones, y el promedio se calcula sumándolas y dividiendo el resultado entre cuatro.

| Promedio | Situación |
|---|---|
| 70 o más | Aprobada |
| Desde 60 hasta menos de 70 | En recuperación |
| Menos de 60 | Reprobada |
| No cumple la asistencia mínima | Reprobada por asistencia |

La asistencia tiene prioridad sobre el promedio: si no se marca que cumple con la asistencia mínima, la asignatura se registra como **Reprobada por asistencia**, aunque las notas sean suficientes.

El promedio general se obtiene sumando los promedios de las asignaturas registradas y dividiendo entre la cantidad de asignaturas.

## Controles utilizados

| Control | Nombre en el proyecto | Uso |
|---|---|---|
| TextBox | `txtEstudiante` | Escribir el nombre del estudiante |
| RadioButton | `rdbMatutina` | Seleccionar tanda matutina |
| RadioButton | `rdbVespertina` | Seleccionar tanda vespertina |
| ComboBox | `cmbAsignatura` | Elegir la asignatura |
| TextBox | `txtP1` | Nota del período 1 |
| TextBox | `txtP2` | Nota del período 2 |
| TextBox | `txtP3` | Nota del período 3 |
| TextBox | `txtP4` | Nota del período 4 |
| CheckBox | `chkAsistencia` | Indicar si cumple la asistencia mínima |
| ListBox | `lstBoletin` | Mostrar asignaturas, tanda, promedio y situación |
| Label | `lblPromedioGeneral` | Mostrar el promedio general |
| Label | `lblAprobadas` | Cantidad de asignaturas aprobadas |
| Label | `lblRecuperacion` | Cantidad de asignaturas en recuperación |
| Label | `lblReprobadas` | Cantidad de asignaturas reprobadas |
| Label | `lblSituacion` | Mostrar mensajes y la situación general |
| Button | `btnRegistrar` | Registrar una asignatura |
| Button | `btnResumen` | Mostrar el resumen final |
| Button | `btnLimpiar` | Reiniciar el formulario y los datos |
| Button | `btnSalir` | Cerrar la aplicación |

## Validaciones

Antes de registrar una asignatura, el programa comprueba que:

- Se haya escrito el nombre del estudiante.
- Se haya seleccionado una tanda.
- Se haya elegido una asignatura.
- Las cuatro calificaciones sean números válidos.
- Cada calificación esté entre 0 y 100.

Si algún dato no cumple con estas condiciones, se muestra un mensaje indicando qué debe corregirse y, cuando corresponde, el cursor vuelve al campo de la calificación que tiene el problema.

También se evita mostrar el resumen cuando todavía no se ha registrado ninguna asignatura.

## Resumen del estudiante

Al presionar **Mostrar resumen**, el programa presenta:

- El promedio general, con dos decimales.
- La cantidad de asignaturas aprobadas.
- La cantidad de asignaturas en recuperación.
- La cantidad de asignaturas reprobadas.
- La situación general del estudiante.

La situación general se determina de esta manera:

1. Si tiene al menos una asignatura reprobada, muestra que tiene asignaturas reprobadas.
2. Si no tiene asignaturas reprobadas, pero tiene alguna en recuperación, muestra que tiene asignaturas en recuperación.
3. Si todas están aprobadas, muestra que aprobó todas las asignaturas.

## Cómo está organizado el código

El código se encuentra en `Form1.cs`, dentro del formulario principal. Se utilizan constantes para los valores de aprobación, recuperación y cantidad de períodos, además de variables que guardan los acumulados y los contadores durante el registro.

Los eventos principales son:

- `btnRegistrar_Click`: valida los datos, calcula el promedio, determina la situación y agrega la asignatura al boletín.
- `btnResumen_Click`: calcula y presenta el resumen general.
- `btnLimpiar_Click`: borra los datos del formulario y reinicia los contadores.
- `btnSalir_Click`: cierra la aplicación.
- `LimpiarCalificaciones()`: limpia los campos de los cuatro períodos.
- `ActualizarContadores()`: actualiza los contadores que aparecen en el formulario.

## Cómo ejecutar el proyecto

1. Abrir el proyecto de Windows Forms en Visual Studio.
2. Verificar que los controles del formulario tengan los nombres indicados en el código.
3. Ejecutar el proyecto.
4. Escribir el nombre, seleccionar la tanda y la asignatura.
5. Introducir las cuatro calificaciones y marcar la asistencia si corresponde.
6. Presionar **Registrar asignatura** para agregarla al boletín.
7. Repetir el proceso con las demás asignaturas.
8. Presionar **Mostrar resumen** para ver los resultados finales.

   # *Imageenes de programa en ejecucion**
   ![ ejecutado ](IMG/Ejecutado.jfif)

   ![ ejecutado ](IMG/Agregados.jfif)
   
   ![ ejecutado ](IMG/Aprobado1.jfif)
   
   ![ ejecutado ](IMG/Aprobado2.jfif)
   
   ![ ejecutado ](IMG/Aprobado3.jfif)
   
   ![ ejecutado ](IMG/Reprobado.jfif)
   
   ![ ejecutado ](IMG/Resumen.jfif)

## Tecnologías utilizadas

- C#
- Windows Forms
- Visual Studio

---

**Actividad:** Boletín de Calificaciones  
**Asignatura:** Programación Básica  
**Tipo de trabajo:** Individual
