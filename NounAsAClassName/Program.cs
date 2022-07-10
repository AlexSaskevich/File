using System.Collections.Generic;

namespace NounAsAClassName
{
    class Player { }
    class Gun { }
    class Pursuer { }
    class Unit
    {
        public IReadOnlyCollection<Unit> UnitsToGet { get; private set; }
    }
}