using System;
using System.Collections.Generic;
using System.Text;

namespace KineticTrack.Application.DTOs.Requests;

public class RegisterPatientRequest
{
    public string Email { get; set; } = string.Empty;
    public string Firstname { get; set; } = string.Empty;
    public string Lastname { get; set; } = string.Empty;

    // Données spécifiques à la table PATIENT
    public DateTime Birthdate { get; set; }
    public string Gender { get; set; } = string.Empty;
    public string MedicalHistory { get; set; } = string.Empty;
}
