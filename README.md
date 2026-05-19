# Sistema de Gestión de Clientes y Autenticación de Empleados

## 💻 Descripción
Aplicación de escritorio desarrollada en C# con Windows Forms para la gestión interna de una empresa proveedora de servicios. El sistema permite la autenticación de empleados y el registro de nuevos clientes, calculando automáticamente las tarifas según el servicio contratado, con persistencia de datos en una base de datos relacional.

## 🛠️ Tecnologías y Herramientas
* **Lenguaje de Programación:** C#
* **Interfaz:** Windows Forms (.NET)
* **Base de Datos:** MySQL
* **Librerías:** MySql.Data

## 🚀 Funcionalidades Principales
* **Login de usuarios:** Validación de credenciales de empleados contra la base de datos.
* **Alta de clientes:** Formulario de registro con cálculo dinámico del precio final según el tipo de servicio (Cable, Internet, Teléfono, Pack Completo).
* **Visualización de datos:** Listado general de todos los clientes registrados en el sistema.

## ⚙️ Instalación y Uso
Para probar este proyecto en tu entorno local:
1. Clonar el repositorio.
2. Importar el archivo `internet.sql` en tu servidor MySQL local (usando XAMPP o MySQL Workbench).
3. Asegurarse de tener instalada la extensión `MySql.Data` en Visual Studio (vía NuGet).
4. Abrir el archivo `.sln`, compilar y ejecutar.

## 📈 Mejoras a Futuro (To-Do)
*Como parte de mi aprendizaje continuo, tengo identificadas las siguientes oportunidades de mejora para escalar el proyecto:*
* Implementar el encriptado de contraseñas (hasheo) en la base de datos para mayor seguridad.
* Agregar manejo de excepciones (bloques `try-catch`) para evitar cierres inesperados si el servidor de base de datos se desconecta.
