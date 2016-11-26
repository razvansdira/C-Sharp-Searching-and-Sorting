using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C_Sharp_Searching_and_Sorting
{
    class Exercise8
    {
        static void Main(string[] args)
        {
            List<Caracter> listChar = new List<Caracter>();
            listChar.Add(new Caracter('V'));
            listChar.Add(new Caracter('A'));
            listChar.Add(new Caracter('N'));

            Console.WriteLine(" The combinations of A, N and V are:");

            List<string> perm = Permutar(listChar, listChar.Count);

            foreach (string p in perm)
                Console.WriteLine(p);
            Console.ReadLine();
        }

        public static List<string> Permutar(List<Caracter> elem, int n)
        {
            List<string> perm = new List<string>();

            Queue<Data> a1 = new Queue<Data>();
            List<Caracter> vacia = new List<Caracter>();
            a1.Enqueue(new Data(vacia, n));

            while (a1.Count > 0)
            {
                Data d = a1.Dequeue();
                if (d.n == 0)
                {
                    string pActual = Concatenar(d.actual);
                    if (!perm.Contains(pActual))
                    {
                        perm.Add(pActual);
                    }
                }
                else
                {
                    for (int i = 0; i < elem.Count; i++)
                    {
                        if (!d.actual.Contains(elem[i]))
                        {
                            List<Caracter> lis = new List<Caracter>();
                            for (int k = 0; k < d.actual.Count; k++)
                            {
                                lis.Add(d.actual[k]);
                            }
                            lis.Add(elem[i]);
                            Data d1 = new Data(lis, d.n - 1);

                            a1.Enqueue(d1);
                        }
                    }
                }
            }

            return perm;
        }

        static string Concatenar(List<Caracter> listaCaracteres)
        {
            string spatiu = "   ";
            for (int i = 0; i < listaCaracteres.Count; i++)
            {
                spatiu += listaCaracteres[i].caracter;
            }
            return spatiu;
        }
    }

    class Data
    {
        public List<Caracter> actual;
        public int n;

        public Data(List<Caracter>actual, int n)
        {
            this.actual = actual;
            this.n = n;
        }
    }

    class Caracter
    {
        public char caracter;

        public Caracter(char caracter)
        {
            this.caracter = caracter;
        }
    }
}
