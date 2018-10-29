using UnityEngine;

namespace AdrianGaborek.SpellSystem
{
    public partial class SSSpellEditor
    {
        private enum TabState
        {
            Bolt,
            Buff,
            Aoe
        }

        private TabState _tabState;

        void TopBar()
        {
            GUILayout.BeginHorizontal("Box", GUILayout.ExpandWidth(true));
            BoltTab();
            BuffTab();
            AoeTab();
            GUILayout.EndHorizontal();
        }

        void BoltTab()
        {
            if (GUILayout.Button("Bolts"))
            {
                _tabState = TabState.Bolt;
            }
        }

        void BuffTab()
        {
            if (GUILayout.Button("Buffs"))
            {
                _tabState = TabState.Buff;
            }
        }

        void AoeTab()
        {
            if (GUILayout.Button("AOEs"))
            {
                _tabState = TabState.Aoe;
            }
        }
    }
}

