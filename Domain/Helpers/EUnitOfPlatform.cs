using System.ComponentModel;

namespace api_rest.Domain.Helpers
{
    public enum EUnitOfBook : byte
    {
        [Description("Fantasia")]
        fantasia = 1,

        [Description("Romance")]
        romance = 2,

        [Description("Suspense")]
        suspense = 3,

    }

}
