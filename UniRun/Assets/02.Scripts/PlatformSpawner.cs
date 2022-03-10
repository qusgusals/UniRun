using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 이전 총알생성기에서 사용했던방식인 매번필요시마다 사용했던 instantiate생성방식이 아닌
//오브젝트 풀링사용
// what is object pooling
//게임 초기에 필요한 만큼 오브젝트를 미리 만들어
// 풀(웅덩이)에 쌓아두는 방식입니다.
// 오브젝트를 실시간으로생성하거나 destory 메서드처럼 실시간으로 파괴하는 처리는 성능을 많이요구하기 때문에
//그리고 메모리르 정리하는 gc를 유발하기 쉽다. 게임도중에 오브젝트를 너무 자주 생성하거나 파괴하면
// 게임 끊김 (프리즈) 현상이 발생이 된다.











public class PlatformSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
