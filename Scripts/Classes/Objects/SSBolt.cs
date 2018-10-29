namespace AdrianGaborek.SpellSystem
{
    using System;
    using UnityEditor;
    using UnityEngine;

    [Serializable]
    public class SSBolt : SSSpell, ISSBolt
    {
        [SerializeField] private string _name;
        [SerializeField] private string _description;
        [SerializeField] private Sprite _icon;
        [SerializeField] private bool _lineOfSight;
        [SerializeField] private float _cooldown;
        private float _cooldownTimer;
        private bool _ready;
        [SerializeField] private float _damage;
        [SerializeField] private float _spellRange;

        public SSBolt()
        {
            _name = "Name Me";
            _description = "Describe Me";
            _icon = Sprite.Create(null, new Rect(), Vector2.zero);
            _lineOfSight = false;
            _cooldown = 1;
            _damage = 1;
            _spellRange = 1;
            _ready = true;
        }

        public SSBolt(SSBolt bolt)
        {
            Clone(bolt);
        }

        #region SSSpell implementation
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

        public sealed override void Clone(ISSSpell spell)
        {
            SSBolt tempBolt = (SSBolt)spell;

            Name = tempBolt.Name;
            Description = tempBolt.Description;
            Icon = tempBolt.Icon;
            LineOfSight = tempBolt.LineOfSight;
            Cooldown = tempBolt.Cooldown;
            Damage = tempBolt.Damage;
            SpellRange = tempBolt.SpellRange;
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region ISSBolt implementation
        public float Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        public float SpellRange
        {
            get { return _spellRange; }
            set { _spellRange = value; }
        }
        #endregion

        #region Editor methods
        #if UNITY_EDITOR
        public override void OnGUI()
        {
            base.OnGUI();

            Damage = EditorGUILayout.FloatField("Damage", Damage);
            SpellRange = EditorGUILayout.FloatField("Range", SpellRange);
        }
        #endif
        #endregion
    }
}

