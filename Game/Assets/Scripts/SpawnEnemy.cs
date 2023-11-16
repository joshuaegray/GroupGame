using System.Collections;
using UnityEngine;


public class SpawnEnemy : MonoBehaviour
{
	public GameObject enemyPrefab;
	public float interval;
	public float minX, maxX, minY, maxY;

   void Start()
   {
	   StartCoroutine(SpawnBalls());
   }
  

   IEnumerator SpawnBalls()
   {
	   yield return new WaitForSeconds(interval);
	   float randX = Random.Range(minX, maxX);
	   float randY = Random.Range(minY, maxY);
	   Vector3 spawnPos = new Vector3(randX, randY, 0f);
	   Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
   }
}
