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

            //Order by coeficient & exponent
            //poly2._terms = poly2._terms.OrderBy(xx => xx.getCoefficient()).ToList().OrderBy(xx => xx.getExponent())
             //   .ToList();
            //Order by coeficient & expontent
            //_terms = _terms.OrderBy(xx => xx.getCoefficient()).ToList().OrderBy(xx => xx.getExponent()).ToList();

            poly2.Sort();
            result.Sort();
            
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
                    term = new Term(polyTwoX.getCoefficient(), polyTwoX.getExponent());
                    poly2._terms.RemoveAt(0);
                }
                else if (polyTwoX != null && polyOneX != null && polyTwoX.getExponent() < polyOneX.getExponent())
                {
                    term = new Term(polyOneX.getCoefficient(), polyOneX.getExponent());
                    _terms.RemoveAt(0);
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

        public Polynomial OptimizedAlgorithm(Polynomial poly2)
        {
            var sumOfPolynomial = new Polynomial();
            int ct = poly2._terms.Count + _terms.Count;

            for (var i = 0; i < ct; i++)
            {
                if (_terms.Count > i)
                    sumOfPolynomial.Add(new Term(_terms[i].getCoefficient(), _terms[i].getExponent()));

                if (poly2._terms.Count > i)
                    sumOfPolynomial.Add(new Term(poly2._terms[i].getCoefficient(), poly2._terms[i].getExponent()));
            }

            sumOfPolynomial.Sort();

            var index = 0;
            while (true)
            {
                if (index >= ct - 1)
                    break;

                var a = sumOfPolynomial._terms[index];
                var b = sumOfPolynomial._terms[index + 1];

                if (sumOfPolynomial._terms[index].getExponent() == sumOfPolynomial._terms[index + 1].getExponent())
                {
                    sumOfPolynomial._terms[index] = new Term(a.getCoefficient() + b.getCoefficient(), a.getExponent());
                    sumOfPolynomial._terms.RemoveAt(index + 1);
                    ct--;
                }
                else
                {
                    index++;
                }
            }

            return sumOfPolynomial;
        }

        public Polynomial SumWorking(Polynomial poly2)
        {

            Polynomial sumPolynomial = new Polynomial();

            foreach (Term t in _terms)
            {
                sumPolynomial.Add(new Term(t.getCoefficient(), t.getExponent()));
            }

            foreach (Term t in poly2._terms)
            {
                sumPolynomial.Add(new Term(t.getCoefficient(), t.getExponent()));
            }

            sumPolynomial.Sort();

            int index = 0;
            while (true)
            {
                if (index >= sumPolynomial._terms.Count - 1)
                    break;

                Term a = sumPolynomial._terms[index];
                Term b = sumPolynomial._terms[index + 1];

                if (a.getExponent() == b.getExponent())
                {
                    sumPolynomial._terms[index] = new Term(a.getCoefficient() + b.getCoefficient(), a.getExponent());
                    sumPolynomial._terms.RemoveAt(index + 1);
                }
                else
                {
                    index++;
                }
            }

            return sumPolynomial;

        }

        private void Sort()
        {
            _terms = _terms.OrderByDescending(t => t.getExponent()).ToList();
        }
    }
}
