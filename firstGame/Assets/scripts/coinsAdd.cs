using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinsAdd : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider o){
        
        if(o.gameObject.tag == "Player"){
            ScoreManager.instance.AddScore(1);
            Invoke("destroyCoins",0.2f);
            
//            Debug.Log("Ball Collided with coin");
        }
    }

    private void destroyCoins(){
        Destroy(this.gameObject);
    }
    // Start is called before the first frame update
    
}
