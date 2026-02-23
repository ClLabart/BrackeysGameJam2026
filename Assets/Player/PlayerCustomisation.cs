using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCustomisation : MonoBehaviour
{
    public GameObject[] Charac;

    void Start()
    {
        foreach (var item in Charac)
        {
            item.SetActive(false);
        }
        ActiveCurrentCharac();
    }

    public void SwitchRight()
    {
        PlayerStats.ActiveCharac++;
        foreach (var item in Charac)
        {
            item.SetActive(false);
        }

        if (PlayerStats.ActiveCharac == Charac.Length)
        {
            PlayerStats.ActiveCharac = 0;
        }

        ActiveCurrentCharac();
    }

    public void SwitchLeft()
    {
        PlayerStats.ActiveCharac--;
        foreach (var item in Charac)
        {
            item.SetActive(false);
        }

        if (PlayerStats.ActiveCharac < 0)
        {
            PlayerStats.ActiveCharac = Charac.Length - 1;
        }

        ActiveCurrentCharac();
    }

    private void ActiveCurrentCharac()
    {
        PlayerStats.dysphoria = Charac[PlayerStats.ActiveCharac].GetComponent<StyleDetail>().dysphoriaCount;
        Charac[PlayerStats.ActiveCharac].SetActive(true);
        Debug.Log("id : " + Charac[PlayerStats.ActiveCharac].GetComponent<StyleDetail>().id);
        Debug.Log("dyspho : " + Charac[PlayerStats.ActiveCharac].GetComponent<StyleDetail>().dysphoriaCount);
        Debug.Log(PlayerStats.ActiveCharac);
        Debug.Log(PlayerStats.dysphoria);
    }

    public void startGame()
    {
        SceneManager.LoadScene(2);
    }
}
