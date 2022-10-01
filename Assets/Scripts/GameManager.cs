using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int playerCorruption = 0;

    public ParticleSystem corruptFrame;
    public Image corruptVignette;

    // Start is called before the first frame update
    void Start()
    {
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
