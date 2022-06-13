using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UserInputHandler : MonoBehaviour
{

    public static UserInputHandler Instance;
    public TMP_InputField userInputField;
    public string userName;

    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }


    public void GetName() // gets name from Input field so we can use it in MainManager class
    {
        userName = userInputField.text;
        Debug.Log("Name: " + userName);
    }

    public void LoadNextScene()// create different script to handle scenes
    {
        SceneManager.LoadScene(1);
    }

    public void ClearData() // to clear PlayePrefs data
    {
        PlayerPrefs.DeleteAll();
    }
}
