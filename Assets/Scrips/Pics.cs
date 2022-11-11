using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pics : MonoBehaviour
{
    public GameObject Settings;
    public GameObject MainMenu;
    public GameObject Gallery;
    public GameObject Authors;
    public GameObject pic1;
    public GameObject pic2;
    public GameObject pic3;
    public GameObject pic4;
    public GameObject pic5;
    public GameObject pic6;
    public GameObject pic7;
    public GameObject pic8;
    public GameObject pic9;
    public GameObject pic10;
    public GameObject pic11;
    public GameObject pic12;
    public GameObject pic13;
    public GameObject pic14;
    public GameObject pic15;
    public GameObject pic16;
    public GameObject pic17;
    public GameObject pic18;
    public GameObject pic19;
    public GameObject pic20;


    /// <summary>
    /// Меню////////////////////////////////////////////////
    /// </summary>
    public void ShowGallery()
    {
        Gallery.SetActive(true);
        MainMenu.SetActive(false);
        Authors.SetActive(false);
    }
    public void ShowSettings()
    {
        Settings.SetActive(true);
        MainMenu.SetActive(false);
        Authors.SetActive(false);
    }
    public void ShowMenu()
    {
        MainMenu.SetActive(true);
        Gallery.SetActive(false);
        Settings.SetActive(false);
        Authors.SetActive(false);
    }
    public void ShowAuthors()
    {
        Authors.SetActive(true);
        MainMenu.SetActive(false);
    }

    public void Exit()
    {
        Application.Quit();
    }
    public void ShowSt1()
    {
        pic1.SetActive(true);
        pic2.SetActive(false);
        pic3.SetActive(false);
        pic4.SetActive(false);
        pic5.SetActive(false);
        pic6.SetActive(false);
        pic7.SetActive(false);
        pic8.SetActive(false);
        pic9.SetActive(false);
        pic10.SetActive(false);
        pic11.SetActive(false);
        pic12.SetActive(false);
        pic13.SetActive(false);
        pic14.SetActive(false);
        pic15.SetActive(false);
        pic16.SetActive(false);
        pic17.SetActive(false);
        pic18.SetActive(false);
        pic19.SetActive(false);
        pic20.SetActive(false);
    }
    public void ShowSt2()
    {
        pic1.SetActive(false);
        pic2.SetActive(true);
        pic3.SetActive(false);
        pic4.SetActive(false);
        pic5.SetActive(false);
        pic6.SetActive(false);
        pic7.SetActive(false);
        pic8.SetActive(false);
        pic9.SetActive(false);
        pic10.SetActive(false);
        pic11.SetActive(false);
        pic12.SetActive(false);
        pic13.SetActive(false);
        pic14.SetActive(false);
        pic15.SetActive(false);
        pic16.SetActive(false);
        pic17.SetActive(false);
        pic18.SetActive(false);
        pic19.SetActive(false);
        pic20.SetActive(false);
    }
    public void ShowSt3()
    {
        pic1.SetActive(false);
        pic2.SetActive(false);
        pic3.SetActive(true);
        pic4.SetActive(false);
        pic5.SetActive(false);
        pic6.SetActive(false);
        pic7.SetActive(false);
        pic8.SetActive(false);
        pic9.SetActive(false);
        pic10.SetActive(false);
        pic11.SetActive(false);
        pic12.SetActive(false);
        pic13.SetActive(false);
        pic14.SetActive(false);
        pic15.SetActive(false);
        pic16.SetActive(false);
        pic17.SetActive(false);
        pic18.SetActive(false);
        pic19.SetActive(false);
        pic20.SetActive(false);
    }
    public void ShowSt4()
    {
        pic1.SetActive(false);
        pic2.SetActive(false);
        pic3.SetActive(false);
        pic4.SetActive(true);
        pic5.SetActive(false);
        pic6.SetActive(false);
        pic7.SetActive(false);
        pic8.SetActive(false);
        pic9.SetActive(false);
        pic10.SetActive(false);
        pic11.SetActive(false);
        pic12.SetActive(false);
        pic13.SetActive(false);
        pic14.SetActive(false);
        pic15.SetActive(false);
        pic16.SetActive(false);
        pic17.SetActive(false);
        pic18.SetActive(false);
        pic19.SetActive(false);
        pic20.SetActive(false);
    }
    public void ShowSt5()
    {
        pic1.SetActive(false);
        pic2.SetActive(false);
        pic3.SetActive(false);
        pic4.SetActive(false);
        pic5.SetActive(true);
        pic6.SetActive(false);
        pic7.SetActive(false);
        pic8.SetActive(false);
        pic9.SetActive(false);
        pic10.SetActive(false);
        pic11.SetActive(false);
        pic12.SetActive(false);
        pic13.SetActive(false);
        pic14.SetActive(false);
        pic15.SetActive(false);
        pic16.SetActive(false);
        pic17.SetActive(false);
        pic18.SetActive(false);
        pic19.SetActive(false);
        pic20.SetActive(false);
    }
    public void ShowSt6()
    {
        pic1.SetActive(false);
        pic2.SetActive(false);
        pic3.SetActive(false);
        pic4.SetActive(false);
        pic5.SetActive(false);
        pic6.SetActive(true);
        pic7.SetActive(false);
        pic8.SetActive(false);
        pic9.SetActive(false);
        pic10.SetActive(false);
        pic11.SetActive(false);
        pic12.SetActive(false);
        pic13.SetActive(false);
        pic14.SetActive(false);
        pic15.SetActive(false);
        pic16.SetActive(false);
        pic17.SetActive(false);
        pic18.SetActive(false);
        pic19.SetActive(false);
        pic20.SetActive(false);
    }
    public void ShowSt7()
    {
        pic1.SetActive(false);
        pic2.SetActive(false);
        pic3.SetActive(false);
        pic4.SetActive(false);
        pic5.SetActive(false);
        pic6.SetActive(false);
        pic7.SetActive(true);
        pic8.SetActive(false);
        pic9.SetActive(false);
        pic10.SetActive(false);
        pic11.SetActive(false);
        pic12.SetActive(false);
        pic13.SetActive(false);
        pic14.SetActive(false);
        pic15.SetActive(false);
        pic16.SetActive(false);
        pic17.SetActive(false);
        pic18.SetActive(false);
        pic19.SetActive(false);
        pic20.SetActive(false);
    }
    public void ShowSt8()
    {
        pic1.SetActive(false);
        pic2.SetActive(false);
        pic3.SetActive(false);
        pic4.SetActive(false);
        pic5.SetActive(false);
        pic6.SetActive(false);
        pic7.SetActive(false);
        pic8.SetActive(true);
        pic9.SetActive(false);
        pic10.SetActive(false);
        pic11.SetActive(false);
        pic12.SetActive(false);
        pic13.SetActive(false);
        pic14.SetActive(false);
        pic15.SetActive(false);
        pic16.SetActive(false);
        pic17.SetActive(false);
        pic18.SetActive(false);
        pic19.SetActive(false);
        pic20.SetActive(false);
    }
    public void ShowSt9()
    {
        pic1.SetActive(false);
        pic2.SetActive(false);
        pic3.SetActive(false);
        pic4.SetActive(false);
        pic5.SetActive(false);
        pic6.SetActive(false);
        pic7.SetActive(false);
        pic8.SetActive(false);
        pic9.SetActive(true);
        pic10.SetActive(false);
        pic11.SetActive(false);
        pic12.SetActive(false);
        pic13.SetActive(false);
        pic14.SetActive(false);
        pic15.SetActive(false);
        pic16.SetActive(false);
        pic17.SetActive(false);
        pic18.SetActive(false);
        pic19.SetActive(false);
        pic20.SetActive(false);
    }
    public void ShowSt10()
    {
        pic1.SetActive(false);
        pic2.SetActive(false);
        pic3.SetActive(false);
        pic4.SetActive(false);
        pic5.SetActive(false);
        pic6.SetActive(false);
        pic7.SetActive(false);
        pic8.SetActive(false);
        pic9.SetActive(false);
        pic10.SetActive(true);
        pic11.SetActive(false);
        pic12.SetActive(false);
        pic13.SetActive(false);
        pic14.SetActive(false);
        pic15.SetActive(false);
        pic16.SetActive(false);
        pic17.SetActive(false);
        pic18.SetActive(false);
        pic19.SetActive(false);
        pic20.SetActive(false);
    }
    public void ShowSt11()
    {
        pic1.SetActive(false);
        pic2.SetActive(false);
        pic3.SetActive(false);
        pic4.SetActive(false);
        pic5.SetActive(false);
        pic6.SetActive(false);
        pic7.SetActive(false);
        pic8.SetActive(false);
        pic9.SetActive(false);
        pic10.SetActive(false);
        pic11.SetActive(true);
        pic12.SetActive(false);
        pic13.SetActive(false);
        pic14.SetActive(false);
        pic15.SetActive(false);
        pic16.SetActive(false);
        pic17.SetActive(false);
        pic18.SetActive(false);
        pic19.SetActive(false);
        pic20.SetActive(false);
    }
    public void ShowSt12()
    {
        pic1.SetActive(false);
        pic2.SetActive(false);
        pic3.SetActive(false);
        pic4.SetActive(false);
        pic5.SetActive(false);
        pic6.SetActive(false);
        pic7.SetActive(false);
        pic8.SetActive(false);
        pic9.SetActive(false);
        pic10.SetActive(false);
        pic11.SetActive(false);
        pic12.SetActive(true);
        pic13.SetActive(false);
        pic14.SetActive(false);
        pic15.SetActive(false);
        pic16.SetActive(false);
        pic17.SetActive(false);
        pic18.SetActive(false);
        pic19.SetActive(false);
        pic20.SetActive(false);
    }
    public void ShowSt13()
    {
        pic1.SetActive(false);
        pic2.SetActive(false);
        pic3.SetActive(false);
        pic4.SetActive(false);
        pic5.SetActive(false);
        pic6.SetActive(false);
        pic7.SetActive(false);
        pic8.SetActive(false);
        pic9.SetActive(false);
        pic10.SetActive(false);
        pic11.SetActive(false);
        pic12.SetActive(false);
        pic13.SetActive(true);
        pic14.SetActive(false);
        pic15.SetActive(false);
        pic16.SetActive(false);
        pic17.SetActive(false);
        pic18.SetActive(false);
        pic19.SetActive(false);
        pic20.SetActive(false);
    }
    public void ShowSt14()
    {
        pic1.SetActive(false);
        pic2.SetActive(false);
        pic3.SetActive(false);
        pic4.SetActive(false);
        pic5.SetActive(false);
        pic6.SetActive(false);
        pic7.SetActive(false);
        pic8.SetActive(false);
        pic9.SetActive(false);
        pic10.SetActive(false);
        pic11.SetActive(false);
        pic12.SetActive(false);
        pic13.SetActive(false);
        pic14.SetActive(true);
        pic15.SetActive(false);
        pic16.SetActive(false);
        pic17.SetActive(false);
        pic18.SetActive(false);
        pic19.SetActive(false);
        pic20.SetActive(false);
    }
    public void ShowSt15()
    {
        pic1.SetActive(false);
        pic2.SetActive(false);
        pic3.SetActive(false);
        pic4.SetActive(false);
        pic5.SetActive(false);
        pic6.SetActive(false);
        pic7.SetActive(false);
        pic8.SetActive(false);
        pic9.SetActive(false);
        pic10.SetActive(false);
        pic11.SetActive(false);
        pic12.SetActive(false);
        pic13.SetActive(false);
        pic14.SetActive(false);
        pic15.SetActive(true);
        pic16.SetActive(false);
        pic17.SetActive(false);
        pic18.SetActive(false);
        pic19.SetActive(false);
        pic20.SetActive(false);
    }
    public void ShowSt16()
    {
        pic1.SetActive(true);
        pic2.SetActive(false);
        pic3.SetActive(false);
        pic4.SetActive(false);
        pic5.SetActive(false);
        pic6.SetActive(false);
        pic7.SetActive(false);
        pic8.SetActive(false);
        pic9.SetActive(false);
        pic10.SetActive(false);
        pic11.SetActive(false);
        pic12.SetActive(false);
        pic13.SetActive(false);
        pic14.SetActive(false);
        pic15.SetActive(false);
        pic16.SetActive(true);
        pic17.SetActive(false);
        pic18.SetActive(false);
        pic19.SetActive(false);
        pic20.SetActive(false);
    }
    public void ShowSt17()
    {
        pic1.SetActive(false);
        pic2.SetActive(false);
        pic3.SetActive(false);
        pic4.SetActive(false);
        pic5.SetActive(false);
        pic6.SetActive(false);
        pic7.SetActive(false);
        pic8.SetActive(false);
        pic9.SetActive(false);
        pic10.SetActive(false);
        pic11.SetActive(false);
        pic12.SetActive(false);
        pic13.SetActive(false);
        pic14.SetActive(false);
        pic15.SetActive(false);
        pic16.SetActive(false);
        pic17.SetActive(true);
        pic18.SetActive(false);
        pic19.SetActive(false);
        pic20.SetActive(false);
    }
    public void ShowSt18()
    {
        pic1.SetActive(false);
        pic2.SetActive(false);
        pic3.SetActive(false);
        pic4.SetActive(false);
        pic5.SetActive(false);
        pic6.SetActive(false);
        pic7.SetActive(false);
        pic8.SetActive(false);
        pic9.SetActive(false);
        pic10.SetActive(false);
        pic11.SetActive(false);
        pic12.SetActive(false);
        pic13.SetActive(false);
        pic14.SetActive(false);
        pic15.SetActive(false);
        pic16.SetActive(false);
        pic17.SetActive(false);
        pic18.SetActive(true);
        pic19.SetActive(false);
        pic20.SetActive(false);
    }
    public void ShowSt19()
    {
        pic1.SetActive(false);
        pic2.SetActive(false);
        pic3.SetActive(false);
        pic4.SetActive(false);
        pic5.SetActive(false);
        pic6.SetActive(false);
        pic7.SetActive(false);
        pic8.SetActive(false);
        pic9.SetActive(false);
        pic10.SetActive(false);
        pic11.SetActive(false);
        pic12.SetActive(false);
        pic13.SetActive(false);
        pic14.SetActive(false);
        pic15.SetActive(false);
        pic16.SetActive(false);
        pic17.SetActive(false);
        pic18.SetActive(false);
        pic19.SetActive(true);
        pic20.SetActive(false);
    }
    public void ShowSt20()
    {
        pic1.SetActive(false);
        pic2.SetActive(false);
        pic3.SetActive(false);
        pic4.SetActive(false);
        pic5.SetActive(false);
        pic6.SetActive(false);
        pic7.SetActive(false);
        pic8.SetActive(false);
        pic9.SetActive(false);
        pic10.SetActive(false);
        pic11.SetActive(false);
        pic12.SetActive(false);
        pic13.SetActive(false);
        pic14.SetActive(false);
        pic15.SetActive(false);
        pic16.SetActive(false);
        pic17.SetActive(false);
        pic18.SetActive(false);
        pic19.SetActive(false);
        pic20.SetActive(true);
    }
    public void CloseAll()
    {
        pic1.SetActive(false);
        pic2.SetActive(false);
        pic3.SetActive(false);
        pic4.SetActive(false);
        pic5.SetActive(false);
        pic6.SetActive(false);
        pic7.SetActive(false);
        pic8.SetActive(false);
        pic9.SetActive(false);
        pic10.SetActive(false);
        pic11.SetActive(false);
        pic12.SetActive(false);
        pic13.SetActive(false);
        pic14.SetActive(false);
        pic15.SetActive(false);
        pic16.SetActive(false);
        pic17.SetActive(false);
        pic18.SetActive(false);
        pic19.SetActive(false);
        pic20.SetActive(false);
    }
    public void LoadScen1()
    {
        SceneManager.LoadScene("actig"); 
    }
    public void LoadMain()
    {
        SceneManager.LoadScene("SampleScene");
    }

}

