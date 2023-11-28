using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;



public class SpawnEnemy : MonoBehaviour
{
	public GameObject[] enemyPrefabs;
	private int stage;
	
	public float startingInterval, minimumInterval, intervalPercentDampening;
	public float minX, maxX, minY, maxY;

	[SerializeField] private float interval;
	
	
	
	

   void Start()
   {
	   stage = SceneManager.GetActiveScene().buildIndex;
	   interval = startingInterval;
	   StartCoroutine(SpawnBalls());
   }
  

   IEnumerator SpawnBalls()
   {
	   while (true)
	   {
		   int enemyNum = Random.Range(0, enemyPrefabs.Length-1);
		   yield return new WaitForSeconds(interval);
		   //Debug.Log("Updating now: " + interval);
		   interval = (interval - minimumInterval) * intervalPercentDampening + minimumInterval;
		   float randX = Random.Range(minX, maxX);
		   float randY = Random.Range(minY, maxY);
		   Vector3 spawnPos = new Vector3(randX, randY, 0f);
		   Instantiate(enemyPrefabs[enemyNum], spawnPos, Quaternion.identity);
	   }
   }
}
