using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointController: MonoBehaviour { 
    public Sprite redStart;
    public Sprite yellowStart;
    private SpriteRenderer checkPointSpriteRenderer;
    public bool checkedPointReached;

    // Start is called before the first frame update
    void Start()
    {
        checkPointSpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "player") {
            checkPointSpriteRenderer.sprite = yellowStart;
            checkedPointReached = true;
        }
    }
}
