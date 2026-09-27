using QRCoder;
using System.Drawing.Imaging;

public class MainForm : Form
{
    private readonly TextBox _txtDatos;
    private readonly Button _btnGenerar;
    private readonly SaveFileDialog _dlgGuardar;

    public MainForm()
    {
        Text = "Generador de QR";
        Size = new Size(460, 150);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        StartPosition = FormStartPosition.CenterScreen;

        var lbl = new Label
        {
            Text = "Dirección o texto:",
            Location = new Point(20, 18),
            AutoSize = true
        };

        _txtDatos = new TextBox
        {
            Location = new Point(20, 40),
            Width = 405
        };

        _btnGenerar = new Button
        {
            Text = "Generar QR",
            Location = new Point(170, 75),
            Width = 120
        };
        _btnGenerar.Click += OnGenerarClick;

        _dlgGuardar = new SaveFileDialog
        {
            Filter = "Imagen PNG|*.png",
            DefaultExt = "png",
            FileName = "qr",
            Title = "Guardar QR como..."
        };

        Controls.AddRange(new Control[] { lbl, _txtDatos, _btnGenerar });
    }

    private void OnGenerarClick(object? sender, EventArgs e)
    {
        string datos = _txtDatos.Text.Trim();
        Console.WriteLine($"Procesando {datos}");
        if (string.IsNullOrEmpty(datos))
        {
            MessageBox.Show(this, "Ingresa una dirección o texto.", "Atención",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (_dlgGuardar.ShowDialog(this) != DialogResult.OK)
        {
            Console.WriteLine("Saliendo del procesamiento");
            return;
        }
        
        try
        {
            Console.WriteLine("Iniciando generación del QR");
            using var generator = new QRCodeGenerator();
            using var qrData = generator.CreateQrCode(datos, QRCodeGenerator.ECCLevel.H);
            using var code = new QRCode(qrData);
            using var bitmap = code.GetGraphic(20);
            bitmap.Save(_dlgGuardar.FileName, ImageFormat.Png);
            Console.WriteLine("QR Finalizado");
            MessageBox.Show(this, $"QR guardado en:\n{_dlgGuardar.FileName}", "Listo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"ERR: {ex.Message} \n\n{ex.StackTrace}");
            MessageBox.Show(this, $"Error al generar el QR:\n{ex.Message}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing) _dlgGuardar?.Dispose();
        base.Dispose(disposing);
    }
}
