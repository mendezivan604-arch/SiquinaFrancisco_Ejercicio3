int tipoCliente;
int metodoPago;
int antifraude;

double montoBase;
double descuento = 0;
double recargo = 0;

string tieneCupon;
string codigoCupon = "";

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
