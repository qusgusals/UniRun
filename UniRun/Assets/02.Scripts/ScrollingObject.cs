using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//게임 오브젝트를 지속적으로 왼쪽으로 움직이는 스크립트
public class ScrollingObject : MonoBehaviour
{

    public float speed = 10f; //이동속도

    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        if(!GameManager.instance.isGameover)
        {
            //초당 speed의 속도로 왼쪽으로 평행이동 구현
            transform.Translate(Vector3.left * speed * Time.deltaTime); 
            //translate : 평행이동 메서드
                                                                        
            //speed를 초당으로 할려면 speed에 time.deltaTime을 곱해야 한다.
                                                                     
            //그렇지않으면 프레임으로 계산된다.
        }

        
    }
}
//transform은 unity의 transform을 가르킨다.
// overloading: 동일한 메서드의 이름으로 각기 다른 기능들을 구현 