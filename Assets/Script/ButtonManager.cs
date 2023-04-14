using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public AudioSource sfx;
    public List<AudioClip> sfxClip;
    public Animator animPanelInfo;
    public Animator animPanelMenu;
    public Animator PlayerAnim;

    public GameObject PanelInfo;
    public GameObject ButtonInfo;
    public GameObject ButtonCloseInfo;
    public GameObject PanelMenu;
    public GameObject ButtonMenu;

    public void OpenInfo()
    {
        sfx.PlayOneShot(sfxClip[0]);
        animPanelInfo.SetBool("open", true);
        PanelInfo.SetActive(true);
        ButtonInfo.SetActive(false);
        ButtonCloseInfo.SetActive(true);
    }
    public void ClosePanelInfo()//this code to hide info panel in game
    {
        sfx.PlayOneShot(sfxClip[0]);
        animPanelInfo.SetBool("open", false);
        StartCoroutine(CLoseInfo(1));
    }
    IEnumerator CLoseInfo(float time)
    {
        yield return new WaitForSeconds(time);
        PanelInfo.SetActive(false);
        ButtonInfo.SetActive(true);
        ButtonCloseInfo.SetActive(false);
    }
    public void OpenMenu()
    {
        sfx.PlayOneShot(sfxClip[0]);
        PanelMenu.SetActive(true);
        ButtonMenu.SetActive(false);
        animPanelMenu.SetBool("Open", true);
    }
    public void CloseMenuPanel()
    {
        sfx.PlayOneShot(sfxClip[0]);
        animPanelMenu.SetBool("Open",false);
        StartCoroutine(CLoseMenu(0.9f));
    }
    IEnumerator CLoseMenu(float time)
    {
        yield return new WaitForSeconds(time);
        PanelMenu.SetActive(false);
        ButtonMenu.SetActive(true);
    }
    public void ButtonAction(int id)
    {
        sfx.PlayOneShot(sfxClip[0]);
        PlayerAnim.SetFloat("ID",id);
    }

    public void OpenMozillaHubs(string LinkMozillaHubs)
    {
        sfx.PlayOneShot(sfxClip[0]);
        Application.OpenURL(LinkMozillaHubs);
    }
    public void changeScene(string nameScene)
    {
        SceneManager.LoadScene(nameScene);
    }
   
}
