using UnityEngine;

public class Lifetime : MonoBehaviour { public float Livetime = 2f;

    private void Start()
    {
        Destroy(gameObject, Livetime); 
        
    }
}