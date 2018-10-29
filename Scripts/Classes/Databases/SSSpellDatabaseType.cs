using UnityEngine;

namespace AdrianGaborek.SpellSystem
{
    public partial class SSSpellDatabaseType<D, T> where D : ScriptableObjectDatabase<T> where T : SSSpell, new()
    {
        [SerializeField] private D _database;
        [SerializeField] private string _databaseName;
        [SerializeField] private string _databasePath = @"Database";
        [SerializeField] public string _itemTypeName = "Item";

        public SSSpellDatabaseType(string name)
        {
            _databaseName = name;
        }

        public void OnEnable(string typeName)
        {
            _itemTypeName = typeName;

            if (_database == null)
            {
                LoadDatabase();
            }
        }

        public void OnGUI(Vector2 buttonSize, int width)
        {
            ListView(buttonSize, width);
            ItemDetails();
        }
    }
}

