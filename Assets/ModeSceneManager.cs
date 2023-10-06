using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ModeSceneManager : MonoBehaviour
{
    public Canvas TeacherMode;
    public Canvas StudentMode;
    public Canvas SelectionMode;
    public InputField TeacherID_INPUT;
    public InputField StudentID_INPUT;

    private string TeacherID = "teacher";
    private string StudentID = "student";
    public void Start()
    {
        TeacherMode.enabled = false;
        StudentMode.enabled = false;
        SelectionMode.enabled = true;
    }
    public void STeacherMode()
    {
        TeacherMode.enabled = true;
        SelectionMode.enabled = false;
        PlayerPrefs.SetString("Mode", "teacher");
    }
    public void SStudentMode()
    {
        StudentMode.enabled = true;
        SelectionMode.enabled = false;
        PlayerPrefs.SetString("Mode", "student");
    }
    public void SignIn()
    {
        if(TeacherMode.isActiveAndEnabled)
        {
           if(TeacherID_INPUT.text == TeacherID)
            {
                //login
                SceneManager.LoadScene("Lobby");
            }
        }
        else
        {
            if (StudentID_INPUT.text == StudentID)
            {
                //login
                SceneManager.LoadScene("Lobby");
            }
        }

    }
}
