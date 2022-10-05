using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Unit : MonoBehaviour
{
    protected Vector3 scale = Vector3.one;
    protected Color color = Color.black;

    // ENCAPSULATION
    protected float m_speed = 1.0f;
    public float Speed
    {
        //getter
        get { return m_speed; }

        //setter
        set
        {
            if (value < 0)
            {
                Debug.LogError("You can't set a negative speed!");
            }
            else
            {
                m_speed = value;
            }
        }
    }


    // ABSTRACTION
    protected abstract void Init();

    private void Awake()
    {
        Init();
        ChangeSettings();
    }

    void ChangeSettings()
    {
        transform.localScale = scale;
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.SetColor("_Color", color);
    }
}
