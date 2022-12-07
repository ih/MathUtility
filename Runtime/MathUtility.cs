using System;
using UnityEngine;

public class MathUtility 
{
    public struct ElementData
    {
        public ElementData(int index, float value)
        {
            Index = index;
            Value = value;
        }
        public int Index { get; }
        public float Value { get; }
    }
    public static ElementData GetMaxComponent(Vector3 vector)
    {
        int maxComponentIndex = 0;
        float maxComponentValue = vector[0];
        for (int i = 1; i < 3; i++)
        {
            if (vector[i] > vector[maxComponentIndex])
            {
                maxComponentIndex = i;
                maxComponentValue = vector[i];
            }
        }

        return new ElementData(maxComponentIndex, maxComponentValue);
    }

    public static Vector3 ElementWiseDivision(Vector3 numerator, Vector3 denominator)
    {
        Vector3 inverseDenominator = new Vector3(1 / denominator.x, 1 / denominator.y, 1 / denominator.z);
        // elementwise multipy
        return Vector3.Scale(numerator, denominator);
    }
}
