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
    public sealed class Buff : Spell, IBuff
    {
        [SerializeField] private string _name;
        [SerializeField] private string _description;
        [SerializeField] private Sprite _icon;
        [SerializeField] private bool _lineOfSight;
        [SerializeField] private float _cooldown;
        private float _cooldownTimer;
        private bool _ready;
        [SerializeField] private int _buffValue;
        [SerializeField] private float _duration;

        public Buff()
        {
            _name = "Name Me";
            _description = "Describe Me";
            _icon = Sprite.Create(null, new Rect(), Vector2.zero);
            _lineOfSight = false;
            _cooldown = 1;
            _buffValue = 1;
            _duration = 1;
            _ready = true;
        }

        public Buff(Buff buff)
        {
            Clone(buff);
        }

        #region Spell implementation
        public override string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public override string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public override Sprite Icon
        {
            get { return _icon; }
            set { _icon = value; }
        }

        public override bool LineOfSight
        {
            get { return _lineOfSight; }
            set { _lineOfSight = value; }
        }

        public override float Cooldown
        {
            get { return _cooldown; }
            set { _cooldown = value; }
        }

        public override float CooldownTimer
        {
            get { return _cooldownTimer; }
            set { _cooldownTimer = value; }
        }

        public override bool Ready
        {
            get { return _ready; }
        }

        public override void Clone(ISpell spell)
        {
            Buff tempBuff = (Buff)spell;

            Name = tempBuff.Name;
            Description = tempBuff.Description;
            Icon = tempBuff.Icon;
            LineOfSight = tempBuff.LineOfSight;
            Cooldown = tempBuff.Cooldown;
            BuffValue = tempBuff.BuffValue;
            Duration = tempBuff.Duration;
        }

        public override void Update()
        {
            throw new System.NotImplementedException();
        }

        #endregion

        #region IBuff implementation
        public int BuffValue
        {
            get { return _buffValue; }
            set { _buffValue = value; }
        }

        public float Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }
        #endregion

        #region Editor methods
        #if UNITY_EDITOR
        public override void OnGUI()
        {
            base.OnGUI();

            BuffValue = EditorGUILayout.IntField("Max buff value", BuffValue);
            Duration = EditorGUILayout.FloatField("Buff duration", Duration);
        }
        #endif
        #endregion
    }
}

