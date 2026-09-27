# Generador de QR — .NET 10 (código fuente)

> Esta carpeta contiene el código fuente. Si solo quieres **usar** la herramienta, descarga `GeneradorQR.exe` desde la sección [Releases](../../releases) del repositorio.

---

## Compilar y actualizar el ejecutable

### Requisitos

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)

### Ejecutar en desarrollo

```bash
dotnet run
```

---

### Opción A — Framework-dependent (así fue creado el archivo que se encuentra en la carpeta /binarios/)

El ejecutable es pequeño (~500KB) pero **requiere que el .NET 10 Desktop Runtime esté instalado** en la máquina donde se ejecute.

```bash
dotnet publish -c Release -r win-x64 --no-self-contained -p:PublishSingleFile=true
```

El archivo generado quedará en:

```
bin\Release\net10.0-windows\win-x64\publish\GeneradorQR.exe
```

#### Cómo instalar el .NET 10 Desktop Runtime (para el usuario final)

Si al abrir el `.exe` aparece un error de runtime, el usuario debe instalar el **Windows Desktop Runtime 10**:

1. Ir a [https://dotnet.microsoft.com/download/dotnet/10.0](https://dotnet.microsoft.com/download/dotnet/10.0)
2. En la sección **".NET Desktop Runtime"**, descargar el instalador para **Windows x64**
3. Ejecutar el instalador y seguir los pasos
4. Volver a abrir `GeneradorQR.exe`

> En muchos casos, Windows detecta automáticamente que falta el runtime y ofrece un enlace de descarga directa al abrirse el `.exe`.

---

### Opción B — Self-contained (sin dependencias, mayor tamaño)

El ejecutable incluye el runtime de .NET dentro (~110MB). No requiere ninguna instalación previa.

> **Nota:** WinForms no es compatible con la opción de recorte (`PublishTrimmed`), por lo que el tamaño no puede reducirse.

```bash
dotnet publish -r win-x64 --self-contained -p:PublishSingleFile=true -c Release
```

El archivo generado quedará en:

```
bin\Release\net10.0-windows\win-x64\publish\GeneradorQR.exe
```

---

## Dependencias

| Paquete | Versión | Propósito |
|---------|---------|-----------|
| [QRCoder](https://github.com/codebude/QRCoder) | 1.6.0 | Generación del QR en formato PNG, código abierto |

## Privacidad

El QR se genera en el equipo del usuario usando `QRCoder`, una librería .NET de código abierto. Ningún dato es enviado a internet.
