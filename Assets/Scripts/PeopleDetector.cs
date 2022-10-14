using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleDetector : MonoBehaviour
{

    public GameObject peopleChecker;
    public LayerMask whatIsDeath;

    Rigidbody2D currentObject;

    public bool isDead = false;
    public bool isScored = false;
    public bool angelMode = false;

    public ScoringTotal ScoringTotal;

    // Start is called before the first frame update
    void Start()
    {
        currentObject = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (isDead == false)
        {

        isDead = Physics2D.OverlapCircle(peopleChecker.transform.position, 3.5f, whatIsDeath);

        }

        if (isDead == true && isScored == false)
        {
            isScored = true;
            ScoringTotal.ScoringAdding();
        }

        if (isDead == true && angelMode == true) 
        {
                currentObject.AddForce(new Vector2(0.0f,33.0f));
        }

    }
}
