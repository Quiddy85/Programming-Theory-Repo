using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    // m_ is used locally to set variable
    float m_ScaleX = 0.1f;
    public float scaleX // Called from other scripts
    {// ENCAPSULATION
        get
        { return m_ScaleX; }
        set
        {
            if (value < 0.1f)
            {
                Debug.LogError("You can't set scale to 0 or less");
            }
            else
            {
                m_ScaleX = value;
            }
        }
    }

    float m_ScaleY = 0.1f;
    public float scaleY // Called from other scripts
    {// ENCAPSULATION
        get
        { return m_ScaleY; }
        set
        {
            if (value < 0.1f)
            {
                Debug.LogError("You can't set scale to 0 or less");
            }
            else
            {
                m_ScaleY = value;
            }
        }
    }

    float m_ScaleZ = 0.1f;
    public float scaleZ // Called from other scripts
    {// ENCAPSULATION
        get
        { return m_ScaleZ; }
        set
        {
            if (value < 0.1f)
            {
                Debug.LogError("You can't set scale to 0 or less");
            }
            else
            {
                m_ScaleZ = value;
            }
        }
    }


    // Set shape name
    public virtual string ShapeStyle()
    {
        return "Shape"; // return "Shape name set in other scripts"
    }

    // Write information to the screen
    public void DisplayText()
    {
        // ABSTRACTION
        print(ShapeStyle()); // Print the overridden name

        print("X: " + m_ScaleX); // Print the scale
        print("Y: " + m_ScaleY);
        print("Z: " + m_ScaleZ);
        print("");
    }

    // Set each shapes scale
    public virtual void SetScale()
    {
        transform.localScale = new Vector3(m_ScaleX, m_ScaleY, m_ScaleZ); // INHERITANCE
    }
}
