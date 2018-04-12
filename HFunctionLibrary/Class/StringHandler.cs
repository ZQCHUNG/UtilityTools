using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HFunctionLibrary
{
    public class StringHandler
    {
        //預計完成
        /*
         * 1. 取得字串的副檔名
         * 2. 取得字串的檔名(含副檔名)
         * 3. 字串加密
         * 4. 字串解密
         * 5. 
         */

        /// <summary>
        /// IsComplexity 密碼是否複雜(需有大寫、小寫、數字、特殊符號其中三種)
        /// <param name="Pwd">Pwd Pwd密碼</param>
        /// </summary>
        public bool IsComplexity(string Pwd)
        {
            int i = 0;

            bool Lower = false;
            bool Upper = false;
            bool Digital = false;
            bool SpecialChar = false;

            foreach (var c in Pwd)
            {
                if (char.IsLower(c))
                {
                    Lower = true;
                }
                else if (char.IsUpper(c))
                {
                    Upper = true;
                }
                else if (char.IsNumber(c))
                {
                    Digital = true;
                }
                else if (!char.IsLetter(c) && !char.IsNumber(c))
                {
                    SpecialChar = true;
                }
            }

            if (Lower)
                i++;
            if (Upper)
                i++;
            if (Digital)
                i++;
            if (SpecialChar)
                i++;

            if (i >= 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
