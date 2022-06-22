namespace Core.Entities.Enum;
[Flags]
public enum Transport : int
{
    Tramway = 1,
    Trolleybus = 2,
    Bus = 4,
    NightBus = 8,
    NightTramway = 16,
    NightTrolleybus = 32,
    TaxiBus = 64,
    NightTaxiBus = 128
}