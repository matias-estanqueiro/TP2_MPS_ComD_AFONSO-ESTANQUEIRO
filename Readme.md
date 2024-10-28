# Product Management System

Este proyecto es un sistema de gestión de productos en C#, desarrollado como aplicación de escritorio con Windows Forms. La aplicación permite agregar productos, calcular el precio con impuestos, y buscar productos por nombre. Además, incluye una suite de pruebas unitarias con NUnit para garantizar la correcta funcionalidad de los componentes clave.

## Características del Proyecto

- **Agregar Producto**: Permite agregar productos con un nombre, precio y categoría.
- **Cálculo de Precio con Impuestos**: Calcula el precio total aplicando un impuesto del 10% para productos de categoría "Electrónica" y un 5% para productos de "Alimentos".
- **Búsqueda de Producto**: Permite buscar productos por nombre.
- **Visualización en Grilla**: La aplicación muestra todos los productos en una grilla, con opción de filtrar por producto buscado.

## Estructura del Proyecto

La solución incluye dos proyectos:
1. **ProductManagementSystem**: Proyecto principal de la aplicación.
2. **ProductManagementSystemTests**: Proyecto de pruebas unitarias que utiliza NUnit.

## Configuración del Entorno

### Prerrequisitos

- .NET SDK 6.0 o superior
- Visual Studio 2022 o compatible (recomendado)
- NUnit y NUnit3TestAdapter (instalados en el proyecto de pruebas)

### Instalación

1. Clona el repositorio:
    ```bash
    git clone https://github.com/usuario/ProductManagementSystem.git
    cd ProductManagementSystem
    ```
2. Abre la solución en Visual Studio.

3. **Configura las Referencias**:
   - Asegúrate de que el proyecto de pruebas (`ProductManagementSystemTests`) tiene una referencia al proyecto principal (`ProductManagementSystem`):
     - En el Explorador de Soluciones, haz clic derecho en `ProductManagementSystemTests`.
     - Selecciona **Agregar** > **Referencia** y marca el proyecto `ProductManagementSystem`.

## Ejecución de la Aplicación

Para compilar y ejecutar la aplicación, sigue estos pasos en Visual Studio:

1. Configura `ProductManagementSystem` como el proyecto de inicio.
2. Presiona `F5` o selecciona **Iniciar depuración** para ejecutar la aplicación.

## Ejecución de Pruebas Unitarias

El proyecto de pruebas (`ProductManagementSystemTests`) contiene pruebas unitarias de las funcionalidades principales.

1. Abre la **Ventana de Pruebas** en Visual Studio.
2. Haz clic en **Ejecutar Todas** o ejecuta `dotnet test` en la terminal desde el directorio raíz del proyecto.

### Pruebas Incluidas

Las pruebas cubren los siguientes casos:

- Creación de producto con propiedades válidas.
- Verificación de que `AddProduct` agrega productos correctamente.
- Búsqueda de productos por nombre con `FindProductByName`.
- Cálculo correcto de precios con impuestos para categorías "Electrónica" y "Alimentos".
