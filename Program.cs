using System;

namespace Cuentas_bancarias
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio Cuentas");
            Persona morty = new Persona();
            morty.Nombre = "Morty";
            morty.Apellido = "Smith";
            morty.DNI = 38234293;
            morty.Mail = "morty@mail.com";
            morty.FechaDeNacimiento = new DateTime(1990, 5, 1);

            Cuenta cuenta1 = new Cuenta();
            cuenta1.NumeroCuenta = 231231;
            cuenta1.Saldo = 0;
            cuenta1.titularCuenta = morty;

            cuenta1.DepositarDinero(4000);
            cuenta1.RetirarDinero(200);

            Console.WriteLine("La cuenta tiene un saldo de: " + cuenta1);
        }
    }
}
