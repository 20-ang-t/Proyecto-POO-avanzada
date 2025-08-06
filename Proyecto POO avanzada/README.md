# README - Sistema de Gestión para CENSA Virtual

## Descripción del Proyecto 📋
Este proyecto es un sistema de gestión integral desarrollado para el Centro de Sistemas de Antioquia (CENSA) en Medellín. Es una aplicación de escritorio Windows Forms que permite administrar información de estudiantes, programas técnicos, matrículas y datos institucionales.

El sistema cuenta con:
- Autenticación de usuarios
- Gestión de estudiantes (CRUD completo)
- Visualización de programas técnicos ofrecidos
- Información institucional (misión, visión, políticas)
- Interfaz intuitiva con menú lateral
- Conexión a base de datos MySQL

## Características Principales ✨
- **Interfaz moderna** con controles personalizados
- **Sistema de ventanas** con minimizar/maximizar/cerrar
- **Menú lateral** con iconos para navegación
- **Validación de datos** en formularios
- **Conexión a base de datos** para persistencia de información
- **Diseño responsive** que se adapta a diferentes tamaños de pantalla

## Tecnologías Utilizadas 🛠️
- C# (.NET 8.0)
- Windows Forms
- MySQL
- Entity Framework
- FontAwesome (para iconos)
- Controles personalizados RJ (TextBox, Button)

## Instalación y Configuración ⚙️
1. Clonar el repositorio
2. Restaurar paquetes NuGet
3. Configurar la cadena de conexión a MySQL en `Form4.cs`
4. Ejecutar el proyecto

Requisitos:
- .NET 8.0 SDK
- MySQL Server
- Visual Studio 2022 (recomendado)

## Estructura del Proyecto 📂
```
CENSA-Virtual/
│
├── 📁 src/
│   ├── 📁 Application/              # Lógica de aplicación
│   │   ├── 📁 Services/             # Servicios de negocio
│   │   ├── 📁 DTOs/                 # Objetos de transferencia de datos
│   │   └── 📁 Interfaces/           # Interfaces de servicios
│   │
│   ├── 📁 Domain/                   # Dominio del negocio
│   │   ├── 📁 Models/               # Entidades del dominio
│   │   ├── 📁 Enums/                # Enumeraciones
│   │   └── 📁 Exceptions/           # Excepciones personalizadas
│   │
│   ├── 📁 Infrastructure/           # Infraestructura
│   │   ├── 📁 Data/                 # Acceso a datos
│   │   │   ├── 📁 Repositories/     # Repositorios
│   │   │   └── 📄 DbContext.cs      # Contexto de base de datos
│   │   ├── 📁 Helpers/              # Utilidades
│   │   └── 📁 Migrations/           # Migraciones de BD
│   │
│   ├── 📁 Presentation/             # Capa de presentación
│   │   ├── 📁 Forms/                # Formularios Windows Forms
│   │   │   ├── 📄 LoginForm.cs      # Formulario de autenticación
│   │   │   ├── 📄 MainForm.cs       # Dashboard principal
│   │   │   ├── 📄 StudentsForm.cs   # Gestión de estudiantes
│   │   │   └── ...                  # Otros formularios
│   │   ├── 📁 Controls/             # Controles personalizados
│   │   └── 📁 Resources/            # Recursos (imágenes, etc.)
│   │
│   └── 📄 Program.cs                # Punto de entrada
│
├── 📁 docs/                         # Documentación
│   ├── 📄 ER-Diagram.png            # Diagrama entidad-relación
│   ├── 📄 Architecture.md           # Documentación arquitectura
│   └── 📄 User-Manual.md            # Manual de usuario
│
├── 📁 scripts/                      # Scripts útiles
│   ├── 📄 database-setup.sql        # Script de creación de BD
│   └── 📄 seed-data.sql             # Datos iniciales
│
├── 📄 .gitignore
├── 📄 LICENSE.md
├── 📄 README.md                     # Documentación principal
└── 📄 CENSA-Virtual.sln             # Solución Visual Studio
```

## Uso del Sistema 🖥️
1. Iniciar sesión con usuario "Censa" y contraseña "12345"
2. Navegar por las diferentes secciones usando el menú lateral
3. Registrar nuevos estudiantes o consultar información existente
4. Explorar los programas técnicos disponibles

## Capturas de Pantalla 🖼️
(Se pueden agregar imágenes de las diferentes pantallas del sistema)

## Contribución 🤝
Las contribuciones son bienvenidas. Por favor, abre un issue o pull request para proponer mejoras.

## Licencia 📄
Este proyecto está bajo la licencia MIT.

---

## Descripción para el Repositorio (GitHub/GitLab)

**Sistema de Gestión Educativa para CENSA Virtual**

Aplicación de escritorio desarrollada en C# y Windows Forms para la gestión académica del Centro de Sistemas de Antioquia (CENSA). Incluye módulos para administración de estudiantes, programas técnicos, matrículas e información institucional, con conexión a base de datos MySQL.

Características destacadas:
- Interfaz intuitiva con controles personalizados
- CRUD completo para gestión de estudiantes
- Catálogo de programas técnicos
- Información institucional organizada
- Sistema de autenticación

Tecnologías: C#, .NET 8, Windows Forms, MySQL, Entity Framework, FontAwesome.

Ideal para instituciones educativas que necesiten un sistema de gestión académica completo y fácil de usar.