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
                GameManager.instance.Anima = GameManager.instance.Anima + animaCost;
                if (GameManager.instance.Anima > 4)
                {
                    GameManager.instance.Anima = 4;
                }
                //CardManager.AnimaChange();
                break;
            case "attack":
                if (GameManager.instance.Anima >= animaCost)
                {
                    GameManager.instance.Anima = GameManager.instance.Anima - animaCost;
                    if (GameManager.instance.EnemyBlock > 0)
                    {
                        int tempvalue = value - GameManager.instance.EnemyBlock;
                        Debug.Log(tempvalue);
                        if (tempvalue > 0)
                        {
                            GameManager.instance.EnemyHealth = GameManager.instance.EnemyHealth - tempvalue;
                            UIManager.instance.EnemyHealthTxT.text = GameManager.instance.EnemyHealth.ToString();
                            GameManager.instance.EnemyBlock = 0;
                            UIManager.instance.EnemyBlockTxT.text = GameManager.instance.EnemyBlock.ToString();
                        }
                        else if (tempvalue < 0)
                        {
                            GameManager.instance.EnemyBlock = GameManager.instance.EnemyBlock - value;
                            UIManager.instance.EnemyBlockTxT.text = GameManager.instance.EnemyBlock.ToString();
                        }
                        else
                        {
                            GameManager.instance.EnemyBlock = 0;
                            UIManager.instance.EnemyBlockTxT.text = GameManager.instance.EnemyBlock.ToString();
                        }
                    }
                    else
                    {
                        GameManager.instance.EnemyHealth = GameManager.instance.EnemyHealth - value;
                        UIManager.instance.EnemyHealthTxT.text = GameManager.instance.EnemyHealth.ToString();
                    }
                    if (GameManager.instance.Anima < 0)
                    {
                        GameManager.instance.Anima = 0;
                    }
                    //CardManager.AnimaChange();
                }
                break;
            case "defend":
                if (GameManager.instance.Anima >= animaCost)
                {
                    GameManager.instance.Anima = GameManager.instance.Anima - animaCost;
                    GameManager.instance.PlayerBlock = GameManager.instance.PlayerBlock + value;
                    UIManager.instance.PlayerBlockTxT.text = GameManager.instance.PlayerBlock.ToString();
                    if (GameManager.instance.Anima < 0)
                    {
                        GameManager.instance.Anima = 0;
                    }
                    //CardManager.AnimaChange();
                }
                break;
        }
        CardManager.instance.MoveToDiscard(this);
    }
}
