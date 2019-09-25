using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CSharp_Basics
{
    [TestFixture]
    public class StringsAndItsOperations
    {
        /// <summary>
        /// String is diffrent then previues types we talk about
        /// values of string we are passing in quotation marks
        /// 
        /// Create new string with your name and then add them together
        /// </summary>
        [Test]
        public void Bascis_Of_Strings()
        {
            string example = "This is example string";
            string myName = ".\nPaweł";
            example = example + myName;
            Console.WriteLine(example);
        }

        /// <summary>
        ///  string is  first Reference Type you see (We will talk more about them later)
        ///  which means he doesn't have to have value.
        ///  use string.Empty;
        ///  create new strings itsEmpty and make it empty
        /// </summary>
        [Test]
        public void String_Initialization()
        {
            ////int mi = int.MaxValue;
            string x = string.Empty;
            ////string y = "";
            string itsEmpty = x;

            Assert.That(itsEmpty, Is.Not.Null);
        }

        /// <summary>
        /// + is not best way of adding string
        ///  use string.Concat();
        ///  put sentence together
        /// </summary>
        [Test]
        public void Adding_String()
        {
            string first = "pancakes.";
            string second = "I like";
            string result = string.Concat(second, ' ', first);

            Assert.AreEqual(result, "I like pancakes.");
        }

        /// <summary>
        /// There is few more ways of constructing strings for example if you need add values of other variables inside you can do
        /// https://docs.microsoft.com/en-us/dotnet/api/system.string.format?view=netframework-4.7.1#Starting
        /// create string with both x and y insed
        /// </summary>
        [Test]
        public void String_Format()
        {
            int x = 500;
            int y = 453;
            ////            string result = x.ToString()+y.ToString();
            string result = $"to jest x = {x} a y={y}";
            StringAssert.Contains(x.ToString(), result);
            StringAssert.Contains(y.ToString(), result);
        }

        /// <summary>
        /// From theString return word "thing".
        /// hint use Substring() method
        /// </summary>
        [Test]
        public void Substrings()
        {
            var theString =
                "The interesting thing about London is that there are always stylish surprises around every corner.";
            string result = theString.Substring(16, 5);
            Assert.AreEqual(result, "thing");
            result = theString.Replace('e', 'f');
            Console.WriteLine(result);
        }
    }
}
