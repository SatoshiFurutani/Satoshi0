using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float MoveSpeed;
    [SerializeField] private float xMax;
    [SerializeField] private float xMin;
    [SerializeField] private float zMax;
    [SerializeField] private float zMin;

    //private===このスクリプト内でしか書き換えられない
    //public===どこからでも書き換えられる
    //[SerializeField]private===unity上でのみ変更できる
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W) && this.transform.position. z < zMax) //Wで上移動かつオブジェクト移動の移動制限
        transform.Translate(new Vector3(0, 0, MoveSpeed) * Time.deltaTime);  //上移動 

        if (Input.GetKey(KeyCode.A) && this.transform.position.x > xMin) //Aで左移動かつオブジェクト移動の移動制限
            transform.Translate(new Vector3(-MoveSpeed, 0, 0) * Time.deltaTime);  //左移動 

        if (Input.GetKey(KeyCode.S) && this.transform.position.z > zMin) //Sで下移動かつオブジェクト移動の移動制限
            transform.Translate(new Vector3(0, 0, -MoveSpeed) * Time.deltaTime);  //下移動 

        if (Input.GetKey(KeyCode.D) && this.transform.position.x < xMax) //Dで右移動かつオブジェクト移動の移動制限
            transform.Translate(new Vector3(MoveSpeed, 0, 0) * Time.deltaTime);  //右移動 
    }

}
