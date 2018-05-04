using UnityEngine;
using System.Collections;


public class platformmanager : MonoBehaviour
{
    public GameObject pinkplatformPrefab;
    public GameObject greenplatformPrefab;
    public GameObject blueplatformPrefab;
    public GameObject orangeplatformPrefab;

    public GameObject yellowplatformPrefab;

    public GameObject bonusspritePrefab;

    public Vector3[] spawnPositions;
    public Vector3[] rightspawnPositions;

    public float timeUntilSpawn;
    public float minSpawnTime;
    public float maxSpawnTime;

    public float spawnTimeDecay;

    public float timeBetweenSpawns = 1f;
    public float xSpawnPos;
    //public float ySpawnPosMin;
    //public float ySpawnPosMax

     
    public float speed;        
    public float spawnerSpeedUp;
    private float speedGain;


    void SpawnPlatform()
    {
        float side = Random.Range(0f, 1f); //what side it's gonna spawn on

        //Debug.Log("side spawn " + side);

        //Debug.Log("current spawnType -> " + i);
        


        if (GameManager.instance.score >= 10)
        {
            int i = Random.Range(0, spawnPositions.Length);//a number between 0 and the number of spawn positions (exclusive)
            Vector3 spawnPosition = spawnPositions[i]; //get the actual position we stored in the inspector
            Vector3 rightspawnPosition = rightspawnPositions[i];

            if (i == 0)
            {


                if (side < 0.5) //spawn on left
                {

                    GameObject pinkplatform = Instantiate(pinkplatformPrefab, spawnPosition, Quaternion.identity) as GameObject;
                    pinkplatform.transform.position = new Vector3(
                    spawnPosition.x,
                    spawnPosition.y,
                    spawnPosition.z);

                    pinkplatform.GetComponent<Rigidbody2D>().gravityScale += speedGain;

                }

                else //spawn on right
                {
                    GameObject pinkplatform = Instantiate(pinkplatformPrefab, rightspawnPosition, Quaternion.identity) as GameObject;
                    pinkplatform.transform.position = new Vector3(
                    rightspawnPosition.x,
                    rightspawnPosition.y,
                    rightspawnPosition.z);

                    pinkplatform.GetComponent<SpriteRenderer>().flipX = true;

                    pinkplatform.GetComponent<Rigidbody2D>().gravityScale += speedGain;
                }
            }

            else if (i == 1)
            {
                if (side < 0.5)
                {
                    GameObject blueplatform = Instantiate(blueplatformPrefab, spawnPosition, Quaternion.identity) as GameObject;
                    blueplatform.transform.position = new Vector3(
                    spawnPosition.x,
                    spawnPosition.y,
                    spawnPosition.z);

                    blueplatform.GetComponent<Rigidbody2D>().gravityScale += speedGain;
                }

                else
                {
                    GameObject blueplatform = Instantiate(blueplatformPrefab, rightspawnPosition, Quaternion.identity) as GameObject;
                    blueplatform.transform.position = new Vector3(
                    rightspawnPosition.x,
                    rightspawnPosition.y,
                    rightspawnPosition.z);

                    blueplatform.GetComponent<SpriteRenderer>().flipX = true;

                    blueplatform.GetComponent<Rigidbody2D>().gravityScale += speedGain;
                }

            }

            else if (i == 2)
            {

                if (side < 0.5)
                {
                    GameObject orangeplatform = Instantiate(orangeplatformPrefab, spawnPosition, Quaternion.identity) as GameObject;
                    orangeplatform.transform.position = new Vector3(
                    spawnPosition.x,
                    spawnPosition.y,
                    spawnPosition.z);

                    orangeplatform.GetComponent<Rigidbody2D>().gravityScale += speedGain;
                }

                else
                {
                    GameObject orangeplatform = Instantiate(orangeplatformPrefab, rightspawnPosition, Quaternion.identity) as GameObject;
                    orangeplatform.transform.position = new Vector3(
                    rightspawnPosition.x,
                    rightspawnPosition.y,
                    rightspawnPosition.z);

                    orangeplatform.GetComponent<SpriteRenderer>().flipX = true;

                    orangeplatform.GetComponent<Rigidbody2D>().gravityScale += speedGain;
                }
            }

            else if (i == 3)
            {
                if (side < 0.5)
                {
                    GameObject greenplatform = Instantiate(greenplatformPrefab, spawnPosition, Quaternion.identity) as GameObject;
                    greenplatform.transform.position = new Vector3(
                    spawnPosition.x,
                    spawnPosition.y,
                    spawnPosition.z);

                    greenplatform.GetComponent<Rigidbody2D>().gravityScale += speedGain;
                }

                else
                {
                    GameObject greenplatform = Instantiate(greenplatformPrefab, rightspawnPosition, Quaternion.identity) as GameObject;
                    greenplatform.transform.position = new Vector3(
                    rightspawnPosition.x,
                    rightspawnPosition.y,
                    rightspawnPosition.z);

                    greenplatform.GetComponent<SpriteRenderer>().flipX = true;

                    greenplatform.GetComponent<Rigidbody2D>().gravityScale += speedGain;
                }
            }

            else if (i == 4)
            {
                if (side < 0.5)
                {
                    GameObject bonussprite = Instantiate(bonusspritePrefab, spawnPosition, Quaternion.identity) as GameObject;
                    bonussprite.transform.position = new Vector3(
                    spawnPosition.x,
                    spawnPosition.y,
                    spawnPosition.z);

                    bonussprite.GetComponent<Rigidbody2D>().gravityScale += speedGain;
                }

                else
                {
                    GameObject bonussprite = Instantiate(bonusspritePrefab, rightspawnPosition, Quaternion.identity) as GameObject;
                    bonussprite.transform.position = new Vector3(
                    rightspawnPosition.x,
                    rightspawnPosition.y,
                    rightspawnPosition.z);

                    bonussprite.GetComponent<Rigidbody2D>().gravityScale += speedGain;
                }
            }

            else if (i == 5)
            {
                if (side < 0.5)
                {
                    GameObject yellowplatform = Instantiate(yellowplatformPrefab, spawnPosition, Quaternion.identity) as GameObject;
                    yellowplatform.transform.position = new Vector3(
                    spawnPosition.x,
                    spawnPosition.y,
                    spawnPosition.z);

                    yellowplatform.GetComponent<Rigidbody2D>().gravityScale += speedGain;
                }

                else
                {
                    GameObject yellowplatform = Instantiate(yellowplatformPrefab, rightspawnPosition, Quaternion.identity) as GameObject;
                    yellowplatform.transform.position = new Vector3(
                    rightspawnPosition.x,
                    rightspawnPosition.y,
                    rightspawnPosition.z);

                    yellowplatform.GetComponent<SpriteRenderer>().flipX = true;

                    yellowplatform.GetComponent<Rigidbody2D>().gravityScale += speedGain;
                }
            }
        }

       
        

        else if (GameManager.instance.score < 10)
        {
            int i = Random.Range(0, 5);

            Vector3 spawnPosition = spawnPositions[i]; //get the actual position we stored in the inspector
            Vector3 rightspawnPosition = rightspawnPositions[i];

            if (i == 0)
            {


                if (side < 0.5) //spawn on left
                {

                    GameObject pinkplatform = Instantiate(pinkplatformPrefab, spawnPosition, Quaternion.identity) as GameObject;
                    pinkplatform.transform.position = new Vector3(
                    spawnPosition.x,
                    spawnPosition.y,
                    spawnPosition.z);

                    pinkplatform.GetComponent<Rigidbody2D>().gravityScale += speedGain;

                }

                else //spawn on right
                {
                    GameObject pinkplatform = Instantiate(pinkplatformPrefab, rightspawnPosition, Quaternion.identity) as GameObject;
                    pinkplatform.transform.position = new Vector3(
                    rightspawnPosition.x,
                    rightspawnPosition.y,
                    rightspawnPosition.z);

                    pinkplatform.GetComponent<SpriteRenderer>().flipX = true;

                    pinkplatform.GetComponent<Rigidbody2D>().gravityScale += speedGain;
                }
            }

            else if (i == 1)
            {
                if (side < 0.5)
                {
                    GameObject blueplatform = Instantiate(blueplatformPrefab, spawnPosition, Quaternion.identity) as GameObject;
                    blueplatform.transform.position = new Vector3(
                    spawnPosition.x,
                    spawnPosition.y,
                    spawnPosition.z);

                    blueplatform.GetComponent<Rigidbody2D>().gravityScale += speedGain;
                }

                else
                {
                    GameObject blueplatform = Instantiate(blueplatformPrefab, rightspawnPosition, Quaternion.identity) as GameObject;
                    blueplatform.transform.position = new Vector3(
                    rightspawnPosition.x,
                    rightspawnPosition.y,
                    rightspawnPosition.z);

                    blueplatform.GetComponent<SpriteRenderer>().flipX = true;

                    blueplatform.GetComponent<Rigidbody2D>().gravityScale += speedGain;
                }

            }

            else if (i == 2)
            {

                if (side < 0.5)
                {
                    GameObject orangeplatform = Instantiate(orangeplatformPrefab, spawnPosition, Quaternion.identity) as GameObject;
                    orangeplatform.transform.position = new Vector3(
                    spawnPosition.x,
                    spawnPosition.y,
                    spawnPosition.z);

                    orangeplatform.GetComponent<Rigidbody2D>().gravityScale += speedGain;
                }

                else
                {
                    GameObject orangeplatform = Instantiate(orangeplatformPrefab, rightspawnPosition, Quaternion.identity) as GameObject;
                    orangeplatform.transform.position = new Vector3(
                    rightspawnPosition.x,
                    rightspawnPosition.y,
                    rightspawnPosition.z);

                    orangeplatform.GetComponent<SpriteRenderer>().flipX = true;

                    orangeplatform.GetComponent<Rigidbody2D>().gravityScale += speedGain;
                }
            }

            else if (i == 3)
            {
                if (side < 0.5)
                {
                    GameObject greenplatform = Instantiate(greenplatformPrefab, spawnPosition, Quaternion.identity) as GameObject;
                    greenplatform.transform.position = new Vector3(
                    spawnPosition.x,
                    spawnPosition.y,
                    spawnPosition.z);

                    greenplatform.GetComponent<Rigidbody2D>().gravityScale += speedGain;
                }

                else
                {
                    GameObject greenplatform = Instantiate(greenplatformPrefab, rightspawnPosition, Quaternion.identity) as GameObject;
                    greenplatform.transform.position = new Vector3(
                    rightspawnPosition.x,
                    rightspawnPosition.y,
                    rightspawnPosition.z);

                    greenplatform.GetComponent<SpriteRenderer>().flipX = true;

                    greenplatform.GetComponent<Rigidbody2D>().gravityScale += speedGain;
                }
            }

            else if (i == 4)
            {
                if (side < 0.5)
                {
                    GameObject bonussprite = Instantiate(bonusspritePrefab, spawnPosition, Quaternion.identity) as GameObject;
                    bonussprite.transform.position = new Vector3(
                    spawnPosition.x,
                    spawnPosition.y,
                    spawnPosition.z);

                    bonussprite.GetComponent<Rigidbody2D>().gravityScale += speedGain;
                }

                else
                {
                    GameObject bonussprite = Instantiate(bonusspritePrefab, rightspawnPosition, Quaternion.identity) as GameObject;
                    bonussprite.transform.position = new Vector3(
                    rightspawnPosition.x,
                    rightspawnPosition.y,
                    rightspawnPosition.z);

                    bonussprite.GetComponent<Rigidbody2D>().gravityScale += speedGain;
                }
            }

        }     

    }

    

    public void Update()
    {

        if (GameManager.instance.score >= 10)
        {
            speedGain = speedGain + (speed * Time.deltaTime);
            timeBetweenSpawns = timeBetweenSpawns - (spawnerSpeedUp * Time.deltaTime);

            if (timeBetweenSpawns < minSpawnTime)
            {
                timeBetweenSpawns = minSpawnTime;
            }
        }


        //Time.delaTime is how much time has occured since the last update. 
        //We subtract it from time until spawn every frame
        timeUntilSpawn -= Time.deltaTime;
        //Once timeUntilSpawn is less than 0, we spawn a new platform
        if (timeUntilSpawn <= 0)
        {
            SpawnPlatform();
            //then we reset timeUntilSpawn to the timeBetweenSpawns & start all over again
            timeUntilSpawn = timeBetweenSpawns;
        }

    }
}