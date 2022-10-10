using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int playerCorruption = 0;

    public ParticleSystem corruptFrame;
    public Image corruptVignette;
    public int Anima;
    public int PlayerHealth;
    public int EnemyHealth;
    public int PlayerBlock;
    public int EnemyBlock;

    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        CardManager.instance.DeckCreate();
    }

    // Update is called once per frame
    void Update()
    {
        updateCorruption();
    }

    private void updateCorruption()
    {
        if (playerCorruption < 10)
        {
            corruptFrame.gameObject.SetActive(false);
            corruptVignette.color = new Color(1, 1, 1, 0);
        }
        else
        {
            corruptFrame.gameObject.SetActive(true);
            corruptFrame.startLifetime = (float)playerCorruption / 100 * 9;
            corruptVignette.color = new Color(1, 1, 1, (float)playerCorruption/100);
        }
    }
}
