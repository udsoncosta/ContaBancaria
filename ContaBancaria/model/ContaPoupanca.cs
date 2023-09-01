using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria.model
{
    public class ContaPoupanca : Conta
    {

        private int aniversario;
        public ContaPoupanca(int numero, int agencia, int tipo, string titular, decimal saldo, int aniversario) 
            : base(numero, agencia, tipo, titular, saldo)
        {
            this.aniversario = aniversario;
        }
        public int GetAniversario() 
        {
            return this.aniversario;
        }
        public void SetAniversario(int aniversario)
        {
            this.aniversario = aniversario;
        }


        //Polimorfismo de sobrescrita
        public override bool Sacar(decimal valor)
        {
            if (this.GetSaldo() + this.aniversario < valor)
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
            Console.WriteLine($"Aniversario da Conta: {this.aniversario}");
        }

    }
}
