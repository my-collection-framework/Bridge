﻿using Bridge;

using System;
using System.Collections;
using System.Collections.Generic;
using Bridge.Test;
using Bridge.ClientTest;
using System.Text.RegularExpressions;

namespace Bridge.ClientTest.SimpleTypes
{
    [Category(Constants.MODULE_STRING)]
    [TestFixture(TestNameFormat = "String - {0}")]
    public class StringTests
    {
        private class MyEnumerable<T> : IEnumerable<T>
        {
            private readonly T[] _items;

            public MyEnumerable(T[] items)
            {
                _items = items;
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return this.GetEnumerator();
            }

            public IEnumerator<T> GetEnumerator()
            {
                return (IEnumerator<T>)(object)_items.GetEnumerator();
            }
        }

        [Test]
        public void TypePropertiesAreCorrect()
        {
            Assert.AreEqual(typeof(string).GetClassName(), "String");
            object s = "X";
            Assert.True(s is string);
        }
        //#353
        [IgnoreTest(Until = Constants.IGNORE_DATE)]
        [Test]
        public void StringInterfaces()
        {
            object s = "X";
            Assert.True(s is object, "string is object");
            Assert.True(s is IComparable<string>);
            Assert.True(s is IEquatable<string>);
        }


        [Test]
        public void DefaultConstructorWorks()
        {
            Assert.AreEqual(new string(), "");
        }

        [Test]
        public void CopyConstructorWorks()
        {
            Assert.AreEqual(new string("abcd"), "abcd");
        }

        [Test]
        public void CharAndCountConstructorWorks()
        {
            Assert.AreEqual(new string('x', 5), "xxxxx");
        }

        [Test]
        public void CharArrayConstructorWorks()
        {
            Assert.AreEqual(new string(new[] { 'a', 'b', 'C' }), "abC");
        }

        [Test]
        public void EmptyFieldWorks()
        {
            Assert.AreEqual(string.Empty, "");
        }

        [Test]
        public void LengthPropertyWorks()
        {
            Assert.AreEqual("abcd".Length, 4);
        }

        [Test]
        public void CharAtWorks()
        {
            Assert.AreEqual("abcd".CharAt(2), "c");
        }

        [Test]
        public void CharCodeAtWorks()
        {
            Assert.AreEqual((int)"abcd".CharCodeAt(2), (int)'c');
        }

        // TODO #353
        //[Test]
        //public void CompareToWithIgnoreCaseArgWorks()
        //{
        //    Assert.True("abcd".CompareTo("abcd", false) == 0);
        //    Assert.True("abcd".CompareTo("abcb", false) > 0);
        //    Assert.True("abcd".CompareTo("abce", false) < 0);
        //    Assert.True("abcd".CompareTo("ABCD", true) == 0);
        //    Assert.True("abcd".CompareTo("ABCB", true) > 0);
        //    Assert.True("abcd".CompareTo("ABCE", true) < 0);
        //}

        [Test]
        public void CompareWorks()
        {
            Assert.True(string.Compare("abcd", "abcd") == 0);
            Assert.True(string.Compare("abcd", "abcb") > 0);
            Assert.True(string.Compare("abcd", "abce") < 0);
        }

        [Test]
        public void CompareWithIgnoreCaseArgWorks()
        {
            Assert.True(string.Compare("abcd", "abcd", false) == 0);
            Assert.True(string.Compare("abcd", "abcb", false) > 0);
            Assert.True(string.Compare("abcd", "abce", false) < 0);
            Assert.True(string.Compare("abcd", "ABCD", true) == 0);
            Assert.True(string.Compare("abcd", "ABCB", true) > 0);
            Assert.True(string.Compare("abcd", "ABCE", true) < 0);
        }

        [Test]
        public void ConcatWorks()
        {
            Assert.AreEqual(string.Concat("a", "b"), "ab");
            Assert.AreEqual(string.Concat("a", "b", "c"), "abc");
            Assert.AreEqual(string.Concat("a", "b", "c", "d"), "abcd");
            Assert.AreEqual(string.Concat("a", "b", "c", "d", "e"), "abcde");
            Assert.AreEqual(string.Concat("a", "b", "c", "d", "e", "f"), "abcdef");
            Assert.AreEqual(string.Concat("a", "b", "c", "d", "e", "f", "g"), "abcdefg");
            Assert.AreEqual(string.Concat("a", "b", "c", "d", "e", "f", "g", "h"), "abcdefgh");
            Assert.AreEqual(string.Concat("a", "b", "c", "d", "e", "f", "g", "h", "i"), "abcdefghi");
        }

        [Test]
        public void ConcatWithObjectsWorks()
        {
            Assert.AreEqual(string.Concat(1), "1");
            Assert.AreEqual(string.Concat(1, 2), "12");
            Assert.AreEqual(string.Concat(1, 2, 3), "123");
            Assert.AreEqual(string.Concat(1, 2, 3, 4), "1234");
            Assert.AreEqual(string.Concat(1, 2, 3, 4, 5), "12345");
            Assert.AreEqual(string.Concat(1, 2, 3, 4, 5, 6), "123456");
            Assert.AreEqual(string.Concat(1, 2, 3, 4, 5, 6, 7), "1234567");
            Assert.AreEqual(string.Concat(1, 2, 3, 4, 5, 6, 7, 8), "12345678");
            Assert.AreEqual(string.Concat(1, 2, 3, 4, 5, 6, 7, 8, 9), "123456789");
        }

        [Test]
        public void EndsWithCharWorks()
        {
            Assert.True("abcd".EndsWith("d"));
            Assert.False("abcd".EndsWith("e"));
        }

        [Test]
        public void EndsWithStringWorks()
        {
            Assert.True("abcd".EndsWith("d"));
            Assert.False("abcd".EndsWith("e"));
        }

        [Test]
        public void StaticEqualsWorks()
        {
            Assert.True(string.Equals("abcd", "abcd"));
            Assert.False(string.Equals("abcd", "abce"));
            Assert.False(string.Equals("abcd", "ABCD"));
            Assert.True(string.Equals("abcd", "abcd"));
            Assert.False(string.Equals("abcd", "abce"));
            Assert.False(string.Equals("abcd", "ABCD"));
        }

        [Test]
        public void FormatWorks()
        {
            Assert.AreEqual(string.Format("x"), "x");
            Assert.AreEqual(string.Format("x{0}", "a"), "xa");
            Assert.AreEqual(string.Format("x{0}{1}", "a", "b"), "xab");
            Assert.AreEqual(string.Format("x{0}{1}{2}", "a", "b", "c"), "xabc");
            Assert.AreEqual(string.Format("x{0}{1}{2}{3}", "a", "b", "c", "d"), "xabcd");

            var arr1 = new object[] { "a" };
            var arr2 = new object[] { "a", "b" };
            var arr3 = new object[] { "a", "b", "c" };
            var arr4 = new object[] { "a", "b", "c", "d" };
            Assert.AreEqual(string.Format("x{0}", arr1), "xa");
            Assert.AreEqual(string.Format("x{0}{1}", arr2[0], arr2[1]), "xab");
            Assert.AreEqual(string.Format("x{0}{1}{2}", arr3[0], arr3[1], arr3[2]), "xabc");
            Assert.AreEqual(string.Format("x{0}{1}{2}{3}", arr4[0], arr4[1], arr4[2], arr4[3]), "xabcd");
        }

        [IgnoreTest(Until = Constants.IGNORE_DATE)]
        [Test]
        public void FormatWorksExtended()
        {
            var arr2 = new object[] { "a", "b" };
            var arr3 = new object[] { "a", "b", "c" };
            var arr4 = new object[] { "a", "b", "c", "d" };

            Assert.AreEqual(string.Format("x{0}{1}", arr2), "xab");
            Assert.AreEqual(string.Format("x{0}{1}{2}", arr3), "xabc");
            Assert.AreEqual(string.Format("x{0}{1}{2}{3}", arr4), "xabcd");
        }

        [Test]
        public void FormatWorksWithIFormattable()
        {
            Assert.AreEqual(string.Format("{0:F2}", 22.0 / 7.0), "3.14");
        }

        [Test]
        public void FormatCanUseEscapedBraces()
        {
            Assert.AreEqual(string.Format("{{0}}"), "{0}");
        }

        [Test]
        public void FromCharCodeWorks()
        {
            Assert.AreEqual(string.FromCharCode(), "");
            Assert.AreEqual(string.FromCharCode('a'), "a");
            Assert.AreEqual(string.FromCharCode('a', 'b'), "ab");
            Assert.AreEqual(string.FromCharCode('a', 'b', 'c'), "abc");
        }

        [Test]
        public void IndexOfCharWorks()
        {
            Assert.AreEqual("abc".IndexOf('b'), 1);
            Assert.AreEqual("abc".IndexOf('d'), -1);
        }

        [Test]
        public void IndexOfStringWorks()
        {
            Assert.AreEqual("abc".IndexOf("bc"), 1);
            Assert.AreEqual("abc".IndexOf("bd"), -1);
        }

        [Test]
        public void IndexOfCharWithStartIndexWorks()
        {
            Assert.AreEqual("abcabc".IndexOf('b', 3), 4);
            Assert.AreEqual("abcabc".IndexOf('d', 3), -1);
        }

        [Test]
        public void IndexOfCharWithStartIndexAndCountWorks()
        {
            Assert.AreEqual("xxxxxabcxxx".IndexOf('c', 3, 8), 7);
            Assert.AreEqual("xxxxxabcxxx".IndexOf('c', 3, 5), 7);
            Assert.AreEqual("xxxxxabcxxx".IndexOf('c', 3, 4), -1);
        }

        [Test]
        public void IndexOfStringWithStartIndexWorks()
        {
            Assert.AreEqual("abcabc".IndexOf("bc", 3), 4);
            Assert.AreEqual("abcabc".IndexOf("bd", 3), -1);
        }

        [Test]
        public void IndexOfStringWithStartIndexAndCountWorks()
        {
            Assert.AreEqual("xxxxxabcxxx".IndexOf("abc", 3, 8), 5);
            Assert.AreEqual("xxxxxabcxxx".IndexOf("abc", 3, 5), 5);
            Assert.AreEqual("xxxxxabcxxx".IndexOf("abc", 3, 4), -1);
        }

        [Test]
        public void IndexOfAnyWorks()
        {
            Assert.AreEqual("abcd".IndexOfAny(new[] { 'b' }), 1);
            Assert.AreEqual("abcd".IndexOfAny(new[] { 'b', 'x' }), 1);
            Assert.AreEqual("abcd".IndexOfAny(new[] { 'b', 'x', 'y' }), 1);
            Assert.AreEqual("abcd".IndexOfAny(new[] { 'x', 'y' }), -1);
        }

        [Test]
        public void IndexOfAnyWithStartIndexWorks()
        {
            Assert.AreEqual("abcdabcd".IndexOfAny(new[] { 'b' }, 4), 5);
            Assert.AreEqual("abcdabcd".IndexOfAny(new[] { 'b', 'x' }, 4), 5);
            Assert.AreEqual("abcdabcd".IndexOfAny(new[] { 'b', 'x', 'y' }, 4), 5);
            Assert.AreEqual("abcdabcd".IndexOfAny(new[] { 'x', 'y' }, 4), -1);
        }

        [Test]
        public void IndexOfAnyWithStartIndexAndCountWorks()
        {
            Assert.AreEqual("abcdabcd".IndexOfAny(new[] { 'b' }, 4, 2), 5);
            Assert.AreEqual("abcdabcd".IndexOfAny(new[] { 'b', 'x' }, 4, 2), 5);
            Assert.AreEqual("abcdabcd".IndexOfAny(new[] { 'b', 'x', 'y' }, 4, 2), 5);
            Assert.AreEqual("abcdabcd".IndexOfAny(new[] { 'x', 'y' }, 4, 2), -1);
            Assert.AreEqual("abcdabcd".IndexOfAny(new[] { 'c' }, 4, 2), -1);
        }

        [Test]
        public void InsertWorks()
        {
            Assert.AreEqual("abcd".Insert(2, "xyz"), "abxyzcd");
        }

        [Test]
        public void IsNullOrEmptyWorks()
        {
            Assert.True(string.IsNullOrEmpty(null));
            Assert.True(string.IsNullOrEmpty(""));
            Assert.False(string.IsNullOrEmpty(" "));
            Assert.False(string.IsNullOrEmpty("0"));
        }

        [Test]
        public void LastIndexOfCharWorks()
        {
            Assert.AreEqual("abc".LastIndexOf("b"), 1);
            Assert.AreEqual("abc".LastIndexOf("d"), -1);
        }

        [Test]
        public void LastIndexOfStringWorks()
        {
            Assert.AreEqual("abc".LastIndexOf("bc"), 1);
            Assert.AreEqual("abc".LastIndexOf("bd"), -1);
        }

        [Test]
        public void LastIndexOfCharWithStartIndexWorks()
        {
            Assert.AreEqual("abcabc".LastIndexOf("b", 3), 1);
            Assert.AreEqual("abcabc".LastIndexOf("d", 3), -1);
        }

        [Test]
        public void LastIndexOfStringWithStartIndexWorks()
        {
            Assert.AreEqual("abcabc".LastIndexOf("bc", 3), 1);
            Assert.AreEqual("abcabc".LastIndexOf("bd", 3), -1);
        }

        [Test]
        public void LastIndexOfCharWithStartIndexAndCountWorks()
        {
            Assert.AreEqual("abcabc".LastIndexOf('b', 3, 3), 1);
            Assert.AreEqual("abcabc".LastIndexOf('b', 3, 2), -1);
            Assert.AreEqual("abcabc".LastIndexOf('d', 3, 3), -1);
        }

        [Test]
        public void LastIndexOfStringWithStartIndexAndCountWorks()
        {
            Assert.AreEqual("xbcxxxbc".LastIndexOf("bc", 3, 3), 1);
            Assert.AreEqual("xbcxxxbc".LastIndexOf("bc", 3, 2), -1);
            Assert.AreEqual("xbcxxxbc".LastIndexOf("bd", 3, 3), -1);
        }

        [Test]
        public void LastIndexOfAnyWorks()
        {
            Assert.AreEqual("abcd".LastIndexOfAny('b'), 1);
            Assert.AreEqual("abcd".LastIndexOfAny('b', 'x'), 1);
            Assert.AreEqual("abcd".LastIndexOfAny('b', 'x', 'y'), 1);
            Assert.AreEqual("abcd".LastIndexOfAny('x', 'y'), -1);
        }

        [Test]
        public void LastIndexOfAnyWithStartIndexWorks()
        {
            Assert.AreEqual("abcdabcd".LastIndexOfAny(new[] { 'b' }, 4), 1);
            Assert.AreEqual("abcdabcd".LastIndexOfAny(new[] { 'b', 'x' }, 4), 1);
            Assert.AreEqual("abcdabcd".LastIndexOfAny(new[] { 'b', 'x', 'y' }, 4), 1);
            Assert.AreEqual("abcdabcd".LastIndexOfAny(new[] { 'x', 'y' }, 4), -1);
        }

        [Test]
        public void LastIndexOfAnyWithStartIndexAndCountWorks()
        {
            Assert.AreEqual("abcdabcd".LastIndexOfAny(new[] { 'b' }, 4, 4), 1);
            Assert.AreEqual("abcdabcd".LastIndexOfAny(new[] { 'b', 'x' }, 4, 4), 1);
            Assert.AreEqual("abcdabcd".LastIndexOfAny(new[] { 'b', 'x', 'y' }, 4, 4), 1);
            Assert.AreEqual("abcdabcd".LastIndexOfAny(new[] { 'x', 'y' }, 4, 4), -1);
            Assert.AreEqual("abcdabcd".LastIndexOfAny(new[] { 'b' }, 4, 2), -1);
        }


        [Test]
        public void LocaleCompareWorks()
        {
            Assert.True("abcd".LocaleCompare("abcd") == 0);
            Assert.True("abcd".LocaleCompare("abcb") > 0);
            Assert.True("abcd".LocaleCompare("abce") < 0);
        }

        [Test]
        public void MatchWorks()
        {
            var result = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".Match(new Regex("[A-E]", "gi"));
            Assert.AreEqual(result, new[] { "A", "B", "C", "D", "E", "a", "b", "c", "d", "e" });
        }

        [Test]
        public void PadLeftWorks()
        {
            Assert.AreEqual("abc".PadLeft(5), "  abc");
        }

        [Test]
        public void PadLeftWithCharWorks()
        {
            Assert.AreEqual("abc".PadLeft(5, '0'), "00abc");
        }

        [Test]
        public void PadRightWorks()
        {
            Assert.AreEqual("abc".PadRight(5), "abc  ");
        }

        [Test]
        public void PadRightWithCharWorks()
        {
            Assert.AreEqual("abc".PadRight(5, '0'), "abc00");
        }

        [Test]
        public void RemoveWorks()
        {
            Assert.AreEqual("abcde".Remove(2), "ab");
        }

        [Test]
        public void RemoveWithCountWorks()
        {
            Assert.AreEqual("abcde".Remove(2, 2), "abe");
        }

        [Test]
        public void ReplaceWorks()
        {
            Assert.AreEqual("abcabcabc".Replace("a", "x"), "xbcxbcxbc");
            Assert.AreEqual("abcabcabc".Replace("ab", "x"), "xcxcxc");
        }

        [Test]
        public void ReplaceCharWorks()
        {
            Assert.AreEqual("abcabcabc".Replace("a", "x"), "xbcxbcxbc");
        }

        [Test]
        public void ReplaceRegexWithReplaceTextWorks()
        {
            Assert.AreEqual("abcabcabc".Replace(new Regex("a|b", "g"), "x"), "xxcxxcxxc");
        }

        [Test]
        public void ReplaceRegexWithReplaceCallbackWorks()
        {
            Assert.AreEqual("abcabcabc".Replace(new Regex("a|b", "g"), s => s == "a" ? "x" : "y"), "xycxycxyc");
        }

        [Test]
        public void SearchWorks()
        {
            Assert.AreEqual("abcabcabc".Search(new Regex("ca")), 2);
            Assert.AreEqual("abcabcabc".Search(new Regex("x")), -1);
        }

        [Test]
        public void SliceWorks()
        {
            var numbers = "0123456789";

            // Let's start by using both begin and end.
             Assert.AreEqual("3456", numbers.Slice(3, 7));

            // What happens when we start with a negative number.
             Assert.AreEqual("3456", numbers.Slice(-7, 7));

            // What happens when we use two negative numbers.
             Assert.AreEqual("3456", numbers.Slice(-7, -3));

            // What happens when we omit the last argument.
             Assert.AreEqual("3456789", numbers.Slice(3));

            // And with the negative, end-relevant index.
             Assert.AreEqual("3456789", numbers.Slice(-7));

            // If the index is out of range, it returns the empty string.
             Assert.AreEqual("", numbers.Slice(100, 101));
        }

        [Test]
        public void SplitWithStringWorks()
        {
            Assert.AreEqual("abcabcabc".Split("b"), new[] { "a", "ca", "ca", "c" });
        }

        [Test]
        public void SplitWithCharWorks()
        {
            Assert.AreEqual("abcabcabc".Split('b'), new[] { "a", "ca", "ca", "c" });
        }

        [Test]
        public void JsSplitWithStringAndLimitWorks()
        {
            Assert.AreEqual("abcaxbcabce".Split("bc", 2), new[] { "a", "ax" });
        }

        [Test]
        public void JsSplitWithCharAndLimitWorks()
        {
            Assert.AreEqual("abcabcabc".Split('b', 2), new[] { "a", "ca" });
        }

        [Test]
        public void SplitWithCharsAndLimitWorks()
        {
            Assert.AreEqual("abcabcabc".Split(new[] { 'b' }, 2), new[] { "a", "cabcabc" });
        }

        [Test]
        public void SplitWithCharsAndStringSplitOptionsAndLimitWorks()
        {
            Assert.AreEqual("abxcabcabc".Split(new[] { 'b', 'x' }, 2, StringSplitOptions.RemoveEmptyEntries), new[] { "a", "cabcabc" });
        }

        [Test]
        public void SplitWithRegexWorks()
        {
            Assert.AreEqual("abcaxcaxc".Split(new Regex("b|x", "g")), new[] { "a", "ca", "ca", "c" });
        }

        [Test]
        public void SomeNetSplitTests()
        {
            Assert.AreEqual("axybcxzde".Split(new[] { "xy", "xz" }, StringSplitOptions.None), new[] { "a", "bc", "de" });
            Assert.AreEqual("axybcxzdexz".Split(new[] { "xy", "xz" }, StringSplitOptions.None), new[] { "a", "bc", "de", "" });
            Assert.AreEqual("xzaxybcxzdexz".Split(new[] { "xy", "xz" }, StringSplitOptions.None), new[] { "", "a", "bc", "de", "" });
            Assert.AreEqual("xzaxyxzbcxzdexz".Split(new[] { "xy", "xz" }, StringSplitOptions.None), new[] { "", "a", "", "bc", "de", "" });
            Assert.AreEqual("xzaxyxzxybcxzdexz".Split(new[] { "xy", "xz" }, StringSplitOptions.None), new[] { "", "a", "", "", "bc", "de", "" });

            Assert.AreEqual("axybcxzde".Split(new[] { "xy", "xz" }, StringSplitOptions.RemoveEmptyEntries), new[] { "a", "bc", "de" });
            Assert.AreEqual("axybcxzdexz".Split(new[] { "xy", "xz" }, StringSplitOptions.RemoveEmptyEntries), new[] { "a", "bc", "de" });
            Assert.AreEqual("xzaxybcxzdexz".Split(new[] { "xy", "xz" }, StringSplitOptions.RemoveEmptyEntries), new[] { "a", "bc", "de" });
            Assert.AreEqual("xzaxyxzbcxzdexz".Split(new[] { "xy", "xz" }, StringSplitOptions.RemoveEmptyEntries), new[] { "a", "bc", "de" });
            Assert.AreEqual("xzaxyxzxybcxzdexz".Split(new[] { "xy", "xz" }, StringSplitOptions.RemoveEmptyEntries), new[] { "a", "bc", "de" });

            Assert.AreEqual("axybcxzde".Split(new[] { "xy", "xz" }, 100, StringSplitOptions.None), new[] { "a", "bc", "de" });
            Assert.AreEqual("axybcxzdexz".Split(new[] { "xy", "xz" }, 100, StringSplitOptions.None), new[] { "a", "bc", "de", "" });
            Assert.AreEqual("xzaxybcxzdexz".Split(new[] { "xy", "xz" }, 100, StringSplitOptions.None), new[] { "", "a", "bc", "de", "" });
            Assert.AreEqual("xzaxyxzbcxzdexz".Split(new[] { "xy", "xz" }, 100, StringSplitOptions.None), new[] { "", "a", "", "bc", "de", "" });
            Assert.AreEqual("xzaxyxzxybcxzdexz".Split(new[] { "xy", "xz" }, 100, StringSplitOptions.None), new[] { "", "a", "", "", "bc", "de", "" });

            Assert.AreEqual("axybcxzde".Split(new[] { "xy", "xz" }, 2, StringSplitOptions.None), new[] { "a", "bcxzde" });
            Assert.AreEqual("axybcxzdexz".Split(new[] { "xy", "xz" }, 2, StringSplitOptions.None), new[] { "a", "bcxzdexz" });
            Assert.AreEqual("axyxzbcxzdexz".Split(new[] { "xy", "xz" }, 2, StringSplitOptions.None), new[] { "a", "xzbcxzdexz" });
            Assert.AreEqual("xzaxybcxzdexz".Split(new[] { "xy", "xz" }, 2, StringSplitOptions.None), new[] { "", "axybcxzdexz" });

            Assert.AreEqual("axybcxzde".Split(new[] { "xy", "xz" }, 2, StringSplitOptions.RemoveEmptyEntries), new[] { "a", "bcxzde" });
            Assert.AreEqual("axybcxzdexz".Split(new[] { "xy", "xz" }, 2, StringSplitOptions.RemoveEmptyEntries), new[] { "a", "bcxzdexz" });
            Assert.AreEqual("axyxzbcxzdexz".Split(new[] { "xy", "xz" }, 2, StringSplitOptions.RemoveEmptyEntries), new[] { "a", "bcxzdexz" });
            Assert.AreEqual("xzaxyxzbcxzdexz".Split(new[] { "xy", "xz" }, 2, StringSplitOptions.RemoveEmptyEntries), new[] { "a", "bcxzdexz" });
        }

        [Test]
        public void SplitWithCharsWorks()
        {
            Assert.AreEqual("Lorem Ipsum, dolor[sit amet".Split(new[] { ',', ' ', '[' }), new[] { "Lorem", "Ipsum", "", "dolor", "sit", "amet" });
            Assert.AreEqual("Lorem Ipsum, dolor[sit amet".Split(new[] { ',', ' ', '[' }, StringSplitOptions.None), new[] { "Lorem", "Ipsum", "", "dolor", "sit", "amet" });
            Assert.AreEqual("Lorem Ipsum, dolor[sit amet".Split(new[] { ',', ' ', '[' }, StringSplitOptions.RemoveEmptyEntries), new[] { "Lorem", "Ipsum", "dolor", "sit", "amet" });
        }

        [Test]
        public void SplitWithStringsWorks()
        {
            Assert.AreEqual("a is b if b is c and c isifis d if d is e".Split(new[] { "is", "if" }, StringSplitOptions.None), new[] { "a ", " b ", " b ", " c and c ", "", "", " d ", " d ", " e" });
            Assert.AreEqual("a is b if b is c and c isifis d if d is e".Split(new[] { "is", "if" }, StringSplitOptions.RemoveEmptyEntries), new[] { "a ", " b ", " b ", " c and c ", " d ", " d ", " e" });
        }

        [Test]
        public void SplitWithStringsAndLimitWorks()
        {
            Assert.AreEqual("abcbcabcabc".Split(new[] { "bc" }, 2, StringSplitOptions.RemoveEmptyEntries), new[] { "a", "abcabc" });
        }

        [Test]
        public void StartsWithCharWorks()
        {
            Assert.True("abc".StartsWith("a"));
            Assert.False("abc".StartsWith("b"));
        }

        [Test]
        public void StartsWithStringWorks()
        {
            Assert.True("abc".StartsWith("ab"));
            Assert.False("abc".StartsWith("bc"));
        }

        [Test]
        public void SubstrWorks()
        {
            Assert.AreEqual("abcde".Substr(2), "cde");
            Assert.AreEqual("abcde".Substr(2, 2), "cd");

            var numbers = "0123456789";

            // Let's start by using both start and length
            Assert.AreEqual("3456", numbers.Substr(3, 4));

            // What happens when we start with a negative number.
            Assert.AreEqual("3456", numbers.Substr(-7, 4));

            // What happens when we omit the last argument.
            Assert.AreEqual("3456789", numbers.Substr(3));

            // And with the negative, end-relevant index.
            Assert.AreEqual("3456789", numbers.Substr(-7));

            // If the index is out of range, it returns the empty string.
            Assert.AreEqual("", numbers.Substr(100, 1));

            Assert.AreEqual("2345", numbers.Substr(2, 4));
        }

        [Test]
        public void SubstringWorks()
        {
            Assert.AreEqual("abcde".Substring(2), "cde");
            Assert.AreEqual("abcde".Substring(2, 2), "cd");

            var numbers = "0123456789";
            // Let's start by using both begin and end.
            Assert.AreEqual("3456789", numbers.Substring(3, 7));

            // What happens when we start with a negative number.
            Assert.AreEqual("3456789", numbers.Substring(-7, 7));

            // What happens when we use two negative numbers.
            Assert.AreEqual("", numbers.Substring(-7, -3));

            // What happens when we omit the last argument.
            Assert.AreEqual("3456789", numbers.Substring(3));

            // And with the negative, end-relevant index.
            Assert.AreEqual("3456789", numbers.Substring(-7));

            // If the index is out of range, it returns the empty string.
            Assert.AreEqual("", numbers.Substring(100, 101));

            Assert.AreEqual("2345", numbers.Substring(2, 4));
        }

        [Test]
        public void JsSubstringWorks()
        {
            var numbers = "0123456789";

            // Let's start by using both begin and end.
            Assert.AreEqual("3456", numbers.JsSubstring(3, 7));

            // What happens when we start with a negative number.
            Assert.AreEqual("0123456", numbers.JsSubstring(-7, 7));

            // What happens when we use two negative numbers.
            Assert.AreEqual("", numbers.JsSubstring(-7, -3));

            // What happens when we omit the last argument.
            Assert.AreEqual("3456789", numbers.JsSubstring(3));

            // And with the negative, end-relevant index.
            Assert.AreEqual("0123456789", numbers.JsSubstring(-7));

            // If the index is out of range, it returns the empty string.
            Assert.AreEqual("", numbers.JsSubstring(100, 101));

            Assert.AreEqual("23", numbers.JsSubstring(2, 4));
        }

        [Test]
        public void ToLowerCaseWorks()
        {
            Assert.AreEqual("ABcd".ToLower(), "abcd");
        }

        [Test]
        public void ToUpperCaseWorks()
        {
            Assert.AreEqual("ABcd".ToUpper(), "ABCD");
        }

        [Test]
        public void ToLowerWorks()
        {
            Assert.AreEqual("ABcd".ToLower(), "abcd");
        }

        [Test]
        public void ToUpperWorks()
        {
            Assert.AreEqual("ABcd".ToUpper(), "ABCD");
        }

        [Test]
        public void TrimWorks()
        {
            Assert.AreEqual("  abc  ".Trim(), "abc");
        }

        [Test]
        public void TrimCharsWorks()
        {
            Assert.AreEqual(",., aa, aa,... ".Trim(',', '.', ' '), "aa, aa");
        }

        [Test]
        public void TrimStartCharsWorks()
        {
            Assert.AreEqual(",., aa, aa,... ".TrimStart(',', '.', ' '), "aa, aa,... ");
        }

        [Test]
        public void TrimEndCharsWorks()
        {
            Assert.AreEqual(",., aa, aa,... ".TrimEnd(',', '.', ' '), ",., aa, aa");
        }

        [Test]
        public void TrimStartWorks()
        {
            Assert.AreEqual("  abc  ".TrimStart(), "abc  ");
        }

        [Test]
        public void TrimEndWorks()
        {
            Assert.AreEqual("  abc  ".TrimEnd(), "  abc");
        }

        [Test]
        public void StringEqualityWorks()
        {
            string s1 = "abc", s2 = null, s3 = null;
            Assert.True(s1 == "abc");
            Assert.False(s1 == "aBc");
            Assert.False(s1 == s2);
            Assert.True(s2 == s3);
        }

        [Test]
        public void StringInequalityWorks()
        {
            string s1 = "abc", s2 = null, s3 = null;
            Assert.False(s1 != "abc");
            Assert.True(s1 != "aBc");
            Assert.True(s1 != s2);
            Assert.False(s2 != s3);
        }

        [Test]
        public void StringIndexingWorks()
        {
            var s = "abcd";
            Assert.AreEqual((int)s[0], (int)'a');
            Assert.AreEqual((int)s[1], (int)'b');
            Assert.AreEqual((int)s[2], (int)'c');
            Assert.AreEqual((int)s[3], (int)'d');
        }

        [Test]
        public void GetHashCodeWorks()
        {
            Assert.AreEqual("a".GetHashCode(), "a".GetHashCode());
            Assert.AreEqual("b".GetHashCode(), "b".GetHashCode());
            Assert.AreNotEqual("a".GetHashCode(), "b".GetHashCode());
            Assert.AreNotEqual("a".GetHashCode(), "ab".GetHashCode());
            Assert.True((long)"abcdefghijklmnopq".GetHashCode() < 0xffffffffL);
        }

        [Test]
        public void InstanceEqualsWorks()
        {
            object r = "a";
            Assert.True("a".Equals(r));
            Assert.False("b".Equals(r));
            r = "b";
            Assert.False("a".Equals(r));
            Assert.True("b".Equals(r));
            r = "A";
            Assert.False("a".Equals(r));
            r = "ab";
            Assert.False("a".Equals(r));
        }

        [Test]
        public void IEquatableEqualsWorks()
        {
            Assert.True("a".Equals("a"));
            Assert.False("b".Equals("a"));
            Assert.False("a".Equals("b"));
            Assert.True("b".Equals("b"));
            Assert.False("a".Equals("A"));
            Assert.False("a".Equals("ab"));

            Assert.True(((IEquatable<string>)"a").Equals("a"));
            Assert.False(((IEquatable<string>)"b").Equals("a"));
            Assert.False(((IEquatable<string>)"a").Equals("b"));
            Assert.True(((IEquatable<string>)"b").Equals("b"));
            Assert.False(((IEquatable<string>)"a").Equals("A"));
            Assert.False(((IEquatable<string>)"a").Equals("ab"));
        }

        [Test]
        public void StringEqualsWorks()
        {
            Assert.True("a".Equals("a"));
            Assert.False("b".Equals("a"));
            Assert.False("a".Equals("b"));
            Assert.True("b".Equals("b"));
            Assert.False("a".Equals("A"));
            Assert.False("a".Equals("ab"));
        }

        [Test]
        public void CompareToWorks()
        {
            Assert.True(string.Compare("abcd", "abcd") == 0);
            Assert.True(string.Compare("abcd", "abcD") != 0);
            Assert.True(string.Compare("abcd", "abcb") > 0);
            Assert.True(string.Compare("abcd", "abce") < 0);
        }

        [Test]
        public void IComparableCompareToWorks()
        {
            Assert.True(((IComparable<string>)"abcd").CompareTo("abcd") == 0);
            Assert.True(((IComparable<string>)"abcd").CompareTo("abcD") != 0);
            Assert.True(((IComparable<string>)"abcd").CompareTo("abcb") > 0);
            Assert.True(((IComparable<string>)"abcd").CompareTo("abce") < 0);

            Assert.True(((IComparable<string>)"").CompareTo(null) > 0);
        }

        [Test]
        public void JoinWorks()
        {
            Assert.AreEqual(string.Join(", ", new[] { "a", "ab", "abc", "abcd" }), "a, ab, abc, abcd");
            Assert.AreEqual(string.Join(", ", new[] { "a", "ab", "abc", "abcd" }, 1, 2), "ab, abc");

            IEnumerable<int> intValues = new MyEnumerable<int>(new[] { 1, 5, 6 });
            Assert.AreEqual(String.Join(", ", intValues), "1, 5, 6");
            IEnumerable<string> stringValues = new MyEnumerable<string>(new[] { "a", "ab", "abc", "abcd" });
            Assert.AreEqual(String.Join(", ", stringValues), "a, ab, abc, abcd");

            // TODO: c# makes it False but js false
            Assert.AreEqual(String.Join(", ", new Object[] { "a", 1, "abc", false }), "a, 1, abc, false");// False");
        }

        [Test]
        public void ContainsWorks()
        {
            string text = "Lorem ipsum dolor sit amet";
            Assert.True(text.Contains("Lorem"));
            Assert.False(text.Contains("lorem"));
            Assert.True(text.Contains(text));
        }

        [Test]
        public void ToCharArrayWorks()
        {
            string text = "Lorem sit dolor";
            Assert.AreEqual(text.ToCharArray(), new[] { 'L', 'o', 'r', 'e', 'm', ' ', 's', 'i', 't', ' ', 'd', 'o', 'l', 'o', 'r' });
        }
    }
}
