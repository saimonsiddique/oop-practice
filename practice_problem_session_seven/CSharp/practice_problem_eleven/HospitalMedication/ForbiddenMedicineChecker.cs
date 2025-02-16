public class ForbiddenMedicineChecker
{
    private static readonly HashSet<(MedicationType, MedicationType)> ForbiddenPairs = new()
    {
        (MedicationType.Antibiotic, MedicationType.Statin),
        (MedicationType.MuscleRelaxant, MedicationType.CNSDepressant),
        (MedicationType.AntiInflammatory, MedicationType.Anticoagulant)
    };

    public static bool IsForbidden(MedicationType type1, MedicationType type2)
    {
        return ForbiddenPairs.Contains((type1, type2)) || ForbiddenPairs.Contains((type2, type1));
    }
}