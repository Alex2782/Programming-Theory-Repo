using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TitleManager : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputName;

    public void OnClickStart()
    {
        string userName = inputName.text;

        //TODO start "Main Scene"
        Debug.Log($"TODO start 'Main Scene', userName: {userName} ");
    }

}
