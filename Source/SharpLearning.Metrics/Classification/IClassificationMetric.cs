﻿
namespace SharpLearning.Metrics.Classification
{
    /// <summary>
    /// Classification metric interface
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IClassificationMetric<T>
    {
        /// <summary>
        /// Calculates the classification error
        /// </summary>
        /// <param name="targets"></param>
        /// <param name="predictions"></param>
        /// <returns></returns>
        double Error(T[] targets, T[] predictions);
        
        /// <summary>
        /// Gives a string representation of the classification matrix
        /// </summary>
        /// <param name="targets"></param>
        /// <param name="predictions"></param>
        /// <returns></returns>
        string ErrorString(T[] targets, T[] predictions);
    }
}