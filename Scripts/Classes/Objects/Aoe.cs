using System;
using UnityEngine;
#region using UnityEditor;
#if UNITY_EDITOR
using UnityEditor;
#endif
#endregion

namespace AdrianGaborek.SpellSystem
{
    [Serializable]
    public class Aoe : Bolt, IAoe
    {
        [SerializeField] private float _aoeRange;
        [SerializeField] private float _aoeDamage;

        public Aoe()
        {
            _aoeRange = 1;
            _aoeDamage = 1;
        }

        public Aoe(SSAoe spell)
        {
            Clone(spell);
        }

        public void Clone(Aoe aoe)
        {
            base.Clone(aoe);

            AoeRange = aoe.AoeRange;
            AoeDamage = aoe.AoeDamage;
        }

        #region IAoe implementation
        public float AoeRange
        {
            get { return _aoeRange; }
            set { _aoeRange = value; }
        }

        public float AoeDamage
        {
            get { return _aoeDamage; }
            set { _aoeDamage = value; }
        }
        #endregion

        #region Editor methods
#if UNITY_EDITOR
        public override void OnGUI()
        {
            base.OnGUI();

            AoeRange = EditorGUILayout.FloatField("AoE Range", AoeRange);
            AoeDamage = EditorGUILayout.FloatField("AoE Damage", AoeDamage);
        }
#endif
        #endregion
    }
}

