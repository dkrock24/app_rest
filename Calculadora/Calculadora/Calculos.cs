using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Calculadora
{
    class Calculos
    {

        private double n1, n2,res,a,b,c,x1,x2;
        private DateTime f1, f2;
        string resultado;




        public Calculos(DateTime fecha1,DateTime fecha2)
        {
            setF1(fecha1);
            setF2(fecha2);
        }
        public Calculos(double num1)
        {
            setN1(num1);
        }

        public Calculos(double num1,double num2)
        {
            setN1(num1);
            setN2(num2);
        }

        public Calculos(double A, double B, double C)
        {
            setX1(A);
            setX2(B);
            setX2(C);
        }
        public void setF1(DateTime A)
        {
            f1 = A;
        }
        public void setF2(DateTime B)
        {
            f2 = B;
        }
        public void setA(double A)
        {
            a = A;
        }
        public void setB(double B)
        {
            b = B;
        }
        public void setC(double C)
        {
            c = C;
        }
        public void setX1(double X1)
        {
            x1 = X1;
        }
        public void setX2(double X2)
        {
            x2 = X2;
        }
        public DateTime getF1()
        {
            return f1;
        }
        public DateTime getF2()
        {
            return f2;
        }
        public double getA()
        {
            return a;
        }
        public double getB()
        {
            return b;
        }
        public double getC()
        {
            return c;
        }
        public double getX1()
        {
            return x1;
        }
        public double getX2()
        {
            return x2;
        }



        public void setN1(double num1)
        {
            n1 = num1;
        }
        public void setN2(double num2)
        {
            n2 = num2;
        }
        public void setRes(double r)
        {
            res = r;
        }
        public double getN1()
        {
            return n1;
        }
        public double getN2()
        {
            return n2;
        }
        public double getRes()
        {
            return res;
        }
        public double suma()
        {
            setRes(getN1() + getN2());
            return getRes();
        }
        public double resta()
        {
            setRes(getN1() - getN2());     
            return getRes();
        }
        public double multiplicacion()
        {
            setRes(getN1() * getN2());
            return getRes();
        }
        public double division()
        {
            setRes(getN1() / getN2());
            return getRes();
        }
        public double raizN()
        {    
            setRes(Math.Pow(getN2(),(1/getN1())));
            return getRes();
        }
        public double potencia()
        {
            setRes(Math.Pow(getN1(),getN2()));
            return getRes();
        }
        public double exponente()
        {
            setRes(Math.Exp(getN1()));
            return getRes();
        }
        public double mod()
        {
            setRes((getN1()%getN2()));
            return getRes();
        }

        public double cuadraticaX1()
        {
            setX1(  -((getB())+(Math.Sqrt((Math.Pow(getB(),2))-4*getA()*getC())))/(2*getA()));
            return getX1();
        }
        public double cuadraticaX2()
        {
            setX2(-((getB()) - (Math.Sqrt((Math.Pow(getB(), 2)) - 4 * getA() * getC()))) / (2 * getA()));
            return getX2();
        }


        public double millasAKilometros()
        {
            setRes(getN1()*1.61);
            return getRes();
        }
        public double galonsALitros()
        {
            setRes(getN1() * 3.78);
            return getRes();
        }
        public double millasAKilometrosV()
        {
            setRes(getN1() * 1.61);
            return getRes();
        }
        public string ResultadoDiferencia()
        {
            int annios=0,meses=0,dias=0;
            double semanas = 0.0;
            annios = Math.Abs(getF2().Year - getF1().Year);
            meses =Math.Abs (getF2().Month - getF1().Month);
            dias = Math.Abs((getF2()- getF1()).Days);
            semanas = Math.Round(Math.Abs(dias/7.00),2);
            return annios+" annios, "+meses+" meses, "+semanas+", semanas ,"+dias+" dias";
        }
        //1.61
        //
        //



















    }
}
