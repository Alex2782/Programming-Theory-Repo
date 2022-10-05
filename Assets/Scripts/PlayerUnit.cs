using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// INHERITANCE
public class PlayerUnit : Unit
{
    public TMP_Text playerName;


    // ABSTRACTION
    // POLYMORPHISM
    protected override void Init()
    {
        m_speed = 12.0f;
        color = Color.blue;
        scale = new Vector3(1.0f, 1.5f, 1.0f);


        string userName = GameManager.Instance.userName;

        Debug.Log("userName: " + userName);

        playerName.text = userName;
    }
}
