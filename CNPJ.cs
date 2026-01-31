using System.Text.RegularExpressions;

namespace LibCNPJAlfanumerico
{
    public static class CNPJ
    {
        private static int Calcular_DigitoVerificador(string cnpj)
        {
            List<int> listCNPJ = new List<int>();

            int peso = 2;
            int soma = 0;
            int digito = 0;
            foreach (char c in cnpj.Reverse())
            {
                listCNPJ.Add(c - 48);

                int indiceAtual = listCNPJ.Count - 1;

                listCNPJ[indiceAtual] *= peso;

                soma += listCNPJ[indiceAtual];
                peso = peso == 9 ? 2 : peso + 1;

                digito = soma % 11 == 0 || soma % 11 == 1 ? 0 : 11 - soma % 11;
            }

            return digito;
        }

        public static bool Validar(string cnpj)
        {
            if (string.IsNullOrEmpty(cnpj)) return false;
            if (cnpj.Length != 14) return false;
            if (cnpj.Equals("00000000000000")) return false;

            string cnpjSemDigito = cnpj.Substring(0, 12);
            int digito1 = Calcular_DigitoVerificador(cnpjSemDigito);
            int digito2 = Calcular_DigitoVerificador($"{cnpjSemDigito}{digito1}");

            if (cnpj.Substring(12).Equals($"{digito1}{digito2}"))
            {
                return true;
            }
            return false;
        }

        public static string Limpar(string cnpj)
        {
            if (string.IsNullOrEmpty(cnpj)) throw new ArgumentNullException("cnpj", "Não é possível limpar um CNPJ nulo ou vazio");

            string cnpjLimpo = Regex.Replace($"{cnpj}", @"[^a-zA-Z0-9]", "");

            if (cnpjLimpo.Length < 14)
            {
                cnpjLimpo = cnpjLimpo.PadLeft(14, '0');
            }

            cnpjLimpo = cnpjLimpo.Substring(cnpjLimpo.Length - 14, 14);

            return cnpjLimpo.ToUpper();
        }
    }
}
