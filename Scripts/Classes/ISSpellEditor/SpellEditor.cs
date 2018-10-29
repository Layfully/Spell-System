using AdrianGaborek.ItemSystem;
using UnityEditor;
using UnityEngine;

namespace AdrianGaborek.SpellSystem
{
    public partial class SpellEditor : EditorWindow
    {
        private SpellDatabaseType<BuffDatabase, Buff> _buffDatabase = new SpellDatabaseType<BuffDatabase, Buff>("BuffDatabase.asset");
        private SpellDatabaseType<BoltDatabase, Bolt> _boltDatabase = new SpellDatabaseType<BoltDatabase, Bolt>("BoltDatabase.asset");
        private SpellDatabaseType<AoeDatabase, Aoe> _aoeDatabase = new SpellDatabaseType<AoeDatabase, Aoe>("AoEDatabase.asset");

        private Vector2 _buttonSize = new Vector2(190, 25);
        private int _listViewWidth = 200;

        [MenuItem("Spell System/Spell System Editor %#t")]
        public static void Initialize()
        {
            SSSpellEditor window = GetWindow<SSSpellEditor>();
            window.minSize = new Vector2(800, 600);
            window.titleContent.text = "Spell System Database";
        }

        void OnEnable()
        {
            _buffDatabase.OnEnable("Buff");
            _boltDatabase.OnEnable("Bolt");
            _aoeDatabase.OnEnable("AoE");

            _tabState = TabState.Bolt;
        }

        void OnGUI()
        {
            TopBar();
            GUILayout.BeginHorizontal();

            switch (_tabState)
            {
                case TabState.Bolt:
                    _boltDatabase.OnGUI(_buttonSize, _listViewWidth);
                    break;
                case TabState.Buff:
                    _buffDatabase.OnGUI(_buttonSize, _listViewWidth);
                    break;
                case TabState.Aoe:
                    _aoeDatabase.OnGUI(_buttonSize, _listViewWidth);
                    break;
                default:
                    break;
            }
            GUILayout.EndHorizontal();
            BottomBar();
        }
    }
}
