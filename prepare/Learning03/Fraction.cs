using System;
using System.Formats.Asn1;
public class Fraction{
        //Creating private attributes for the class
        private int _top;
        private int _down;

        //Creating constructors for the class Fraction
        public Fraction(){
            _top    = 1;
            _down   = 1;  
        }

        public Fraction(int wholeNumber){
            _top    = wholeNumber ;
            _down   = 1;
        }

        public Fraction(int top, int down){
            _top    = top;
            _down   = down;
        }

        public string GetFractionString(){
            string display = $"{_top} / {_down}";
            return display;
        }

        public double GetDecimalValue(){
            double value = (double)_top/(double)_down;
            return value;
        }
    }