using UnityEngine;

namespace MiniclipTrick.Game.Scriptables
{
    [CreateAssetMenu(menuName = "Scriptables/Game/UI Hearts")]
    public class UiHeartScriptable : ScriptableObject
    {
        public Sprite fullHeartSprite;
        public Sprite emptyHeartSprite;
    }
}