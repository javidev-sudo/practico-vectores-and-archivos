using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace practico_de_vectrores
{
    class Vector
    {
        const int MAX = 101;
        private int[] v;
        private int n;
        public Vector()
        {
            v = new int[MAX];
            n = 0;
        }

        public void cargar(int n1, int a, int b)
        {
            Random r;
            r = new Random();
            n = n1;
            for (int i = 1; i <= n; i++)
            {
                v[i] = r.Next(a, b + 1);
            }
        }
        public void Cargar(int ele)
        {
            n++;
            v[n] = ele;
        }

        public string Descargar()
        {
            string s = "";
            for (int i = 1; i <= n; i++)
            {
                s = s + v[i] + " | ";
            }

            return s;
        }
        public void cargarFi(int n1) // ejer 1
        {
            int a, b, c;
            a = -1; b = 1;
            n = n1;
            for (int i = n; i >= 1; i--)
            {
                c = a + b; a = b; b = c;
                v[i] = c;
            }

        }
        public void cargarFibo(int n1)
        {
            int a, b, c;
            a = -1; b = 1;
            n = n1;
            for (int i = 1; i <= n; i++)
            {
                c = a + b; a = b; b = c;
                v[i] = c;
            }

        }

        public double OperacionFibo() // ejer2

        {
            bool b = true;
            double resul = 0;
            double ser = 0;

            for (int i = 1; i <= n; i++)
            {
                ser = ser + 2;
                if (b)
                {
                    resul = resul + v[i] / ser;

                    b = !b;
                }
                else
                {
                    resul = resul - v[i] / ser;
                    b = !b;
                }
            }

            return resul;

        }



        public int EleMaPosiMul(int m)//ejer 3
        {
            int mayor = v[1];

            for (int i = 1; i <= n / m; i++)
            {

                if (v[i * m] > mayor)
                {
                    mayor = v[i * m];
                }
            }
            return mayor;
        }

        public int MediaPosMultM(int m) // ejer 4
        {
            int s = 0;
            for (int i = 1; i <= n / m; i++)
            {
                s = s + v[i * m];
            }

            return s / (n / m);
        }


        public void MultYNomult(int m, ref Vector r1, ref Vector r2)//ejer 5
        {
            r1.n = 0;
            r2.n = 0;

            for (int i = 1; i <= n; i++)
            {
                if (v[i] % m == 0)
                {
                    r1.Cargar(v[i]);
                }
                else
                {
                    r2.Cargar(v[i]);
                }
            }

        }


        public void inveVec()
        {
            int aux;
            for (int i = 1; i <= n / 2; i++) // ejer 6
            {
                aux = v[i];
                v[i] = v[n - (i - 1)];
                v[n - (i - 1)] = aux;
            }
        }

        public bool VerifOrde() // ejer 7
        {
            int i = 1;
            int aux = v[1];
            bool b = true;
            while ((i <= n) && (b))
            {
                if (aux != v[i])
                {
                    b = !b;
                }
                else
                {
                    i++;
                }
            }

            return b;
        }


        public void Elimpos(int pos)
        {
            for (int i = 1; i <= n - pos; i++)
            {
                v[pos + (i - 1)] = v[pos + i];
            }

            this.n = n - 1;
        }

        public void UniElementos(ref Vector ve, ref Vector vr) // ejer 8 ordenar de cualquier forma
        {
            vr.n = 0;
            for (int i = 1; i <= n; i++)
            {
                vr.Cargar(v[i]);
            }

            for (int i = 1; i <= ve.n; i++)
            {
                vr.Cargar(ve.v[i]);
            }

            for (int p = 1; p <= vr.n - 1; p++)
            {
                int fre = 0;

                for (int d = p + 1; d <= vr.n; d++) // 1,2,5,2,4,7,1
                {
                    if (vr.v[p] == vr.v[d])
                    {
                        fre++;
                    }
                }
                if (fre != 0)
                {
                    vr.Elimpos(p);
                    p = 0;
                }

            }
        }

        public bool Perte(int ele)
        {
            bool b = false;
            int i = 1;
            while ((i <= n) && (b == false))
            {
                if (ele == v[i])
                {
                    b = !b;
                }

                i++;
            }

            return b;
        }

        public void ElimRep()
        {
            for (int p = 1; p <= n - 1; p++)
            {
                int fre = 0;

                for (int d = p + 1; d <= n; d++)
                {
                    if (v[p] == v[d])
                    {
                        fre++;
                    }
                }
                if (fre != 0)
                {
                    this.Elimpos(p);
                    p = 0;
                }

            }
        }

        public void DifElemntos(ref Vector ve, ref Vector vr) //ejer 9
        {
            vr.n = 0;
            for (int i = 1; i <= n; i++)
            {
                if (!ve.Perte(v[i]))
                {
                    vr.Cargar(v[i]);
                }
            }
            vr.ElimRep();
        }


        public bool VerifSegOr(int a, int b)
        {
            int i = a;
            bool b1 = true;
            while ((i <= b - 1) && (b1))
            {
                if (v[i] > v[i + 1])
                {
                    b1 = !b1;
                }
                else
                {
                    i++;
                }

            }
            return b1;
        }


        public void ElimEleNoPrim()// ejer 1
        {
            bool b;
            int con;
            int c;
            int i = 1;

            while (i <= n)
            {
                con = 1;
                c = 0;
                while (con <= v[i])
                {
                    if ((v[i] % con) == 0)
                    {
                        c++;
                    }

                    con++;
                }

                b = (c == 2);
                if (!b)
                {
                    this.Elimpos(i);
                }
                else
                {
                    i++;
                }
            }


        }

        public void Inter(int pos, int pos2)
        {
            int aux = v[pos];
            v[pos] = v[pos2];
            v[pos2] = aux;
        }

        public void OrdBur()
        {
            for (int t = n; t >= 2; t--)
            {
                for (int d = 1; d <= t - 1; d++)
                {
                    if (v[d] > v[d + 1])
                    {
                        this.Inter(d, d + 1);
                    }
                }
            }
        }




        public void OrdBur(int a, int b)
        {
            for (int t = b; t >= a + 1; t--)
            {
                for (int d = a; d <= b - 1; d++)
                {
                    if (v[d] > v[d + 1])
                    {
                        this.Inter(d, d + 1);
                    }
                }
            }
        }

        public void OrdBurMaMe(int a, int b)
        {
            for (int t = b; t >= a + 1; t--)
            {
                for (int d = a; d <= b - 1; d++)
                {
                    if (v[d] < v[d + 1])
                    {
                        this.Inter(d, d + 1);
                    }
                }
            }
        }

        public void OrdMultM(int m) // ejer 2
        {

            for (int t = ((n / m) * m); t >= m; t = t - m)
            {
                for (int d = 1; d <= ((n / m) - 1); d++)
                {
                    if (v[d * m] > v[(d * m) + m])
                    {
                        this.Inter((d * m), ((d * m) + m));
                    }
                }
            }


        }


        public void OrdEspi()//ejer 3
        {
            int lim = n;
            int aux;
            this.OrdBur();
            if ((n % 2) != 0)
            {
                lim = n - 1;
            }

            for (int i = lim; i >= 2; i = i - 2)
            {
                aux = v[i];
                this.Elimpos(i);
                this.Cargar(aux);
            }
        }


        public int ConteleDif(int a, int b)
        {
            this.OrdBur(a, b);
            int cd = 1;

            for (int i = a; i <= b - 1; i++)
            {
                if (v[i] != v[i + 1])
                {
                    cd++;
                }
            }

            return cd;
        }



        public void EleMasRep(int a, int b, ref int ele, ref int fre) //Dictionary<String, int> 
        {

            this.OrdBur(a, b);
            int i, mayor, ele2;
            i = a;
            mayor = 0;

            //var result = new Dictionary<String, int>();

            while (i <= b)
            {
                ele2 = v[i];
                fre = 0;
                while ((i <= b) && (v[i] == ele2))
                {
                    fre++;
                    i++;
                }
                if (fre > mayor)
                {
                    mayor = fre;
                    ele = v[i - 1];
                    //result["elemento"] = ele;
                }

            }

            fre = mayor;
            // result["mayor"] = mayor;

            //return result;
        }


         public Dictionary<String, int> EleMasRepV2(int a, int b)
         {
             var numbers = new Dictionary<int, int>();
             int  i = a ;
             while (i <= b)
             {
                 int c = numbers.ContainsKey(v[i]) ? numbers[v[i]] : 0;
                 numbers[v[i]] = c + 1;
                 i++;
             }

             int frecM = 0;
             var result = new Dictionary<String, int>();
             foreach(var elem in numbers)
             {
                 if(frecM < elem.Value)
                 {
                     frecM = elem.Value;
                     result["elemento"] = elem.Key;
                     result["frecuencia"] = elem.Value;
                 }

             }
             return result;

         }


        public void EleRepSeg(int a, int b, ref Vector e, ref Vector f)
        {

            this.OrdBur(a, b);
            int ele, fr, i;
            e.n = 0;
            f.n = 0;
            i = a;

            while (i <= b)
            {
                ele = v[i];
                fr = 0;
                while ((i <= b) && (ele == v[i]))
                {
                    fr++;
                    i++;
                }

                e.Cargar(ele);
                f.Cargar(fr);

            }
        }

        private bool Esfibo(int d)
        {
            int a, b, c;
            a = -1; b = 1;
            do
            {
                c = a + b; a = b; b = c;

            } while (!((c > d) || (c == d)));

            return (c == d);

        }
        public void EleFreFibo(ref Vector e, ref Vector f)
        {
            e.n = 0;
            f.n = 0;
            this.OrdBur();
            int i, ele, fre;
            i = 1;

            while (i <= n)
            {


                if (Esfibo(v[i]))
                {
                    fre = 0;
                    ele = v[i];

                    while ((i <= n) && (ele == v[i]))
                    {
                        fre++;
                        i++;
                    }
                    e.Cargar(ele);
                    f.Cargar(fre);
                }
                else
                {
                    i++;
                }
            }
        }

        public void insertar(int ele, int pos) 
        {
            this.n++;

            for (int i = n; i >= pos; i--)
            {
                v[i] = v[i - 1];
            }

            v[pos] = ele;
        }
    

        public void ElerepNorep(int a, int b)
        {
            this.OrdBurMaMe(a,b);
            int i, fre, ele, cont;
            i = b;
            cont = 0;

            while (i>=a)
            {
                ele = v[i];
                fre = 0;
                while ((i>=a)&&(ele == v[i]))
                {
                    fre++;
                    i--;
                }
                if (fre == 1)
                {
                    cont++;
                    this.Elimpos(i+1);
                    this.insertar(ele, b+1);
                }

            }

            this.OrdBurMaMe((b-cont)+1,b);

        }
        public void ordBurb(int a, int b)
        {
            int t, d;
            for (t = b; t >= a; t--)
                for (d = a; d <= t - 1; d++)
                    if (v[d] > v[d + 1])
                        Inter(d, d + 1);

        }
        public bool Escapi(int num)
        {
            int dig;
            int cant = num;
            int resul = 0;
            while (cant > 0)
            {
                dig = cant % 10; cant = cant / 10;
                resul = (10 * resul) + dig;

            }

            return (num == resul);
        }
       
        public void ordenarCapicuas()
        {
            OrdBur();
            int i,ele;
            i = n;
            while (i>=1)
            {
                
                if (!Escapi(v[i]))
                {
                    ele = v[i];
                    Elimpos(i);
                    Cargar(ele);

                }
                i--;
            }
        } 

        public bool Esprimo(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }


        public void InterPrim(int a, int b)
        {
            bool p, q;
            int c, e, r, t, y, aux, aux2;
            bool ba = true;
            c = 1; e = a; r = a; t = b; y = b;
            p = true; q = true;



            OrdBur(a, b);
            for (int i = a; i <= b;)
            {
                if (ba)
                {


                    while ((e <= t) && (p == true))
                    {
                        aux = v[e];
                        if (Esprimo(aux) == true)
                        {
                            Inter(i, e);
                            i++;
                            ordBurb(i, b);
                            p = false;
                        }

                        e++;


                    }
                    q = true;

                }
                else
                {



                    while ((r <= y) && (q == true))
                    {
                        aux2 = v[r];
                        if (Esprimo(aux2) == false)
                        {
                            Inter(i, r);
                            i++;
                            ordBurb(i, b);
                            q = false;
                        }

                        r++;



                    }
                    p = true;

                }
                ba = !ba;


            }
        }






    }
}
