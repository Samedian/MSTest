using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProject1
{
    public static class CustomAsserts
    {
        public static void IsInRange(this Assert assert, int actual, int expectedMin, int expectedMax)
        {
            if (actual < expectedMin || actual > expectedMax)
                throw new AssertFailedException($"{actual} was not  in range {expectedMin} & {expectedMax} ");

            //Access Assert.That.IsInRange
        }

        public static void AllItemNotNullOrWhiteSpace(this CollectionAssert collectionAssert,
            ICollection<string> collection)
        {
            foreach (var item in collection)
            {
                if (string.IsNullOrEmpty(item))
                    throw new AssertFailedException("One or more items are null or white spaces");
            }
            //Access CollectionAssert.That.AllItemNotNullOrWhiteSpace(weapon);
        }

        public static void AllItemSatisfy<T>(this CollectionAssert collectionAssert,
            ICollection<T> collection,
            Predicate<T> predicate)
        {
            foreach (var item in collection)
            {
                if (!predicate(item))
                    throw new AssertFailedException("All Item do not satisfy predicate");
            }
            //Access CollectionAssert.That.AllItemSatisfy(weapon,weapon=>!string.IsNullOrWhiteSpace(weapon));
        }

        public static void AtleastOneItemSatisfy<T>(this CollectionAssert collectionAssert,
           ICollection<T> collection,
           Predicate<T> predicate)
        {
            foreach (var item in collection)
            {
                if (predicate(item))
                    return;
            }
            throw new AssertFailedException("All Item do not satisfy predicate");

            //Access CollectionAssert.That.AtleastOneItemSatisfy(weapon,weapon=>weapon.contains());
        }
        public static void All<T>(this CollectionAssert collectionAssert,
            ICollection<T> collection,
            Action<T> assert)
        {
            foreach (var item in collection)
            {
                assert(item);
            }
            //Access CollectionAssert.That.All(weapon,weapon=>StringAssert.That.NotNullorWhiteSpaces(weapon);
            // Assert.IsTrue(weapon.length>5));
        }

        public static void NotNullorWhiteSpaces(this StringAssert stringAssert,
           string actual)
        {
            if (string.IsNullOrWhiteSpace(actual))
                throw new AssertFailedException("Value is null or white spaces");
            //Access CollectionAssert.That.All(weapon,weapon=>StringAssert.That.NotNullorWhiteSpaces(weapon);
            // Assert.IsTrue(weapon.length>5));
        }
    }
}
