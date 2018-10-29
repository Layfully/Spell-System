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
    public class SSAoe : SSBolt, ISSAoe
    {
        [SerializeField] private float _aoeRange;
        [SerializeField] private float _aoeDamage;

        public SSAoe()
        {
            _aoeRange = 1;
            _aoeDamage = 1;
        }

        public SSAoe(SSAoe spell)
        {
            Clone(spell);
        }

        public void Clone(SSAoe aoe)
        {
            base.Clone(aoe);

            AoeRange = aoe.AoeRange;
            AoeDamage = aoe.AoeDamage;
        }

        #region ISSAoe implementation
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

