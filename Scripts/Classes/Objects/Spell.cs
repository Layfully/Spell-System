using System;
using UnityEditor;
using UnityEngine;

namespace AdrianGaborek.SpellSystem
{
    [Serializable]
    public abstract class Spell : ISpell {
        public abstract string Name { get; set; }
        public abstract string Description { get; set; }
        public abstract Sprite Icon { get; set; }
        public abstract bool LineOfSight { get; set; }
        public abstract float Cooldown { get; set; }
        public abstract float CooldownTimer { get; set; }
        public abstract bool Ready { get; }

        public abstract void Clone(ISpell spell);

        public virtual void OnGUI()
        {
            Name = EditorGUILayout.TextField("Name", Name);
            Description = EditorGUILayout.TextField("Description", Description);
            Icon = EditorGUILayout.ObjectField("Icon", Icon, typeof(Sprite), false) as Sprite;
            Cooldown = EditorGUILayout.FloatField("Cooldown", Cooldown);
        }

        public abstract void Update();
    }
}

