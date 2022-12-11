using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Card : MonoBehaviour
{
    [Header("Card Stats")]
    public int ID;
    public string Type;
    public int animaCost;
    public int profanedAnima;
    public int value;
    public int profanedValue;
    public bool secondaryEffect;
    public string secondaryEffectName;
    public int secondaryEffectValue;
    public int profanedSecondaryEffectValue;
    [Header("Card Bools")]
    public bool Profane;
    public bool Reinforced;
    [Header("Text Fields")]
    public GameObject nDesc;
    public GameObject cDesc;

    public GameObject playerAnim;
    [Header("Materials")]
    public Material[] materials;
    public Renderer materialPlane;
    public GameObject reinforcedCorners;
     

    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GameObject.FindGameObjectWithTag("PlayerModel");
        materials[0] = materialPlane.material;
        if (Reinforced == true)
        {
            reinforcedCorners.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            if (Profane == false)
            {
                nDesc.SetActive(false);
                cDesc.SetActive(true);
            }
            else
            {
                nDesc.SetActive(true);
                cDesc.SetActive(false);
            }
        }

        if (Input.GetKeyUp(KeyCode.LeftAlt))
        {
            if (Profane == false)
            {
                nDesc.SetActive(true);
                cDesc.SetActive(false);
            }
            else
            {
                nDesc.SetActive(false);
                cDesc.SetActive(true);
            }
        }
    }
    private void OnMouseExit()
    {
        if (Profane == false)
        {
            nDesc.SetActive(true);
            cDesc.SetActive(false);
        }
        else
        {
            nDesc.SetActive(false);
            cDesc.SetActive(true);
        }
    }



    private void OnMouseDown()
    {
        if (GameManager.instance.reinforcingCards == true)
        {
            Reinforced = true;
            GameManager.instance.CardsReinforced();
            return;
        }
        if (CardManager.instance.selection == true)
        {
            CardManager.instance.CurrentDeckList.Add(this);
            this.transform.SetParent(CardManager.instance.startDeckParent);
            this.transform.localPosition = new Vector3(0, 0, 0);
            CardManager.instance.EndSelection();
            return;
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (GameManager.instance.Anima == 4)
            {
                return;
            }
            GameManager.instance.Anima = GameManager.instance.Anima + profanedAnima;
            if (GameManager.instance.Anima > 4)
            {
                GameManager.instance.Anima = 4;
            }
            CardManager.AnimaChange();
            if (Profane == true)
            {
                Debug.Log("Profaned");
                CardManager.instance.HandList.Remove(this);
                GameObject.Destroy(this.gameObject);
                return;
            }
            else
            {
                if (Reinforced == true)
                {
                    reinforcedCorners.SetActive(false);
                    Reinforced = false;
                    CardManager.instance.MoveToDiscard(this);
                    return;
                }
                Debug.Log("Profaning");
                Profane = true;
                materialPlane.materials = materials;
                CardManager.instance.MoveToDiscard(this);
                return;
            }
        }
        else
        {
            if (Profane == true)
            {
                switch (Type)
                {
                    case "attack":
                        Attack(profanedValue);
                        
                        break;

                    case "defend":
                        Defend(profanedValue);
                        break;

                    case "triattack":
                        Attack(profanedValue);
                        Attack(profanedValue);
                        Attack(profanedValue);
                        break;

                    case "discardattack":
                        Attack(CardManager.instance.Discard.Count);
                        break;

                    case "handattack":
                        Attack(CardManager.instance.HandList.Count);
                        break;

                    case "discarddefend":
                        Defend(CardManager.instance.Discard.Count);
                        break;

                    case "handdefend":
                        Defend(CardManager.instance.HandList.Count);
                        break;

                    case "cleanse":
                        Cleanse(profanedValue);
                        break;

                    case "heal":
                        Heal(profanedValue);
                        break;
                }
                if (secondaryEffect == true)
                {
                    Debug.Log("AAAAAA");
                    switch (secondaryEffectName)
                    {
                        case "cleanse":
                            CleanseNoDiscard(profanedSecondaryEffectValue);
                            break;
                    }
                }
            }
            else
            {
                switch (Type)
                {
                    case "attack":
                        Attack(value);
                        break;

                    case "defend":
                        Defend(value);
                        break;

                    case "triattack":
                        Attack(value);
                        Attack(value);
                        Attack(value);
                        break;

                    case "discardattack":
                        Attack(CardManager.instance.Discard.Count);
                        break;

                    case "handattack":
                        Attack(CardManager.instance.HandList.Count);
                        break;

                    case "discarddefend":
                        Defend(CardManager.instance.Discard.Count);
                        break;

                    case "handdefend":
                        Defend(CardManager.instance.HandList.Count);
                        break;

                    case "cleanse":
                        Cleanse(value);
                        break;

                    case "heal":
                        Heal(value);
                        break;
                }
                if (secondaryEffect == true)
                {
                    switch (secondaryEffectName)
                    {
                        case "cleanse":
                            CleanseNoDiscard(secondaryEffectValue);
                            break;
                    }
                }
            }

        }
    CardManager.AnimaChange();
    }


    private void Attack(int attackPower)
    {
        playerAnim.GetComponent<Animator>().SetTrigger("Attack");
        if (GameManager.instance.Anima >= animaCost)
        {
            GameManager.instance.Anima = GameManager.instance.Anima - animaCost;
            if (GameManager.instance.EnemyStats.Block > 0)
            {
                int tempvalue = attackPower - GameManager.instance.EnemyStats.Block;
                Debug.Log(tempvalue);
                if (tempvalue > 0)
                {
                    GameManager.instance.EnemyStats.Health = GameManager.instance.EnemyStats.Health - tempvalue;
                    GameManager.instance.EnemyStats.Block = 0;
                }
                else if (tempvalue < 0)
                {
                    GameManager.instance.EnemyStats.Block = GameManager.instance.EnemyStats.Block - attackPower;
                }
                else
                {
                    GameManager.instance.EnemyStats.Block = 0;
                }
            }
            else
            {
                GameManager.instance.EnemyStats.Health = GameManager.instance.EnemyStats.Health - attackPower;
            }

            if (GameManager.instance.Anima < 0)
            {
                GameManager.instance.Anima = 0;
            }
            CardManager.instance.MoveToDiscard(this);
        }

        if (GameManager.instance.EnemyStats.Health <= 0)
        {
            GameManager.instance.Anima = 0;
            GameManager.instance.HideUI();
            GameManager.instance.CombatView(false);
            Object.Destroy(GameManager.instance.Enemy);
            CardManager.instance.StartSelection();
        }

        CardManager.AnimaChange();

        UIManager.instance.EnemyHealthTxT.text = GameManager.instance.EnemyStats.Health.ToString();
        UIManager.instance.EnemyBlockTxT.text = GameManager.instance.EnemyStats.Block.ToString();
    }
    private void Defend(int defendPower)
    {
        if (GameManager.instance.Anima >= animaCost)
        {
            GameManager.instance.Anima = GameManager.instance.Anima - animaCost;
            GameManager.instance.PlayerBlock = GameManager.instance.PlayerBlock + defendPower;
            UIManager.instance.PlayerBlockTxT.text = GameManager.instance.PlayerBlock.ToString();
            if (GameManager.instance.Anima < 0)
            {
                GameManager.instance.Anima = 0;
            }
            CardManager.instance.MoveToDiscard(this);
        }
        GameManager.instance.UpdateBlock();
        CardManager.AnimaChange();
    }
    private void Cleanse(int cleansePower)
    {
        if (GameManager.instance.Anima >= animaCost)
        {
            GameManager.instance.Anima = GameManager.instance.Anima - animaCost;
            GameManager.instance.playerCorruption += cleansePower;
            GameManager.instance.updateCorruption();
            CardManager.instance.MoveToDiscard(this);
        }
        CardManager.AnimaChange();
    }
    private void Heal(int healPower)
    {
        if (GameManager.instance.Anima >= animaCost)
        {
            GameManager.instance.Anima = GameManager.instance.Anima - animaCost;
            GameManager.instance.PlayerHealth += healPower;
            if (GameManager.instance.PlayerHealth > 30)
            {
                GameManager.instance.PlayerHealth = 30;
            }
            if (GameManager.instance.PlayerHealth > 100 /* Replace with Max hehalth */)
            {
                GameManager.instance.PlayerHealth = 100;
            }
            CardManager.instance.MoveToDiscard(this);
        }
        CardManager.AnimaChange();
    }

    private void CleanseNoDiscard(int cleansePower)
    {
        GameManager.instance.playerCorruption += cleansePower;
        GameManager.instance.updateCorruption();
        CardManager.AnimaChange();
    }
}
