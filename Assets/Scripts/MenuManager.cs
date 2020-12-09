using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public GameObject mainMenu;
    //public GameObject settingsMenu;
    public GameObject creditMenu;

    public void SwapMenu(string menu)
    {
        DisableAllMenu();
        switch (menu)
        {
            case "Main" :
                mainMenu.SetActive(true);
                break;
            case "Credits" :
                creditMenu.SetActive(true);
                break;
            default:
                Debug.Log("Wrong Argument");
                break;
        }

    }
    private void DisableAllMenu()
    {
        mainMenu.SetActive(false);
        creditMenu.SetActive(false);
    }
    
    public void LauchGame()
    {
        SceneManager.LoadScene("Scenes/Game");
    }
    
    // Start is called before the first frame update
    void Start()
    {
        mainMenu.SetActive(true);
        creditMenu.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
