using System.ComponentModel;

namespace Core.Entities.Enum;
[Flags]
public enum Information
{
    [Description("None")]
    None = 0,
    [Description("В депо")]
    InDepot = 1,
    [Description("Підкреслення")]
    Underline = 2,
    [Description("Зірка")]
    Star = 4,
    [Description("С")]
    CNote = 8,
    [Description("Н")]
    HNote = 16,
    [Description("В")]
    BNote = 32,
    [Description("Д")]
    DNote = 64,
    [Description("М")]
    MNote = 128,
    [Description("EmptySchedule")]
    EmptyScheduleNote = 256,
    [Description("DeviationNote")]
    DeviationNote = 512
}