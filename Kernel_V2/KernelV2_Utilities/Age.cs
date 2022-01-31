﻿using System;

namespace Attune.KernelV2.Utilities
{
    public class Age
    {
        public int Years;
        public int Months;
        public int Days;

        public Age(DateTime Bday)
        {
            Count(Bday);
        }

        public Age(DateTime Bday, DateTime Cday)
        {
            Count(Bday, Cday);
        }

        public Age Count(DateTime Bday)
        {
            return Count(Bday, DateTime.Today);
        }

        public Age Count(DateTime Bday, DateTime Cday)
        {
            if ((Cday.Year - Bday.Year) > 0 ||
                (((Cday.Year - Bday.Year) == 0) && ((Bday.Month < Cday.Month) ||
                  ((Bday.Month == Cday.Month) && (Bday.Day <= Cday.Day)))))
            {
                int DaysInBdayMonth = DateTime.DaysInMonth(Bday.Year, Bday.Month);
                int DaysRemain = Cday.Day + (DaysInBdayMonth - Bday.Day);

                if (Cday.Month > Bday.Month)
                {
                    Years = Cday.Year - Bday.Year;
                    Months = Cday.Month - (Bday.Month + 1) + Math.Abs(DaysRemain / DaysInBdayMonth);
                    if (DaysRemain == 31 && (DaysInBdayMonth == 28 || DaysInBdayMonth == 30 || DaysInBdayMonth == 29))
                    {
                        Days = 0;
                    }
                    else
                    {
                        Days = (DaysRemain % DaysInBdayMonth + DaysInBdayMonth) % DaysInBdayMonth;
                    }
                }
                else if (Cday.Month == Bday.Month)
                {
                    if (Cday.Day >= Bday.Day)
                    {
                        Years = Cday.Year - Bday.Year;
                        Months = 0;
                        Days = Cday.Day - Bday.Day;
                    }
                    else
                    {
                        Years = (Cday.Year - 1) - Bday.Year;
                        Months = 11;
                        Days = DateTime.DaysInMonth(Bday.Year, Bday.Month) - (Bday.Day - Cday.Day);
                    }
                }
                else
                {
                    Years = (Cday.Year - 1) - Bday.Year;
                    Months = Cday.Month + (11 - Bday.Month) + Math.Abs(DaysRemain / DaysInBdayMonth);
                    if (DaysRemain == 31 && (DaysInBdayMonth == 28 || DaysInBdayMonth == 30 || DaysInBdayMonth == 29))
                    {
                        Days = 0;
                    }
                    else
                    {
                        Days = (DaysRemain % DaysInBdayMonth + DaysInBdayMonth) % DaysInBdayMonth;
                    }
                }
            }
            else
            {
                throw new ArgumentException("Birthday date must be earlier than current date");
            }
            return this;
        }
    }
}
