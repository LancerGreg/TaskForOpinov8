// <copyright file="ProgramTest.cs">Copyright ©  2019</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskForOpinov8;

namespace TaskForOpinov8.Tests {
    /// <summary>Этот класс содержит параметризованные модульные тесты для Program</summary>
    [PexClass(typeof(Program))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class ProgramTest {
        [TestMethod]
        public void solutionTest() {
            // arrange 
            int[] A = { 0, 1, 2, 1, -1, -10, 1, -5, 6, 7, 9, 10, -3, -4, -6, -8, -4, -2, -1, 0, 5, 3, 1, -2, 4 };
            int result = 9;

            // act 
            int actual = Program.solution(A);

            // assert
            Assert.AreEqual(result, actual);
        }
    }
}
