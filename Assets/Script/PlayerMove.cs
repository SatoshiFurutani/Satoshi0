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

    //private===���̃X�N���v�g���ł��������������Ȃ�
    //public===�ǂ�����ł�������������
    //[SerializeField]private===unity��ł̂ݕύX�ł���
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W) && this.transform.position. z < zMax) //W�ŏ�ړ����I�u�W�F�N�g�ړ��̈ړ�����
        transform.Translate(new Vector3(0, 0, MoveSpeed) * Time.deltaTime);  //��ړ� 

        if (Input.GetKey(KeyCode.A) && this.transform.position.x > xMin) //A�ō��ړ����I�u�W�F�N�g�ړ��̈ړ�����
            transform.Translate(new Vector3(-MoveSpeed, 0, 0) * Time.deltaTime);  //���ړ� 

        if (Input.GetKey(KeyCode.S) && this.transform.position.z > zMin) //S�ŉ��ړ����I�u�W�F�N�g�ړ��̈ړ�����
            transform.Translate(new Vector3(0, 0, -MoveSpeed) * Time.deltaTime);  //���ړ� 

        if (Input.GetKey(KeyCode.D) && this.transform.position.x < xMax) //D�ŉE�ړ����I�u�W�F�N�g�ړ��̈ړ�����
            transform.Translate(new Vector3(MoveSpeed, 0, 0) * Time.deltaTime);  //�E�ړ� 
    }

}
