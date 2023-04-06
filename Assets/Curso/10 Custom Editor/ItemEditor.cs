using UnityEngine;
using UnityEditor;

namespace Curso.CustomEditor
{
    [UnityEditor.CustomEditor(typeof(Item))] //modifico a la clase Item
    public class ItemEditor : Editor
    {
        private Item currentTarget;
        public override void OnInspectorGUI() //Cuando se dibuja el script en el editor
        {
            base.OnInspectorGUI(); //las 4 variables, las referencias
            
            currentTarget = (Item)target;
            
            GUILayout.Space(10); //espacio entre las 4 variables y el boton

            if (IsTargetReady())
            {
                if(!EditorApplication.isPlaying)
                {
                    GUILayout.Box($"Data: {currentTarget.data.title} (${currentTarget.data.price})");
                }

                EditorGUI.BeginDisabledGroup(EditorApplication.isPlaying); //agrupa todo, si se ejecuta se desabilita el boton, pero si se muestra

                string buttonText = EditorApplication.isPlaying ? "Consume (Only in Editor Mode)" : "Consume"; //el boton dira el primero si se esta ejecutando, y si esta en el editor el otro

                if (GUILayout.Button(buttonText, GUILayout.Height(30)))
                {
                    currentTarget.Consume();
                }

                EditorGUI.EndDisabledGroup();
            }
            else //coloco un helpbox
            {
                EditorGUILayout.HelpBox($"Error: {GetErrorMessage()}", MessageType.Error);
            }

        }

        private bool IsTargetReady()
        {
            return 
                currentTarget.data && 
                currentTarget.itemImg && 
                currentTarget.itemTitleTxt &&
                currentTarget.itemPriceTxt;
        }

        private string GetErrorMessage()
        {
            if(!currentTarget.data) return "Data Empty!";
            if(!currentTarget.itemImg) return "Image Reference Empty!";
            if(!currentTarget.itemTitleTxt) return "Title Reference Empty!";
            if(!currentTarget.itemPriceTxt) return "Price Reference Empty!";
            
            return "Unknow";
        }
    }
}
