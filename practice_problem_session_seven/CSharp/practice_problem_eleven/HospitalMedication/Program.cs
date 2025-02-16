var patient = new Patient("P001", "John Doe");


var ibuprofen = new Medication("Ibuprofen", MedicationType.AntiInflammatory);
var amoxicillin = new Medication("Amoxicillin", MedicationType.Antibiotic);
var warfarin = new Medication("Warfarin", MedicationType.Anticoagulant);
var atorvastatin = new Medication("Atorvastatin", MedicationType.Statin);


patient.Prescribe(ibuprofen);
patient.Prescribe(amoxicillin);
// patient.Prescribe(warfarin);


foreach (var medication in patient.GetAllMedications())
{
    Console.WriteLine($"{medication.Name} - {medication.Type}");
}


