using UnityEngine;

namespace AdrianGaborek.SpellSystem
{
    public interface ISpell
    {
        string Name { get; set; }
        string Description { get; set; }
        Sprite Icon { get; set; }
        bool LineOfSight { get; set; }
        float Cooldown { get; set; }
        float CooldownTimer { get; set; }
        bool Ready { get; }

        void Clone(ISpell spell);
        void Update();
    }
}

