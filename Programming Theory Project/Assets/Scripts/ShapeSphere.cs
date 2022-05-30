using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeSphere : Shape
{
    // POLYMORPHISM
    public override string ShapeStyle()
    {
        return "Sphere";
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
