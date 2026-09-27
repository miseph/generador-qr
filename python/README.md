# Generador de QR — Versión Python

Genera códigos QR en tu propio equipo, sin enviar datos a internet. Funciona en Windows, Mac y Linux.

---

## Antes de empezar: ¿tienes Python instalado?

Abre una terminal (en Windows: busca "Símbolo del sistema" o "PowerShell" en el menú Inicio) y escribe:

```
python --version
```

Si ves algo como `Python 3.11.0`, ya está instalado. Si no, descárgalo desde [python.org](https://www.python.org/downloads/) (versión 3.8 o superior). Durante la instalación, **marca la opción "Add Python to PATH"**.

---

## Instalación

Ejecuta este comando en la terminal:

```
pip install segno
```

Verás una serie de líneas y al final el mensaje `Successfully installed segno-...`.

---

## Uso

En la terminal, navega hasta la carpeta `python/` y ejecuta:

```
python generar_qr.py
```

Se abre una ventana donde:

1. Escribe la dirección, URL o texto que quieres convertir en QR
2. Presiona **Generar QR**
3. Elige dónde guardar el archivo `.png`

---

## Privacidad

El QR se genera completamente en tu equipo. Ningún dato es enviado a internet.
