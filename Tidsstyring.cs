class Tidsstyring
{

    public static bool KvarterKontrol(DateTime tidspunkt)
    {
        return tidspunkt.Minute == 0 || tidspunkt.Minute == 15 || tidspunkt.Minute == 30 || tidspunkt.Minute == 45;
    }
}