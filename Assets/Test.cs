using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int mp = 53;//int�^�̕ϐ�mp��錾���A53�ŏ���������

    //mp������āA���@�U��������Magic�֐�
    public void Magic()
    {
        //�������Fmp��5�ȏ�̏ꍇ�A
        if (mp >= 5)
        {
            //mp��5���炷
            this.mp -= 5;

            //�R���\�[���Ɂh���@�U���������h�{�c���mp�l��\��
            Debug.Log("���@�U���������B�c��MP��" + mp);
        }
        else
        {
            //mp5�ȉ��̏ꍇ�A�R���\�[����"MP������Ȃ����߁A���@���g���Ȃ�"��\��
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ�");
        }
    }

}


public class Test : MonoBehaviour
{
    void Start()
    {
        //�v�f��5�Aint�^�̔z�������������
        int[] Array = { 1, 2, 3, 4, 5 };

        //for���ŁA�z��̗v�f���̂Ԃ񂾂��A���Ԃɏ������J��Ԃ�
        for (int i = 0; i < Array.Length; i++)
        {
            //�z��̗v�f��\������i���ԁj
            Debug.Log(Array[i]);
        }


        //for���ŁA�z��̗v�f���̂Ԃ񂾂��A�t���Ԃɏ������J��Ԃ�
        for (int i = Array.Length - 1; i >= 0; i--)
        {
            //�z��̗v�f��\������i�t���ԁj
            Debug.Log(Array[i]);
        }

        //Boss�N���X�̕ϐ���錾���āA�C���X�^���X����
        Boss boss = new Boss();

        //for���ŁA10�񏈗����J��Ԃ�
        for (int i = 0; i < 10; i++)
        {
            //Magic�֐����Ăяo��
            boss.Magic();
        }

        boss.Magic();
    }
}
