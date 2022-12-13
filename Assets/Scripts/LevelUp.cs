using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUp : MonoBehaviour
{
    public Camera cam;
    Color customColor,groundColor,wallColor,finishColor;
    GameObject[] level1,level2,level3,level4,level5,level6;
    int currentLevel;


    // Start is called before the first frame update
    void Start()
    {
        currentLevel = 1;
        customColor = new Color(0.1f, 0.1f, 0.1f, 0.1f);
        level1 = GameObject.FindGameObjectsWithTag("Level_1");
    
        foreach(GameObject obj in level1){
            if(obj.name == "Ground"){
                groundColor = obj.GetComponent<MeshRenderer>().material.color;
            }
            else if(obj.name == "Wall"){
                wallColor = obj.GetComponent<MeshRenderer>().material.color;
            }
            else if(obj.name == "Finish"){
                finishColor = obj.GetComponent<MeshRenderer>().material.color;
            }
        }
        level2 = GameObject.FindGameObjectsWithTag("Level_2");
        foreach(GameObject obj in level2){
            obj.GetComponent<MeshRenderer>().material.SetColor("_Color",customColor);
        }
        level3 = GameObject.FindGameObjectsWithTag("Level_3");
        foreach(GameObject obj in level3){
            obj.GetComponent<MeshRenderer>().material.SetColor("_Color",customColor);
        }
        level4 = GameObject.FindGameObjectsWithTag("Level_4");
        foreach(GameObject obj in level4){
            obj.GetComponent<MeshRenderer>().material.SetColor("_Color",customColor);
        }
        level5 = GameObject.FindGameObjectsWithTag("Level_5");
        foreach(GameObject obj in level5){
            obj.GetComponent<MeshRenderer>().material.SetColor("_Color",customColor);
        }
        level6 = GameObject.FindGameObjectsWithTag("Level_6");
        foreach(GameObject obj in level6){
            obj.GetComponent<MeshRenderer>().material.SetColor("_Color",customColor);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other){
        if(other.gameObject.name=="Finish" ){
            other.enabled = false;
            other.gameObject.GetComponent<MeshRenderer>().material.SetColor("_Color",customColor);
            if(currentLevel == 1){
                nextLevel(level1,level2);
            }
            else if (currentLevel == 2){
                nextLevel(level2,level3);
            }
            else if (currentLevel == 3){
                nextLevel(level3,level4);
            }
            else if (currentLevel == 4){
                nextLevel(level4,level5);
            }
            else if (currentLevel == 5){
                nextLevel(level5,level6);
            }

        }
    }

    void nextLevel(GameObject[] disperseLevel,GameObject[] highlightLevel){
        foreach(GameObject obj in disperseLevel){
                    obj.GetComponent<MeshRenderer>().material.SetColor("_Color",customColor);
                }
                foreach(GameObject obj in highlightLevel){
                    if(obj.name == "Ground"){
                        obj.GetComponent<MeshRenderer>().material.SetColor("_Color",groundColor);
                    }
                    else if(obj.name == "Wall"){
                        obj.GetComponent<MeshRenderer>().material.SetColor("_Color",wallColor);
                    }
                    else if(obj.name == "Finish"){
                        obj.GetComponent<MeshRenderer>().material.SetColor("_Color",finishColor);
                    }
                }
                currentLevel++;
    }
}
