int tipoCliente;
int metodoPago;
int antifraude;

double montoBase;
double descuento = 0;
double recargo = 0;

string tieneCupon;
string codigoCupon = "";
int ultimoNumero = 0;

Console.WriteLine("Tipo de cliente:");
Console.WriteLine("1 Estudiante");
Console.WriteLine("2 Docente");
Console.WriteLine("3 Administrativo");
Console.WriteLine("4 Externo");
tipoCliente = int.Parse(Console.ReadLine());

Console.Write("Monto base: ");
montoBase = double.Parse(Console.ReadLine());

Console.WriteLine("Metodo de pago:");
Console.WriteLine("1 Efectivo");
Console.WriteLine("2 Tarjeta");
Console.WriteLine("3 Transferencia");
metodoPago = int.Parse(Console.ReadLine());

Console.Write("Tiene cupon (S/N): ");
tieneCupon = Console.ReadLine();

if (tieneCupon == "S")
{
    Console.Write("Ingrese codigo del cupon: ");
    codigoCupon = Console.ReadLine();

    Console.Write("Ingrese el último número del cupón: ");
    ultimoNumero = int.Parse(Console.ReadLine());
}

Console.WriteLine("Reporte antifraude:");
Console.WriteLine("1 Ninguno");
Console.WriteLine("2 Cupon invalido repetido");
Console.WriteLine("3 Pagos rechazados multiples");
antifraude = int.Parse(Console.ReadLine());

switch (tipoCliente)
{
    case 1:
        switch (metodoPago)
        {
            case 1:
                descuento = montoBase * 0.10;
                break;

            case 2:
                descuento = montoBase * 0.07;
                break;
        }
        break;

    case 2:
        descuento = montoBase * 0.08;
        break;

    case 3:
        descuento = montoBase * 0.05;
        break;

    case 4:
        descuento = 0;
        break;
}

if (tieneCupon == "S")
{
    if (codigoCupon.StartsWith("U"))
    {
        if (ultimoNumero % 2 == 0)
        {
            descuento = descuento + (montoBase * 0.05);
        }
    }
}


if (antifraude == 2 || antifraude == 3)
{
    descuento = 0;

    if (antifraude == 2)
    {
        recargo = montoBase * 0.10;
    }
    else
    {
        recargo = montoBase * 0.15;
    }
}

double totalFinal = montoBase - descuento + recargo;

Console.WriteLine("Descuentos aplicados: " + descuento);
Console.WriteLine("Recargos: " + recargo);
Console.WriteLine("Total final: " + totalFinal);


