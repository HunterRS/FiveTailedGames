using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public int ID;
    public string Type;
    public int animaCost;
    public int profanedAnima;
    public int value;
    public bool Profane;
    public bool Reinforced;
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
        Debug.Log("click");
        if (Input.GetKey(KeyCode.LeftShift))
        {
            GameManager.instance.Anima = GameManager.instance.Anima + profanedAnima;
            if (GameManager.instance.Anima > 4)
            {
                GameManager.instance.Anima = 4;
            }
            CardManager.AnimaChange();
            Profane = true;
            CardManager.instance.MoveToDiscard(this);
        }
        else
        {
            switch (Type)
            {
                case "attack":
                    if (GameManager.instance.Anima >= animaCost)
                    {
                        GameManager.instance.Anima = GameManager.instance.Anima - animaCost;
                        if (GameManager.instance.EnemyStats.Block > 0)
                        {
                            int tempvalue = value - GameManager.instance.EnemyStats.Block;
                            Debug.Log(tempvalue);
                            if (tempvalue > 0)
                            {
                                GameManager.instance.EnemyStats.Health = GameManager.instance.EnemyStats.Health - tempvalue;
                                GameManager.instance.EnemyStats.Block = 0;
                            }
                            else if (tempvalue < 0)
                            {
                                GameManager.instance.EnemyStats.Block = GameManager.instance.EnemyStats.Block - value;
                            }
                            else
                            {
                                GameManager.instance.EnemyStats.Block = 0;
                            }
                        }
                        else
                        {
                            GameManager.instance.EnemyStats.Health = GameManager.instance.EnemyStats.Health - value;
                        }
                        if (GameManager.instance.Anima < 0)
                        {
                            GameManager.instance.Anima = 0;
                        }
                        CardManager.AnimaChange();
                        CardManager.instance.MoveToDiscard(this);
                    }
                    if (GameManager.instance.EnemyStats.Health <= 0)
                    {
                        Object.Destroy(GameManager.instance.Enemy);
                        GameManager.instance.Playerrigidbody.constraints = RigidbodyConstraints.FreezeRotation;
                        GameManager.instance.BattleCamera.SetActive(false);
                    }
                    UIManager.instance.EnemyHealthTxT.text = GameManager.instance.EnemyStats.Health.ToString();
                    UIManager.instance.EnemyBlockTxT.text = GameManager.instance.EnemyStats.Block.ToString();
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
                        CardManager.AnimaChange();
                        CardManager.instance.MoveToDiscard(this);
                    }
                    break;
            }
        }
    }
}
