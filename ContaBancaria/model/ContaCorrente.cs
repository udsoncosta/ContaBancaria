﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria.model
{
    public class ContaCorrente : Conta
    {

        private decimal limite;

        public ContaCorrente(int numero, int agencia, int tipo, string titular, decimal saldo, decimal limite) 
            : base(numero, agencia, tipo, titular, saldo)
        {
            this.limite = limite;
        }

        public decimal GetLimite()
        {
            return this.limite;
        }
        public void SetLImite(decimal limite)
        {
            this.limite = limite;
        }

        //Polimorfismo de sobrescrita
        public override bool Sacar(decimal valor)
        {
            if (this.GetSaldo() + this.limite < valor)
            {
                Console.WriteLine("\n Saldo insuficiente!");
                return false;
            }
            this.SetSaldo(this.GetSaldo() - valor);
            return true;
        }

    
        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Limite da conta: {this.limite}");
        }
    }
}
