using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Attune.Cryptography;

namespace Attune.Podium.Common
{
    public class GeneratePassword
    {
        Random rand = new Random();
        public GeneratePassword()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public void GenerateNewPassword(int PasswordLength, out string NewPassword)
        {
            /* Declaration Part */
            string alphaCaps = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string alphaLow = "abcdefghijklmnopqrstuvwxyz";
            string numerics = "0123456789";
            string special = "@#$";
            string allChars = alphaCaps + alphaLow + numerics + special;
            int pAlphaCaps, pAlphaLow, pNumerics, pSpecial;
            string PositionArray = "0123456789";
            string RandomPassword = string.Empty;
            NewPassword = string.Empty;
            /* Declaration End */
            try
            {
                /* Generate Random Password Code Start */
                if (PasswordLength < PositionArray.Length)
                    PositionArray = PositionArray.Substring(0, PasswordLength);
                pAlphaCaps = GetRandomPosition(ref PositionArray);
                pAlphaLow = GetRandomPosition(ref PositionArray);
                pNumerics = GetRandomPosition(ref PositionArray);
                pSpecial = GetRandomPosition(ref PositionArray);
                for (int i = 0; i < PasswordLength; i++)
                {
                    if (i == pAlphaCaps)
                        RandomPassword += GetRandomChar(alphaCaps);
                    else if (i == pAlphaLow)
                        RandomPassword += GetRandomChar(alphaLow);
                    else if (i == pNumerics)
                        RandomPassword += GetRandomChar(numerics);
                    else if (i == pSpecial)
                        RandomPassword += GetRandomChar(special);
                    else
                        RandomPassword += GetRandomChar(allChars);
                }
                /* Code Ends */
                // Enrypt the Generated Random Password //
                CCryptography objEncryptText = new CCryptFactory().GetEncryptor();
                objEncryptText.Crypt(RandomPassword, out NewPassword);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /* Return Random postion from the Position Array List */
        #region Return RandomPostion
        private int GetRandomPosition(ref string PositionArray)
        {
            try
            {
                int pos;
                string RandomChar = PositionArray.ToCharArray()[(int)Math.Floor(rand.NextDouble() * PositionArray.Length)].ToString();
                Int32.TryParse(RandomChar, out pos);
                PositionArray = PositionArray.Replace(RandomChar, "");
                return pos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        /* Return Random char of th FullString */
        #region returnChar
        private string GetRandomChar(string FullString)
        {
            try
            {
                return FullString.ToCharArray()[(int)Math.Floor(rand.NextDouble() * FullString.Length)].ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
