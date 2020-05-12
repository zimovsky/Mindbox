using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class FigureArea : MonoBehaviour
{
    
    public static double UnknownFigureArea(double radius) {
        Debug.Log("It's a circle!");
        double area = CircleAreaByRadius(radius);
        return area;
    }

    public static double UnknownFigureArea(double sideA, double sideB) {
        Debug.Log("It's a rectangle!");
        double area = RectangleAreaBy2Sides(sideA, sideB);
        return area;
    }

    public static double UnknownFigureArea(double sideA, double sideB, double sideC) {
        Debug.Log("It's a triangle!");
        double area = TriangleAreaBy3Sides(sideA, sideB, sideC);
        return area;
    }

    /// <summary>
    /// Calculates total area of a circle by its radius.
    /// </summary>
    /// <param name="radius">Radius of the circle.</param>
    /// <returns>Total area of the circle.</returns>
    public static double CircleAreaByRadius(double radius) {
        double area;
        area = Math.PI * Math.Pow(radius, 2);
        Debug.Log("Math.PI * Math.Pow(" + radius + ", 2) = " + area);
        return area;
    }

    /// <summary>
    /// Calculates total area of a rectangle by its 2 sides.
    /// </summary>
    /// <param name="sideA">Length of the side A.</param>
    /// <param name="sideB">Length of the side B.</param>
    /// <returns>Total area of the rectangle.</returns>
    public static double RectangleAreaBy2Sides(double sideA, double sideB) {
        double area;
        area = sideA * sideB;
        Debug.Log(sideA + " * " + sideB + " = " + area);
        return area;
    }

    /// <summary>
    /// Calculates total area of a triangle by its 3 sides.
    /// </summary>
    /// <param name="sideA">Length of the side A.</param>
    /// <param name="sideB">Length of the side B.</param>
    /// <param name="sideC">Length of the side C.</param>
    /// <returns></returns>
    public static double TriangleAreaBy3Sides(double sideA, double sideB, double sideC) {
        double area;

        double p = (sideA + sideB + sideC) / 2;
        area = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        Debug.Log("Math.Sqrt(" + p + " * (" + p + " - " + sideA + ") * (" + p + " - " + sideB + ") * (" + p + " - " + sideB + ")) = " + area);
        return area;
    }

    /// <summary>
    /// Checks if the triangle is a right one.
    /// </summary>
    /// <param name="sideA">Length of the side A.</param>
    /// <param name="sideB">Length of the side B.</param>
    /// <param name="sideC">Length of the side C.</param>
    /// <returns>Rerurns true if it is right, false - if not.</returns>
    public static bool IsRightTriangle(double sideA, double sideB, double sideC) {
        if (Math.Pow(sideA, 2) + Math.Pow(sideB, 2) == Math.Pow(sideC, 2) || Math.Pow(sideB, 2) + Math.Pow(sideC, 2) == Math.Pow(sideA, 2) || Math.Pow(sideA, 2) + Math.Pow(sideC, 2) == Math.Pow(sideB, 2)) {
            return true;
        }
        else {
            return false;
        }
    }
}
