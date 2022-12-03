using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    [Header("UI Elements")]
    public TextMeshProUGUI PlayerHealthTxT;
    public TextMeshProUGUI EnemyHealthTxT;
    public TextMeshProUGUI PlayerBlockTxT;
    public TextMeshProUGUI EnemyBlockTxT;

    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
