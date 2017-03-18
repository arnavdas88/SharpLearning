﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpLearning.Containers.Tensors;

namespace SharpLearning.Containers.Test.Tensors
{
    /// <summary>
    /// Summary description for TensorExtensionsTest
    /// </summary>
    [TestClass]
    public class TensorExtensionsTest
    {
        [TestMethod]
        public void TensorExtensions_AddRowWise()
        {
            var tensor = Tensor<float>.Build(2, 3);
            var vector = new float[] { 1f, 2f, 3f };
            var actual = Tensor<float>.Build(2, 3);

            tensor.AddRowWise(vector, actual);

            var expected = Tensor<float>.Build(new float[] { 1, 2, 3, 1, 2, 3 }, 2, 3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TensorExtensions_SumColumns()
        {
            var tensor = Tensor<float>.Build(new float[] { 1, 2, 3, 1, 2, 3 }, 2, 3);
            var actual = new float[3];

            tensor.SumColumns(actual);

            var expected = new float[] { 2, 4, 6 };
            CollectionAssert.AreEqual(expected, actual);
        }

    }
}
