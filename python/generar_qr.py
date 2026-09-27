import tkinter as tk
from tkinter import filedialog, messagebox
import segno


def generar():
    datos = entrada.get().strip()
    if not datos:
        messagebox.showwarning("Atención", "Ingresa una dirección o texto.")
        return

    ruta = filedialog.asksaveasfilename(
        defaultextension=".png",
        filetypes=[("Imagen PNG", "*.png")],
        initialfile="qr",
        title="Guardar QR como...",
    )
    if not ruta:
        return

    try:
        qr = segno.make(datos, error="H")
        qr.save(ruta, scale=10)
        messagebox.showinfo("Listo", f"QR guardado en:\n{ruta}")
    except Exception as e:
        messagebox.showerror("Error", str(e))


ventana = tk.Tk()
ventana.title("Generador de QR")
ventana.resizable(False, False)
ventana.geometry("440x130")

tk.Label(ventana, text="Dirección o texto:").pack(padx=20, pady=(20, 4), anchor="w")
entrada = tk.Entry(ventana, width=58)
entrada.pack(padx=20)
tk.Button(ventana, text="Generar QR", command=generar, padx=12, pady=4).pack(pady=14)

ventana.mainloop()
