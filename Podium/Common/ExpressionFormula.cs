using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NCalc;

namespace Attune.Podium.Common
{
    public class ExpressionFormula
    {
        public string ExpressionEvaluator(string Formula)
        {
            string finalValue = string.Empty ;
            int decimaldigit=0;
            try
            {


                if (!String.IsNullOrEmpty(Formula) && Formula.Length > 0)
                {
                    Expression exp = new Expression(Formula);
                    exp.Parameters["X"] = 10;
                    //finalValue = Convert.ToString(exp.Evaluate());
                    exp.EvaluateFunction += delegate(string name, FunctionArgs args)
                    {
                        if (args.Parameters.Length == 1)
                        {

                            Int32.TryParse(args.Parameters[0].Evaluate().ToString(), out decimaldigit);
                        }


                        if (args.Parameters.Length > 1)
                        {

                            Int32.TryParse(args.Parameters[1].Evaluate().ToString(), out decimaldigit);
                        }

                        if (name == "Div")
                        {
                            args.Result = args.Parameters[0].Evaluate();
                        }
                        //if (name == "RoundOff" || name == "Round")
                        else if (name == "RoundOff")
                        {
                            double valueToRound = Convert.ToDouble(args.Parameters[0].Evaluate());
                            double floorValue = Math.Floor(valueToRound);
                            if (valueToRound > 1)
                            {
                                if ((valueToRound - floorValue) >= .5)
                                {
                                    args.Result = (floorValue + 1);
                                }
                                else
                                {
                                    args.Result = (floorValue);
                                }
                            }
                            else
                            {
                                args.Result = args.Parameters[0].Evaluate();
                            }
                        }
                        else if (name == "Round")
                        {
                            string decimalString = string.Empty;
                            if (decimaldigit == 0)
                            {
                                double valueToRound0 = Convert.ToDouble(args.Parameters[0].Evaluate());
                                if (valueToRound0 >= 1)
                                {
                                    decimalString = String.Format("{0:0}", args.Parameters[0].Evaluate());
                                   
                                }
                                else if(valueToRound0 < 1)
                                {
                                    if (valueToRound0 <= .5)
                                    {

                                        decimalString ="0.5";
                                    }
                                    else if (valueToRound0 > .5 && valueToRound0 <= 1)
                                    {
                                       decimalString = "1";
                                    }
                                }
                              
                            }
                            if (decimaldigit == 1)
                            {
                                 decimalString = String.Format("{0:0.0}", args.Parameters[0].Evaluate());
                            }
                            if (decimaldigit == 2)
                            {
                                 decimalString = String.Format("{0:0.00}", args.Parameters[0].Evaluate());
                            }
                            if (decimaldigit == 3)
                            {
                                 decimalString = String.Format("{0:0.000}", args.Parameters[0].Evaluate());
                            }
                            if (decimaldigit == 4)
                            {
                                 decimalString = String.Format("{0:0.0000}", args.Parameters[0].Evaluate());
                            }
                            if (decimaldigit == 5)
                            {
                                 decimalString = String.Format("{0:0.0000}", args.Parameters[0].Evaluate());
                            }
                            if (decimaldigit == 6)
                            {
                                decimalString = String.Format("{0:0.00000}", args.Parameters[0].Evaluate());
                            }
                          //  double valueToRound = Convert.ToDouble(decimalString);
                            args.Result = decimalString;
                            
                            
                        }

                    };

                    finalValue = Convert.ToString(exp.Evaluate());
                }

            }
            catch (Exception ex)
            {
                CLogger.LogError("Error while GetValues in DeviceFormula", ex);

            }

            return finalValue;

        }



    }
}
