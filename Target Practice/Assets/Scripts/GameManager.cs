using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    private bool p1 = true;
    private bool p2 = true;
    private Transform SpawnPosition1;
    private Transform SpawnPosition2;

    public void UpdateSpawnPosition(Transform newPosition, int player)
    {
        if (player == 1){
            SpawnPosition1=newPosition;
        }
        else if (player == 2){
            SpawnPosition2=newPosition;
        }
    }
    public void GameOver(GameObject player)
    {
        StartCoroutine(RestartGame(player));
    }

    IEnumerator RestartGame(GameObject player)
    {
        yield return new WaitForSeconds(1f);
        if (p1 == false){
            p1=true;
            player1.transform.position = SpawnPosition1.position;
            player1.transform.rotation = Quaternion.LookRotation(Vector3.forward);
        }
        if (p2 == false){
            p2=true;
            player2.transform.position = SpawnPosition2.position;
            player2.transform.rotation = Quaternion.LookRotation(Vector3.forward);
        }

    }

    public void playerDeath(int player){
        if (player == 1)
            p1 = false;
        if (player == 2)
            p2 = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
