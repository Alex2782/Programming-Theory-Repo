using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputName;

    public void OnClickStart()
    {
        string userName = inputName.text;
        Debug.Log($"userName: {userName} ");

        SceneManager.LoadScene(1);
    }

}
