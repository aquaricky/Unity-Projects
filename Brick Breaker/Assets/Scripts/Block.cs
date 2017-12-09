using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    public static int breakableCount=0;
    private int MaxHits;
    private int TimesHit;
    private LevelManager lvlManager;
    public Sprite[] HitSprites;
    bool isBreakable;
    public AudioClip crack;
    
    // Use this for initialization
    void Start () {
        isBreakable = (this.tag == "Breakable");
        lvlManager = GameObject.FindObjectOfType<LevelManager>();

        this.TimesHit = 0;
        if (isBreakable)
        {
            breakableCount++;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionExit2D()
    {
        if (isBreakable)
        {
            AudioSource.PlayClipAtPoint(crack, transform.position);
            handleHits();
        }
    }

    void handleHits()
    {
        TimesHit++;
        MaxHits = HitSprites.Length + 1;
        if (TimesHit >= MaxHits)
        {
            breakableCount--;
            lvlManager.BrickDestroyed();
            Destroy(gameObject);
        }
        else
        {
            loadSprites();
        }
        
    }
    
    private void loadSprites()
    {
        int spriteIndex = TimesHit - 1;
        if (HitSprites[spriteIndex])
        {
            this.GetComponent<SpriteRenderer>().sprite = HitSprites[spriteIndex];
        }
        
    } 

    //TODO: remove this method once we actually win 
    void simulateWin()
    {
        lvlManager.LoadNextLevel();
    }
}
