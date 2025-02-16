public class Patient
{
    public string Id { get; }
    public string Name { get; }
    private List<Medication> Medications { get; } = new();

    public Patient(string id, string name)
    {
        Id = id;
        Name = name;
        Medications = new List<Medication>();
    }

    public void Prescribe(Medication medication)
    {
        foreach (var existingMedication in Medications)
        {
            if (ForbiddenMedicineChecker.IsForbidden(existingMedication.Type, medication.Type))
            {
                throw new InvalidOperationException("Forbidden medication combination");
            }
        }

        Medications.Add(medication);
    }

    public List<Medication> GetAllMedications()
    {
        return Medications.ToList();
    }
}
