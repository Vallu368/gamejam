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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Item1"))
        {
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
