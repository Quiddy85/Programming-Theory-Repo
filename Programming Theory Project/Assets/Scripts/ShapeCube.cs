using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeCube : Shape
{
    // POLYMORPHISM
    public override string ShapeStyle()
    {
        return "Cube";
    }

    private void Start()
    {
        scaleX = 1;
        scaleY = 1;
        scaleZ = 1;
    }

    private void OnMouseDown()
    {
        SetScale();
        DisplayText();
    }
}
