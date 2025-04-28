# Prueba Apl

## Descripción
Este repositorio contiene 3 folders con 3 proyectos para ser evaluados según los requisitos proporcionados por el área de reclutamiento.

## Proyectos

* **Straad.ChallengingCodeApl.ApiService**: Este folder contiene los fuentes del servicio rest (Usando Net 8) que incluye 2 endpoints, uno para generar un producto y el otro para recuperar el listado de productos. Además incluye las validaciones del modelo y organización basica de los folders para organizar de mejor manera el proyecto. Esta API es una API basica que no está basada en Clean Archiitecture.
    * Endpoint para obtener productos.
    * Endpint para agregar un producto.
    * Validaciones de las entidades.
    * Organización de folders para controller, DBContext, entidades de base de datos, DTO, etc.
* **Straad.ChallengingCodeApl.Sql**:  Este proyecto incluye un archivo fuente (SQLQuery1.sql), el cual incluye los scripts necesarios (T-SQL) para generar los objetos como tablas indices, etc. además incluye la consulta para recuperar la información especificada en el documento de especificación. Además incluye un diagrama entidad relación de las tablas para poder ejemplificar la normalización.
    * Scripts para generar objetos y registros de base de datos.
    * Queries para ejecutar el total gastado en 2023.
    * Normalización de las columnas 'Tipo de Producto' y 'País del Usuario'
    * Generación de indice no clustereado para busquedas del cliente por Email.
* **Straad.ChallengingCodeApl.WebApplication.Angular.AngularMaterial**:  Proyecto en Angular para mostrar el listado de los productos. Este proyecto contiene una estructura basica y fue desarrollado usando Node v22.11.0 y Angular 19.2.9
    * Componente Product-List para mostrar el listado.
    * Oranización de los directorios, incluyendo el componente, el servicio, el archivo de ruteo global y el archivo de ruteo por categoria de componente, DTO, etc.

## Preguntas
* **¿Qué es Clean Architecture?**:  Clean Architecture es un marco de trabajo que ayuda a estructurar aplicaciones (está orientado principalmente para aplicaciones grandes con muchos desarroladores), facilitando la modularización/granularidad, aislamien de componentes para facilitar pruebas y así como para eliminar el fuerte acoplamiento entre componentes. Si bien este tipo de arquitecturas está orientado más a microservicios, puede ser usada en cualqueir tipo de proyecto, solo se debe considerar la curva de aprendizaje ya que es un poco elevada. Esta arquitectura se basa en 4 capas principalmente (Presentación, Infraestructura, Applicación y Dominio) y se basa en principios SOLID, apoyandose de diferentes patrones. 
* **¿Cómo la aplicarías en el ejercicio anterior?**:  Si tuviera que aplicar Clean Architecture en el proyecto que se me solicito, hubiera generado una query y un command en la capa de Aplicación, la query para para recuperar y el command para persistir los productos. Las entidades las generaria en la capa de dominio, pero su configuración la generaria en la capa de infraestructura ya que EntityFramework es un servicio ajeno al dominio. En la capa de presentación construiria el controller, y las validaciones del DTO del POST lo generaria en la capa de Aplicación, ya que son parte de los casos de uso. Pero este tipo de proyecto se deseara trasladar de monolito a microservicios, en el cual en un microservicio pudieramos tener los CLientes, y en otro microservicios los Productos y en otro las Ventas.
* **Explica la diferencia entre monolithic y microservicios.**:  Un sistema de tipo monolito es una aplicación que concentra cualquier tipo de funcionalidad dentro del mismo sistema, un ejemplo pueden ser algunos sistemas de venta que existen en el mercado, que incluyen facturación, nomina, contabilidad, etc. todo en la misma base de datos, para ser consumida dicha información desde un unico sistema con modulos fuertemente acoplados. Por otra parte, los microservicios son sistemas aislados en modulos o dominios, cada dominio o modulo está aislado del otro y mantiene comunicación via servicios o por consumo de lotes de archivos, pero incluso cada dominio puede hacer uso de sus propias tecnologias y pueden ser diferentes a otros dominios. Las ventajas es que al estar aislados, tanto la disponibiliad, escabilidad y despliegue pueden ser controlados de manera aislada al no existir acoplamientos entre dominios.
* **¿Cómo implementarías un pipeline CI/CD para el proyecto que desarrollaste? (Menciona herramientas).**:  Yo no he trabajado con la implementación de Pipelines CI/CD, sin embargo me ha tocado ver lo que realizan los DevOps, y generan las diferentes ramas como main, satge, develop, develop/funcionalidad1, etc.. para indicar el Git Workflow de cómo se debe versionar el código para ser llevado hasta main, y con ello se puedan ejecutar las diferentes Github-Actions para realizar una compilación de los aplicativos/servicios y validaciones de calidad de código. Sé que en un pipeline se establacen artefactos que incluyen la ejecución automatica de unit test, valdiaciones de calidad de código, etc.. sin embargo, yo no las he implementado, pero eso haria, colocar la secuencia de artefactos para poder hacer el despliegue automático cada vez que el código se despliegue en main.
* **¿Qué ventajas tiene usar Angular frente a React? (Menciona al menos 2).**:  Solo he trabajado con Angular, y lo que he sabido es que Angular permite mejor organización, ya que separa de una mejor manera cada componente y cada elemento.
* **¿Por qué es importante el versionamiento semántico (SemVer)?**:  Es un versionamiento basado basado en organizar las versiones según el impacto que tenga una nueva versión sobre el consumidor, es decir, si es una prueba de grandes cambios puede cambiar una versión de 1.0.0 a 2.0.0, sin mebargo si los cambios no son de gran impacto para el usuario o dentro de la infraestructura de los servicios, puede generarse un cambio de 1.0.0 a 1.1.0, sin emabrgo si los cambios son menores pero son necesarios realizarlos como Quickfixes se podría aplicar un cambio de 1.0.0 a 1.0.1. Esto depende de la forma o estandar adoptado por la compañia, pero ayuda a dar trazabilidad en el flujo de versiones para ver en qué punto estamos ubicados e incluso para analizar el como abordar grandes merges (en aplicaciones monolitas lo he visto mucho).
* **¿Por qué es importante el versionamiento semántico (SemVer)?**:  Es un versionamiento basado basado en organizar las versiones según el impacto que tenga una nueva versión sobre el consumidor, es decir, si es una prueba de grandes cambios puede cambiar una versión de 1.0.0 a 2.0.0, sin mebargo si los cambios no son de gran impacto para el usuario o dentro de la infraestructura de los servicios, puede generarse un cambio de 1.0.0 a 1.1.0, sin emabrgo si los cambios son menores pero son necesarios realizarlos como Quickfixes se podría aplicar un cambio de 1.0.0 a 1.0.1. Esto depende de la forma o estandar adoptado por la compañia, pero ayuda a dar trazabilidad en el flujo de versiones para ver en qué punto estamos ubicados e incluso para analizar el como abordar grandes merges (en aplicaciones monolitas lo he visto mucho).

## Capturas

Angular
![Angular](https://github.com/user-attachments/assets/446cd271-17fd-425e-8d11-59b6daf9536e)

Api
![Api](https://github.com/user-attachments/assets/5e31020b-2c11-45c2-8977-be90e23d7d19)

Sql
![Sql](https://github.com/user-attachments/assets/db0049f8-e288-49be-9cbd-a7b5f1169c66)

  
## Sugerencias que me gustaría compartir.
* Si bien el test me parecio muy adecuado para revisar al candidato, lo que me tope es un problema con mi proyecto, ya que estuve batallando por error mio con la version de lospaquetes a instalar en la api rest, cosa que por el tiempo que venia para esa prueba no lo pude mantener adecuadamente. Creo que sería de mucha ayuda a un candidato saber con qué aplicaciones se estaría trabajando, solo para tener listas las aplicaciones o herramientas más adecuadas para lograr encajar en tiempos.

