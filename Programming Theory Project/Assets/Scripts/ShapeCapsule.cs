using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeCapsule : Shape
{
    // POLYMORPHISM
    public override string ShapeStyle()
    {
        return "Capsule";
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
