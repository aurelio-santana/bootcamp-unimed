using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploConstrutores.Models
{
    public class Data
    {
        private int mes;
        private bool mesValido;

        public int GetMes()
        {
            return this.mes;
        }

        public void SetMes(int mes)
        {
            if (mes > 0 && mes <= 12)
            {
                this.mes = mes;
                this.mesValido = true;
            }
        }

        public int Mes //Utilizando Propriedade ao invés de métodos Get e Set
        {
            get
            {
                return this.mes;
            }

            set
            {
                if (value > 0 && value <= 12) //Value representa o valor após o igual em data.Mes = 12
                {
                    this.mes = value;
                    this.mesValido = true;
                }
            }
        }

        public void ApresentarMes()
        {
            if (this.mesValido)
            {
                System.Console.WriteLine(this.mes);
            }
            else
            {
                System.Console.WriteLine("Mês inválido!");
            }
        }
    }
}