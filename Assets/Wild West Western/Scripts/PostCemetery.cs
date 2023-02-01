using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PostCemetery: MonoBehaviour {
 
void Update(){
if(Input.GetKeyDown(KeyCode.F)){
Application.LoadLevel(4);
}
}
}