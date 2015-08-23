﻿namespace Telerik.ILS.Common
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Static Class, that provides string extension methods
    /// <list type="disk">
    /// <item>
    /// <description>ToMd5Hash,</description> 
    /// </item> 
    /// <item> 
    /// <description>ToBoolean,</description> 
    /// </item>
    /// <item> 
    /// <description>ToShort,</description> 
    /// </item> 
    /// <item> 
    /// <description>ToInteger,</description> 
    /// </item>
    /// <item> 
    /// <description>ToLong,</description> 
    /// </item>
    /// <item> 
    /// <description>ToDateTime,</description> 
    /// </item>
    /// <item> 
    /// <description>CapitalizeFirstLetter,</description> 
    /// </item>
    /// <item>
    /// <description>ConvertCyrillicToLatinLetters,</description>
    /// </item>
    /// <item>
    /// <description>ConvertLatinToCyrillicKeyboard,</description>
    /// </item>
    /// <item>
    /// <description>ToValidUsername,</description>
    /// </item>
    /// <item>
    /// <description>ToValidLatinFileName,</description>
    /// </item>
    /// <item>
    /// <description>GetFirstCharacters,</description>
    /// </item>
    /// <item>
    /// <description>GetFileExtension,</description>
    /// </item>
    /// <item>
    /// <description>ToContentType,</description>
    /// </item>
    /// <item>
    /// <description>ToByteArray,</description>
    /// </item>
    /// </list>
    /// </summary>

    public static class StringExtensions
    {
        /// <summary>
        /// A string extension method that converts the target string to a byte array, and 
        /// computes the hashes for each element.
        /// Then bytes are formatted as a hexadecimal strings and appended to the resulting
        /// string that is finally returned.
        /// </summary>
        /// <param name="input">The method is called upon this string.</param>
        /// <returns>A hexadecimal string</returns>

        public static string ToMd5Hash(this string input)
        {
            var md5Hash = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new StringBuilder to collect the bytes
            // and create a string.
            var builder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return builder.ToString();
        }

        /// <summary>
        /// A string extension method that checks if the target string is contained within a 
        /// predefined collection of true-like values.
        /// </summary>
        /// <param name="input">The method is called upon this string.</param>
        /// <returns>Whether the input is among the given true values (True/False).</returns>

        public static bool ToBoolean(this string input)
        {
            var stringTrueValues = new[] { "true", "ok", "yes", "1", "да" };
            return stringTrueValues.Contains(input.ToLower());
        }

        /// <summary>
        /// Converts the target string to a short value and returns it.
        /// </summary>
        /// <param name="input">The method is called upon this string.</param>
        /// <returns>The short value obtained from parsing the input string.</returns>

        public static short ToShort(this string input)
        {
            short shortValue;
            short.TryParse(input, out shortValue);
            return shortValue;
        }

        /// <summary>
        /// Converts the target string to an integer value and returns it.
        /// </summary>
        /// <param name="input">The method is called upon this string.</param>
        /// <returns>The integer value obtained from parsing the input string.</returns>

        public static int ToInteger(this string input)
        {
            int integerValue;
            int.TryParse(input, out integerValue);
            return integerValue;
        }

        /// <summary>
        /// Converts the target string to a long value and returns it.
        /// </summary>
        /// <param name="input">The method is called upon this string.</param>
        /// <returns>The long value obtained from parsing the input string.</returns>

        public static long ToLong(this string input)
        {
            long longValue;
            long.TryParse(input, out longValue);
            return longValue;
        }

        /// <summary>
        /// Converts the target string to a DateTime value and returns it.
        /// </summary>
        /// <param name="input">The method is called upon this string.</param>
        /// <returns>The DateTime value obtained from parsing the input string.</returns>

        public static DateTime ToDateTime(this string input)
        {
            DateTime dateTimeValue;
            DateTime.TryParse(input, out dateTimeValue);
            return dateTimeValue;
        }

        /// <summary>
        /// Makes the first letter of the string capitalized.
        /// </summary>
        /// <param name="input">The method is called upon this string.</param>
        /// <returns>The string with capital first letter.</returns>

        public static string CapitalizeFirstLetter(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + input.Substring(1, input.Length - 1);
        }

        /// <summary>
        /// Returns the string between two given strings.
        /// </summary>
        /// <param name="input">The method is called upon this string.</param>
        /// <param name="startString">The start of the string.</param>
        /// <param name="endString">The end of the string.</param>
        /// <param name="startFrom">The index to start the search from.</param>
        /// <returns>The found string.</returns>

        public static string GetStringBetween(this string input, string startString, string endString, int startFrom = 0)
        {
            input = input.Substring(startFrom);
            startFrom = 0;
            if (!input.Contains(startString) || !input.Contains(endString))
            {
                return string.Empty;
            }

            var startPosition = input.IndexOf(startString, startFrom, StringComparison.Ordinal) + startString.Length;
            if (startPosition == -1)
            {
                return string.Empty;
            }

            var endPosition = input.IndexOf(endString, startPosition, StringComparison.Ordinal);
            if (endPosition == -1)
            {
                return string.Empty;
            }

            return input.Substring(startPosition, endPosition - startPosition);
        }

        /// <summary>
        /// Converts cyrillic letters in their latin representation.
        /// </summary>
        /// <param name="input">The method is called upon this string.</param>
        /// <returns>The new string with latin letters.</returns>

        public static string ConvertCyrillicToLatinLetters(this string input)
        {
            var bulgarianLetters = new[]
                                       {
                                           "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п",
                                           "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ь", "ю", "я"
                                       };
            var latinRepresentationsOfBulgarianLetters = new[]
                                                             {
                                                                 "a", "b", "v", "g", "d", "e", "j", "z", "i", "y", "k",
                                                                 "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "h",
                                                                 "c", "ch", "sh", "sht", "u", "i", "yu", "ya"
                                                             };
            for (var i = 0; i < bulgarianLetters.Length; i++)
            {
                input = input.Replace(bulgarianLetters[i], latinRepresentationsOfBulgarianLetters[i]);
                input = input.Replace(bulgarianLetters[i].ToUpper(), latinRepresentationsOfBulgarianLetters[i].CapitalizeFirstLetter());
            }

            return input;
        }

        /// <summary>
        /// Converts latin letters cyrillic letters.
        /// </summary>
        /// <param name="input">The method is called upon this string.</param>
        /// <returns>The new string with cyrillic letters.</returns>

        public static string ConvertLatinToCyrillicKeyboard(this string input)
        {
            var latinLetters = new[]
                                   {
                                       "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
                                       "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
                                   };

            var bulgarianRepresentationOfLatinKeyboard = new[]
                                                             {
                                                                 "а", "б", "ц", "д", "е", "ф", "г", "х", "и", "й", "к",
                                                                 "л", "м", "н", "о", "п", "я", "р", "с", "т", "у", "ж",
                                                                 "в", "ь", "ъ", "з"
                                                             };

            for (int i = 0; i < latinLetters.Length; i++)
            {
                input = input.Replace(latinLetters[i], bulgarianRepresentationOfLatinKeyboard[i]);
                input = input.Replace(latinLetters[i].ToUpper(), bulgarianRepresentationOfLatinKeyboard[i].ToUpper());
            }

            return input;
        }

        /// <summary>
        /// Converts a string into a valid username.
        /// </summary>
        /// <param name="input">The method is called upon this string.</param>
        /// <returns>The string after the cyrllic letters are converted to latin 
        /// (".", or "_", are removed!).</returns>

        public static string ToValidUsername(this string input)
        {
            input = input.ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.]+", string.Empty);
        }

        /// <summary>
        /// Converts a string into a valid latin file name.
        /// </summary>
        /// <param name="input">The method is called upon this string.</param>
        /// <returns>The string after the cyrllic letters are converted to latin (spaces are replaced with "-",
        /// characters ".", "-", or "_", are removed!).</returns>

        public static string ToValidLatinFileName(this string input)
        {
            input = input.Replace(" ", "-").ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.\-]+", string.Empty);
        }

        /// <summary>
        /// Returns the first n characters from the string, where n is the second parameter.
        /// </summary>
        /// <param name="input">The method is called upon this string.</param>
        /// <param name="charsCount">The number of returned characters.</param>
        /// <returns>The first n characters from the string.</returns>

        public static string GetFirstCharacters(this string input, int charsCount)
        {
            return input.Substring(0, Math.Min(input.Length, charsCount));
        }

        /// <summary>
        /// Returns the file extension of the given filename.
        /// </summary>
        /// <param name="fileName">The the method is called upon this filename.</param>
        /// <returns>The extension of the filename.</returns>

        public static string GetFileExtension(this string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return string.Empty;
            }

            string[] fileParts = fileName.Split(new[] { "." }, StringSplitOptions.None);
            if (fileParts.Count() == 1 || string.IsNullOrEmpty(fileParts.Last()))
            {
                return string.Empty;
            }

            return fileParts.Last().Trim().ToLower();
        }

        /// <summary>
        /// Returns the content type of a file depending on its extension.
        /// </summary>
        /// <param name="fileExtension">The file extension.</param>
        /// <returns>The content type associated with the given file extension.</returns>

        public static string ToContentType(this string fileExtension)
        {
            var fileExtensionToContentType = new Dictionary<string, string>
                                                 {
                                                     { "jpg", "image/jpeg" },
                                                     { "jpeg", "image/jpeg" },
                                                     { "png", "image/x-png" },
                                                     {
                                                         "docx",
                                                         "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
                                                     },
                                                     { "doc", "application/msword" },
                                                     { "pdf", "application/pdf" },
                                                     { "txt", "text/plain" },
                                                     { "rtf", "application/rtf" }
                                                 };
            if (fileExtensionToContentType.ContainsKey(fileExtension.Trim()))
            {
                return fileExtensionToContentType[fileExtension.Trim()];
            }

            return "application/octet-stream";
        }

        /// <summary>
        /// Converts a string into an array of bytes.
        /// </summary>
        /// <param name="input">The method is called upon this string.</param>
        /// <returns>An array of bytes derived from converting every character 
        /// in the given string to its byte representation.</returns>

        public static byte[] ToByteArray(this string input)
        {
            var bytesArray = new byte[input.Length * sizeof(char)];
            Buffer.BlockCopy(input.ToCharArray(), 0, bytesArray, 0, bytesArray.Length);
            return bytesArray;
        }
    }
}