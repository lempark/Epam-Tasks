

namespace Second_Webinar_Tasks
{
    namespace Task_5
    {
        class ComplexNumber
        {
            #region Properties
            public double Real { get; }
            public double Imaginary { get; }
            #endregion

            #region Constructors
            public ComplexNumber(double real , double imaginary)
            {
                Real = real;
                Imaginary = imaginary;
            }
            #endregion

            #region Operators
            public static ComplexNumber operator * (ComplexNumber left , ComplexNumber right)
            {
                double Real = left.Real * right.Real - left.Imaginary * right.Imaginary;
                double Imaginary = left.Real * right.Imaginary + left.Imaginary * right.Real;
                return new ComplexNumber(Real, Imaginary);
            }

            public static ComplexNumber operator / (ComplexNumber left, ComplexNumber right)
            {
                double Real = ((left.Real * right.Real + left.Imaginary * right.Imaginary) /
                               (right.Real * right.Real + right.Imaginary * right.Imaginary));

                double Imaginary = ((left.Imaginary * right.Real - left.Real * right.Imaginary) /
                                    (right.Real * right.Real + right.Imaginary * right.Imaginary));

                return new ComplexNumber(Real, Imaginary);
            }
            #endregion
        }
    }
}
