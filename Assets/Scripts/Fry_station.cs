using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fry_station : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject _effectPrefab;


    public void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(_effectPrefab, transform.position,transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
