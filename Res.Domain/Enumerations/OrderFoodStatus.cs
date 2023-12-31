using System.ComponentModel;

namespace Res.Domain.Enumerations;

public enum OrderFoodStatus
{
    [Description("Ordenado")]
    Order = 1,
    [Description("Preparandose")]
    Make = 2,
    [Description("Terminado")]
    Finished = 3,
    [Description("Cancelado")]
    Canceled = 5
}