# Generador de QR — Herramienta Local

## ¿Por qué usar esta herramienta?

Los servicios web gratuitos para generar QR pueden registrar cada dirección o dato ingresado en sus servidores. No siempre es posible saber qué hacen con esa información, y existe el riesgo de que sea reutilizada, cedida a terceros o empleada para rastreo.

Esta herramienta genera los códigos QR **en tu propio equipo**, sin conectarse a internet.

---

## Cómo usarla

### Opción A — Ejecutable para Windows (recomendado, sin instalar nada)

1. Abre la carpeta [`binarios/`](binarios/)
2. Haz doble clic en `GeneradorQR.exe`
3. Escribe la dirección o URL y presiona **Generar QR**
4. Elige dónde guardar la imagen `.png`

> Ver [`binarios/README.md`](binarios/README.md) si Windows muestra una advertencia al abrir el archivo.

### Opción B — Versión Python (Windows, Mac y Linux)

Requiere tener Python instalado en el equipo. Ver el paso a paso en [`python/README.md`](python/README.md).

---

## Para quien mantiene o actualiza esta herramienta

- El ejecutable de la carpeta `binarios/` se genera a partir del código fuente en `dotnet/`
- Las instrucciones para compilarlo y actualizarlo están en [`dotnet/README.md`](dotnet/README.md)

---

## Estructura del proyecto

```
GeneradorQR/
├── binarios/
│   ├── GeneradorQR.exe     ← programa listo para usar (Windows)
│   └── README.md           ← instrucciones de uso del ejecutable
├── python/
│   ├── generar_qr.py       ← código fuente Python
│   ├── requirements.txt
│   └── README.md
└── dotnet/
    ├── GeneradorQR.csproj  ← código fuente .NET 10
    ├── Program.cs
    ├── MainForm.cs
    └── README.md
```
