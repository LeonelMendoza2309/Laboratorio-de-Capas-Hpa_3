<div align="center">

# LABORATORIO: LOGIN DE USUARIO

Universidad Tecnológica de Panamá  
Facultad de Ingeniería en Sistemas y Computación  
Licenciatura en Ingeniería de Sistemas Computacionales

</div>

## Descripción del laboratorio

Este proyecto corresponde al laboratorio de la carpeta `Login De Usuario` y en si consiste en una solucion con distintas capas cada una con su respectivo codigo.

La solución está organizada en cuatro capas principales:

- `Entidades`: define los modelos de datos.
- `Datos`: realiza la conexión a la base de datos y las consultas.
- `Negocio`: aplica la lógica de negocio.
- `Presentación`: contiene la interfaz gráfica del sistema.

---

## Objetivo

Implementar un sistema de login funcional utilizando una arquitectura en capas y una base de datos relacional, aplicando conceptos de:

- Conexión a MySQL desde C#.
- Separación de responsabilidades por capas.
- Validación de credenciales de usuario.
- Manejo de formularios Windows Forms.

---

## Funcionalidades

- Inicio de sesión con usuario y contraseña.
- Validación de credenciales contra la base de datos.
- Mensaje de bienvenida al acceder correctamente.
- Mensaje de error si las credenciales son incorrectas.
- Acceso a una pantalla principal tras iniciar sesión.
- Estructura modular para mantener el código ordenado y reutilizable.

---

## Estructura del laboratorio (Solución)

```text
Laboratorio-de-Capas-Hpa_3/
├── Login De Usuario/
│   ├── Datos/
│   │   ├── D_Conexion.cs          # Cadena de conexión a MySQL
│   │   ├── D_Usuario.cs            # Lógica de acceso a datos del usuario
│   │   ├── Datos.csproj            # Proyecto de la capa de datos
│   │   └── ...                     # Archivos de compilación
│   │
│   ├── Entidades/
│   │   ├── E_Usuario.cs            # Clase modelo del usuario
│   │   ├── Entidades.csproj        # Proyecto de la capa de entidades
│   │   └── ...
│   │
│   ├── Negocio/
│   │   ├── N_Usuario.cs            # Lógica de negocio para login
│   │   ├── Negocio.csproj          # Proyecto de la capa de negocio
│   │   └── ...
│   │
│   ├── Presentación/
│   │   ├── frmLogin.cs             # Formulario de inicio de sesión
│   │   ├── frmLogin.Designer.cs    # Diseñador del formulario
│   │   ├── frmPrincipal.cs         # Pantalla principal después del login
│   │   ├── Program.cs              # Punto de entrada de la aplicación
│   │   ├── Presentación.csproj     # Proyecto de la capa de presentación
│   │   └── ...
│   │
│   ├── Login De Usuario.slnx      # Solución del proyecto
│   └── .vs/                        # Configuración local de Visual Studio
│
└── 
```

---

## Componentes principales

### `Entidades`

Contiene la clase `E_Usuario`, la cual representa la estructura del usuario con atributos como:

- `ID`
- `dsUsuario`
- `dsPassword`
- `dsEstado`
- `dsUsuarioCreacion`
- `dtFechaCreacion`
- `idUsuarioModificacion`
- `dtFechaModificacion`

### `Datos`

En esta capa se encuentran:

- `D_Conexion.cs`: define la cadena de conexión a la base de datos.
- `D_Usuario.cs`: ejecuta el procedimiento almacenado `sp_ValidarLoginHash` para validar las credenciales.

### `Negocio`

La clase `N_Usuario` sirve como intermediario entre la capa de presentación y la capa de datos. Aquí se centraliza la lógica del login.

### `Presentación`

Contiene los formularios de la aplicación:

- `frmLogin`: formulario principal para autenticar al usuario.
- `frmPrincipal`: ventana que se muestra una vez que el usuario accede correctamente.

---

## Base de datos

El proyecto utiliza una base de datos llamada `db_sistema_login` y una tabla `Usuario`.

### Script de creación

El archivo `SISTEMALOGIN.sql` incluye la creación de la base de datos y la tabla de usuarios, además de un procedimiento almacenado para validar credenciales.

### Estructura principal de la tabla

```sql
CREATE TABLE IF NOT EXISTS Usuario (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    dsUsuario VARCHAR(50) NOT NULL,
    dsPassword VARBINARY(64) NOT NULL,
    dsEstado CHAR(1) NOT NULL DEFAULT '1',
    dsUsuarioCreacion VARCHAR(50) DEFAULT NULL,
    dtFechaCreacion DATETIME DEFAULT CURRENT_TIMESTAMP,
    idUsuarioModificacion VARCHAR(50) DEFAULT NULL,
    dtFechaModificacion DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
);
```

También se define el procedimiento:

```sql
sp_ValidarLoginHash
```

Este procedimiento compara el nombre de usuario y la contraseña ingresada con un valor encriptado mediante hash.

---

## Tecnologías utilizadas

- C#
- Windows Forms (.NET)
- MySQL
- MySql.Data connector
- Visual Studio
- Arquitectura por capas

---

## Requisitos

Para ejecutar este proyecto correctamente se necesita:

- Windows 10 o posterior.
- Visual Studio 2019 o superior.
- .NET Framework compatible con el proyecto.
- MySQL Server instalado y en ejecución.
- MySQL Workbench o una herramienta similar para importar el script SQL.

---

## Configuración

### 1. Importar la base de datos

Ejecuta el archivo `SISTEMALOGIN.sql` en MySQL para crear la base de datos y las tablas necesarias.

### 2. Ajustar la cadena de conexión

En el archivo:

```text
Login De Usuario/Datos/D_Conexion.cs
```

debe configurarse la conexión según el entorno local:

```csharp
public static string cadenaConexion = "server = localhost; database = db_sistema_login; Uid = root; Pwd = tu_contraseña";
```

### 3. Ejecutar la solución

1. Abrir `Login De Usuario.slnx` en Visual Studio.
2. Verificar que el proyecto de inicio sea `Presentación`.
3. Restaurar paquetes NuGet si es necesario.
4. Compilar y ejecutar la aplicación.

---

## Flujo de autenticación

1. El usuario ingresa su nombre de usuario y contraseña en `frmLogin`.
2. La capa de presentación llama a la capa de negocio.
3. `N_Usuario.Login(...)` invoca a `D_Usuario.Login(...)`.
4. La capa de datos ejecuta el procedimiento almacenado `sp_ValidarLoginHash`.
5. Si los datos coinciden, el usuario recibe un mensaje de bienvenida y se abre `frmPrincipal`.
6. Si no coinciden, el sistema muestra un error de autenticación.

---

## Problemas comunes

| Problema | Solución |
|---|---|
| No conecta a la base de datos | Verificar que MySQL esté activo y que la cadena de conexión sea correcta. |
| Error de login aunque el usuario existe | Comprobar que la contraseña se esté validando con el mismo formato de hash esperado por la base de datos. |
| Falta de referencias | Restaurar NuGet y verificar que se hayan agregado las referencias de MySql.Data. |
| La solución no abre | Revisar que el proyecto `Presentación` esté configurado como proyecto de inicio. |

---

## Resultados esperados

- Sistema de autenticación funcional.
- Separación clara entre las capas de la aplicación.
- Uso correcto de MySQL como motor de persistencia.

<img width="719" height="388" alt="image" src="https://github.com/user-attachments/assets/d9cf6af4-3d84-40b1-92d4-16caa93988c8" />

<img width="718" height="388" alt="image" src="https://github.com/user-attachments/assets/87a3cddb-61bb-4dc4-9412-85173ed7ba73" />

<img width="718" height="390" alt="image" src="https://github.com/user-attachments/assets/49d3ab7b-6a71-4d76-b4bb-72dd3d331e72" />

<img width="609" height="396" alt="image" src="https://github.com/user-attachments/assets/880ca3ae-aef2-4908-b26b-3299cdf465db" />

---

## Conclusiones

Este laboratorio me permitió comprender de manera correcta los distintos conceptos como lo fueron la utilización y creación de capas y como estas pueden dar una estructura mas limpia y eficiente en la utilización de los proyectos en soluciones. Además, reforcé mis conocimientos en base a la creación y edición de las bases de datos.


