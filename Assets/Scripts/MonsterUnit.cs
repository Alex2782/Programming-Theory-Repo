using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class MonsterUnit : Unit
{
    private Rigidbody rb;

    // ABSTRACTION
    // POLYMORPHISM
    protected override void Init()
    {
        m_speed = 15.0f;
        color = Color.red;
        scale = new Vector3(2.0f, 2.5f, 2.0f);

        rb = GetComponent<Rigidbody>();
    }

    private void LateUpdate()
    {
        PlayerUnit player = FindObjectOfType<PlayerUnit>();
        Vector3 toPlayer = (player.gameObject.transform.position - gameObject.transform.position).normalized;

        rb.AddForce(toPlayer * m_speed, ForceMode.Acceleration);
    }
}
