using System;
using NUnit.Framework;
using Action = Unity.Plastic.Antlr3.Runtime.Misc.Action;

namespace Tests
{
    public static class AssertExtensions
    {
        public static void Throws<T>(Action action) where T : Exception
        {
            try
            {
                action();
                Assert.IsTrue(false);
            }
            catch (T e) { }
            catch (Exception e)
            {
                Assert.IsTrue(false);
            }
        }
    }
}