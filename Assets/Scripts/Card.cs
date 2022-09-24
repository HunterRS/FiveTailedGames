using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public int ID;
    public string Type;
    public int animaCost;
    public int value;
    public bool CardAnima;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        switch (Type)
        {
            case "anima":
                CardManager.instance.Anima = CardManager.instance.Anima + animaCost;
                if (CardManager.instance.Anima > 4)
                {
                    CardManager.instance.Anima = 4;
                }
                CardManager.AnimaChange();
                break;
            case "attack":
                if (CardManager.instance.Anima >= animaCost)
                {
                    CardManager.instance.Anima = CardManager.instance.Anima - animaCost;
                    if (CardManager.instance.EnemyBlock > 0)
                    {
                        int tempvalue = value - CardManager.instance.EnemyBlock;
                        Debug.Log(tempvalue);
                        if (tempvalue > 0)
                        {
                            CardManager.instance.EnemyHealth = CardManager.instance.EnemyHealth - tempvalue;
                            CardManager.instance.EnemyHealthTxT.text = CardManager.instance.EnemyHealth.ToString();
                            CardManager.instance.EnemyBlock = 0;
                            CardManager.instance.EnemyBlockTxT.text = CardManager.instance.EnemyBlock.ToString();
                        }
                        else if (tempvalue < 0)
                        {
                            CardManager.instance.EnemyBlock = CardManager.instance.EnemyBlock - value;
                            CardManager.instance.EnemyBlockTxT.text = CardManager.instance.EnemyBlock.ToString();
                        }
                        else
                        {
                            CardManager.instance.EnemyBlock = 0;
                            CardManager.instance.EnemyBlockTxT.text = CardManager.instance.EnemyBlock.ToString();
                        }
                    }
                    else
                    {
                        CardManager.instance.EnemyHealth = CardManager.instance.EnemyHealth - value;
                        CardManager.instance.EnemyHealthTxT.text = CardManager.instance.EnemyHealth.ToString();
                    }
                    if (CardManager.instance.Anima < 0)
                    {
                        CardManager.instance.Anima = 0;
                    }
                    CardManager.AnimaChange();
                }
                break;
            case "defend":
                if (CardManager.instance.Anima >= animaCost)
                {
                    CardManager.instance.Anima = CardManager.instance.Anima - animaCost;
                    CardManager.instance.PlayerBlock = CardManager.instance.PlayerBlock + value;
                    CardManager.instance.PlayerBlockTxT.text = CardManager.instance.PlayerBlock.ToString();
                    if (CardManager.instance.Anima < 0)
                    {
                        CardManager.instance.Anima = 0;
                    }
                    CardManager.AnimaChange();
                }
                break;
        }
    }
}
