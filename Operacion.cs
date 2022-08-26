using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Operacion
    {

        private static string? PorcentageStringNumber;
        private static double PorcentageNumber;
        
        private static string? SymbolStringNumber;
        private static double SymbolNumber;

        private static string? SymbolInFormula;

        public Operacion()
        {

        }

        /// <summary>
        /// Método que recibe un operación con porcentajes en formato de string, 
        /// convierte a número y realiza las operaciones de porcentaje
        /// </summary>
        /// <param name="formula">Este parámetro es un string con la operación de porcentaje</param>
        /// <returns>El resultado de la operación de porcentaje</returns>
        public static double Porcentage(string formula)
        {
            if (formula.Contains("+"))
            {
                SymbolInFormula = "+";
            } 
            
            else if (formula.Contains("-"))
            {
                SymbolInFormula = "-";
            } 
            
            else if (formula.Contains("*"))
            {
                SymbolInFormula = "*";
            }
             
            else if (formula.Contains("/"))
            {
                SymbolInFormula = "/";
            }


            try
            {
                //obtiene el numero antes del simbolo de porcentaje y lo convierte a double
                PorcentageStringNumber = formula.Substring(0, formula.IndexOf("%"));
                PorcentageStringNumber = PorcentageStringNumber.Substring(formula.IndexOf(SymbolInFormula) + 1);
                PorcentageNumber = Convert.ToDouble(PorcentageStringNumber) / 100;

                //Obtiene el número antes de un simbolo + - * /
                if (formula.Contains("*"))
                {
                    SymbolStringNumber = formula.Substring(0, formula.IndexOf("*"));
                    SymbolNumber = Convert.ToDouble(SymbolStringNumber);
                    return SymbolNumber * PorcentageNumber;

                }

                if (formula.Contains("/"))
                {
                    SymbolStringNumber = formula.Substring(0, formula.IndexOf("/"));
                    SymbolNumber = Convert.ToDouble(SymbolStringNumber);
                    return SymbolNumber / PorcentageNumber;

                }

                if (formula.Contains("+"))
                {
                    SymbolStringNumber = formula.Substring(0, formula.IndexOf("+"));
                    SymbolNumber = Convert.ToDouble(SymbolStringNumber);
                    return SymbolNumber + (PorcentageNumber * 100) / 2;

                }

                if (formula.Contains("-"))
                {
                    SymbolStringNumber = formula.Substring(0, formula.IndexOf("-"));
                    SymbolNumber = Convert.ToDouble(SymbolStringNumber);
                    return SymbolNumber - (PorcentageNumber * 100) / 2;

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }

            return 0;
        }

    }
}
