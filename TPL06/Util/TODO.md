## ABMCs Desktop
✔ Modulos [HECHO]
✔ Modulos_Usuarios [HECHO]
✔ Usuarios
* Personas
* Planes
* Comisiones
* Especialidades
* Materias
* Cursos
* Alumnos_Inscripciones
* Docentes_Cursos

## ABMCs Web
* Modulos
* Modulos_Usuarios
* Usuarios
* Personas
* Planes
* Comisiones
* Especialidades
* Materias
* Cursos
* Alumnos_Inscripciones
* Docentes_Cursos

## GENERAL  
1. Refactorización de Persona y Usuario:
  * Los métodos que ya funcionan del ABMC Usuario tienen que trasladarse a Persona, usando INNER JOINs de usuarios y personas cuando se necesite.
  * La clase Usuario tiene que tener sólo: ID, NombreUsuario, Clave.
  * Si hace falta, la clase Usuario puede recuperar Apellido, Nombre, etc., pero en el fondo eso tiene que funcionar con queries a tabla personas.
  * La tabla usuarios tiene que tener sólo: id_usuario, nombre_usuario, clave, id_persona.
2. Perfil del usuario que inició sesión:
  ✔ Mostrar información personal. [HECHO]
  * Editar información personal. 
3. Desktop: Funcionalidad del botón Cerrar sesión.
4. Desktop: Reemplazar la visualización de todos los IDs por información más relevante o no mostrarlos directamente.
5. Web: El logo tiene que llevar al Home.
✔ Desktop: Arreglar categorías del menú lateral para que coincidan con las del PDF. [HECHO]
✔ Web: Arreglar categorías del menú lateral para que coincidan con las del PDF.[HECHO]


## ALUMNOS  
8. Ver materias (read-only DataGrid de sus Materias).  
9. Inscribirse a materias:  
  * Ver materias del plan del alumno (seleccionar una).  
  * Ver cursos de la materia seleccionada (seleccionar uno).  
  * Confirmar.  

## PROFESORES  
10. Ver cursos:
  * Mostrar DataGrid de Cursos del profesor.  
  * El profesor selecciona un curso:  
   * Mostrar alumnos del curso (el profesor puede editar condición y nota del alumno)  

11. Ver alumnos:
  * Mostar DataGrid de Alumnos del profesor.  
  * El profesor selecciona un alumno:  
   * Mostrar todos los cursos del alumno con ese profesor (el profesor puede editar condición y nota del alumno)  
