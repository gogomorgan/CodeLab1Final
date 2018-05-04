using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class playercontrol : MonoBehaviour {

    public float moveSpeed = 2;
    public Color[] colorlist;
    //public int score;
    //public TextMesh scoreText;

    private Rigidbody2D rb;
    private SpriteRenderer sr;

    // Use this for initialization
    void Start () {

        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        GameManager.instance.score = 0;
    }
	
	// Update is called once per frame
	void Update () {

        var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transform.position += move * moveSpeed * Time.deltaTime;

            //scoreText.text = score.ToString();
        }

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("collision");

        Color currentcolor = GetComponent<SpriteRenderer>().color;
        Debug.Log("now: " + currentcolor);

        if (col.gameObject.name.Contains("bonus"))
        {
            GameManager.instance.score += 3;

            Destroy(col.gameObject);
        }

        //pink orb

        if (currentcolor == colorlist[0] && col.gameObject.name.Contains("pinkplatform")) //if orb is pink and hits pink platform
        {
            Debug.Log("pink on pink");
            GameManager.instance.score++;
            Debug.Log("score: " + GameManager.instance.score);
            GetComponent<SpriteRenderer>().color = colorlist[Random.Range(0, 3)];

            Destroy(col.gameObject);
        }

        else if (currentcolor == colorlist[0] && col.gameObject.name.Contains("greenplatform"))
        {
            Debug.Log("pink on green");
            //GameManager.instance.score -= 1;
            GameManager.instance.endGame();
            Debug.Log("score: " + GameManager.instance.score);

            Destroy(col.gameObject);
        }

        else if (currentcolor == colorlist[0] && col.gameObject.name.Contains("blueplatform"))
        {
            Debug.Log("pink on blue");
            //GameManager.instance.score -= 1;
            GameManager.instance.endGame();
            Debug.Log("score: " + GameManager.instance.score);

            Destroy(col.gameObject);
        }

        else if (currentcolor == colorlist[0] && col.gameObject.name.Contains("orangeplatform"))
        {
            Debug.Log("pink on orange");
            //GameManager.instance.score -= 1;
            GameManager.instance.endGame();
            Debug.Log("score: " + GameManager.instance.score);

            Destroy(col.gameObject);
        }

        else if (currentcolor == colorlist[0] && col.gameObject.name.Contains("yellowplatform"))
        {
            Debug.Log("pink on yellow");
            //GameManager.instance.score -= 1;
            GameManager.instance.endGame();
            Debug.Log("score: " + GameManager.instance.score);

            Destroy(col.gameObject);
        }

        //green orb

        else if (currentcolor == colorlist[1] && col.gameObject.name.Contains("greenplatform"))  //if orb is green and hits green platform
        {
            Debug.Log("green on green");
            GameManager.instance.score++;
            Debug.Log("score: " + GameManager.instance.score);
            GetComponent<SpriteRenderer>().color = colorlist[Random.Range(0, 3)];

            Destroy(col.gameObject);
        }

        else if (currentcolor == colorlist[1] && col.gameObject.name.Contains("pinkplatform"))  //if orb is green and hits green platform
        {
            Debug.Log("green on pink");
            //GameManager.instance.score -= 1;
            GameManager.instance.endGame();
            Debug.Log("score: " + GameManager.instance.score);

            Destroy(col.gameObject);
        }

        else if (currentcolor == colorlist[1] && col.gameObject.name.Contains("orangeplatform"))  //if orb is green and hits green platform
        {
            Debug.Log("green on orange");
            //GameManager.instance.score -= 1;
            GameManager.instance.endGame();
            Debug.Log("score: " + GameManager.instance.score);

            Destroy(col.gameObject);
        }

        else if (currentcolor == colorlist[1] && col.gameObject.name.Contains("blueplatform"))  //if orb is green and hits green platform
        {
            Debug.Log("green on blue");
            //GameManager.instance.score -= 1;
            GameManager.instance.endGame();
            Debug.Log("score: " + GameManager.instance.score);

            Destroy(col.gameObject);
        }

        else if (currentcolor == colorlist[1] && col.gameObject.name.Contains("yellowplatform"))  //if orb is green and hits green platform
        {
            Debug.Log("green on yellow");
            //GameManager.instance.score -= 1;
            GameManager.instance.endGame();
            Debug.Log("score: " + GameManager.instance.score);

            Destroy(col.gameObject);
        }

        //orange orb

        else if (currentcolor == colorlist[2] && col.gameObject.name.Contains("orangeplatform"))  //if orb is green and hits green platform
        {
            Debug.Log("orange on orange");
            GameManager.instance.score++;
            Debug.Log("score: " + GameManager.instance.score);
            GetComponent<SpriteRenderer>().color = colorlist[Random.Range(0, 3)];

            Destroy(col.gameObject);
        }

        else if (currentcolor == colorlist[2] && col.gameObject.name.Contains("pinkplatform"))  //if orb is green and hits green platform
        {
            Debug.Log("orange on pink");
            //GameManager.instance.score -= 1;
            GameManager.instance.endGame();
            Debug.Log("score: " + GameManager.instance.score);

            Destroy(col.gameObject);
        }

        else if (currentcolor == colorlist[2] && col.gameObject.name.Contains("greenplatform"))  //if orb is green and hits green platform
        {
            Debug.Log("orange on green");
            //GameManager.instance.score -= 1;
            GameManager.instance.endGame();
            Debug.Log("score: " + GameManager.instance.score);

            Destroy(col.gameObject);
        }

        else if (currentcolor == colorlist[2] && col.gameObject.name.Contains("blueplatform"))  //if orb is green and hits green platform
        {
            Debug.Log("orange on blue");
            //GameManager.instance.score -= 1;
            GameManager.instance.endGame();
            Debug.Log("score: " + GameManager.instance.score);

            Destroy(col.gameObject);
        }

        else if (currentcolor == colorlist[2] && col.gameObject.name.Contains("yellowplatform"))  //if orb is green and hits green platform
        {
            Debug.Log("orange on yellow");
            //GameManager.instance.score -= 1;
            GameManager.instance.endGame();
            Debug.Log("score: " + GameManager.instance.score);

            Destroy(col.gameObject);
        }

        //blue orb

        else if (currentcolor == colorlist[3] && col.gameObject.name.Contains("blueplatform"))  //if orb is green and hits green platform
        {
            Debug.Log("blue on blue");
            GameManager.instance.score++;
            Debug.Log("score: " + GameManager.instance.score);
            GetComponent<SpriteRenderer>().color = colorlist[Random.Range(0, 3)];

            Destroy(col.gameObject);
        }

        else if (currentcolor == colorlist[3] && col.gameObject.name.Contains("pinkplatform"))  //if orb is green and hits green platform
        {
            Debug.Log("blue on pink");
            //GameManager.instance.score -= 1;
            GameManager.instance.endGame();
            Debug.Log("score: " + GameManager.instance.score);

            Destroy(col.gameObject);
        }

        else if (currentcolor == colorlist[3] && col.gameObject.name.Contains("greenplatform"))  //if orb is green and hits green platform
        {
            Debug.Log("blue on green");
            //GameManager.instance.score -= 1;
            GameManager.instance.endGame();
            Debug.Log("score: " + GameManager.instance.score);

            Destroy(col.gameObject);
        }

        else if (currentcolor == colorlist[3] && col.gameObject.name.Contains("orangeplatform"))  //if orb is green and hits green platform
        {
            Debug.Log("blue on orange");
            //GameManager.instance.score -= 1;
            GameManager.instance.endGame();
            Debug.Log("score: " + GameManager.instance.score);

            Destroy(col.gameObject);
        }

        else if (currentcolor == colorlist[3] && col.gameObject.name.Contains("yellowplatform"))  //if orb is green and hits green platform
        {
            Debug.Log("blue on yellow");
            //GameManager.instance.score -= 1;
            GameManager.instance.endGame();
            Debug.Log("score: " + GameManager.instance.score);

            Destroy(col.gameObject);
        }

    }
}
