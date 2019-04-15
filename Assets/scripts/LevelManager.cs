using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LevelManager : MonoBehaviour
{
    public float reSpawnDelay;
    public PlayerControll gamePlayer;
    public int coins;
    public Text coinText;
    // Start is called before the first frame update
    void Start()
    {
        gamePlayer = FindObjectOfType<PlayerControll> ();
        coinText.text = "Coins: " + coins;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void reSpawn() {
        StartCoroutine("reSpawnCoroutine");
    }
    public IEnumerator reSpawnCoroutine() {
        gamePlayer.gameObject.SetActive(false);
        yield return new WaitForSeconds(reSpawnDelay);
        gamePlayer.transform.position = gamePlayer.respawnPoint;
        gamePlayer.gameObject.SetActive(true);
    }

    public void addCoins(int numberOfCoins) {
        coins += numberOfCoins;
        coinText.text = "Coins: " + coins;
    }
}
