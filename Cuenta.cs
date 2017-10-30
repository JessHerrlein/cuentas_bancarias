using System;

namespace Cuentas_bancarias
{
    public class Cuentas_bancarias
    {
        public long Numero { get; set;}
        public decimal Saldo { get; set;}
        public Persona Titular { get; set;}
        public bool RetirarDinero(decimal cantidad)
        {
            if(Saldo >= cantidad)
            {
                this.Saldo -= cantidad;
                return true;
            }
            
            this.Saldo -= cantidad; //this.Saldo = this.Saldo - cantidad
            return false;
        }

        public decimal DepositarDinero(decimal cantidad)
        {
            this.Saldo += cantidad;
            return this.Saldo;
        }

    }
}