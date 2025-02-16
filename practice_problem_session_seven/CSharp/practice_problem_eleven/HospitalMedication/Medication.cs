public class Medication
{
  public string Name { get; }
  public MedicationType Type { get; }

  public Medication(string name, MedicationType type)
  {
    Name = name;
    Type = type;
  }
}


public enum MedicationType
{
  AntiInflammatory,
  MuscleRelaxant,
  Antibiotic,
  CoughSyrup,
  Insulin,
  Anticoagulant,
  CNSDepressant,
  Statin
}
