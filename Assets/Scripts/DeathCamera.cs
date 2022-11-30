using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathCamera : MonoBehaviour
{
    public GameObject HUD;
    public GameObject animaPlaque;
    public GameObject Amulet;
    public GameObject Cloth;
    public GameObject CombatCanvas;
    public string endSceneName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IsolateOsin()
    {
        HUD.SetActive(false);
        animaPlaque.SetActive(false);
        Amulet.SetActive(false);
        Cloth.SetActive(false);
        CombatCanvas.SetActive(false);
    }

    public void IncreaseCorruption()
    {
        GameManager.instance.playerCorruption += 33;
    }

    public void EndGame()
    {
        this.GetComponent<Animator>().enabled = false;
        SceneManager.LoadScene(endSceneName);
    }
}
