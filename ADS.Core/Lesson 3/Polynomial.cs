using System;
using System.Collections.Generic;
using System.Linq;

namespace ADS.Core.Lesson_3
{
    public class Polynomial
    {

        private List<Term> _terms;

        public Polynomial()
        {
            _terms = new List<Term>();
        }

        public List<Term> GetAllTerms()
        {
            return _terms;
        }

        public void Add(Term term)
        {
            _terms.Add(term);
        }

        //Als je de polynomen
        //x2 +3x +1
        //–x3 +2x2 –5
        //–x3 +3x2 +3x –4.
        public Polynomial Sum(Polynomial poly2)
        {
            var result = new Polynomial();

            //Order by coeficient
            poly2._terms = poly2._terms.OrderBy(xx => xx.getCoefficient()).ToList();
            //Order by exponent
            poly2._terms = poly2._terms.OrderBy(xx => xx.getExponent()).ToList();

            //Order by coeficient
            _terms = _terms.OrderBy(xx => xx.getCoefficient()).ToList();
            //Order by expontent
            _terms = _terms.OrderBy(xx => xx.getExponent()).ToList();
          
            while (_terms.Count > 0 || poly2._terms.Count > 0)
            {
                Term term;

                Term polyOneX = null;
                Term polyTwoX = null;
                if (0 < _terms.Count && _terms[0] != null)
                    polyOneX = _terms[0];
                if (0 < poly2._terms.Count && poly2._terms[0] != null)
                    polyTwoX = poly2._terms[0];


                if (polyOneX != null && polyTwoX != null && polyTwoX.getExponent() > polyOneX.getExponent())
                {
                    term = new Term(polyOneX.getCoefficient(), polyOneX.getExponent());
                    _terms.RemoveAt(0);
                }
                else if (polyTwoX != null && polyOneX != null && polyTwoX.getExponent() < polyOneX.getExponent())
                {
                    term = new Term(polyTwoX.getCoefficient(), polyTwoX.getExponent());
                    poly2._terms.RemoveAt(0);
                }
                else
                {
                    if (polyOneX == null)
                    {
                        term = new Term(polyTwoX.getCoefficient(), polyTwoX.getExponent());
                        poly2._terms.RemoveAt(0);
                       
                    }
                    else if (polyTwoX == null)
                    {
                        term = new Term(polyOneX.getCoefficient(), polyOneX.getExponent());
                        _terms.RemoveAt(0);
                    }

                    else
                    {
                        term = new Term(polyOneX.getCoefficient() + polyTwoX.getCoefficient(),
                            polyOneX.getExponent());

                        _terms.RemoveAt(0);
                        poly2._terms.RemoveAt(0);
                    }
                }
                result.Add(term);
            }
            return result;
        }

        //public Polynomial()
        //{
        //    _terms = new List<Term>();
        //}
    }
}
