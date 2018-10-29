using UnityEngine;

namespace AdrianGaborek.SpellSystem
{
    public interface ISSSpell
    {
        string Name { get; set; }
        string Description { get; set; }
        Sprite Icon { get; set; }
        bool LineOfSight { get; set; }
        float Cooldown { get; set; }
        float CooldownTimer { get; set; }
        bool Ready { get; }

        void Clone(ISSSpell spell);
        void Update();
    }
}

