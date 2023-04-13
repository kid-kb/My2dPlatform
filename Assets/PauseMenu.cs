using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(!pauseMenu.activeSelf){
                Cursor.visible = true;
                Time.timeScale = 0f;
                pauseMenu.SetActive(true);
            } else{
                Cursor.visible = false;
                Time.timeScale = 1f;
                pauseMenu.SetActive(false);
            }
        }
    }

    public void Resume(){
        Debug.Log("hello");
        Cursor.visible = false;
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
    }

    public void Quit(){
        Application.Quit();
    }
}
