using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    
    public void StartGame()
    {
        SceneManager.LoadScene("SCPLvlOne"); 
    }

    public void QuitGame()
    {
        Application.Quit(); 
    }

    public void Menureturn()
    {
        SceneManager.LoadScene("HubWorld"); 
    }

}
