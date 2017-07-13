﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculette.Calcul
{
    enum OPERATION { ADD, SOUS, MULT, DIV, DEFAULT};


    class Main_Calcul
    {

        private bool m_printed;

        public bool printed                     //indicate if the result of a calcul should be printed in the screen
        {
            get
            {
                return m_printed;
            }

            set
            {
                m_printed = value;
            }
        }

        public Main_Calcul()
        {
            printed = true;
        }

        public bool Calculate()
        {
            Console.Write("Result of the Calcul\n");
            return true;
        }


    }

    class Line
    {
        public double mFirstOperande {get; private set;}
        public double mSecondOperande { get; private set; }
        public OPERATION mOperation { get; private set; }

        public Line(double inFirstOperande, double inSecondOperande, OPERATION inOperation)
        {
            mFirstOperande = inFirstOperande;
            mSecondOperande = inSecondOperande;
            mOperation = inOperation;
        }

        public double Calculate()
        {
            double theResult = 0;

            switch (mOperation)
            {
                case OPERATION.ADD:
                    theResult = mFirstOperande + mSecondOperande;
                    break;
                case OPERATION.SOUS:
                    theResult = mFirstOperande - mSecondOperande;
                    break;
                case OPERATION.DIV:
                    theResult = mFirstOperande / mSecondOperande;
                    break;
                case OPERATION.MULT:
                    theResult = mFirstOperande * mSecondOperande;
                    break;
            }
            return theResult;
        }
    }
}
