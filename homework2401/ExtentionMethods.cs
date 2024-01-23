using System;
using System.Linq;
using System.Reflection.Metadata;

namespace homework2401
{
	internal static class ExtentionMethods
	{
     
        //+IsOdd() - int obyektlər üçün həmin obyektin tək ədəd olub olmadığını geri qaytaran(true/false) method
        public static bool IsOdd(params int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0) return false;
            }
            return true;

        }
        //+IsEven() - int obyektlər üçün həmin obyektin cüt ədəd olub olmadığını geri qaytaran(true/false) method
        public static bool IsEven(params int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0) return false;
            }
            return true;

        }
        //+IsContainsDigit() - string obyektlər üçün həmin obyektin daxilində digit
        //character olub olmamasını geri qaytaran(true/false) metod
        public static bool IsContainsDigit(string str)
        {

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    return true; 
                }
            }
            return false;
        }

        //+ToCapitalize() - String-lər üçün ToCapitalize adlı extention metod yaradırsınız.
        //Bu metod string dəyərini capitalaize edib geri qaytarmalıdır.
        public static string ToCapitalize(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return str;
            }
            return char.ToUpper(str[0]) + str.Substring(1).ToLower();
        }

        //GetValueIndexes() - string-lər üçün parameter olaraq göndərilən charin stringin
        //hansı indexlerində yerləşdiyini tapan və tapdığı bütün indexləri array olaraq
        //geri qaytaran metod(heç bir dəyər tapılmazsa geriyə boş (0 uzunluqlu) int[] qayıdır)c



        //+GetFirstSentence() - stringlər üçün verilmiş stringdəki ilk cümləni return edən metod
        public static string GetFirstSentence(string sentences)
        {
            if (string.IsNullOrEmpty(sentences))
            {
                return string.Empty;
            }

            var sentenceArray = sentences.Split('.'); 
            return sentenceArray.Length > 0 ? sentenceArray[0].Trim() : string.Empty;

        }

        //+GetSecondWord() - verilmiş stringdəki 2ci sözü return edən metod
        public static string GetSecondWord(string sentences)
        {
            if (string.IsNullOrEmpty(sentences))
            {
                return string.Empty;
            }
            var startIndext = sentences.IndexOf(" ");
            var lastIndext = sentences.Length - startIndext;
            var secondword = sentences.Substring(startIndext + 1, lastIndext); return secondword;

        }

    }
}

