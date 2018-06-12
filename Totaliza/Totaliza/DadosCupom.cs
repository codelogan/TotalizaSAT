using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Totaliza
{
    public class DadosCupom
    {
        public  DadosCupom() { }
        public DadosCupom(int _numero, DateTime _data, decimal _valor, string _id, string _chcanc)
        {
            this.p_numero = _numero;
            this.p_data = _data;
            this.p_valor = _valor;
            this.p_id = _id;
            this.p_chcanc = _chcanc;
        }

        private int p_numero=0;
        private DateTime p_data = DateTime.Now;
        private decimal p_valor = 0;
        private string p_id = "";
        private string p_chcanc = "";

        public int Numero
        {
            get { return p_numero; }
            set { p_numero = value; }
        }
        public DateTime Data
        {
            get { return p_data; }
            set { p_data = value; }
        }
        public decimal Valor
        {
            get { return p_valor; }
            set { p_valor = value; }
        }
        public string id
        {
            get { return p_id; }
            set { p_id = value; }
        }
        public string chcanc
        {
            get { return p_chcanc; }
            set { p_chcanc = value; }
        }

        public static decimal SomaLista(List<DadosCupom> lista)
        {
            decimal total=0;
            foreach (DadosCupom DadosCupom in lista)
                if (DadosCupom.p_chcanc.Length == 0)
                {
                    total = total + DadosCupom.p_valor;
                }
            return total;
        }
        public static decimal Soma(Hashtable hashtableCupons)
        {
            decimal total = 0;
            foreach (DictionaryEntry entry in hashtableCupons)
                if (((DadosCupom)hashtableCupons[entry.Key]).p_chcanc.Length == 0)
                {
                    total = total + ((DadosCupom)hashtableCupons[entry.Key]).p_valor;
                }
            return total;
        }
    }
}
