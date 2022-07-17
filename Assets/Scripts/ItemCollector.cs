using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    [SerializeField] GameObject Level1;
    [SerializeField] GameObject Level2;
    [SerializeField] GameObject Level3;
    [SerializeField] GameObject Level4;
    [SerializeField] GameObject Level5;
    [SerializeField] GameObject Level6;
    [SerializeField] GameObject DiceScene;
    [SerializeField] GameObject Dice;
    [SerializeField] GameObject Player;
    [SerializeField] private AudioSource itemSound;

    public bool hasItem1 = false;
    public bool hasItem2 = false;
    public bool hasItem3 = false;
    public bool hasItem4 = false;
    public bool hasItem5 = false;
    public bool hasItem6 = false;

    public bool winner = false;
    [SerializeField] GameObject victoryScreen;

    private void Update()
    {
        if(hasItem1 && hasItem2 && hasItem3 && hasItem4 && hasItem5 && hasItem6)
        {
            winner = true;
        }

        if (winner)
        {
            victoryScreen.SetActive(true);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Item1"))
        {
            hasItem1 = true;
            Destroy(collision.gameObject);
            itemSound.Play();
            Debug.Log("Item 1 collected");
            StartCoroutine(WaitTime());
            Level1.SetActive(false);
            DiceScene.SetActive(true);
            Dice.transform.position = new Vector2(0, 0);
            Player.SetActive(false);
        }

        if (collision.CompareTag("Item2"))
        {
            hasItem2 = true;
            Destroy(collision.gameObject);
            itemSound.Play();
            Debug.Log("Item 2 collected");
            StartCoroutine(WaitTime());
            Level2.SetActive(false);
            DiceScene.SetActive(true);
            Dice.transform.position = new Vector2(0, 0);
            Player.SetActive(false);
        }

        if (collision.CompareTag("Item3"))
        {
            hasItem3 = true;
            Destroy(collision.gameObject);
            itemSound.Play();
            Debug.Log("Item 3 collected");
            StartCoroutine(WaitTime());
            Level3.SetActive(false);
            DiceScene.SetActive(true);
            Dice.transform.position = new Vector2(0, 0);
            Player.SetActive(false);
        }

        if (collision.CompareTag("Item4"))
        {
            hasItem4 = true;
            Destroy(collision.gameObject);
            itemSound.Play();
            Debug.Log("Item 4 collected");
            StartCoroutine(WaitTime());
            Level4.SetActive(false);
            DiceScene.SetActive(true);
            Dice.transform.position = new Vector2(0, 0);
            Player.SetActive(false);
        }

        if (collision.CompareTag("Item5"))
        {
            hasItem5 = true;
            Destroy(collision.gameObject);
            itemSound.Play();
            Debug.Log("Item 5 collected");
            StartCoroutine(WaitTime());
            Level5.SetActive(false);
            DiceScene.SetActive(true);
            Dice.transform.position = new Vector2(0, 0);
            Player.SetActive(false);
        }

        if (collision.CompareTag("Item6"))
        {
            hasItem6 = true;
            Destroy(collision.gameObject);
            itemSound.Play();
            Debug.Log("Item 6 collected");
            StartCoroutine(WaitTime());
            Level6.SetActive(false);
            DiceScene.SetActive(true);
            Dice.transform.position = new Vector2(0, 0);
            Player.SetActive(false);
        }
    }

    IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(2f);
    }
}
